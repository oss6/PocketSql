using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PocketSql
{
    public partial class PocketSql : Form
    {
        MySqlClient client = new MySqlClient("localhost", "root", "pippo123");

        public PocketSql()
        {
            InitializeComponent();
        }

        // ==============
        // === METODI ===
        // ==============
        void VisualizeTree()
        {
            List<object> dbs = client.ExecuteQuery("SHOW DATABASES;");
            List<object> tables;

            treeView.Nodes.Clear();

            foreach (object db in dbs)
            {
                // Visualizza database
                TreeNode tnDataBase = treeView.Nodes.Add((string)db);
                tnDataBase.ContextMenuStrip = cmsDBM;

                // Visualizza tabelle database
                client.Connection.ChangeDatabase((string)db);
                tables = client.ExecuteQuery("SHOW TABLES;");

                foreach (object table in tables)
                    tnDataBase.Nodes.Add((string)table).ContextMenuStrip = cmsDBM;
            }
        }

        // ==============
        // === EVENTI ===
        // ==============
        private void PocketSql_Load(object sender, EventArgs e)
        {
            // Avvio del server e visualizzazione struttura databases
            if (client.StartServer(@"..\mysqld.exe"))
            {
                VisualizeTree();

                // Informazioni sul client nella barra di stato
                lblInfo.Text = "MySQL v. " + client.Connection.ServerVersion;
                lblState.Text += client.Connection.State.ToString();
            }

            // Gestione datagridview creazione tabella
            dgvCreateTable.ColumnCount = 3;
            dgvCreateTable.Columns[0].HeaderText = "Nome";
            dgvCreateTable.Columns[1].HeaderText = "Tipo di dati";
            dgvCreateTable.Columns[2].HeaderText = "Null";
        }

        private void avviaConnessioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (client.OpenConnection())
            {
                VisualizeTree();

                lblInfo.Text = "MySQL v. " + client.Connection.ServerVersion;
                lblState.Text = "Stato: " + client.Connection.State.ToString();
            }
            else
                MessageBox.Show("Errore durante l'apertura della connessione.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //
        // REFRESH DELLA LISTA AD ALBERO
        //
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualizeTree();
        }

        //
        // CLICK SU DATABASE O TABELLA
        //
        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Click su nome database
            if (e.Node.Level == 0)
            {
                try
                {
                    client.Connection.ChangeDatabase(e.Node.Text);
                    tabControl.TabPages[0].Text = "Database: " + e.Node.Text;

                    // Svuotamento datagridviews
                    dgvDescribeTable.DataSource = null;
                    dgvDescribeTable.Rows.Clear();

                    dgvDataTable.DataSource = null;
                    dgvDataTable.Rows.Clear();
                }
                catch
                {
                    MessageBox.Show("Attenzione si è verificato un errore nel cambio del database!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                { client.CurrentTable = ""; }
            }
            // Click su nome tabella
            else if (e.Node.Level == 1)
            {
                client.Connection.ChangeDatabase(e.Node.Parent.Text);
                tabControl.TabPages[0].Text = "Database: " + e.Node.Parent.Text;

                client.DescribeTable(e.Node.Text, ref dgvDescribeTable);
                client.SelectAll(e.Node.Text, ref dgvDataTable);
                client.CurrentTable = e.Node.Text;
            }
        }

        //
        // CREAZIONE DATABASE
        //
        private void creaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nomeDB = Prompt.ShowDialog("Nome database", "Creazione database");

            if (nomeDB != String.Empty)
            {
                if (!client.CreateDatabase(nomeDB))
                    MessageBox.Show("Attenzione. Si è verificato un errore!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else VisualizeTree();
            }
        }

        //
        // RIMOZIONE DATABASE O TABELLA
        //
        private void eliminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (treeView.SelectedNode.Level)
            {
                // Gestione databases
                case 0:
                    if (MessageBox.Show("Sei sicuro di voler eliminare il database: " + treeView.SelectedNode.Text + "?", "Attenzione", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (client.DropDatabase(treeView.SelectedNode.Text))
                        {
                            MessageBox.Show("Database eliminato correttamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            VisualizeTree();
                        }
                        else
                            MessageBox.Show("Attenzione si è verificato un errore!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;

                // Gestione tabelle
                case 1:
                    if (MessageBox.Show("Sei sicuro di voler eliminare la tabella: " + treeView.SelectedNode.Text + "?", "Attenzione", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        if (client.DropTable(treeView.SelectedNode.Text))
                        {
                            MessageBox.Show("Tabella eliminata correttamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            VisualizeTree();
                        }
                        else
                            MessageBox.Show("Attenzione si è verificato un errore!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
            }
        }

        //
        // CREAZIONE TABELLA
        //
        private void nuovaTabellaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (treeView.SelectedNode.Level)
            {
                case 0:
                    tabControl1.SelectedIndex = 2;
                    break;

                case 1:
                    MessageBox.Show("Azione non permessa.");
                    break;
            }
        }

        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            // Creazione comando
            string strCmd = "CREATE TABLE " + txtTableNameCreate.Text + " (";
            for (int i = 0; i < dgvCreateTable.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgvCreateTable.Columns.Count; j++)
                    strCmd += dgvCreateTable[j, i].Value + " ";

                if (i == dgvCreateTable.Rows.Count - 2)
                    strCmd += ");";
                else strCmd += ",";
            }

            if (!client.ExecuteNonQuery(strCmd))
                MessageBox.Show("Attenzione si è verificato un errore!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                VisualizeTree();

                txtTableNameCreate.Text = "";
                dgvCreateTable.DataSource = null;
                dgvCreateTable.Rows.Clear();
            }
        }

        //
        // SALVATAGGIO TABELLA IN FORMATO CSV
        //
        private void btnSaveTableCSV_Click(object sender, EventArgs e)
        {
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                if (!client.WriteTable(SFD.FileName, client.CurrentTable))
                    MessageBox.Show("Attenzione si è verificato un errore!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else MessageBox.Show("Tabella salvata correttamente!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //
        // INSERIMENTO CHIAVE PRIMARIA --> RICORDO: anche più attributi
        //
        private void btnAddPK_Click(object sender, EventArgs e)
        {
            if (!client.AddPrimaryKey(client.CurrentTable, txtPKFieldName.Text))
                MessageBox.Show("Attenzione si è verificato un errore!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                client.DescribeTable(client.CurrentTable, ref dgvDescribeTable);
                client.SelectAll(client.CurrentTable, ref dgvDataTable);
                MessageBox.Show("Chiave primaria aggiunta correttamente.");
            }

            txtPKFieldName.Text = "";
        }

        //
        // RIMOZIONE CHIAVE PRIMARIA
        //
        private void btnDropPK_Click(object sender, EventArgs e)
        {
            if (!client.DropPrimaryKey(client.CurrentTable))
                MessageBox.Show("Attenzione si è verificato un errore!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                client.DescribeTable(client.CurrentTable, ref dgvDescribeTable);
                client.SelectAll(client.CurrentTable, ref dgvDataTable);
                MessageBox.Show("Chiave primaria eliminata correttamente.");
            }
        }

        //
        // INSERIMENTO CHIAVE ESTERNA
        //
        private void btnAddFK_Click(object sender, EventArgs e)
        {
            if (!client.AddForeignKey(client.CurrentTable, txtFKFieldName.Text, txtRefTableName.Text, txtPKRefFieldName.Text))
                MessageBox.Show("Attenzione si è verificato un errore!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                client.DescribeTable(client.CurrentTable, ref dgvDescribeTable);
                client.SelectAll(client.CurrentTable, ref dgvDataTable);
                MessageBox.Show("Chiave esterna aggiunta correttamente.");
            }

            txtRefTableName.Text = "";
            txtPKRefFieldName.Text = "";
        }

        //
        // RIMOZIONE CHIAVE ESTERNA
        //
        private void btnDropFK_Click(object sender, EventArgs e)
        {
            if (!client.DropForeignKey(client.CurrentTable))
                MessageBox.Show("Attenzione si è verificato un errore!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                client.DescribeTable(client.CurrentTable, ref dgvDescribeTable);
                client.SelectAll(client.CurrentTable, ref dgvDataTable);
                MessageBox.Show("Chiave esterna eliminata correttamente.");
            }
        }

        //
        // INSERIMENTO CAMPO
        //
        private void btnAddField_Click(object sender, EventArgs e)
        {
            bool isNull = rbNullYes.Checked;

            if (!client.AddColumn(client.CurrentTable, txtFieldNameAdd.Text, txtDataTypeAdd.Text, isNull, ref dgvDescribeTable, ref dgvDataTable))
                MessageBox.Show("Attenzione si è verificato un errore!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            txtFieldNameAdd.Text = "";
            txtDataTypeAdd.Text = "";
        }

        //
        // RIMOZIONE CAMPO
        //
        private void btnRemoveField_Click(object sender, EventArgs e)
        {
            if (!client.DropColumn(client.CurrentTable, txtFieldNameRemove.Text, ref dgvDescribeTable, ref dgvDataTable))
                MessageBox.Show("Attenzione si è verificato un errore!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            VisualizeTree();
            txtFieldNameRemove.Text = "";
        }

        //
        // OPERAZIONI DI MODIFICA SUI DATI
        //
        private void btnSaveDataTable_Click(object sender, EventArgs e)
        {
            if (!client.CommitChanges(ref dgvDataTable))
                MessageBox.Show("Attenzione! Si è verificato un errore!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //
        // OPERAZIONI DI FILTRO
        //
        private void btnFilter_Click(object sender, EventArgs e)
        {
            if(!client.SelectWithCondition(client.CurrentTable, txtConditionFilter.Text, ref dgvDataTable))
                MessageBox.Show("Attenzione! Si è verificato un errore!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            txtConditionFilter.Text = "";
        }

        //
        // LINEA DI COMANDO
        //
        private void txtCommandLine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string istruzione = txtCommandLine.Text.ToLower();

                // Espressioni regolari
                Match nonQuery = Regex.Match(istruzione, @"update|insert|delete|create|alter|drop|use");
                Match queryDgv = Regex.Match(istruzione, @"select|describe");
                Match queryLb = Regex.Match(istruzione, @"show");

                rtbCommandHistory.Text += ">> " + txtCommandLine.Text + "\n";

                if (nonQuery.Success)
                {
                    if (!client.ExecuteNonQuery(istruzione))
                        MessageBox.Show("Istruzione non corretta.");
                }
                else if (queryDgv.Success)
                {
                    if (!client.ExecuteQueryDGV(istruzione, ref dgvDataTable)) // quale dgv????
                        MessageBox.Show("Istruzione non corretta.");
                }
                else if (queryLb.Success)
                {
                    List<object> ls = client.ExecuteQuery(istruzione);

                    if (ls != null)
                        lbOutput.DataSource = ls;
                    else MessageBox.Show("Istruzione non corretta.");
                }
                else
                    MessageBox.Show("Istruzione non supportata.");

                txtCommandLine.Text = "";
            }
        }

        private void documentazioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La documentazione si può trovare al seguente link: http://www.pocketsql.altervista.org/", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PocketSql_FormClosed(sender, null);
            Close();
        }

        private void PocketSql_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (client.Connection.State != System.Data.ConnectionState.Closed)
                client.Connection.Close();
            client.CloseServer();
        }
    }
}