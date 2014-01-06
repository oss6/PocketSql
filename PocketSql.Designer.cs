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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PocketSql));
            this.treeView = new System.Windows.Forms.TreeView();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.avviaConnessioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentazioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.txtFKFieldName = new System.Windows.Forms.TextBox();
            this.lblFKFieldName = new System.Windows.Forms.Label();
            this.txtRefTableName = new System.Windows.Forms.TextBox();
            this.lblTableNameRef = new System.Windows.Forms.Label();
            this.btnDropFK = new System.Windows.Forms.Button();
            this.btnAddFK = new System.Windows.Forms.Button();
            this.txtPKRefFieldName = new System.Windows.Forms.TextBox();
            this.lblPKRefFieldName = new System.Windows.Forms.Label();
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
            this.gbDataTableManagement = new System.Windows.Forms.GroupBox();
            this.btnSaveDataTable = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtConditionFilter = new System.Windows.Forms.TextBox();
            this.lblConditionFilter = new System.Windows.Forms.Label();
            this.btnSaveTableCSV = new System.Windows.Forms.Button();
            this.dgvDataTable = new System.Windows.Forms.DataGridView();
            this.tpCreateTable = new System.Windows.Forms.TabPage();
            this.lblCreateTableFields = new System.Windows.Forms.Label();
            this.lblTableName = new System.Windows.Forms.Label();
            this.txtTableNameCreate = new System.Windows.Forms.TextBox();
            this.dgvCreateTable = new System.Windows.Forms.DataGridView();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.tpCommandLine = new System.Windows.Forms.TabPage();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.txtCommandLine = new System.Windows.Forms.TextBox();
            this.rtbCommandHistory = new System.Windows.Forms.RichTextBox();
            this.cmsDBM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuovaTabellaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.lblInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblState = new System.Windows.Forms.ToolStripStatusLabel();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.menu.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tpDatabase.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpDescribeTable.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tpPKManagement.SuspendLayout();
            this.tpFKManagement.SuspendLayout();
            this.tpAddField.SuspendLayout();
            this.tpRemoveField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescribeTable)).BeginInit();
            this.tpDataTable.SuspendLayout();
            this.gbDataTableManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataTable)).BeginInit();
            this.tpCreateTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreateTable)).BeginInit();
            this.tpCommandLine.SuspendLayout();
            this.cmsDBM.SuspendLayout();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView.Location = new System.Drawing.Point(14, 31);
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
            this.documentazioneToolStripMenuItem,
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
            // documentazioneToolStripMenuItem
            // 
            this.documentazioneToolStripMenuItem.Name = "documentazioneToolStripMenuItem";
            this.documentazioneToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.documentazioneToolStripMenuItem.Text = "Documentazione";
            this.documentazioneToolStripMenuItem.Click += new System.EventHandler(this.documentazioneToolStripMenuItem_Click);
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
            this.tabControl1.Size = new System.Drawing.Size(716, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tpDescribeTable
            // 
            this.tpDescribeTable.Controls.Add(this.tabControl2);
            this.tpDescribeTable.Controls.Add(this.dgvDescribeTable);
            this.tpDescribeTable.Location = new System.Drawing.Point(4, 24);
            this.tpDescribeTable.Name = "tpDescribeTable";
            this.tpDescribeTable.Padding = new System.Windows.Forms.Padding(3);
            this.tpDescribeTable.Size = new System.Drawing.Size(708, 422);
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
            this.tabControl2.Location = new System.Drawing.Point(444, 7);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(256, 401);
            this.tabControl2.TabIndex = 7;
            // 
            // tpPKManagement
            // 
            this.tpPKManagement.Controls.Add(this.btnDropPK);
            this.tpPKManagement.Controls.Add(this.btnAddPK);
            this.tpPKManagement.Controls.Add(this.txtPKFieldName);
            this.tpPKManagement.Controls.Add(this.lblPKFieldName);
            this.tpPKManagement.Location = new System.Drawing.Point(4, 24);
            this.tpPKManagement.Name = "tpPKManagement";
            this.tpPKManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tpPKManagement.Size = new System.Drawing.Size(248, 373);
            this.tpPKManagement.TabIndex = 0;
            this.tpPKManagement.Text = "Chiave primaria";
            this.tpPKManagement.UseVisualStyleBackColor = true;
            // 
            // btnDropPK
            // 
            this.btnDropPK.Location = new System.Drawing.Point(73, 226);
            this.btnDropPK.Name = "btnDropPK";
            this.btnDropPK.Size = new System.Drawing.Size(117, 24);
            this.btnDropPK.TabIndex = 3;
            this.btnDropPK.Text = "Elimina chiave";
            this.btnDropPK.UseVisualStyleBackColor = true;
            this.btnDropPK.Click += new System.EventHandler(this.btnDropPK_Click);
            // 
            // btnAddPK
            // 
            this.btnAddPK.Location = new System.Drawing.Point(73, 164);
            this.btnAddPK.Name = "btnAddPK";
            this.btnAddPK.Size = new System.Drawing.Size(117, 24);
            this.btnAddPK.TabIndex = 2;
            this.btnAddPK.Text = "OK";
            this.btnAddPK.UseVisualStyleBackColor = true;
            this.btnAddPK.Click += new System.EventHandler(this.btnAddPK_Click);
            // 
            // txtPKFieldName
            // 
            this.txtPKFieldName.Location = new System.Drawing.Point(73, 134);
            this.txtPKFieldName.Name = "txtPKFieldName";
            this.txtPKFieldName.Size = new System.Drawing.Size(116, 21);
            this.txtPKFieldName.TabIndex = 1;
            // 
            // lblPKFieldName
            // 
            this.lblPKFieldName.AutoSize = true;
            this.lblPKFieldName.Location = new System.Drawing.Point(70, 112);
            this.lblPKFieldName.Name = "lblPKFieldName";
            this.lblPKFieldName.Size = new System.Drawing.Size(47, 15);
            this.lblPKFieldName.TabIndex = 0;
            this.lblPKFieldName.Text = "Campo";
            // 
            // tpFKManagement
            // 
            this.tpFKManagement.Controls.Add(this.txtFKFieldName);
            this.tpFKManagement.Controls.Add(this.lblFKFieldName);
            this.tpFKManagement.Controls.Add(this.txtRefTableName);
            this.tpFKManagement.Controls.Add(this.lblTableNameRef);
            this.tpFKManagement.Controls.Add(this.btnDropFK);
            this.tpFKManagement.Controls.Add(this.btnAddFK);
            this.tpFKManagement.Controls.Add(this.txtPKRefFieldName);
            this.tpFKManagement.Controls.Add(this.lblPKRefFieldName);
            this.tpFKManagement.Location = new System.Drawing.Point(4, 24);
            this.tpFKManagement.Name = "tpFKManagement";
            this.tpFKManagement.Size = new System.Drawing.Size(248, 373);
            this.tpFKManagement.TabIndex = 3;
            this.tpFKManagement.Text = "Chiave esterna";
            this.tpFKManagement.UseVisualStyleBackColor = true;
            // 
            // txtFKFieldName
            // 
            this.txtFKFieldName.Location = new System.Drawing.Point(70, 197);
            this.txtFKFieldName.Name = "txtFKFieldName";
            this.txtFKFieldName.Size = new System.Drawing.Size(116, 21);
            this.txtFKFieldName.TabIndex = 11;
            // 
            // lblFKFieldName
            // 
            this.lblFKFieldName.AutoSize = true;
            this.lblFKFieldName.Location = new System.Drawing.Point(67, 179);
            this.lblFKFieldName.Name = "lblFKFieldName";
            this.lblFKFieldName.Size = new System.Drawing.Size(129, 15);
            this.lblFKFieldName.TabIndex = 10;
            this.lblFKFieldName.Text = "Campo chiave esterna";
            // 
            // txtRefTableName
            // 
            this.txtRefTableName.Location = new System.Drawing.Point(70, 74);
            this.txtRefTableName.Name = "txtRefTableName";
            this.txtRefTableName.Size = new System.Drawing.Size(116, 21);
            this.txtRefTableName.TabIndex = 9;
            // 
            // lblTableNameRef
            // 
            this.lblTableNameRef.AutoSize = true;
            this.lblTableNameRef.Location = new System.Drawing.Point(67, 56);
            this.lblTableNameRef.Name = "lblTableNameRef";
            this.lblTableNameRef.Size = new System.Drawing.Size(116, 15);
            this.lblTableNameRef.TabIndex = 8;
            this.lblTableNameRef.Text = "Tabella referenziata";
            // 
            // btnDropFK
            // 
            this.btnDropFK.Location = new System.Drawing.Point(70, 297);
            this.btnDropFK.Name = "btnDropFK";
            this.btnDropFK.Size = new System.Drawing.Size(117, 24);
            this.btnDropFK.TabIndex = 7;
            this.btnDropFK.Text = "Elimina chiave";
            this.btnDropFK.UseVisualStyleBackColor = true;
            this.btnDropFK.Click += new System.EventHandler(this.btnDropFK_Click);
            // 
            // btnAddFK
            // 
            this.btnAddFK.Location = new System.Drawing.Point(70, 241);
            this.btnAddFK.Name = "btnAddFK";
            this.btnAddFK.Size = new System.Drawing.Size(117, 24);
            this.btnAddFK.TabIndex = 6;
            this.btnAddFK.Text = "OK";
            this.btnAddFK.UseVisualStyleBackColor = true;
            this.btnAddFK.Click += new System.EventHandler(this.btnAddFK_Click);
            // 
            // txtPKRefFieldName
            // 
            this.txtPKRefFieldName.Location = new System.Drawing.Point(70, 137);
            this.txtPKRefFieldName.Name = "txtPKRefFieldName";
            this.txtPKRefFieldName.Size = new System.Drawing.Size(116, 21);
            this.txtPKRefFieldName.TabIndex = 5;
            // 
            // lblPKRefFieldName
            // 
            this.lblPKRefFieldName.AutoSize = true;
            this.lblPKRefFieldName.Location = new System.Drawing.Point(67, 119);
            this.lblPKRefFieldName.Name = "lblPKRefFieldName";
            this.lblPKRefFieldName.Size = new System.Drawing.Size(93, 15);
            this.lblPKRefFieldName.TabIndex = 4;
            this.lblPKRefFieldName.Text = "Chiave primaria";
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
            this.tpAddField.Size = new System.Drawing.Size(248, 373);
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
            this.tpRemoveField.Size = new System.Drawing.Size(248, 373);
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
            this.dgvDescribeTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDescribeTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDescribeTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDescribeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescribeTable.Location = new System.Drawing.Point(7, 7);
            this.dgvDescribeTable.Name = "dgvDescribeTable";
            this.dgvDescribeTable.ReadOnly = true;
            this.dgvDescribeTable.Size = new System.Drawing.Size(431, 405);
            this.dgvDescribeTable.TabIndex = 0;
            // 
            // tpDataTable
            // 
            this.tpDataTable.Controls.Add(this.gbDataTableManagement);
            this.tpDataTable.Controls.Add(this.dgvDataTable);
            this.tpDataTable.Location = new System.Drawing.Point(4, 24);
            this.tpDataTable.Name = "tpDataTable";
            this.tpDataTable.Padding = new System.Windows.Forms.Padding(3);
            this.tpDataTable.Size = new System.Drawing.Size(708, 422);
            this.tpDataTable.TabIndex = 1;
            this.tpDataTable.Text = "Dati tabella";
            this.tpDataTable.UseVisualStyleBackColor = true;
            // 
            // gbDataTableManagement
            // 
            this.gbDataTableManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDataTableManagement.Controls.Add(this.btnSaveDataTable);
            this.gbDataTableManagement.Controls.Add(this.btnFilter);
            this.gbDataTableManagement.Controls.Add(this.txtConditionFilter);
            this.gbDataTableManagement.Controls.Add(this.lblConditionFilter);
            this.gbDataTableManagement.Controls.Add(this.btnSaveTableCSV);
            this.gbDataTableManagement.Location = new System.Drawing.Point(522, 7);
            this.gbDataTableManagement.Name = "gbDataTableManagement";
            this.gbDataTableManagement.Size = new System.Drawing.Size(177, 297);
            this.gbDataTableManagement.TabIndex = 2;
            this.gbDataTableManagement.TabStop = false;
            this.gbDataTableManagement.Text = "Gestione dati tabella";
            // 
            // btnSaveDataTable
            // 
            this.btnSaveDataTable.Location = new System.Drawing.Point(34, 212);
            this.btnSaveDataTable.Name = "btnSaveDataTable";
            this.btnSaveDataTable.Size = new System.Drawing.Size(117, 44);
            this.btnSaveDataTable.TabIndex = 6;
            this.btnSaveDataTable.Text = "Salva aggiornamenti";
            this.btnSaveDataTable.UseVisualStyleBackColor = true;
            this.btnSaveDataTable.Click += new System.EventHandler(this.btnSaveDataTable_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(34, 91);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(117, 24);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Filtra";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtConditionFilter
            // 
            this.txtConditionFilter.Location = new System.Drawing.Point(34, 61);
            this.txtConditionFilter.Name = "txtConditionFilter";
            this.txtConditionFilter.Size = new System.Drawing.Size(116, 21);
            this.txtConditionFilter.TabIndex = 2;
            // 
            // lblConditionFilter
            // 
            this.lblConditionFilter.AutoSize = true;
            this.lblConditionFilter.Location = new System.Drawing.Point(30, 43);
            this.lblConditionFilter.Name = "lblConditionFilter";
            this.lblConditionFilter.Size = new System.Drawing.Size(95, 15);
            this.lblConditionFilter.TabIndex = 1;
            this.lblConditionFilter.Text = "Condizione filtro";
            // 
            // btnSaveTableCSV
            // 
            this.btnSaveTableCSV.Location = new System.Drawing.Point(34, 163);
            this.btnSaveTableCSV.Name = "btnSaveTableCSV";
            this.btnSaveTableCSV.Size = new System.Drawing.Size(117, 24);
            this.btnSaveTableCSV.TabIndex = 0;
            this.btnSaveTableCSV.Text = "Esporta CSV";
            this.btnSaveTableCSV.UseVisualStyleBackColor = true;
            this.btnSaveTableCSV.Click += new System.EventHandler(this.btnSaveTableCSV_Click);
            // 
            // dgvDataTable
            // 
            this.dgvDataTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataTable.Location = new System.Drawing.Point(7, 7);
            this.dgvDataTable.Name = "dgvDataTable";
            this.dgvDataTable.Size = new System.Drawing.Size(508, 409);
            this.dgvDataTable.TabIndex = 1;
            // 
            // tpCreateTable
            // 
            this.tpCreateTable.Controls.Add(this.lblCreateTableFields);
            this.tpCreateTable.Controls.Add(this.lblTableName);
            this.tpCreateTable.Controls.Add(this.txtTableNameCreate);
            this.tpCreateTable.Controls.Add(this.dgvCreateTable);
            this.tpCreateTable.Controls.Add(this.btnCreateTable);
            this.tpCreateTable.Location = new System.Drawing.Point(4, 24);
            this.tpCreateTable.Name = "tpCreateTable";
            this.tpCreateTable.Size = new System.Drawing.Size(708, 422);
            this.tpCreateTable.TabIndex = 2;
            this.tpCreateTable.Text = "Creazione tabella";
            this.tpCreateTable.UseVisualStyleBackColor = true;
            // 
            // lblCreateTableFields
            // 
            this.lblCreateTableFields.AutoSize = true;
            this.lblCreateTableFields.Location = new System.Drawing.Point(13, 88);
            this.lblCreateTableFields.Name = "lblCreateTableFields";
            this.lblCreateTableFields.Size = new System.Drawing.Size(109, 15);
            this.lblCreateTableFields.TabIndex = 4;
            this.lblCreateTableFields.Text = "Inserimento campi";
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
            this.dgvCreateTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCreateTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCreateTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCreateTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCreateTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCreateTable.Location = new System.Drawing.Point(16, 106);
            this.dgvCreateTable.Name = "dgvCreateTable";
            this.dgvCreateTable.Size = new System.Drawing.Size(670, 256);
            this.dgvCreateTable.TabIndex = 1;
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreateTable.Location = new System.Drawing.Point(274, 382);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(127, 24);
            this.btnCreateTable.TabIndex = 0;
            this.btnCreateTable.Text = "Salva";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            this.btnCreateTable.Click += new System.EventHandler(this.btnCreateTable_Click);
            // 
            // tpCommandLine
            // 
            this.tpCommandLine.Controls.Add(this.lbOutput);
            this.tpCommandLine.Controls.Add(this.txtCommandLine);
            this.tpCommandLine.Controls.Add(this.rtbCommandHistory);
            this.tpCommandLine.Location = new System.Drawing.Point(4, 24);
            this.tpCommandLine.Name = "tpCommandLine";
            this.tpCommandLine.Padding = new System.Windows.Forms.Padding(3);
            this.tpCommandLine.Size = new System.Drawing.Size(731, 468);
            this.tpCommandLine.TabIndex = 1;
            this.tpCommandLine.Text = "Modalità interattiva";
            this.tpCommandLine.UseVisualStyleBackColor = true;
            // 
            // lbOutput
            // 
            this.lbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.ItemHeight = 15;
            this.lbOutput.Location = new System.Drawing.Point(529, 27);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(186, 409);
            this.lbOutput.TabIndex = 2;
            // 
            // txtCommandLine
            // 
            this.txtCommandLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommandLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCommandLine.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommandLine.Location = new System.Drawing.Point(7, 421);
            this.txtCommandLine.Name = "txtCommandLine";
            this.txtCommandLine.Size = new System.Drawing.Size(504, 23);
            this.txtCommandLine.TabIndex = 1;
            this.txtCommandLine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCommandLine_KeyDown);
            // 
            // rtbCommandHistory
            // 
            this.rtbCommandHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbCommandHistory.BackColor = System.Drawing.Color.LightSteelBlue;
            this.rtbCommandHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbCommandHistory.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbCommandHistory.Location = new System.Drawing.Point(7, 27);
            this.rtbCommandHistory.Name = "rtbCommandHistory";
            this.rtbCommandHistory.ReadOnly = true;
            this.rtbCommandHistory.Size = new System.Drawing.Size(504, 395);
            this.rtbCommandHistory.TabIndex = 0;
            this.rtbCommandHistory.Text = "";
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
            // PocketSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.status);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "PocketSql";
            this.Text = "Pocket SQL v 0.1";
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
            this.tpFKManagement.PerformLayout();
            this.tpAddField.ResumeLayout(false);
            this.tpAddField.PerformLayout();
            this.tpRemoveField.ResumeLayout(false);
            this.tpRemoveField.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescribeTable)).EndInit();
            this.tpDataTable.ResumeLayout(false);
            this.gbDataTableManagement.ResumeLayout(false);
            this.gbDataTableManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataTable)).EndInit();
            this.tpCreateTable.ResumeLayout(false);
            this.tpCreateTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreateTable)).EndInit();
            this.tpCommandLine.ResumeLayout(false);
            this.tpCommandLine.PerformLayout();
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
        private System.Windows.Forms.TextBox txtCommandLine;
        private System.Windows.Forms.RichTextBox rtbCommandHistory;
        private System.Windows.Forms.ListBox lbOutput;
        private System.Windows.Forms.ContextMenuStrip cmsDBM;
        private System.Windows.Forms.ToolStripMenuItem eliminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuovaTabellaToolStripMenuItem;
        private System.Windows.Forms.Button btnAddPK;
        private System.Windows.Forms.TextBox txtPKFieldName;
        private System.Windows.Forms.Label lblPKFieldName;
        private System.Windows.Forms.Button btnDropPK;
        private System.Windows.Forms.ToolStripMenuItem documentazioneToolStripMenuItem;
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
        private System.Windows.Forms.Button btnSaveTableCSV;
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
    }
}

