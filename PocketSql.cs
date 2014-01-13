using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PocketSql
{
    public partial class PocketSql : Form
    {
        // =============================
        // === DICHIARAZIONE OGGETTI ===
        // =============================
        MySqlClient client = new MySqlClient("localhost", "root", "pippo123");
        string nonQueryStatements = @"update|insert|delete|create|alter|drop|use|grant|revoke|analyze|audit|comment|truncate|rename";
        string queryStatements = @"select|describe|show";
        string fileName = "";
        bool toggleLineNumbers = false;

        public PocketSql()
        {
            InitializeComponent();

            // Usa Segoe UI in Vista e 7 e Microsoft Sans Serif in XP e precedenti.
            Font = SystemFonts.MessageBoxFont;
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
            if (client.StartServer(@"C:\Users\EdBali O\Documents\MySQL\mysql-5.6.12-win32-portable\mysql-5.6.12-win32-portable\mysql-5.6.12-win32\bin\mysqld.exe"))
            {
                VisualizeTree();

                // Informazioni sul client nella barra di stato
                lblInfo.Text = "MySQL v. " + client.Connection.ServerVersion;
                lblState.Text += client.Connection.State.ToString();
            }

            // Gestione datagridview creazione tabella
            dgvCreateTable.ColumnCount = 4;
            dgvCreateTable.Columns[0].HeaderText = "Nome";
            dgvCreateTable.Columns[1].HeaderText = "Tipo di dati";
            dgvCreateTable.Columns[2].HeaderText = "Null";
            dgvCreateTable.Columns[3].HeaderText = "Chiave primaria";

            // Gestione datagridview output
            dgvOutput.ColumnCount = 5;
            dgvOutput.Columns[0].HeaderText = "Esito";
            dgvOutput.Columns[1].HeaderText = "N. riga";
            dgvOutput.Columns[2].HeaderText = "Tempo";
            dgvOutput.Columns[3].HeaderText = "Azione";
            dgvOutput.Columns[4].HeaderText = "Messaggio";

            rtbEditor.Language = Language.SQL;
            rtbSchemaLogico.Language = Language.Custom;
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
            string fieldName, dataType, isNull;
            List<string> primaryKeys = new List<string>();

            for (int i = 0; i < dgvCreateTable.Rows.Count - 1; i++)
            {
                fieldName = dgvCreateTable[0, i].Value + "";
                dataType = dgvCreateTable[1, i].Value + "";
                isNull = (dgvCreateTable[2, i].Value + "").ToUpper() == "SI" ? "NULL" : "NOT NULL";
                strCmd += (fieldName + " " + dataType + " " + isNull);

                if((dgvCreateTable[3, i].Value + "").ToUpper() == "SI")
                    primaryKeys.Add(fieldName);

                // Controllo ultimo campo
                if (i == dgvCreateTable.Rows.Count - 2 && primaryKeys.Count == 0)
                    strCmd += ");";
                else strCmd += ",";
            }

            // Aggiunta di eventuali chiavi primarie
            if (primaryKeys.Count != 0)
            {
                string constraint = "pk_" + txtTableNameCreate.Text;
                strCmd += "CONSTRAINT " + constraint + " PRIMARY KEY (";
                for (int i = 0; i < primaryKeys.Count; i++)
                    strCmd += (i == primaryKeys.Count - 1 ? primaryKeys[i] + ")" : primaryKeys[i] + ",");
                strCmd += ");";
            }

            if (!(bool)client.ExecuteNonQuery(strCmd)[0])
                MessageBox.Show("Attenzione si è verificato un errore!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                VisualizeTree();

                txtTableNameCreate.Text = "";
                dgvCreateTable.DataSource = null;
                dgvCreateTable.Rows.Clear();
            }
        }

        private void btnResetTableCreation_Click(object sender, EventArgs e)
        {
            txtTableNameCreate.Text = "";
            dgvCreateTable.DataSource = null;
            dgvCreateTable.Rows.Clear();
        }

        //
        // SALVATAGGIO TABELLA IN FORMATO: CSV, JSON, HTML
        //
        private void btnSaveTable_Click(object sender, EventArgs e)
        {
            switch (cbSaveTableFormat.SelectedIndex)
            {
                // CSV
                case 0: 
                    SFD.Filter = "File CSV|*.csv|Tutti i file|*.*";

                    if (SFD.ShowDialog() == DialogResult.OK)
                    {
                        if (!client.WriteTableCSV(SFD.FileName, client.CurrentTable))
                            MessageBox.Show("Attenzione si è verificato un errore!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else MessageBox.Show("Tabella salvata correttamente!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                // JSON
                case 1: 
                    SFD.Filter = "File JSON|*.json|Tutti i file|*.*";

                    if (SFD.ShowDialog() == DialogResult.OK)
                    {
                        if (!client.WriteTableJSON(SFD.FileName, client.CurrentTable))
                            MessageBox.Show("Attenzione si è verificato un errore!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else MessageBox.Show("Tabella salvata correttamente!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                // HTML
                case 2: 
                    SFD.Filter = "File HTML|*.html|Tutti i file|*.*";

                    if (SFD.ShowDialog() == DialogResult.OK)
                    {
                        if (!client.WriteTableHTML(SFD.FileName, client.CurrentTable))
                            MessageBox.Show("Attenzione si è verificato un errore!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else MessageBox.Show("Tabella salvata correttamente!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
            }
        }

        //
        // INSERIMENTO CHIAVE PRIMARIA
        //
        private void btnAddPK_Click(object sender, EventArgs e)
        {
            if (!client.AddPrimaryKey(client.CurrentTable, txtPKFieldName.Text))
                MessageBox.Show("Attenzione si è verificato un errore!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                client.DescribeTable(client.CurrentTable, ref dgvDescribeTable);
                client.SelectAll(client.CurrentTable, ref dgvDataTable);
                MessageBox.Show("Chiave primaria aggiunta correttamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Chiave primaria eliminata correttamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (!client.DropForeignKey(client.CurrentTable, txtFKFieldNameRemove.Text))
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
                MessageBox.Show("Attenzione! Si è verificato un errore!\nControllare se la tabella possiede una chiave primaria.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        void HighlightComments(Range range)
        {
            Style GreenStyle = rtbEditor.SyntaxHighlighter.GreenStyle;

            range.ClearStyle(GreenStyle);

            // Commenti
            range.SetStyle(GreenStyle, @"#.*$", RegexOptions.Multiline);
            range.SetStyle(GreenStyle, @"(/\*.*?\*/)|(/\*.*)", RegexOptions.Singleline);
            range.SetStyle(GreenStyle, @"(/\*.*?\*/)|(.*\*/)", RegexOptions.Singleline | RegexOptions.RightToLeft);
        }

        void HighlightExtendedKeyWords(Range range)
        {
            Style BlueBoldStyle = rtbEditor.SyntaxHighlighter.BlueBoldStyle;
            range.SetStyle(BlueBoldStyle, @"(show|databases|tables|describe)", RegexOptions.Multiline);
        }

        bool ExecuteStatement(string st, int riga)
        {
            Match nonQuery = Regex.Match(st, nonQueryStatements);
            Match query = Regex.Match(st, queryStatements);
            object[] res = null; // Result array

            if (nonQuery.Success)
                res = client.ExecuteNonQuery(st);
            else if (query.Success)
                res = client.ExecuteQueryDGV(st, ref dgvResults);
            else return false;

            // Aggiorna la griglia di output (feedback)
            dgvOutput.Rows.Add();
            dgvOutput[0, dgvOutput.RowCount - 1].Value = (bool)res[0] ? "Positivo" : "Negativo";
            dgvOutput[1, dgvOutput.RowCount - 1].Value = riga + 1;
            dgvOutput[2, dgvOutput.RowCount - 1].Value = DateTime.Now.ToLongTimeString();
            dgvOutput[3, dgvOutput.RowCount - 1].Value = st;
            dgvOutput[4, dgvOutput.RowCount - 1].Value = (bool)res[0] ? res[1] + " riga/righe riportate" : (string)res[2];

            return true;
        }

        private void eseguiRigaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int riga = rtbEditor.GetRange(rtbEditor.SelectionStart, rtbEditor.SelectionStart).End.iLine;
            string istruzione = rtbEditor.GetLineText(riga);

            if (!ExecuteStatement(istruzione.Trim().Replace("\"", "'"), riga))
                MessageBox.Show("Controllare la sintassi.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void eseguiBloccoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] statements = rtbEditor.SelectedText == "" ? rtbEditor.Text.Split(';') : rtbEditor.SelectedText.Split(';');

            for (int i = 0; i < statements.Length - 1; i++)
                ExecuteStatement(statements[i].Trim().Replace("\"", "'") + ";", i);
        }

        private void rtbEditor_TextChanged(object sender, TextChangedEventArgs e)
        {
            HighlightComments(rtbEditor.VisibleRange);
            HighlightExtendedKeyWords(rtbEditor.VisibleRange);
        }

        private void rtbEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (!tpFile1.Text.Contains("*"))
                tpFile1.Text += "*";

            if (e.Control && e.KeyCode == Keys.S)
            {
                salvaScriptToolStripMenuItem_Click(null, null);
                e.SuppressKeyPress = true;
            }
        }

        private void salvaScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName == "")
                salvaScriptConNomeToolStripMenuItem_Click(null, null);
            else
            {
                rtbEditor.SaveToFile(fileName, Encoding.UTF8);
                tpFile1.Text = tpFile1.Text.Replace("*", "");

                rtbEditor.SyntaxHighlighter.SQLSyntaxHighlight(rtbEditor.Range);
            }
        }

        private void salvaScriptConNomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SFDSql.ShowDialog() == DialogResult.OK)
            {
                rtbEditor.SaveToFile(SFDSql.FileName, Encoding.UTF8);
                fileName = SFDSql.FileName; // Registra nome del file
                tpFile1.Text = fileName.Split('\\').Last();
            }

            rtbEditor.SyntaxHighlighter.SQLSyntaxHighlight(rtbEditor.Range);
        }

        private void apriScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OFDSql.ShowDialog() == DialogResult.OK)
            {
                rtbEditor.OpenBindingFile(OFDSql.FileName, Encoding.UTF8);
                tpFile1.Text = OFDSql.SafeFileName;
                fileName = OFDSql.FileName;
            }

            rtbEditor.SyntaxHighlighter.SQLSyntaxHighlight(rtbEditor.Range);
            HighlightComments(rtbEditor.Range);
        }

        private void visualizzaNascondiNumeroRigheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.ShowLineNumbers = toggleLineNumbers;
            toggleLineNumbers = !toggleLineNumbers;
        }

        private void coloreDiSfondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialogEditor.ShowDialog() == DialogResult.OK)
                rtbEditor.BackColor = colorDialogEditor.Color;
        }

        private void tipoDiCarattereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialogEditor.ShowDialog() == DialogResult.OK)
                rtbEditor.Font = fontDialogEditor.Font;
        }

        //
        // SCHEMA LOGICO
        //
        private void rtbSchemaLogico_TextChanged(object sender, TextChangedEventArgs e)
        {
            Range range = e.ChangedRange;
            Style BoldStyle = rtbSchemaLogico.SyntaxHighlighter.BlueBoldStyle;

            range.ClearStyle(BoldStyle);
            range.SetStyle(BoldStyle, @"(pk|fk|opt|{|})");
        }

        private void btnImplementaSchemaLogico_Click(object sender, EventArgs e)
        {
            if (txtNomeSchemaLogico.Text != "" || rtbSchemaLogico.Text != "")
            {
                SchemaLogico schema = SchemaLogico.Analizza(txtNomeSchemaLogico.Text, rtbSchemaLogico.Text.Trim());
                client.ExecuteNonQuery(schema.GeneraSQL());

                VisualizeTree();
            }
            else MessageBox.Show("Inserire il nome dello schema.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGenerateSQL_Click(object sender, EventArgs e)
        {
            if (txtNomeSchemaLogico.Text != "" || rtbSchemaLogico.Text != "")
            {
                SchemaLogico schema = SchemaLogico.Analizza(txtNomeSchemaLogico.Text, rtbSchemaLogico.Text.Trim());
                rtbEditor.Text = schema.GeneraSQL(true);
                tabControl.SelectedIndex = 1;
            }
            else MessageBox.Show("Inserire il nome dello schema.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalvaSchemaLogico_Click(object sender, EventArgs e)
        {
            if (txtNomeSchemaLogico.Text != "" || rtbSchemaLogico.Text != "")
            {
                SchemaLogico schema = SchemaLogico.Analizza(txtNomeSchemaLogico.Text, rtbSchemaLogico.Text.Trim());
                SFD.Filter = "File JSON|*.json|Tutti i file|*.*";

                if (SFD.ShowDialog() == DialogResult.OK)
                {
                    if (!schema.Salva(SFD.FileName))
                        MessageBox.Show("Attenzione si è verificato un errore!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else MessageBox.Show("Schema logico salvato correttamente!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else MessageBox.Show("Inserire il nome dello schema.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void documentazioneToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.pocketsql.altervista.org/doc.html");
        }

        private void licenzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.pocketsql.altervista.org/license.html");
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
        }
    }
}