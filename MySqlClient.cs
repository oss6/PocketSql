using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace PocketSql
{
    public class MySqlClient
    {
        // ATTRIBUTI
        MySqlConnection _connection;
        Process _pServer;
        string _connStr;
        string _currentTable;

        // COSTRUTTORI
        public MySqlClient(string server, string uid, string pwd)
        {
            _connStr = @"Server=" + server + ";Uid=" + uid + ";Pwd=" + pwd + ";";
            _connection = new MySqlConnection(_connStr);
        }

        public string CurrentTable
        {
            get { return _currentTable; }
            set { _currentTable = value; }
        }

        public MySqlConnection Connection
        {
            get { return _connection; }
        }

        bool GetResultSet(string strQuery, ref List<string> result)
        {
            MySqlCommand cmd = new MySqlCommand(strQuery, _connection);
            MySqlDataReader dr;

            try
            {
                dr = cmd.ExecuteReader();
            }
            catch
            { return false; }


            // LETTURA TABELLA (RECORD --> CAMPO)
            string lettura;
            while (dr.Read())
            {
                lettura = "";
                for (int i = 0; i < dr.FieldCount; i++)
                    lettura += dr[i].ToString() + "; ";

                result.Add(lettura);
            }

            return true;
        }

        public bool StartServer(string serverPath)
        {
            // AVVIA IL SERVER MySQL PORTABILE
            Process[] listaP;
            _pServer = new Process();
            bool esiste = false;

            // Manda in esecuzione il processo (può anche partire dopo l'apertura della connessione)
            // Si possono usare anche percorsi relativi
            _pServer.StartInfo.FileName = serverPath;
            _pServer.StartInfo.WindowStyle = ProcessWindowStyle.Hidden; // Finestra nascosta
            _pServer.Start();

            do
            {
                // Restituisce una lista dei processi attivi
                listaP = Process.GetProcesses();
                foreach (Process pr in listaP)
                    if (pr.ProcessName.StartsWith("mysqld"))
                        esiste = true;
            } while (!esiste);

            // APERTURA CONNESSIONE
            if (OpenConnection())
                return true;

            return false;
        }

        public void CloseServer()
        {
            _pServer.Kill();
        }

        public bool OpenConnection()
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();
            }
            catch
            {
                _connection.Close();
                return false;
            }

            return true;
        }

        public bool ExecuteNonQuery(string strCmd)
        {
            MySqlCommand cmd = new MySqlCommand(strCmd, _connection);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            { return false; }

            return true;
        }

        public bool ExecuteQueryDGV(string strCmd, ref DataGridView dataGridView)
        {
            MySqlDataAdapter da = new MySqlDataAdapter(strCmd, Connection);
            DataTable dt = new DataTable();

            try
            {
                da.Fill(dt);
                dataGridView.DataSource = dt;

                return true;
            }
            catch
            { return false; }
        }

        public List<object> ExecuteQuery(string strCmd)
        {
            MySqlDataAdapter da = new MySqlDataAdapter(strCmd, Connection);
            DataTable dt = new DataTable();
            List<object> resultSet = new List<object>();

            try
            {
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                    for (int j = 0; j < dt.Columns.Count; j++)
                        resultSet.Add(dt.Rows[i][j]);
            }
            catch
            { return null; }

            return resultSet;
        }

        public bool CommitChanges(ref DataGridView dgv)
        {
            try
            {
                // Creo connessione temporanea (serve per problemi con MySqlCommandBuilder)
                MySqlConnection cn = new MySqlConnection("Server=localhost;Uid=root;Pwd=pippo123");
                cn.Open();
                cn.ChangeDatabase(Connection.Database);

                // Impostazione comando
                MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT * FROM " + CurrentTable;

                // Impostazione DataAdapter e CommandBuilder
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                MySqlCommandBuilder mcb = new MySqlCommandBuilder();
                mcb.DataAdapter = da;
                
                // Aggiornamento tabella
                DataTable dt = new DataTable();
                dt = ((DataTable)dgv.DataSource).GetChanges();
                da.Update(dt);

                cn.Close();
            }
            catch
            { return false; }

            return true;
        }

        public bool CreateDatabase(string name)
        {
            if (!ExecuteNonQuery("CREATE DATABASE " + name + ";"))
                return false;
            return true;
        }

        public bool DropDatabase(string dbName)
        {
            if (!ExecuteNonQuery("DROP DATABASE " + dbName + ";"))
                return false;
            return true;
        }

        public bool DropTable(string tableName)
        {
            if (!ExecuteNonQuery("DROP TABLE " + tableName + ";"))
                return false;
            return true;
        }

        public bool DescribeTable(string tableName, ref DataGridView output)
        {
            try
            {
                ExecuteQueryDGV("DESCRIBE " + tableName + ";", ref output);
            }
            catch
            { return false; }

            return true;
        }

        public bool SelectAll(string tableName, ref DataGridView output)
        {
            try
            {
                ExecuteQueryDGV("SELECT * FROM " + tableName + ";", ref output);
            }
            catch
            { return false; }

            return true;
        }

        public bool SelectWithCondition(string tableName, string condition, ref DataGridView output)
        {
            try
            {
                ExecuteQueryDGV("SELECT * FROM " + tableName + " WHERE " + condition + ";", ref output);
            }
            catch
            { return false; }

            return true;
        }

        public bool AddColumn(string tableName, string columnName, string dataType, bool isNull, ref DataGridView dgvDescribeTable, ref DataGridView dgvDataTable)
        {
            try
            {
                // Aggiunta della colonna
                ExecuteNonQuery("ALTER TABLE " + tableName + " ADD " + columnName + " " + dataType + " " + (isNull ? "NULL" : "NOT NULL") + ";");

                // Aggiornamento
                ExecuteQueryDGV("DESCRIBE " + tableName + ";", ref dgvDescribeTable);
                ExecuteQueryDGV("SELECT * FROM " + tableName + ";", ref dgvDataTable);
            }
            catch
            { return false; }

            return true;
        }

        public bool DropColumn(string tableName, string columnName, ref DataGridView dgvDescribeTable, ref DataGridView dgvDataTable)
        {
            try
            {
                // Rimozione della colonna
                if (((DataTable)dgvDescribeTable.DataSource).Rows.Count != 1)
                {
                    ExecuteNonQuery("ALTER TABLE " + tableName + " DROP COLUMN " + columnName + ";");

                    // Aggiornamento
                    ExecuteQueryDGV("DESCRIBE " + tableName + ";", ref dgvDescribeTable);
                    ExecuteQueryDGV("SELECT * FROM " + tableName + ";", ref dgvDataTable);
                }
                else
                    ExecuteNonQuery("DROP TABLE " + tableName + ";");
            }
            catch
            { return false; }

            return true;
        }

        public bool AddPrimaryKey(string tableName, string field)
        {
            if (!ExecuteNonQuery("ALTER TABLE " + tableName + " ADD PRIMARY KEY (" + field + ");"))
                return false;
            return true;
        }

        public bool DropPrimaryKey(string tableName)
        {
            if (!ExecuteNonQuery("ALTER TABLE " + tableName + " DROP PRIMARY KEY;"))
                return false;
            return true;
        }

        public bool AddForeignKey(string tableName, string fkField, string tableNameRef, string pkRef)
        {
            if (!ExecuteNonQuery("ALTER TABLE " + tableName + " ADD CONSTRAINT " + fkField + " FOREIGN KEY (" + fkField + ") REFERENCES " + tableNameRef + "(" + pkRef + ") ON UPDATE CASCADE ON DELETE CASCADE;"))
                return false;

            return true;
        }

        public bool DropForeignKey(string tableName)
        {
            if (!ExecuteNonQuery("ALTER TABLE " + tableName + " DROP FOREIGN KEY ForeignKeyP;"))
                return false;
            return true;
        }

        public bool WriteTable(string fileName, string tableName)
        {
            List<string> output = new List<string>();
            StreamWriter sw = new StreamWriter(fileName + ".csv");

            try
            {
                GetResultSet("SELECT * FROM " + tableName + ";", ref output);

                foreach (string linea in output)
                    sw.WriteLine(linea);
            }
            catch
            { return false; }
            finally
            { sw.Close(); }

            return true;
        }
    }
}