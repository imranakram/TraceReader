namespace CrmTraceReader
{
    sealed partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lvTraces = new System.Windows.Forms.ListView();
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOperation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProcess = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOrganization = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chThread = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chReqId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiFilterByOperation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilterByProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilterByOrganization = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilterByThread = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilterByCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilterByUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilterByLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilterByReqId = new System.Windows.Forms.ToolStripMenuItem();
            this.tracesIcons = new System.Windows.Forms.ImageList(this.components);
            this.txtTraceDetail = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.loadingPanel = new System.Windows.Forms.Panel();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.btnClearAllFilters = new System.Windows.Forms.Button();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbRequId = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbLevel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbUser = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbThread = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbOrganization = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbProcess = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbOperation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tsMainMenu = new System.Windows.Forms.ToolStrip();
            this.tsbOpenFolder = new System.Windows.Forms.ToolStripButton();
            this.tsbOpenFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbViewXml = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRate = new System.Windows.Forms.ToolStripButton();
            this.tsbDiscuss = new System.Windows.Forms.ToolStripButton();
            this.tsbReportBug = new System.Windows.Forms.ToolStripButton();
            this.tsbResolveNames = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslNumberOfItems = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClearNameCache = new System.Windows.Forms.ToolStripButton();
            this.tsslConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.loadingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gbFilters.SuspendLayout();
            this.tsMainMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvTraces
            // 
            this.lvTraces.AllowDrop = true;
            this.lvTraces.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvTraces.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDate,
            this.chOperation,
            this.chProcess,
            this.chOrganization,
            this.chThread,
            this.chCategory,
            this.chUser,
            this.chLevel,
            this.chReqId});
            this.lvTraces.ContextMenuStrip = this.contextMenuStrip1;
            this.lvTraces.FullRowSelect = true;
            this.lvTraces.HideSelection = false;
            this.lvTraces.Location = new System.Drawing.Point(3, 3);
            this.lvTraces.MultiSelect = false;
            this.lvTraces.Name = "lvTraces";
            this.lvTraces.Size = new System.Drawing.Size(722, 344);
            this.lvTraces.SmallImageList = this.tracesIcons;
            this.lvTraces.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvTraces.TabIndex = 1;
            this.lvTraces.UseCompatibleStateImageBehavior = false;
            this.lvTraces.View = System.Windows.Forms.View.Details;
            this.lvTraces.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LvTracesColumnClick);
            this.lvTraces.SelectedIndexChanged += new System.EventHandler(this.LvTracesSelectedIndexChanged);
            this.lvTraces.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvTraces_DragDrop);
            this.lvTraces.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvTraces_DragEnter);
            // 
            // chDate
            // 
            this.chDate.Text = "Date";
            this.chDate.Width = 150;
            // 
            // chOperation
            // 
            this.chOperation.Text = "Operation";
            this.chOperation.Width = 300;
            // 
            // chProcess
            // 
            this.chProcess.Text = "Process";
            // 
            // chOrganization
            // 
            this.chOrganization.Text = "Organization";
            this.chOrganization.Width = 250;
            // 
            // chThread
            // 
            this.chThread.Text = "Thread";
            this.chThread.Width = 250;
            // 
            // chCategory
            // 
            this.chCategory.Text = "Category";
            this.chCategory.Width = 120;
            // 
            // chUser
            // 
            this.chUser.Text = "User";
            this.chUser.Width = 250;
            // 
            // chLevel
            // 
            this.chLevel.Text = "Level";
            // 
            // chReqId
            // 
            this.chReqId.Text = "ReqId";
            this.chReqId.Width = 250;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFilterByOperation,
            this.tsmiFilterByProcess,
            this.tsmiFilterByOrganization,
            this.tsmiFilterByThread,
            this.tsmiFilterByCategory,
            this.tsmiFilterByUser,
            this.tsmiFilterByLevel,
            this.tsmiFilterByReqId});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(234, 180);
            // 
            // tsmiFilterByOperation
            // 
            this.tsmiFilterByOperation.Name = "tsmiFilterByOperation";
            this.tsmiFilterByOperation.Size = new System.Drawing.Size(233, 22);
            this.tsmiFilterByOperation.Tag = "";
            this.tsmiFilterByOperation.Text = "Filter by selected Operation";
            this.tsmiFilterByOperation.Click += new System.EventHandler(this.TsmiFilterBClick);
            // 
            // tsmiFilterByProcess
            // 
            this.tsmiFilterByProcess.Name = "tsmiFilterByProcess";
            this.tsmiFilterByProcess.Size = new System.Drawing.Size(233, 22);
            this.tsmiFilterByProcess.Text = "Filter by selected Process";
            this.tsmiFilterByProcess.Click += new System.EventHandler(this.TsmiFilterBClick);
            // 
            // tsmiFilterByOrganization
            // 
            this.tsmiFilterByOrganization.Name = "tsmiFilterByOrganization";
            this.tsmiFilterByOrganization.Size = new System.Drawing.Size(233, 22);
            this.tsmiFilterByOrganization.Text = "Filter by selected Organization";
            this.tsmiFilterByOrganization.Click += new System.EventHandler(this.TsmiFilterBClick);
            // 
            // tsmiFilterByThread
            // 
            this.tsmiFilterByThread.Name = "tsmiFilterByThread";
            this.tsmiFilterByThread.Size = new System.Drawing.Size(233, 22);
            this.tsmiFilterByThread.Text = "Filter by selected Thread";
            this.tsmiFilterByThread.Click += new System.EventHandler(this.TsmiFilterBClick);
            // 
            // tsmiFilterByCategory
            // 
            this.tsmiFilterByCategory.Name = "tsmiFilterByCategory";
            this.tsmiFilterByCategory.Size = new System.Drawing.Size(233, 22);
            this.tsmiFilterByCategory.Text = "Filter by selected Category";
            this.tsmiFilterByCategory.Click += new System.EventHandler(this.TsmiFilterBClick);
            // 
            // tsmiFilterByUser
            // 
            this.tsmiFilterByUser.Name = "tsmiFilterByUser";
            this.tsmiFilterByUser.Size = new System.Drawing.Size(233, 22);
            this.tsmiFilterByUser.Text = "Filter by selected User";
            this.tsmiFilterByUser.Click += new System.EventHandler(this.TsmiFilterBClick);
            // 
            // tsmiFilterByLevel
            // 
            this.tsmiFilterByLevel.Name = "tsmiFilterByLevel";
            this.tsmiFilterByLevel.Size = new System.Drawing.Size(233, 22);
            this.tsmiFilterByLevel.Text = "Filter by selected Level";
            this.tsmiFilterByLevel.Click += new System.EventHandler(this.TsmiFilterBClick);
            // 
            // tsmiFilterByReqId
            // 
            this.tsmiFilterByReqId.Name = "tsmiFilterByReqId";
            this.tsmiFilterByReqId.Size = new System.Drawing.Size(233, 22);
            this.tsmiFilterByReqId.Text = "Filter by selected ReqId";
            this.tsmiFilterByReqId.Click += new System.EventHandler(this.TsmiFilterBClick);
            // 
            // tracesIcons
            // 
            this.tracesIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tracesIcons.ImageStream")));
            this.tracesIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.tracesIcons.Images.SetKeyName(0, "notif_icn_info16.png");
            this.tracesIcons.Images.SetKeyName(1, "notif_icn_alert16.png");
            this.tracesIcons.Images.SetKeyName(2, "notif_icn_crit16.png");
            this.tracesIcons.Images.SetKeyName(3, "comment.png");
            this.tracesIcons.Images.SetKeyName(4, "notif_icn_info16.png");
            this.tracesIcons.Images.SetKeyName(5, "notif_icn_warn16.png");
            this.tracesIcons.Images.SetKeyName(6, "notif_icn_crit16.png");
            // 
            // txtTraceDetail
            // 
            this.txtTraceDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTraceDetail.Location = new System.Drawing.Point(3, 3);
            this.txtTraceDetail.Multiline = true;
            this.txtTraceDetail.Name = "txtTraceDetail";
            this.txtTraceDetail.ReadOnly = true;
            this.txtTraceDetail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTraceDetail.Size = new System.Drawing.Size(722, 86);
            this.txtTraceDetail.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(4, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvTraces);
            this.splitContainer1.Panel1.Controls.Add(this.loadingPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtTraceDetail);
            this.splitContainer1.Size = new System.Drawing.Size(728, 446);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.TabIndex = 3;
            // 
            // loadingPanel
            // 
            this.loadingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loadingPanel.Controls.Add(this.pbLoading);
            this.loadingPanel.Controls.Add(this.loadingLabel);
            this.loadingPanel.Location = new System.Drawing.Point(3, 3);
            this.loadingPanel.Name = "loadingPanel";
            this.loadingPanel.Size = new System.Drawing.Size(722, 344);
            this.loadingPanel.TabIndex = 2;
            this.loadingPanel.Visible = false;
            this.loadingPanel.Resize += new System.EventHandler(this.LoadingPanelResize);
            // 
            // pbLoading
            // 
            this.pbLoading.Image = ((System.Drawing.Image)(resources.GetObject("pbLoading.Image")));
            this.pbLoading.Location = new System.Drawing.Point(343, 210);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(36, 36);
            this.pbLoading.TabIndex = 1;
            this.pbLoading.TabStop = false;
            // 
            // loadingLabel
            // 
            this.loadingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.loadingLabel.Location = new System.Drawing.Point(0, 169);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(720, 38);
            this.loadingLabel.TabIndex = 0;
            this.loadingLabel.Text = "[TEXT]";
            this.loadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(2, 41);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gbFilters);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(947, 449);
            this.splitContainer2.SplitterDistance = 207;
            this.splitContainer2.TabIndex = 8;
            // 
            // gbFilters
            // 
            this.gbFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFilters.Controls.Add(this.btnClearAllFilters);
            this.gbFilters.Controls.Add(this.btnClearSearch);
            this.gbFilters.Controls.Add(this.btnSearch);
            this.gbFilters.Controls.Add(this.txtSearch);
            this.gbFilters.Controls.Add(this.label9);
            this.gbFilters.Controls.Add(this.cbbRequId);
            this.gbFilters.Controls.Add(this.label8);
            this.gbFilters.Controls.Add(this.cbbLevel);
            this.gbFilters.Controls.Add(this.label7);
            this.gbFilters.Controls.Add(this.cbbUser);
            this.gbFilters.Controls.Add(this.label6);
            this.gbFilters.Controls.Add(this.cbbCategory);
            this.gbFilters.Controls.Add(this.label5);
            this.gbFilters.Controls.Add(this.cbbThread);
            this.gbFilters.Controls.Add(this.label4);
            this.gbFilters.Controls.Add(this.cbbOrganization);
            this.gbFilters.Controls.Add(this.label3);
            this.gbFilters.Controls.Add(this.cbbProcess);
            this.gbFilters.Controls.Add(this.label2);
            this.gbFilters.Controls.Add(this.cbbOperation);
            this.gbFilters.Controls.Add(this.label1);
            this.gbFilters.Location = new System.Drawing.Point(1, 0);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(203, 443);
            this.gbFilters.TabIndex = 8;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filters";
            // 
            // btnClearAllFilters
            // 
            this.btnClearAllFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearAllFilters.Image = ((System.Drawing.Image)(resources.GetObject("btnClearAllFilters.Image")));
            this.btnClearAllFilters.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearAllFilters.Location = new System.Drawing.Point(6, 380);
            this.btnClearAllFilters.Name = "btnClearAllFilters";
            this.btnClearAllFilters.Size = new System.Drawing.Size(190, 22);
            this.btnClearAllFilters.TabIndex = 20;
            this.btnClearAllFilters.Text = "Clear all filters";
            this.btnClearAllFilters.UseVisualStyleBackColor = true;
            this.btnClearAllFilters.Click += new System.EventHandler(this.btnClearAllFilters_Click);
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnClearSearch.Image")));
            this.btnClearSearch.Location = new System.Drawing.Point(170, 353);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(24, 22);
            this.btnClearSearch.TabIndex = 19;
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(148, 353);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(24, 22);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(6, 354);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(144, 20);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Search";
            // 
            // cbbRequId
            // 
            this.cbbRequId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbRequId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRequId.FormattingEnabled = true;
            this.cbbRequId.Location = new System.Drawing.Point(6, 312);
            this.cbbRequId.Name = "cbbRequId";
            this.cbbRequId.Size = new System.Drawing.Size(190, 21);
            this.cbbRequId.TabIndex = 15;
            this.cbbRequId.SelectedIndexChanged += new System.EventHandler(this.CbbSelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "ReqId";
            // 
            // cbbLevel
            // 
            this.cbbLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLevel.FormattingEnabled = true;
            this.cbbLevel.Location = new System.Drawing.Point(6, 272);
            this.cbbLevel.Name = "cbbLevel";
            this.cbbLevel.Size = new System.Drawing.Size(190, 21);
            this.cbbLevel.TabIndex = 13;
            this.cbbLevel.SelectedValueChanged += new System.EventHandler(this.CbbSelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Level";
            // 
            // cbbUser
            // 
            this.cbbUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUser.FormattingEnabled = true;
            this.cbbUser.Location = new System.Drawing.Point(6, 232);
            this.cbbUser.Name = "cbbUser";
            this.cbbUser.Size = new System.Drawing.Size(190, 21);
            this.cbbUser.TabIndex = 11;
            this.cbbUser.SelectedValueChanged += new System.EventHandler(this.CbbSelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "User";
            // 
            // cbbCategory
            // 
            this.cbbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(6, 192);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(190, 21);
            this.cbbCategory.TabIndex = 9;
            this.cbbCategory.SelectedValueChanged += new System.EventHandler(this.CbbSelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Category";
            // 
            // cbbThread
            // 
            this.cbbThread.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbThread.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbThread.FormattingEnabled = true;
            this.cbbThread.Location = new System.Drawing.Point(6, 152);
            this.cbbThread.Name = "cbbThread";
            this.cbbThread.Size = new System.Drawing.Size(190, 21);
            this.cbbThread.TabIndex = 7;
            this.cbbThread.SelectedValueChanged += new System.EventHandler(this.CbbSelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thread";
            // 
            // cbbOrganization
            // 
            this.cbbOrganization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbOrganization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbOrganization.FormattingEnabled = true;
            this.cbbOrganization.Location = new System.Drawing.Point(6, 112);
            this.cbbOrganization.Name = "cbbOrganization";
            this.cbbOrganization.Size = new System.Drawing.Size(190, 21);
            this.cbbOrganization.TabIndex = 5;
            this.cbbOrganization.SelectedValueChanged += new System.EventHandler(this.CbbSelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Organization";
            // 
            // cbbProcess
            // 
            this.cbbProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbProcess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProcess.FormattingEnabled = true;
            this.cbbProcess.Location = new System.Drawing.Point(6, 72);
            this.cbbProcess.Name = "cbbProcess";
            this.cbbProcess.Size = new System.Drawing.Size(190, 21);
            this.cbbProcess.TabIndex = 3;
            this.cbbProcess.SelectedValueChanged += new System.EventHandler(this.CbbSelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Process";
            // 
            // cbbOperation
            // 
            this.cbbOperation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbOperation.FormattingEnabled = true;
            this.cbbOperation.Location = new System.Drawing.Point(6, 32);
            this.cbbOperation.Name = "cbbOperation";
            this.cbbOperation.Size = new System.Drawing.Size(190, 21);
            this.cbbOperation.TabIndex = 1;
            this.cbbOperation.SelectedValueChanged += new System.EventHandler(this.CbbSelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operation";
            // 
            // tsMainMenu
            // 
            this.tsMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpenFolder,
            this.tsbOpenFile,
            this.toolStripSeparator1,
            this.tsbRefresh,
            this.toolStripSeparator2,
            this.tsbResolveNames,
            this.tsbClearNameCache,
            this.toolStripSeparator4,
            this.tsbViewXml,
            this.toolStripSeparator3,
            this.tsbRate,
            this.tsbDiscuss,
            this.tsbReportBug});
            this.tsMainMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMainMenu.Name = "tsMainMenu";
            this.tsMainMenu.Size = new System.Drawing.Size(961, 25);
            this.tsMainMenu.TabIndex = 9;
            this.tsMainMenu.Text = "toolStrip1";
            // 
            // tsbOpenFolder
            // 
            this.tsbOpenFolder.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpenFolder.Image")));
            this.tsbOpenFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenFolder.Name = "tsbOpenFolder";
            this.tsbOpenFolder.Size = new System.Drawing.Size(90, 22);
            this.tsbOpenFolder.Text = "Open folder";
            this.tsbOpenFolder.ToolTipText = "Reads all log files in the specified folder\r\n\r\nIt can take some time to load file" +
    "s depending on their sizes";
            this.tsbOpenFolder.Click += new System.EventHandler(this.TsbOpenFolderClick);
            // 
            // tsbOpenFile
            // 
            this.tsbOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpenFile.Image")));
            this.tsbOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenFile.Name = "tsbOpenFile";
            this.tsbOpenFile.Size = new System.Drawing.Size(75, 22);
            this.tsbOpenFile.Text = "Open file";
            this.tsbOpenFile.ToolTipText = "This can take some time depending on the file size";
            this.tsbOpenFile.Click += new System.EventHandler(this.TsbOpenFileClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(95, 22);
            this.tsbRefresh.Text = "Reload file(s)";
            this.tsbRefresh.Click += new System.EventHandler(this.TsbRefreshClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbViewXml
            // 
            this.tsbViewXml.Enabled = false;
            this.tsbViewXml.Image = ((System.Drawing.Image)(resources.GetObject("tsbViewXml.Image")));
            this.tsbViewXml.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbViewXml.Name = "tsbViewXml";
            this.tsbViewXml.Size = new System.Drawing.Size(153, 22);
            this.tsbViewXml.Text = "Improve Xml readability";
            this.tsbViewXml.Click += new System.EventHandler(this.tsbViewXml_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRate
            // 
            this.tsbRate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRate.Image = ((System.Drawing.Image)(resources.GetObject("tsbRate.Image")));
            this.tsbRate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRate.Name = "tsbRate";
            this.tsbRate.Size = new System.Drawing.Size(23, 22);
            this.tsbRate.Text = "Rate this tool";
            this.tsbRate.ToolTipText = "Rate this tool on CodePlex and make this tool more visible to the community\r\n\r\nWe" +
    "ther you like it or not, please review this tool!";
            this.tsbRate.Click += new System.EventHandler(this.tsbRate_Click);
            // 
            // tsbDiscuss
            // 
            this.tsbDiscuss.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDiscuss.Image = ((System.Drawing.Image)(resources.GetObject("tsbDiscuss.Image")));
            this.tsbDiscuss.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDiscuss.Name = "tsbDiscuss";
            this.tsbDiscuss.Size = new System.Drawing.Size(23, 22);
            this.tsbDiscuss.Text = "Start a discussion";
            this.tsbDiscuss.ToolTipText = "Start a discussion about this tool on CodePlex";
            this.tsbDiscuss.Click += new System.EventHandler(this.tsbDiscuss_Click);
            // 
            // tsbReportBug
            // 
            this.tsbReportBug.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbReportBug.Image = ((System.Drawing.Image)(resources.GetObject("tsbReportBug.Image")));
            this.tsbReportBug.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReportBug.Name = "tsbReportBug";
            this.tsbReportBug.Size = new System.Drawing.Size(23, 22);
            this.tsbReportBug.Text = "Report a bug";
            this.tsbReportBug.ToolTipText = "Report a bug for this tool on CodePlex.\r\n\r\nReport a bug help to have a better too" +
    "l!";
            this.tsbReportBug.Click += new System.EventHandler(this.tsbReportBug_Click);
            // 
            // tsbResolveNames
            // 
            this.tsbResolveNames.Image = ((System.Drawing.Image)(resources.GetObject("tsbResolveNames.Image")));
            this.tsbResolveNames.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbResolveNames.Name = "tsbResolveNames";
            this.tsbResolveNames.Size = new System.Drawing.Size(105, 22);
            this.tsbResolveNames.Text = "Resolve names";
            this.tsbResolveNames.ToolTipText = "This action allows to replace unique identifiers (GUID) by names. \r\n\r\nIt only wor" +
    "ks for one Dynamics CRM deployment.";
            this.tsbResolveNames.Click += new System.EventHandler(this.tsbResolveNames_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslNumberOfItems,
            this.tsslConnection});
            this.statusStrip1.Location = new System.Drawing.Point(0, 493);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(961, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslNumberOfItems
            // 
            this.tslNumberOfItems.Name = "tslNumberOfItems";
            this.tslNumberOfItems.Size = new System.Drawing.Size(112, 17);
            this.tslNumberOfItems.Text = "Number of items : 0";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbClearNameCache
            // 
            this.tsbClearNameCache.Image = ((System.Drawing.Image)(resources.GetObject("tsbClearNameCache.Image")));
            this.tsbClearNameCache.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClearNameCache.Name = "tsbClearNameCache";
            this.tsbClearNameCache.Size = new System.Drawing.Size(126, 22);
            this.tsbClearNameCache.Text = "Clear names cache";
            this.tsbClearNameCache.ToolTipText = "This also reloads traces";
            this.tsbClearNameCache.Click += new System.EventHandler(this.tsbClearNameCache_Click);
            // 
            // tsslConnection
            // 
            this.tsslConnection.Name = "tsslConnection";
            this.tsslConnection.Size = new System.Drawing.Size(803, 17);
            this.tsslConnection.Spring = true;
            this.tsslConnection.Text = "Not connected";
            this.tsslConnection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 515);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tsMainMenu);
            this.Controls.Add(this.splitContainer2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Dynamics CRM Trace Reader";
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.loadingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            this.tsMainMenu.ResumeLayout(false);
            this.tsMainMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvTraces;
        private System.Windows.Forms.ColumnHeader chOperation;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.ColumnHeader chProcess;
        private System.Windows.Forms.ColumnHeader chOrganization;
        private System.Windows.Forms.ColumnHeader chThread;
        private System.Windows.Forms.ColumnHeader chCategory;
        private System.Windows.Forms.ColumnHeader chUser;
        private System.Windows.Forms.ColumnHeader chLevel;
        private System.Windows.Forms.TextBox txtTraceDetail;
        private System.Windows.Forms.ImageList tracesIcons;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.ComboBox cbbLevel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbThread;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbOrganization;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbProcess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbOperation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel loadingPanel;
        private System.Windows.Forms.Label loadingLabel;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.ToolStrip tsMainMenu;
        private System.Windows.Forms.ToolStripButton tsbOpenFolder;
        private System.Windows.Forms.ToolStripButton tsbOpenFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ColumnHeader chReqId;
        private System.Windows.Forms.ComboBox cbbRequId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterByOperation;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterByProcess;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterByOrganization;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterByThread;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterByCategory;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterByLevel;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterByUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterByReqId;
        private System.Windows.Forms.ToolStripButton tsbViewXml;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslNumberOfItems;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbRate;
        private System.Windows.Forms.ToolStripButton tsbDiscuss;
        private System.Windows.Forms.ToolStripButton tsbReportBug;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClearAllFilters;
        private System.Windows.Forms.ToolStripButton tsbResolveNames;
        private System.Windows.Forms.ToolStripButton tsbClearNameCache;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripStatusLabel tsslConnection;
    }
}

