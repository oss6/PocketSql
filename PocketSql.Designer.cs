namespace PocketSql
{
    partial class PocketSql
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PocketSql));
            this.treeView = new System.Windows.Forms.TreeView();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.avviaConnessioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentazioneToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.licenzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpDatabase = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpDescribeTable = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tpPKManagement = new System.Windows.Forms.TabPage();
            this.btnDropPK = new System.Windows.Forms.Button();
            this.btnAddPK = new System.Windows.Forms.Button();
            this.txtPKFieldName = new System.Windows.Forms.TextBox();
            this.lblPKFieldName = new System.Windows.Forms.Label();
            this.tpFKManagement = new System.Windows.Forms.TabPage();
            this.gbRemoveFK = new System.Windows.Forms.GroupBox();
            this.txtFKFieldNameRemove = new System.Windows.Forms.TextBox();
            this.lblFKFieldNameRemove = new System.Windows.Forms.Label();
            this.btnDropFK = new System.Windows.Forms.Button();
            this.gbAddFK = new System.Windows.Forms.GroupBox();
            this.txtRefTableName = new System.Windows.Forms.TextBox();
            this.lblPKRefFieldName = new System.Windows.Forms.Label();
            this.txtFKFieldName = new System.Windows.Forms.TextBox();
            this.txtPKRefFieldName = new System.Windows.Forms.TextBox();
            this.lblFKFieldName = new System.Windows.Forms.Label();
            this.btnAddFK = new System.Windows.Forms.Button();
            this.lblTableNameRef = new System.Windows.Forms.Label();
            this.tpAddField = new System.Windows.Forms.TabPage();
            this.btnAddField = new System.Windows.Forms.Button();
            this.lblNull = new System.Windows.Forms.Label();
            this.lblFieldName = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtFieldNameAdd = new System.Windows.Forms.TextBox();
            this.txtDataTypeAdd = new System.Windows.Forms.TextBox();
            this.rbNullNo = new System.Windows.Forms.RadioButton();
            this.rbNullYes = new System.Windows.Forms.RadioButton();
            this.tpRemoveField = new System.Windows.Forms.TabPage();
            this.btnRemoveField = new System.Windows.Forms.Button();
            this.lblFieldRemove = new System.Windows.Forms.Label();
            this.txtFieldNameRemove = new System.Windows.Forms.TextBox();
            this.dgvDescribeTable = new System.Windows.Forms.DataGridView();
            this.tpDataTable = new System.Windows.Forms.TabPage();
            this.gbExportTable = new System.Windows.Forms.GroupBox();
            this.btnSaveTable = new System.Windows.Forms.Button();
            this.cbSaveTableFormat = new System.Windows.Forms.ComboBox();
            this.lblExport = new System.Windows.Forms.Label();
            this.gbDataTableManagement = new System.Windows.Forms.GroupBox();
            this.btnSaveDataTable = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtConditionFilter = new System.Windows.Forms.TextBox();
            this.lblConditionFilter = new System.Windows.Forms.Label();
            this.dgvDataTable = new System.Windows.Forms.DataGridView();
            this.tpCreateTable = new System.Windows.Forms.TabPage();
            this.btnResetTableCreation = new System.Windows.Forms.Button();
            this.lblCreateTableFields = new System.Windows.Forms.Label();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.lblTableName = new System.Windows.Forms.Label();
            this.txtTableNameCreate = new System.Windows.Forms.TextBox();
            this.dgvCreateTable = new System.Windows.Forms.DataGridView();
            this.tpCommandLine = new System.Windows.Forms.TabPage();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tabControlSQLFiles = new System.Windows.Forms.TabControl();
            this.tpFile1 = new System.Windows.Forms.TabPage();
            this.rtbEditor = new FastColoredTextBoxNS.FastColoredTextBox();
            this.dgvOutput = new System.Windows.Forms.DataGridView();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.menuCommandLine = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaScriptConNomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eseguiRigaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eseguiBloccoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opzioniEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizzaNascondiNumeroRigheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coloreDiSfondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDiCarattereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpSchemaLogico = new System.Windows.Forms.TabPage();
            this.btnGenerateSQL = new System.Windows.Forms.Button();
            this.btnSalvaSchemaLogico = new System.Windows.Forms.Button();
            this.txtNomeSchemaLogico = new System.Windows.Forms.TextBox();
            this.lblNomeSchemaLogico = new System.Windows.Forms.Label();
            this.btnImplementaSchemaLogico = new System.Windows.Forms.Button();
            this.rtbSchemaLogico = new FastColoredTextBoxNS.FastColoredTextBox();
            this.cmsDBM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuovaTabellaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.lblInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblState = new System.Windows.Forms.ToolStripStatusLabel();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.OFDSql = new System.Windows.Forms.OpenFileDialog();
            this.SFDSql = new System.Windows.Forms.SaveFileDialog();
            this.colorDialogEditor = new System.Windows.Forms.ColorDialog();
            this.fontDialogEditor = new System.Windows.Forms.FontDialog();
            this.lblPKDesc = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tpDatabase.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpDescribeTable.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tpPKManagement.SuspendLayout();
            this.tpFKManagement.SuspendLayout();
            this.gbRemoveFK.SuspendLayout();
            this.gbAddFK.SuspendLayout();
            this.tpAddField.SuspendLayout();
            this.tpRemoveField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescribeTable)).BeginInit();
            this.tpDataTable.SuspendLayout();
            this.gbExportTable.SuspendLayout();
            this.gbDataTableManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataTable)).BeginInit();
            this.tpCreateTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreateTable)).BeginInit();
            this.tpCommandLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tabControlSQLFiles.SuspendLayout();
            this.tpFile1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rtbEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.menuCommandLine.SuspendLayout();
            this.tpSchemaLogico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rtbSchemaLogico)).BeginInit();
            this.cmsDBM.SuspendLayout();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView.BackColor = System.Drawing.Color.Lavender;
            this.treeView.Location = new System.Drawing.Point(10, 31);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(209, 497);
            this.treeView.TabIndex = 0;
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avviaConnessioneToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.esciToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(984, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // avviaConnessioneToolStripMenuItem
            // 
            this.avviaConnessioneToolStripMenuItem.Name = "avviaConnessioneToolStripMenuItem";
            this.avviaConnessioneToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.avviaConnessioneToolStripMenuItem.Text = "Avvia connessione";
            this.avviaConnessioneToolStripMenuItem.Click += new System.EventHandler(this.avviaConnessioneToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creaToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // creaToolStripMenuItem
            // 
            this.creaToolStripMenuItem.Name = "creaToolStripMenuItem";
            this.creaToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.creaToolStripMenuItem.Text = "Crea";
            this.creaToolStripMenuItem.Click += new System.EventHandler(this.creaToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentazioneToolStripMenuItem1,
            this.licenzaToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // documentazioneToolStripMenuItem1
            // 
            this.documentazioneToolStripMenuItem1.Name = "documentazioneToolStripMenuItem1";
            this.documentazioneToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.documentazioneToolStripMenuItem1.Text = "Documentazione";
            this.documentazioneToolStripMenuItem1.Click += new System.EventHandler(this.documentazioneToolStripMenuItem1_Click);
            // 
            // licenzaToolStripMenuItem
            // 
            this.licenzaToolStripMenuItem.Name = "licenzaToolStripMenuItem";
            this.licenzaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.licenzaToolStripMenuItem.Text = "Licenza";
            this.licenzaToolStripMenuItem.Click += new System.EventHandler(this.licenzaToolStripMenuItem_Click);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.esciToolStripMenuItem.Text = "Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tpDatabase);
            this.tabControl.Controls.Add(this.tpCommandLine);
            this.tabControl.Controls.Add(this.tpSchemaLogico);
            this.tabControl.Location = new System.Drawing.Point(231, 31);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(739, 496);
            this.tabControl.TabIndex = 2;
            // 
            // tpDatabase
            // 
            this.tpDatabase.Controls.Add(this.tabControl1);
            this.tpDatabase.Location = new System.Drawing.Point(4, 24);
            this.tpDatabase.Name = "tpDatabase";
            this.tpDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.tpDatabase.Size = new System.Drawing.Size(731, 468);
            this.tpDatabase.TabIndex = 0;
            this.tpDatabase.Text = "Database";
            this.tpDatabase.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpDescribeTable);
            this.tabControl1.Controls.Add(this.tpDataTable);
            this.tabControl1.Controls.Add(this.tpCreateTable);
            this.tabControl1.Location = new System.Drawing.Point(7, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(717, 454);
            this.tabControl1.TabIndex = 0;
            // 
            // tpDescribeTable
            // 
            this.tpDescribeTable.Controls.Add(this.tabControl2);
            this.tpDescribeTable.Controls.Add(this.dgvDescribeTable);
            this.tpDescribeTable.Location = new System.Drawing.Point(4, 24);
            this.tpDescribeTable.Name = "tpDescribeTable";
            this.tpDescribeTable.Padding = new System.Windows.Forms.Padding(3);
            this.tpDescribeTable.Size = new System.Drawing.Size(709, 426);
            this.tpDescribeTable.TabIndex = 0;
            this.tpDescribeTable.Text = "Descrizione tabella";
            this.tpDescribeTable.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tpPKManagement);
            this.tabControl2.Controls.Add(this.tpFKManagement);
            this.tabControl2.Controls.Add(this.tpAddField);
            this.tabControl2.Controls.Add(this.tpRemoveField);
            this.tabControl2.Location = new System.Drawing.Point(445, 7);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(255, 414);
            this.tabControl2.TabIndex = 7;
            // 
            // tpPKManagement
            // 
            this.tpPKManagement.Controls.Add(this.lblPKDesc);
            this.tpPKManagement.Controls.Add(this.btnDropPK);
            this.tpPKManagement.Controls.Add(this.btnAddPK);
            this.tpPKManagement.Controls.Add(this.txtPKFieldName);
            this.tpPKManagement.Controls.Add(this.lblPKFieldName);
            this.tpPKManagement.Location = new System.Drawing.Point(4, 24);
            this.tpPKManagement.Name = "tpPKManagement";
            this.tpPKManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tpPKManagement.Size = new System.Drawing.Size(247, 386);
            this.tpPKManagement.TabIndex = 0;
            this.tpPKManagement.Text = "Chiave primaria";
            this.tpPKManagement.UseVisualStyleBackColor = true;
            // 
            // btnDropPK
            // 
            this.btnDropPK.Location = new System.Drawing.Point(73, 315);
            this.btnDropPK.Name = "btnDropPK";
            this.btnDropPK.Size = new System.Drawing.Size(117, 24);
            this.btnDropPK.TabIndex = 3;
            this.btnDropPK.Text = "Elimina chiave";
            this.btnDropPK.UseVisualStyleBackColor = true;
            this.btnDropPK.Click += new System.EventHandler(this.btnDropPK_Click);
            // 
            // btnAddPK
            // 
            this.btnAddPK.Location = new System.Drawing.Point(73, 241);
            this.btnAddPK.Name = "btnAddPK";
            this.btnAddPK.Size = new System.Drawing.Size(117, 24);
            this.btnAddPK.TabIndex = 2;
            this.btnAddPK.Text = "OK";
            this.btnAddPK.UseVisualStyleBackColor = true;
            this.btnAddPK.Click += new System.EventHandler(this.btnAddPK_Click);
            // 
            // txtPKFieldName
            // 
            this.txtPKFieldName.Location = new System.Drawing.Point(15, 197);
            this.txtPKFieldName.Name = "txtPKFieldName";
            this.txtPKFieldName.Size = new System.Drawing.Size(221, 21);
            this.txtPKFieldName.TabIndex = 1;
            // 
            // lblPKFieldName
            // 
            this.lblPKFieldName.AutoSize = true;
            this.lblPKFieldName.Location = new System.Drawing.Point(26, 175);
            this.lblPKFieldName.Name = "lblPKFieldName";
            this.lblPKFieldName.Size = new System.Drawing.Size(200, 15);
            this.lblPKFieldName.TabIndex = 0;
            this.lblPKFieldName.Text = "Inserisci campi (separati da virgole)";
            // 
            // tpFKManagement
            // 
            this.tpFKManagement.Controls.Add(this.gbRemoveFK);
            this.tpFKManagement.Controls.Add(this.gbAddFK);
            this.tpFKManagement.Location = new System.Drawing.Point(4, 24);
            this.tpFKManagement.Name = "tpFKManagement";
            this.tpFKManagement.Size = new System.Drawing.Size(247, 386);
            this.tpFKManagement.TabIndex = 3;
            this.tpFKManagement.Text = "Chiave esterna";
            this.tpFKManagement.UseVisualStyleBackColor = true;
            // 
            // gbRemoveFK
            // 
            this.gbRemoveFK.Controls.Add(this.txtFKFieldNameRemove);
            this.gbRemoveFK.Controls.Add(this.lblFKFieldNameRemove);
            this.gbRemoveFK.Controls.Add(this.btnDropFK);
            this.gbRemoveFK.Location = new System.Drawing.Point(31, 265);
            this.gbRemoveFK.Name = "gbRemoveFK";
            this.gbRemoveFK.Size = new System.Drawing.Size(199, 112);
            this.gbRemoveFK.TabIndex = 8;
            this.gbRemoveFK.TabStop = false;
            this.gbRemoveFK.Text = "Rimozione";
            // 
            // txtFKFieldNameRemove
            // 
            this.txtFKFieldNameRemove.Location = new System.Drawing.Point(42, 44);
            this.txtFKFieldNameRemove.Name = "txtFKFieldNameRemove";
            this.txtFKFieldNameRemove.Size = new System.Drawing.Size(116, 21);
            this.txtFKFieldNameRemove.TabIndex = 12;
            // 
            // lblFKFieldNameRemove
            // 
            this.lblFKFieldNameRemove.AutoSize = true;
            this.lblFKFieldNameRemove.Location = new System.Drawing.Point(38, 26);
            this.lblFKFieldNameRemove.Name = "lblFKFieldNameRemove";
            this.lblFKFieldNameRemove.Size = new System.Drawing.Size(129, 15);
            this.lblFKFieldNameRemove.TabIndex = 13;
            this.lblFKFieldNameRemove.Text = "Campo chiave esterna";
            // 
            // btnDropFK
            // 
            this.btnDropFK.Location = new System.Drawing.Point(42, 71);
            this.btnDropFK.Name = "btnDropFK";
            this.btnDropFK.Size = new System.Drawing.Size(117, 24);
            this.btnDropFK.TabIndex = 7;
            this.btnDropFK.Text = "Elimina chiave";
            this.btnDropFK.UseVisualStyleBackColor = true;
            this.btnDropFK.Click += new System.EventHandler(this.btnDropFK_Click);
            // 
            // gbAddFK
            // 
            this.gbAddFK.Controls.Add(this.txtRefTableName);
            this.gbAddFK.Controls.Add(this.lblPKRefFieldName);
            this.gbAddFK.Controls.Add(this.txtFKFieldName);
            this.gbAddFK.Controls.Add(this.txtPKRefFieldName);
            this.gbAddFK.Controls.Add(this.lblFKFieldName);
            this.gbAddFK.Controls.Add(this.btnAddFK);
            this.gbAddFK.Controls.Add(this.lblTableNameRef);
            this.gbAddFK.Location = new System.Drawing.Point(31, 10);
            this.gbAddFK.Name = "gbAddFK";
            this.gbAddFK.Size = new System.Drawing.Size(199, 249);
            this.gbAddFK.TabIndex = 8;
            this.gbAddFK.TabStop = false;
            this.gbAddFK.Text = "Inserimento";
            // 
            // txtRefTableName
            // 
            this.txtRefTableName.Location = new System.Drawing.Point(42, 46);
            this.txtRefTableName.Name = "txtRefTableName";
            this.txtRefTableName.Size = new System.Drawing.Size(116, 21);
            this.txtRefTableName.TabIndex = 9;
            // 
            // lblPKRefFieldName
            // 
            this.lblPKRefFieldName.AutoSize = true;
            this.lblPKRefFieldName.Location = new System.Drawing.Point(38, 87);
            this.lblPKRefFieldName.Name = "lblPKRefFieldName";
            this.lblPKRefFieldName.Size = new System.Drawing.Size(93, 15);
            this.lblPKRefFieldName.TabIndex = 4;
            this.lblPKRefFieldName.Text = "Chiave primaria";
            // 
            // txtFKFieldName
            // 
            this.txtFKFieldName.Location = new System.Drawing.Point(41, 165);
            this.txtFKFieldName.Name = "txtFKFieldName";
            this.txtFKFieldName.Size = new System.Drawing.Size(116, 21);
            this.txtFKFieldName.TabIndex = 11;
            // 
            // txtPKRefFieldName
            // 
            this.txtPKRefFieldName.Location = new System.Drawing.Point(41, 105);
            this.txtPKRefFieldName.Name = "txtPKRefFieldName";
            this.txtPKRefFieldName.Size = new System.Drawing.Size(116, 21);
            this.txtPKRefFieldName.TabIndex = 5;
            // 
            // lblFKFieldName
            // 
            this.lblFKFieldName.AutoSize = true;
            this.lblFKFieldName.Location = new System.Drawing.Point(38, 147);
            this.lblFKFieldName.Name = "lblFKFieldName";
            this.lblFKFieldName.Size = new System.Drawing.Size(129, 15);
            this.lblFKFieldName.TabIndex = 10;
            this.lblFKFieldName.Text = "Campo chiave esterna";
            // 
            // btnAddFK
            // 
            this.btnAddFK.Location = new System.Drawing.Point(41, 209);
            this.btnAddFK.Name = "btnAddFK";
            this.btnAddFK.Size = new System.Drawing.Size(117, 24);
            this.btnAddFK.TabIndex = 6;
            this.btnAddFK.Text = "OK";
            this.btnAddFK.UseVisualStyleBackColor = true;
            this.btnAddFK.Click += new System.EventHandler(this.btnAddFK_Click);
            // 
            // lblTableNameRef
            // 
            this.lblTableNameRef.AutoSize = true;
            this.lblTableNameRef.Location = new System.Drawing.Point(38, 28);
            this.lblTableNameRef.Name = "lblTableNameRef";
            this.lblTableNameRef.Size = new System.Drawing.Size(116, 15);
            this.lblTableNameRef.TabIndex = 8;
            this.lblTableNameRef.Text = "Tabella referenziata";
            // 
            // tpAddField
            // 
            this.tpAddField.Controls.Add(this.btnAddField);
            this.tpAddField.Controls.Add(this.lblNull);
            this.tpAddField.Controls.Add(this.lblFieldName);
            this.tpAddField.Controls.Add(this.lblSize);
            this.tpAddField.Controls.Add(this.txtFieldNameAdd);
            this.tpAddField.Controls.Add(this.txtDataTypeAdd);
            this.tpAddField.Controls.Add(this.rbNullNo);
            this.tpAddField.Controls.Add(this.rbNullYes);
            this.tpAddField.Location = new System.Drawing.Point(4, 24);
            this.tpAddField.Name = "tpAddField";
            this.tpAddField.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddField.Size = new System.Drawing.Size(247, 386);
            this.tpAddField.TabIndex = 1;
            this.tpAddField.Text = "Inserimento campo";
            this.tpAddField.UseVisualStyleBackColor = true;
            // 
            // btnAddField
            // 
            this.btnAddField.Location = new System.Drawing.Point(68, 296);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(87, 24);
            this.btnAddField.TabIndex = 9;
            this.btnAddField.Text = "Aggiungi";
            this.btnAddField.UseVisualStyleBackColor = true;
            this.btnAddField.Click += new System.EventHandler(this.btnAddField_Click);
            // 
            // lblNull
            // 
            this.lblNull.AutoSize = true;
            this.lblNull.Location = new System.Drawing.Point(65, 198);
            this.lblNull.Name = "lblNull";
            this.lblNull.Size = new System.Drawing.Size(69, 15);
            this.lblNull.TabIndex = 8;
            this.lblNull.Text = "Accetta null";
            // 
            // lblFieldName
            // 
            this.lblFieldName.AutoSize = true;
            this.lblFieldName.Location = new System.Drawing.Point(65, 55);
            this.lblFieldName.Name = "lblFieldName";
            this.lblFieldName.Size = new System.Drawing.Size(41, 15);
            this.lblFieldName.TabIndex = 5;
            this.lblFieldName.Text = "Nome";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(65, 124);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(145, 15);
            this.lblSize.TabIndex = 7;
            this.lblSize.Text = "Tipo di dati e dimensione";
            // 
            // txtFieldNameAdd
            // 
            this.txtFieldNameAdd.Location = new System.Drawing.Point(68, 73);
            this.txtFieldNameAdd.Name = "txtFieldNameAdd";
            this.txtFieldNameAdd.Size = new System.Drawing.Size(116, 21);
            this.txtFieldNameAdd.TabIndex = 0;
            // 
            // txtDataTypeAdd
            // 
            this.txtDataTypeAdd.Location = new System.Drawing.Point(68, 141);
            this.txtDataTypeAdd.Name = "txtDataTypeAdd";
            this.txtDataTypeAdd.Size = new System.Drawing.Size(116, 21);
            this.txtDataTypeAdd.TabIndex = 2;
            // 
            // rbNullNo
            // 
            this.rbNullNo.AutoSize = true;
            this.rbNullNo.Location = new System.Drawing.Point(68, 242);
            this.rbNullNo.Name = "rbNullNo";
            this.rbNullNo.Size = new System.Drawing.Size(41, 19);
            this.rbNullNo.TabIndex = 4;
            this.rbNullNo.TabStop = true;
            this.rbNullNo.Text = "No";
            this.rbNullNo.UseVisualStyleBackColor = true;
            // 
            // rbNullYes
            // 
            this.rbNullYes.AutoSize = true;
            this.rbNullYes.Location = new System.Drawing.Point(68, 215);
            this.rbNullYes.Name = "rbNullYes";
            this.rbNullYes.Size = new System.Drawing.Size(36, 19);
            this.rbNullYes.TabIndex = 3;
            this.rbNullYes.TabStop = true;
            this.rbNullYes.Text = "Si";
            this.rbNullYes.UseVisualStyleBackColor = true;
            // 
            // tpRemoveField
            // 
            this.tpRemoveField.Controls.Add(this.btnRemoveField);
            this.tpRemoveField.Controls.Add(this.lblFieldRemove);
            this.tpRemoveField.Controls.Add(this.txtFieldNameRemove);
            this.tpRemoveField.Location = new System.Drawing.Point(4, 24);
            this.tpRemoveField.Name = "tpRemoveField";
            this.tpRemoveField.Size = new System.Drawing.Size(247, 386);
            this.tpRemoveField.TabIndex = 2;
            this.tpRemoveField.Text = "Rimozione campo";
            this.tpRemoveField.UseVisualStyleBackColor = true;
            // 
            // btnRemoveField
            // 
            this.btnRemoveField.Location = new System.Drawing.Point(76, 197);
            this.btnRemoveField.Name = "btnRemoveField";
            this.btnRemoveField.Size = new System.Drawing.Size(87, 24);
            this.btnRemoveField.TabIndex = 2;
            this.btnRemoveField.Text = "Rimuovi";
            this.btnRemoveField.UseVisualStyleBackColor = true;
            this.btnRemoveField.Click += new System.EventHandler(this.btnRemoveField_Click);
            // 
            // lblFieldRemove
            // 
            this.lblFieldRemove.AutoSize = true;
            this.lblFieldRemove.Location = new System.Drawing.Point(73, 133);
            this.lblFieldRemove.Name = "lblFieldRemove";
            this.lblFieldRemove.Size = new System.Drawing.Size(41, 15);
            this.lblFieldRemove.TabIndex = 1;
            this.lblFieldRemove.Text = "Nome";
            // 
            // txtFieldNameRemove
            // 
            this.txtFieldNameRemove.Location = new System.Drawing.Point(76, 151);
            this.txtFieldNameRemove.Name = "txtFieldNameRemove";
            this.txtFieldNameRemove.Size = new System.Drawing.Size(116, 21);
            this.txtFieldNameRemove.TabIndex = 0;
            // 
            // dgvDescribeTable
            // 
            this.dgvDescribeTable.AllowUserToAddRows = false;
            this.dgvDescribeTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvDescribeTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDescribeTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDescribeTable.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDescribeTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvDescribeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDescribeTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDescribeTable.Location = new System.Drawing.Point(6, 7);
            this.dgvDescribeTable.Name = "dgvDescribeTable";
            this.dgvDescribeTable.ReadOnly = true;
            this.dgvDescribeTable.Size = new System.Drawing.Size(431, 410);
            this.dgvDescribeTable.TabIndex = 0;
            // 
            // tpDataTable
            // 
            this.tpDataTable.Controls.Add(this.gbExportTable);
            this.tpDataTable.Controls.Add(this.gbDataTableManagement);
            this.tpDataTable.Controls.Add(this.dgvDataTable);
            this.tpDataTable.Location = new System.Drawing.Point(4, 24);
            this.tpDataTable.Name = "tpDataTable";
            this.tpDataTable.Padding = new System.Windows.Forms.Padding(3);
            this.tpDataTable.Size = new System.Drawing.Size(709, 426);
            this.tpDataTable.TabIndex = 1;
            this.tpDataTable.Text = "Dati tabella";
            this.tpDataTable.UseVisualStyleBackColor = true;
            // 
            // gbExportTable
            // 
            this.gbExportTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbExportTable.Controls.Add(this.btnSaveTable);
            this.gbExportTable.Controls.Add(this.cbSaveTableFormat);
            this.gbExportTable.Controls.Add(this.lblExport);
            this.gbExportTable.Location = new System.Drawing.Point(522, 240);
            this.gbExportTable.Name = "gbExportTable";
            this.gbExportTable.Size = new System.Drawing.Size(177, 181);
            this.gbExportTable.TabIndex = 11;
            this.gbExportTable.TabStop = false;
            this.gbExportTable.Text = "Esporta tabella";
            // 
            // btnSaveTable
            // 
            this.btnSaveTable.Location = new System.Drawing.Point(34, 114);
            this.btnSaveTable.Name = "btnSaveTable";
            this.btnSaveTable.Size = new System.Drawing.Size(115, 22);
            this.btnSaveTable.TabIndex = 11;
            this.btnSaveTable.Text = "Esporta";
            this.btnSaveTable.UseVisualStyleBackColor = true;
            this.btnSaveTable.Click += new System.EventHandler(this.btnSaveTable_Click);
            // 
            // cbSaveTableFormat
            // 
            this.cbSaveTableFormat.FormattingEnabled = true;
            this.cbSaveTableFormat.Items.AddRange(new object[] {
            "CSV",
            "JSON",
            "HTML"});
            this.cbSaveTableFormat.Location = new System.Drawing.Point(31, 67);
            this.cbSaveTableFormat.Name = "cbSaveTableFormat";
            this.cbSaveTableFormat.Size = new System.Drawing.Size(121, 23);
            this.cbSaveTableFormat.TabIndex = 10;
            // 
            // lblExport
            // 
            this.lblExport.AutoSize = true;
            this.lblExport.Location = new System.Drawing.Point(41, 48);
            this.lblExport.Name = "lblExport";
            this.lblExport.Size = new System.Drawing.Size(95, 15);
            this.lblExport.TabIndex = 9;
            this.lblExport.Text = "Scegli il formato";
            // 
            // gbDataTableManagement
            // 
            this.gbDataTableManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDataTableManagement.Controls.Add(this.btnSaveDataTable);
            this.gbDataTableManagement.Controls.Add(this.btnFilter);
            this.gbDataTableManagement.Controls.Add(this.txtConditionFilter);
            this.gbDataTableManagement.Controls.Add(this.lblConditionFilter);
            this.gbDataTableManagement.Location = new System.Drawing.Point(522, 7);
            this.gbDataTableManagement.Name = "gbDataTableManagement";
            this.gbDataTableManagement.Size = new System.Drawing.Size(177, 227);
            this.gbDataTableManagement.TabIndex = 2;
            this.gbDataTableManagement.TabStop = false;
            this.gbDataTableManagement.Text = "Gestione dati tabella";
            // 
            // btnSaveDataTable
            // 
            this.btnSaveDataTable.Location = new System.Drawing.Point(34, 161);
            this.btnSaveDataTable.Name = "btnSaveDataTable";
            this.btnSaveDataTable.Size = new System.Drawing.Size(115, 27);
            this.btnSaveDataTable.TabIndex = 6;
            this.btnSaveDataTable.Text = "Applica modifiche";
            this.btnSaveDataTable.UseVisualStyleBackColor = true;
            this.btnSaveDataTable.Click += new System.EventHandler(this.btnSaveDataTable_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(34, 100);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(117, 24);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Filtra";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtConditionFilter
            // 
            this.txtConditionFilter.Location = new System.Drawing.Point(34, 70);
            this.txtConditionFilter.Name = "txtConditionFilter";
            this.txtConditionFilter.Size = new System.Drawing.Size(116, 21);
            this.txtConditionFilter.TabIndex = 2;
            // 
            // lblConditionFilter
            // 
            this.lblConditionFilter.AutoSize = true;
            this.lblConditionFilter.Location = new System.Drawing.Point(30, 52);
            this.lblConditionFilter.Name = "lblConditionFilter";
            this.lblConditionFilter.Size = new System.Drawing.Size(95, 15);
            this.lblConditionFilter.TabIndex = 1;
            this.lblConditionFilter.Text = "Condizione filtro";
            // 
            // dgvDataTable
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvDataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDataTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataTable.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDataTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDataTable.Location = new System.Drawing.Point(8, 7);
            this.dgvDataTable.Name = "dgvDataTable";
            this.dgvDataTable.Size = new System.Drawing.Size(508, 413);
            this.dgvDataTable.TabIndex = 1;
            // 
            // tpCreateTable
            // 
            this.tpCreateTable.Controls.Add(this.btnResetTableCreation);
            this.tpCreateTable.Controls.Add(this.lblCreateTableFields);
            this.tpCreateTable.Controls.Add(this.btnCreateTable);
            this.tpCreateTable.Controls.Add(this.lblTableName);
            this.tpCreateTable.Controls.Add(this.txtTableNameCreate);
            this.tpCreateTable.Controls.Add(this.dgvCreateTable);
            this.tpCreateTable.Location = new System.Drawing.Point(4, 24);
            this.tpCreateTable.Name = "tpCreateTable";
            this.tpCreateTable.Size = new System.Drawing.Size(709, 426);
            this.tpCreateTable.TabIndex = 2;
            this.tpCreateTable.Text = "Creazione tabella";
            this.tpCreateTable.UseVisualStyleBackColor = true;
            // 
            // btnResetTableCreation
            // 
            this.btnResetTableCreation.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnResetTableCreation.Location = new System.Drawing.Point(375, 375);
            this.btnResetTableCreation.Name = "btnResetTableCreation";
            this.btnResetTableCreation.Size = new System.Drawing.Size(127, 24);
            this.btnResetTableCreation.TabIndex = 5;
            this.btnResetTableCreation.Text = "Reset";
            this.btnResetTableCreation.UseVisualStyleBackColor = true;
            this.btnResetTableCreation.Click += new System.EventHandler(this.btnResetTableCreation_Click);
            // 
            // lblCreateTableFields
            // 
            this.lblCreateTableFields.AutoSize = true;
            this.lblCreateTableFields.Location = new System.Drawing.Point(13, 77);
            this.lblCreateTableFields.Name = "lblCreateTableFields";
            this.lblCreateTableFields.Size = new System.Drawing.Size(109, 15);
            this.lblCreateTableFields.TabIndex = 4;
            this.lblCreateTableFields.Text = "Inserimento campi";
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreateTable.Location = new System.Drawing.Point(227, 375);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(127, 24);
            this.btnCreateTable.TabIndex = 0;
            this.btnCreateTable.Text = "Salva";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            this.btnCreateTable.Click += new System.EventHandler(this.btnCreateTable_Click);
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Location = new System.Drawing.Point(13, 18);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(81, 15);
            this.lblTableName.TabIndex = 3;
            this.lblTableName.Text = "Nome tabella";
            // 
            // txtTableNameCreate
            // 
            this.txtTableNameCreate.Location = new System.Drawing.Point(16, 37);
            this.txtTableNameCreate.Name = "txtTableNameCreate";
            this.txtTableNameCreate.Size = new System.Drawing.Size(116, 21);
            this.txtTableNameCreate.TabIndex = 2;
            // 
            // dgvCreateTable
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvCreateTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCreateTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCreateTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCreateTable.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCreateTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvCreateTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCreateTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCreateTable.Location = new System.Drawing.Point(16, 95);
            this.dgvCreateTable.Name = "dgvCreateTable";
            this.dgvCreateTable.Size = new System.Drawing.Size(671, 246);
            this.dgvCreateTable.TabIndex = 1;
            // 
            // tpCommandLine
            // 
            this.tpCommandLine.Controls.Add(this.mainSplitContainer);
            this.tpCommandLine.Controls.Add(this.menuCommandLine);
            this.tpCommandLine.Location = new System.Drawing.Point(4, 24);
            this.tpCommandLine.Name = "tpCommandLine";
            this.tpCommandLine.Padding = new System.Windows.Forms.Padding(3);
            this.tpCommandLine.Size = new System.Drawing.Size(731, 468);
            this.tpCommandLine.TabIndex = 1;
            this.tpCommandLine.Text = "Modalità interattiva";
            this.tpCommandLine.UseVisualStyleBackColor = true;
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 30);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.splitContainer);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.dgvResults);
            this.mainSplitContainer.Size = new System.Drawing.Size(728, 435);
            this.mainSplitContainer.SplitterDistance = 533;
            this.mainSplitContainer.SplitterWidth = 3;
            this.mainSplitContainer.TabIndex = 9;
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.splitContainer.Location = new System.Drawing.Point(3, 3);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tabControlSQLFiles);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.dgvOutput);
            this.splitContainer.Size = new System.Drawing.Size(528, 429);
            this.splitContainer.SplitterDistance = 297;
            this.splitContainer.TabIndex = 8;
            // 
            // tabControlSQLFiles
            // 
            this.tabControlSQLFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlSQLFiles.Controls.Add(this.tpFile1);
            this.tabControlSQLFiles.Location = new System.Drawing.Point(3, 5);
            this.tabControlSQLFiles.Name = "tabControlSQLFiles";
            this.tabControlSQLFiles.SelectedIndex = 0;
            this.tabControlSQLFiles.Size = new System.Drawing.Size(522, 291);
            this.tabControlSQLFiles.TabIndex = 6;
            // 
            // tpFile1
            // 
            this.tpFile1.Controls.Add(this.rtbEditor);
            this.tpFile1.Location = new System.Drawing.Point(4, 24);
            this.tpFile1.Name = "tpFile1";
            this.tpFile1.Padding = new System.Windows.Forms.Padding(3);
            this.tpFile1.Size = new System.Drawing.Size(514, 263);
            this.tpFile1.TabIndex = 0;
            this.tpFile1.Text = "SQL File";
            this.tpFile1.UseVisualStyleBackColor = true;
            // 
            // rtbEditor
            // 
            this.rtbEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbEditor.AutoScrollMinSize = new System.Drawing.Size(25, 15);
            this.rtbEditor.BackBrush = null;
            this.rtbEditor.CharHeight = 15;
            this.rtbEditor.CharWidth = 7;
            this.rtbEditor.CommentPrefix = "--";
            this.rtbEditor.CurrentLineColor = System.Drawing.Color.LightGray;
            this.rtbEditor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbEditor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.rtbEditor.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.rtbEditor.IsReplaceMode = false;
            this.rtbEditor.Language = FastColoredTextBoxNS.Language.SQL;
            this.rtbEditor.LeftBracket = '(';
            this.rtbEditor.Location = new System.Drawing.Point(3, 3);
            this.rtbEditor.Name = "rtbEditor";
            this.rtbEditor.Paddings = new System.Windows.Forms.Padding(0);
            this.rtbEditor.RightBracket = ')';
            this.rtbEditor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.rtbEditor.Size = new System.Drawing.Size(511, 260);
            this.rtbEditor.TabIndex = 8;
            this.rtbEditor.Zoom = 100;
            this.rtbEditor.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.rtbEditor_TextChanged);
            this.rtbEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbEditor_KeyDown);
            // 
            // dgvOutput
            // 
            this.dgvOutput.AllowUserToAddRows = false;
            this.dgvOutput.AllowUserToDeleteRows = false;
            this.dgvOutput.AllowUserToResizeColumns = false;
            this.dgvOutput.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightBlue;
            this.dgvOutput.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOutput.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOutput.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutput.Location = new System.Drawing.Point(5, 4);
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.RowHeadersVisible = false;
            this.dgvOutput.Size = new System.Drawing.Size(520, 120);
            this.dgvOutput.TabIndex = 4;
            // 
            // dgvResults
            // 
            this.dgvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(3, 3);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.Size = new System.Drawing.Size(186, 429);
            this.dgvResults.TabIndex = 5;
            // 
            // menuCommandLine
            // 
            this.menuCommandLine.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.eseguiRigaToolStripMenuItem,
            this.eseguiBloccoToolStripMenuItem,
            this.opzioniEditorToolStripMenuItem});
            this.menuCommandLine.Location = new System.Drawing.Point(3, 3);
            this.menuCommandLine.Name = "menuCommandLine";
            this.menuCommandLine.Size = new System.Drawing.Size(725, 24);
            this.menuCommandLine.TabIndex = 7;
            this.menuCommandLine.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvaScriptToolStripMenuItem,
            this.salvaScriptConNomeToolStripMenuItem,
            this.apriScriptToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // salvaScriptToolStripMenuItem
            // 
            this.salvaScriptToolStripMenuItem.Name = "salvaScriptToolStripMenuItem";
            this.salvaScriptToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.salvaScriptToolStripMenuItem.Text = "Salva script";
            this.salvaScriptToolStripMenuItem.Click += new System.EventHandler(this.salvaScriptToolStripMenuItem_Click);
            // 
            // salvaScriptConNomeToolStripMenuItem
            // 
            this.salvaScriptConNomeToolStripMenuItem.Name = "salvaScriptConNomeToolStripMenuItem";
            this.salvaScriptConNomeToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.salvaScriptConNomeToolStripMenuItem.Text = "Salva script con nome";
            this.salvaScriptConNomeToolStripMenuItem.Click += new System.EventHandler(this.salvaScriptConNomeToolStripMenuItem_Click);
            // 
            // apriScriptToolStripMenuItem
            // 
            this.apriScriptToolStripMenuItem.Name = "apriScriptToolStripMenuItem";
            this.apriScriptToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.apriScriptToolStripMenuItem.Text = "Apri script";
            this.apriScriptToolStripMenuItem.Click += new System.EventHandler(this.apriScriptToolStripMenuItem_Click);
            // 
            // eseguiRigaToolStripMenuItem
            // 
            this.eseguiRigaToolStripMenuItem.Name = "eseguiRigaToolStripMenuItem";
            this.eseguiRigaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.eseguiRigaToolStripMenuItem.Text = "Esegui riga";
            this.eseguiRigaToolStripMenuItem.Click += new System.EventHandler(this.eseguiRigaToolStripMenuItem_Click);
            // 
            // eseguiBloccoToolStripMenuItem
            // 
            this.eseguiBloccoToolStripMenuItem.Name = "eseguiBloccoToolStripMenuItem";
            this.eseguiBloccoToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.eseguiBloccoToolStripMenuItem.Text = "Esegui blocco";
            this.eseguiBloccoToolStripMenuItem.Click += new System.EventHandler(this.eseguiBloccoToolStripMenuItem_Click);
            // 
            // opzioniEditorToolStripMenuItem
            // 
            this.opzioniEditorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizzaNascondiNumeroRigheToolStripMenuItem,
            this.coloreDiSfondoToolStripMenuItem,
            this.tipoDiCarattereToolStripMenuItem});
            this.opzioniEditorToolStripMenuItem.Name = "opzioniEditorToolStripMenuItem";
            this.opzioniEditorToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.opzioniEditorToolStripMenuItem.Text = "Opzioni editor";
            // 
            // visualizzaNascondiNumeroRigheToolStripMenuItem
            // 
            this.visualizzaNascondiNumeroRigheToolStripMenuItem.Name = "visualizzaNascondiNumeroRigheToolStripMenuItem";
            this.visualizzaNascondiNumeroRigheToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.visualizzaNascondiNumeroRigheToolStripMenuItem.Text = "Visualizza/Nascondi numero righe";
            this.visualizzaNascondiNumeroRigheToolStripMenuItem.Click += new System.EventHandler(this.visualizzaNascondiNumeroRigheToolStripMenuItem_Click);
            // 
            // coloreDiSfondoToolStripMenuItem
            // 
            this.coloreDiSfondoToolStripMenuItem.Name = "coloreDiSfondoToolStripMenuItem";
            this.coloreDiSfondoToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.coloreDiSfondoToolStripMenuItem.Text = "Colore di sfondo";
            this.coloreDiSfondoToolStripMenuItem.Click += new System.EventHandler(this.coloreDiSfondoToolStripMenuItem_Click);
            // 
            // tipoDiCarattereToolStripMenuItem
            // 
            this.tipoDiCarattereToolStripMenuItem.Name = "tipoDiCarattereToolStripMenuItem";
            this.tipoDiCarattereToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.tipoDiCarattereToolStripMenuItem.Text = "Tipo di carattere";
            this.tipoDiCarattereToolStripMenuItem.Click += new System.EventHandler(this.tipoDiCarattereToolStripMenuItem_Click);
            // 
            // tpSchemaLogico
            // 
            this.tpSchemaLogico.Controls.Add(this.btnGenerateSQL);
            this.tpSchemaLogico.Controls.Add(this.btnSalvaSchemaLogico);
            this.tpSchemaLogico.Controls.Add(this.txtNomeSchemaLogico);
            this.tpSchemaLogico.Controls.Add(this.lblNomeSchemaLogico);
            this.tpSchemaLogico.Controls.Add(this.btnImplementaSchemaLogico);
            this.tpSchemaLogico.Controls.Add(this.rtbSchemaLogico);
            this.tpSchemaLogico.Location = new System.Drawing.Point(4, 24);
            this.tpSchemaLogico.Name = "tpSchemaLogico";
            this.tpSchemaLogico.Size = new System.Drawing.Size(731, 468);
            this.tpSchemaLogico.TabIndex = 2;
            this.tpSchemaLogico.Text = "Schema logico relazionale";
            this.tpSchemaLogico.UseVisualStyleBackColor = true;
            // 
            // btnGenerateSQL
            // 
            this.btnGenerateSQL.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGenerateSQL.Location = new System.Drawing.Point(337, 391);
            this.btnGenerateSQL.Name = "btnGenerateSQL";
            this.btnGenerateSQL.Size = new System.Drawing.Size(91, 30);
            this.btnGenerateSQL.TabIndex = 5;
            this.btnGenerateSQL.Text = "Genera SQL";
            this.btnGenerateSQL.UseVisualStyleBackColor = true;
            this.btnGenerateSQL.Click += new System.EventHandler(this.btnGenerateSQL_Click);
            // 
            // btnSalvaSchemaLogico
            // 
            this.btnSalvaSchemaLogico.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSalvaSchemaLogico.Location = new System.Drawing.Point(456, 391);
            this.btnSalvaSchemaLogico.Name = "btnSalvaSchemaLogico";
            this.btnSalvaSchemaLogico.Size = new System.Drawing.Size(91, 30);
            this.btnSalvaSchemaLogico.TabIndex = 4;
            this.btnSalvaSchemaLogico.Text = "Salva";
            this.btnSalvaSchemaLogico.UseVisualStyleBackColor = true;
            this.btnSalvaSchemaLogico.Click += new System.EventHandler(this.btnSalvaSchemaLogico_Click);
            // 
            // txtNomeSchemaLogico
            // 
            this.txtNomeSchemaLogico.Location = new System.Drawing.Point(71, 18);
            this.txtNomeSchemaLogico.Name = "txtNomeSchemaLogico";
            this.txtNomeSchemaLogico.Size = new System.Drawing.Size(100, 21);
            this.txtNomeSchemaLogico.TabIndex = 3;
            // 
            // lblNomeSchemaLogico
            // 
            this.lblNomeSchemaLogico.AutoSize = true;
            this.lblNomeSchemaLogico.Location = new System.Drawing.Point(23, 18);
            this.lblNomeSchemaLogico.Name = "lblNomeSchemaLogico";
            this.lblNomeSchemaLogico.Size = new System.Drawing.Size(41, 15);
            this.lblNomeSchemaLogico.TabIndex = 2;
            this.lblNomeSchemaLogico.Text = "Nome";
            // 
            // btnImplementaSchemaLogico
            // 
            this.btnImplementaSchemaLogico.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImplementaSchemaLogico.Location = new System.Drawing.Point(216, 391);
            this.btnImplementaSchemaLogico.Name = "btnImplementaSchemaLogico";
            this.btnImplementaSchemaLogico.Size = new System.Drawing.Size(91, 30);
            this.btnImplementaSchemaLogico.TabIndex = 1;
            this.btnImplementaSchemaLogico.Text = "Implementa";
            this.btnImplementaSchemaLogico.UseVisualStyleBackColor = true;
            this.btnImplementaSchemaLogico.Click += new System.EventHandler(this.btnImplementaSchemaLogico_Click);
            // 
            // rtbSchemaLogico
            // 
            this.rtbSchemaLogico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSchemaLogico.AutoScrollMinSize = new System.Drawing.Size(25, 15);
            this.rtbSchemaLogico.BackBrush = null;
            this.rtbSchemaLogico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbSchemaLogico.CharHeight = 15;
            this.rtbSchemaLogico.CharWidth = 7;
            this.rtbSchemaLogico.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbSchemaLogico.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.rtbSchemaLogico.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.rtbSchemaLogico.IsReplaceMode = false;
            this.rtbSchemaLogico.Location = new System.Drawing.Point(23, 58);
            this.rtbSchemaLogico.Name = "rtbSchemaLogico";
            this.rtbSchemaLogico.Paddings = new System.Windows.Forms.Padding(0);
            this.rtbSchemaLogico.RightBracket = ')';
            this.rtbSchemaLogico.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.rtbSchemaLogico.Size = new System.Drawing.Size(687, 312);
            this.rtbSchemaLogico.TabIndex = 0;
            this.rtbSchemaLogico.Zoom = 100;
            this.rtbSchemaLogico.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.rtbSchemaLogico_TextChanged);
            // 
            // cmsDBM
            // 
            this.cmsDBM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminaToolStripMenuItem,
            this.nuovaTabellaToolStripMenuItem});
            this.cmsDBM.Name = "cmsDBM";
            this.cmsDBM.Size = new System.Drawing.Size(148, 48);
            // 
            // eliminaToolStripMenuItem
            // 
            this.eliminaToolStripMenuItem.Name = "eliminaToolStripMenuItem";
            this.eliminaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.eliminaToolStripMenuItem.Text = "Elimina";
            this.eliminaToolStripMenuItem.Click += new System.EventHandler(this.eliminaToolStripMenuItem_Click);
            // 
            // nuovaTabellaToolStripMenuItem
            // 
            this.nuovaTabellaToolStripMenuItem.Name = "nuovaTabellaToolStripMenuItem";
            this.nuovaTabellaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.nuovaTabellaToolStripMenuItem.Text = "Nuova tabella";
            this.nuovaTabellaToolStripMenuItem.Click += new System.EventHandler(this.nuovaTabellaToolStripMenuItem_Click);
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.SystemColors.Window;
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblInfo,
            this.lblState});
            this.status.Location = new System.Drawing.Point(0, 540);
            this.status.Name = "status";
            this.status.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.status.Size = new System.Drawing.Size(984, 22);
            this.status.TabIndex = 3;
            this.status.Text = "statusStrip1";
            // 
            // lblInfo
            // 
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(45, 17);
            this.lblInfo.Text = "MySQL";
            // 
            // lblState
            // 
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(40, 17);
            this.lblState.Text = "Stato: ";
            // 
            // SFD
            // 
            this.SFD.Filter = "File CSV|*.csv|Tutti i file|*.*";
            // 
            // OFDSql
            // 
            this.OFDSql.Filter = "File SQL|*.sql|Tutti i file|*.*";
            // 
            // SFDSql
            // 
            this.SFDSql.Filter = "File SQL|*.sql|Tutti i file|*.*";
            // 
            // lblPKDesc
            // 
            this.lblPKDesc.AutoSize = true;
            this.lblPKDesc.Location = new System.Drawing.Point(3, 45);
            this.lblPKDesc.Name = "lblPKDesc";
            this.lblPKDesc.Size = new System.Drawing.Size(246, 75);
            this.lblPKDesc.TabIndex = 4;
            this.lblPKDesc.Text = "In questa sezione è possibile aggiungere \r\nuna o più chiavi primarie\r\n(chiave com" +
    "posta). I nomi dei campi\r\nda aggiungere come chiave primaria\r\nvanno separati da " +
    "virgole (anche con spazi).";
            // 
            // PocketSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.status);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.menu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(999, 600);
            this.Name = "PocketSql";
            this.Text = "Pocket SQL v 0.2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PocketSql_FormClosed);
            this.Load += new System.EventHandler(this.PocketSql_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tpDatabase.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpDescribeTable.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tpPKManagement.ResumeLayout(false);
            this.tpPKManagement.PerformLayout();
            this.tpFKManagement.ResumeLayout(false);
            this.gbRemoveFK.ResumeLayout(false);
            this.gbRemoveFK.PerformLayout();
            this.gbAddFK.ResumeLayout(false);
            this.gbAddFK.PerformLayout();
            this.tpAddField.ResumeLayout(false);
            this.tpAddField.PerformLayout();
            this.tpRemoveField.ResumeLayout(false);
            this.tpRemoveField.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescribeTable)).EndInit();
            this.tpDataTable.ResumeLayout(false);
            this.gbExportTable.ResumeLayout(false);
            this.gbExportTable.PerformLayout();
            this.gbDataTableManagement.ResumeLayout(false);
            this.gbDataTableManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataTable)).EndInit();
            this.tpCreateTable.ResumeLayout(false);
            this.tpCreateTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreateTable)).EndInit();
            this.tpCommandLine.ResumeLayout(false);
            this.tpCommandLine.PerformLayout();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tabControlSQLFiles.ResumeLayout(false);
            this.tpFile1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rtbEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.menuCommandLine.ResumeLayout(false);
            this.menuCommandLine.PerformLayout();
            this.tpSchemaLogico.ResumeLayout(false);
            this.tpSchemaLogico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rtbSchemaLogico)).EndInit();
            this.cmsDBM.ResumeLayout(false);
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpDatabase;
        private System.Windows.Forms.TabPage tpCommandLine;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpDescribeTable;
        private System.Windows.Forms.TabPage tpDataTable;
        private System.Windows.Forms.DataGridView dgvDescribeTable;
        private System.Windows.Forms.DataGridView dgvDataTable;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsDBM;
        private System.Windows.Forms.ToolStripMenuItem eliminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuovaTabellaToolStripMenuItem;
        private System.Windows.Forms.Button btnAddPK;
        private System.Windows.Forms.TextBox txtPKFieldName;
        private System.Windows.Forms.Label lblPKFieldName;
        private System.Windows.Forms.Button btnDropPK;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel lblInfo;
        private System.Windows.Forms.ToolStripStatusLabel lblState;
        private System.Windows.Forms.TextBox txtFieldNameAdd;
        private System.Windows.Forms.TextBox txtDataTypeAdd;
        private System.Windows.Forms.RadioButton rbNullYes;
        private System.Windows.Forms.RadioButton rbNullNo;
        private System.Windows.Forms.Label lblNull;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblFieldName;
        private System.Windows.Forms.Button btnAddField;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tpPKManagement;
        private System.Windows.Forms.TabPage tpAddField;
        private System.Windows.Forms.TabPage tpRemoveField;
        private System.Windows.Forms.Label lblFieldRemove;
        private System.Windows.Forms.TextBox txtFieldNameRemove;
        private System.Windows.Forms.Button btnRemoveField;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.TabPage tpCreateTable;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.DataGridView dgvCreateTable;
        private System.Windows.Forms.TextBox txtTableNameCreate;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.GroupBox gbDataTableManagement;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtConditionFilter;
        private System.Windows.Forms.Label lblConditionFilter;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.TabPage tpFKManagement;
        private System.Windows.Forms.Button btnDropFK;
        private System.Windows.Forms.Button btnAddFK;
        private System.Windows.Forms.TextBox txtPKRefFieldName;
        private System.Windows.Forms.Label lblPKRefFieldName;
        private System.Windows.Forms.TextBox txtRefTableName;
        private System.Windows.Forms.Label lblTableNameRef;
        private System.Windows.Forms.TextBox txtFKFieldName;
        private System.Windows.Forms.Label lblFKFieldName;
        private System.Windows.Forms.Button btnSaveDataTable;
        private System.Windows.Forms.ToolStripMenuItem avviaConnessioneToolStripMenuItem;
        private System.Windows.Forms.Label lblCreateTableFields;
        private System.Windows.Forms.DataGridView dgvOutput;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.TabControl tabControlSQLFiles;
        private System.Windows.Forms.TabPage tpFile1;
        private System.Windows.Forms.MenuStrip menuCommandLine;
        private System.Windows.Forms.ToolStripMenuItem eseguiRigaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaScriptConNomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apriScriptToolStripMenuItem;
        private FastColoredTextBoxNS.FastColoredTextBox rtbEditor;
        private System.Windows.Forms.OpenFileDialog OFDSql;
        private System.Windows.Forms.SaveFileDialog SFDSql;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.ToolStripMenuItem eseguiBloccoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opzioniEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizzaNascondiNumeroRigheToolStripMenuItem;
        private System.Windows.Forms.TabPage tpSchemaLogico;
        private FastColoredTextBoxNS.FastColoredTextBox rtbSchemaLogico;
        private System.Windows.Forms.Button btnImplementaSchemaLogico;
        private System.Windows.Forms.TextBox txtNomeSchemaLogico;
        private System.Windows.Forms.Label lblNomeSchemaLogico;
        private System.Windows.Forms.Button btnSalvaSchemaLogico;
        private System.Windows.Forms.Button btnGenerateSQL;
        private System.Windows.Forms.Label lblFKFieldNameRemove;
        private System.Windows.Forms.TextBox txtFKFieldNameRemove;
        private System.Windows.Forms.ComboBox cbSaveTableFormat;
        private System.Windows.Forms.Label lblExport;
        private System.Windows.Forms.GroupBox gbExportTable;
        private System.Windows.Forms.Button btnSaveTable;
        private System.Windows.Forms.GroupBox gbAddFK;
        private System.Windows.Forms.GroupBox gbRemoveFK;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentazioneToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem licenzaToolStripMenuItem;
        private System.Windows.Forms.Button btnResetTableCreation;
        private System.Windows.Forms.ToolStripMenuItem coloreDiSfondoToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialogEditor;
        private System.Windows.Forms.FontDialog fontDialogEditor;
        private System.Windows.Forms.ToolStripMenuItem tipoDiCarattereToolStripMenuItem;
        private System.Windows.Forms.Label lblPKDesc;
    }
}

