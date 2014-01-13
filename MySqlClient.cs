using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
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
        { get { return _connection; } }

        // SERVIZI PRIVATI
        bool GetResultSet(string strQuery, ref List<string> result)
        {
            MySqlCommand cmd = new MySqlCommand(strQuery, _connection);
            MySqlDataReader dr = null;

            try
            {
                dr = cmd.ExecuteReader();

                // LETTURA TABELLA (RECORD --> CAMPO)
                string lettura;
                while (dr.Read())
                {
                    lettura = "";
                    for (int i = 0; i < dr.FieldCount; i++)
                        lettura += dr[i].ToString() + "; ";

                    result.Add(lettura);
                }
            }
            catch
            { return false; }
            finally
            {
                if (dr != null)
                    dr.Close();
            }

            return true;
        }

        // SERVIZI PUBBLICI
        public bool StartServer(string serverPath)
        {
            // AVVIA IL SERVER MySQL PORTABILE
            Process[] listaP;
            _pServer = new Process();
            bool esiste = false;

            // Manda in esecuzione il processo (può anche partire dopo l'apertura della connessione)
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

        public object[] ExecuteNonQuery(string strCmd)
        {
            MySqlCommand cmd = new MySqlCommand(strCmd, _connection);
            int rowsAffected = 0;

            try
            {
                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            { return new object[] { false, rowsAffected, ex.Number + ": " + ex.Message }; }

            return new object[] { true, rowsAffected };
        }

        public object[] ExecuteQueryDGV(string strCmd, ref DataGridView dataGridView)
        {
            MySqlDataAdapter da = new MySqlDataAdapter(strCmd, Connection);
            DataTable dt = new DataTable();
            int rowsAffected = 0;

            try
            {
                rowsAffected = da.Fill(dt);
                dataGridView.DataSource = dt;
            }
            catch (MySqlException ex)
            { return new object[] { false, rowsAffected, ex.Number + ": " + ex.Message }; }

            return new object[] { true, rowsAffected };
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
            if (!(bool)ExecuteNonQuery("CREATE DATABASE " + name + ";")[0])
                return false;
            return true;
        }

        public bool DropDatabase(string dbName)
        {
            if (!(bool)ExecuteNonQuery("DROP DATABASE " + dbName + ";")[0])
                return false;
            return true;
        }

        public bool DropTable(string tableName)
        {
            if (!(bool)ExecuteNonQuery("DROP TABLE " + tableName + ";")[0])
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
                DescribeTable(tableName, ref dgvDescribeTable);
                SelectAll(tableName, ref dgvDataTable);
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
                    DescribeTable(tableName, ref dgvDescribeTable);
                    SelectAll(tableName, ref dgvDataTable);
                }
                else
                    ExecuteNonQuery("DROP TABLE " + tableName + ";");
            }
            catch
            { return false; }

            return true;
        }

        public bool AddPrimaryKey(string tableName, string fields)
        {
            string frmtFields = String.Join(",", fields.Split(',').Select(s => s.Trim()));
            string constraint = "pk_" + tableName;

            // Ricostruzione campi PK
            List<string> prevFields = new List<string>();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE TABLE_NAME = '" + tableName + "';", Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
                prevFields.Add(dt.Rows[i][0] + "");
            string prevFieldsStr = String.Join(",", prevFields);

            // Rimozione chiave primaria
            if (!DropPrimaryKey(tableName))
                return false;

            // Inserimento chiave primaria
            if (!(bool)ExecuteNonQuery("ALTER TABLE " + tableName + " ADD CONSTRAINT " + constraint + " PRIMARY KEY (" + prevFieldsStr + "," + frmtFields + ");")[0])
                return false;

            return true;
        }

        public bool DropPrimaryKey(string tableName)
        {
            if (!(bool)ExecuteNonQuery("ALTER TABLE " + tableName + " DROP PRIMARY KEY;")[0])
                return false;
            return true;
        }

        public bool AddForeignKey(string tableName, string fkField, string tableNameRef, string pkRef)
        {
            if (!(bool)ExecuteNonQuery("ALTER TABLE " + tableName + " ADD CONSTRAINT " + fkField + " FOREIGN KEY (" + fkField + ") REFERENCES " + tableNameRef + "(" + pkRef + ") ON UPDATE CASCADE ON DELETE CASCADE;")[0])
                return false;

            return true;
        }
        
        public bool DropForeignKey(string tableName, string fkField)
        {
            if (!(bool)ExecuteNonQuery("ALTER TABLE " + tableName + " DROP FOREIGN KEY " + fkField + 
                "; ALTER TABLE " + tableName + " DROP INDEX " + fkField + ";")[0])
                return false;
            return true;
        }

        public bool WriteTableCSV(string fileName, string tableName)
        {
            List<string> output = new List<string>();
            StreamWriter sw = new StreamWriter(fileName);

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

        public bool WriteTableJSON(string fileName, string tableName)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM " + tableName + ";", Connection);
            DataTable dt = new DataTable(), dtFieldNames = new DataTable();
            List<string> fieldNames = new List<string>();
            StreamWriter sw = new StreamWriter(fileName);

            try
            {
                // Dati tabella
                da.Fill(dt);

                // Nomi campi
                da.SelectCommand.CommandText = "DESCRIBE " + tableName + ";";
                da.Fill(dtFieldNames);
                for (int i = 0; i < dtFieldNames.Rows.Count; i++)
                    fieldNames.Add(dtFieldNames.Rows[i]["Field"] + "");

                // Scrittura effettiva su file
                sw.WriteLine("[");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sw.WriteLine("\t{");
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        string s = j == dt.Columns.Count - 1 ? "\t\t" + "'" + fieldNames[j] + "' : '" + dt.Rows[i][j] + "'" : "\t\t" + "'" + fieldNames[j] + "' : '" + dt.Rows[i][j] + "'" + ",";
                        sw.WriteLine(s);
                    }
                    sw.WriteLine(i == dt.Rows.Count - 1 ? "\t}" : "\t},");
                }
                sw.WriteLine("]");
            }
            catch
            { return false; }
            finally
            { sw.Close(); }

            return true;
        }

        public bool WriteTableHTML(string fileName, string tableName)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM " + tableName + ";", Connection);
            DataTable dt = new DataTable(), dtFieldNames = new DataTable();
            List<string> fieldNames = new List<string>();
            StreamWriter sw = new StreamWriter(fileName);

            try
            {
                // Dati tabella
                da.Fill(dt);

                // Nomi campi
                da.SelectCommand.CommandText = "DESCRIBE " + tableName + ";";
                da.Fill(dtFieldNames);
                for (int i = 0; i < dtFieldNames.Rows.Count; i++)
                    fieldNames.Add(dtFieldNames.Rows[i]["Field"] + "");

                // Scrittura intestazioni e tag di apertura
                sw.WriteLine("<!DOCTYPE html>");
                sw.WriteLine("<html>");
                sw.WriteLine("\t<head>");
                sw.WriteLine("\t\t<meta charset='utf-8'>");
                sw.WriteLine("\t\t<title>Data</title>");
                sw.WriteLine("\t</head>");
                sw.WriteLine("\t<body>");
                sw.WriteLine("\t\t<table border=1>");

                // Scrittura dei nomi dei campi
                sw.WriteLine("\t\t\t<tr>");
                foreach (string field in fieldNames)
                    sw.WriteLine("\t\t\t\t<td bgcolor=silver>" + field + "</td>");
                sw.WriteLine("\t\t\t</tr>");

                // Scrittura dei dati
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sw.WriteLine("\t\t\t<tr>");
                    for (int j = 0; j < dt.Columns.Count; j++)
                        sw.WriteLine("\t\t\t\t<td>" + dt.Rows[i][j] + "</td>");
                    sw.WriteLine("\t\t\t</tr>");
                }

                // Scrittura tag di chiusura
                sw.WriteLine("\t\t</table>");
                sw.WriteLine("\t</body>");
                sw.WriteLine("</html>");
            }
            catch
            { return false; }
            finally
            { sw.Close(); }

            return true;
        }
    }
}