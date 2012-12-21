namespace buildSkin
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.skinsTab = new System.Windows.Forms.TabPage();
            this.skinsCustomize = new System.Windows.Forms.DataGridView();
            this.customCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customOptions = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.skinsPreview = new System.Windows.Forms.PictureBox();
            this.skinsPanel = new System.Windows.Forms.Panel();
            this.skinsEditXML = new System.Windows.Forms.LinkLabel();
            this.skinsReload = new System.Windows.Forms.LinkLabel();
            this.skinsClear = new System.Windows.Forms.LinkLabel();
            this.skinsDelete = new System.Windows.Forms.LinkLabel();
            this.skinsRename = new System.Windows.Forms.LinkLabel();
            this.skinsBuild = new System.Windows.Forms.LinkLabel();
            this.skinsList = new System.Windows.Forms.ComboBox();
            this.addonsTab = new System.Windows.Forms.TabPage();
            this.addonsSelectAll = new System.Windows.Forms.CheckBox();
            this.addonsDataGrid = new System.Windows.Forms.DataGridView();
            this.addonsSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.addonsInstalled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.addonsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addonsAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addonsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addonsDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addonsVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addonsInstVer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addonsLink = new System.Windows.Forms.DataGridViewLinkColumn();
            this.addonsFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addonsDescription = new System.Windows.Forms.TextBox();
            this.addonsPanel = new System.Windows.Forms.Panel();
            this.addonsDelete = new System.Windows.Forms.LinkLabel();
            this.addonsRefreshLabel = new System.Windows.Forms.Label();
            this.addonsFilter = new System.Windows.Forms.TextBox();
            this.addonsInstUpd = new System.Windows.Forms.LinkLabel();
            this.addonsRefreshLocal = new System.Windows.Forms.LinkLabel();
            this.addonsRefreshRemote = new System.Windows.Forms.LinkLabel();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.infoGroup = new System.Windows.Forms.GroupBox();
            this.infoCopyrightLabel = new System.Windows.Forms.LinkLabel();
            this.infoAuthorsLabel = new System.Windows.Forms.LinkLabel();
            this.infoReadMe = new System.Windows.Forms.TextBox();
            this.infoReadMeLabel = new System.Windows.Forms.LinkLabel();
            this.infoLILabel = new System.Windows.Forms.LinkLabel();
            this.infoCreditsLabel = new System.Windows.Forms.Label();
            this.infoCredits = new System.Windows.Forms.TextBox();
            this.infoAuthors = new System.Windows.Forms.TextBox();
            this.infoVersion = new System.Windows.Forms.TextBox();
            this.infoVersionLabel = new System.Windows.Forms.Label();
            this.infoCopyright = new System.Windows.Forms.TextBox();
            this.infoLI = new System.Windows.Forms.TextBox();
            this.settingsGroup = new System.Windows.Forms.GroupBox();
            this.settingsResolution = new System.Windows.Forms.ComboBox();
            this.settingsResolutionLabel = new System.Windows.Forms.Label();
            this.settingsEditorBrowse = new System.Windows.Forms.LinkLabel();
            this.settingsEditorPath = new System.Windows.Forms.TextBox();
            this.settingsEditorLabel = new System.Windows.Forms.Label();
            this.settingsTranslucent = new System.Windows.Forms.CheckBox();
            this.settingsReadOnly = new System.Windows.Forms.CheckBox();
            this.settingsTransMax = new System.Windows.Forms.CheckBox();
            this.settingsAutoLoad = new System.Windows.Forms.CheckBox();
            this.settingsConfirmation = new System.Windows.Forms.CheckBox();
            this.settingsNoRecycle = new System.Windows.Forms.CheckBox();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.settingsReload = new System.Windows.Forms.LinkLabel();
            this.settingsSave = new System.Windows.Forms.LinkLabel();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainTabs.SuspendLayout();
            this.skinsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinsCustomize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinsPreview)).BeginInit();
            this.skinsPanel.SuspendLayout();
            this.addonsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addonsDataGrid)).BeginInit();
            this.addonsPanel.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.infoGroup.SuspendLayout();
            this.settingsGroup.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabs
            // 
            this.mainTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabs.Controls.Add(this.skinsTab);
            this.mainTabs.Controls.Add(this.addonsTab);
            this.mainTabs.Controls.Add(this.settingsTab);
            this.mainTabs.Location = new System.Drawing.Point(2, 2);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(580, 410);
            this.mainTabs.TabIndex = 1;
            // 
            // skinsTab
            // 
            this.skinsTab.Controls.Add(this.skinsCustomize);
            this.skinsTab.Controls.Add(this.skinsPreview);
            this.skinsTab.Controls.Add(this.skinsPanel);
            this.skinsTab.Location = new System.Drawing.Point(4, 22);
            this.skinsTab.Name = "skinsTab";
            this.skinsTab.Padding = new System.Windows.Forms.Padding(3);
            this.skinsTab.Size = new System.Drawing.Size(572, 384);
            this.skinsTab.TabIndex = 0;
            this.skinsTab.Text = "Skins";
            this.skinsTab.UseVisualStyleBackColor = true;
            // 
            // skinsCustomize
            // 
            this.skinsCustomize.AllowUserToAddRows = false;
            this.skinsCustomize.AllowUserToDeleteRows = false;
            this.skinsCustomize.AllowUserToOrderColumns = true;
            this.skinsCustomize.AllowUserToResizeRows = false;
            this.skinsCustomize.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.skinsCustomize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skinsCustomize.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customCategory,
            this.customName,
            this.customOptions});
            this.skinsCustomize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinsCustomize.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.skinsCustomize.EnableHeadersVisualStyles = false;
            this.skinsCustomize.Location = new System.Drawing.Point(3, 27);
            this.skinsCustomize.MultiSelect = false;
            this.skinsCustomize.Name = "skinsCustomize";
            this.skinsCustomize.RowHeadersVisible = false;
            this.skinsCustomize.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.skinsCustomize.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Window;
            this.skinsCustomize.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.skinsCustomize.RowTemplate.Height = 20;
            this.skinsCustomize.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.skinsCustomize.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.skinsCustomize.Size = new System.Drawing.Size(566, 254);
            this.skinsCustomize.TabIndex = 11;
            this.skinsCustomize.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.skinOptionEditing);
            // 
            // customCategory
            // 
            this.customCategory.HeaderText = "Category";
            this.customCategory.Name = "customCategory";
            this.customCategory.ReadOnly = true;
            this.customCategory.Width = 158;
            // 
            // customName
            // 
            this.customName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customName.HeaderText = "Element Name";
            this.customName.Name = "customName";
            this.customName.ReadOnly = true;
            // 
            // customOptions
            // 
            this.customOptions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customOptions.HeaderText = "Options";
            this.customOptions.Name = "customOptions";
            // 
            // skinsPreview
            // 
            this.skinsPreview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skinsPreview.Location = new System.Drawing.Point(3, 281);
            this.skinsPreview.Name = "skinsPreview";
            this.skinsPreview.Size = new System.Drawing.Size(566, 100);
            this.skinsPreview.TabIndex = 10;
            this.skinsPreview.TabStop = false;
            // 
            // skinsPanel
            // 
            this.skinsPanel.Controls.Add(this.skinsEditXML);
            this.skinsPanel.Controls.Add(this.skinsReload);
            this.skinsPanel.Controls.Add(this.skinsClear);
            this.skinsPanel.Controls.Add(this.skinsDelete);
            this.skinsPanel.Controls.Add(this.skinsRename);
            this.skinsPanel.Controls.Add(this.skinsBuild);
            this.skinsPanel.Controls.Add(this.skinsList);
            this.skinsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinsPanel.Location = new System.Drawing.Point(3, 3);
            this.skinsPanel.Name = "skinsPanel";
            this.skinsPanel.Size = new System.Drawing.Size(566, 24);
            this.skinsPanel.TabIndex = 1;
            // 
            // skinsEditXML
            // 
            this.skinsEditXML.AutoSize = true;
            this.skinsEditXML.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.skinsEditXML.Location = new System.Drawing.Point(287, 3);
            this.skinsEditXML.Name = "skinsEditXML";
            this.skinsEditXML.Size = new System.Drawing.Size(50, 13);
            this.skinsEditXML.TabIndex = 6;
            this.skinsEditXML.TabStop = true;
            this.skinsEditXML.Text = "&Edit XML";
            this.skinsEditXML.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.skinEditXML);
            // 
            // skinsReload
            // 
            this.skinsReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinsReload.AutoSize = true;
            this.skinsReload.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.skinsReload.Location = new System.Drawing.Point(489, 3);
            this.skinsReload.Name = "skinsReload";
            this.skinsReload.Size = new System.Drawing.Size(41, 13);
            this.skinsReload.TabIndex = 7;
            this.skinsReload.TabStop = true;
            this.skinsReload.Text = "&Reload";
            this.skinsReload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.skinReload);
            // 
            // skinsClear
            // 
            this.skinsClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinsClear.AutoSize = true;
            this.skinsClear.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.skinsClear.Location = new System.Drawing.Point(532, 3);
            this.skinsClear.Name = "skinsClear";
            this.skinsClear.Size = new System.Drawing.Size(31, 13);
            this.skinsClear.TabIndex = 8;
            this.skinsClear.TabStop = true;
            this.skinsClear.Text = "&Clear";
            this.skinsClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.skinClear);
            // 
            // skinsDelete
            // 
            this.skinsDelete.AutoSize = true;
            this.skinsDelete.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.skinsDelete.Location = new System.Drawing.Point(247, 3);
            this.skinsDelete.Name = "skinsDelete";
            this.skinsDelete.Size = new System.Drawing.Size(38, 13);
            this.skinsDelete.TabIndex = 5;
            this.skinsDelete.TabStop = true;
            this.skinsDelete.Text = "&Delete";
            this.skinsDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.skinDelete);
            // 
            // skinsRename
            // 
            this.skinsRename.AutoSize = true;
            this.skinsRename.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.skinsRename.Location = new System.Drawing.Point(198, 3);
            this.skinsRename.Name = "skinsRename";
            this.skinsRename.Size = new System.Drawing.Size(47, 13);
            this.skinsRename.TabIndex = 4;
            this.skinsRename.TabStop = true;
            this.skinsRename.Text = "Re&name";
            this.skinsRename.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.skinRename);
            // 
            // skinsBuild
            // 
            this.skinsBuild.AutoSize = true;
            this.skinsBuild.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.skinsBuild.Location = new System.Drawing.Point(166, 3);
            this.skinsBuild.Name = "skinsBuild";
            this.skinsBuild.Size = new System.Drawing.Size(30, 13);
            this.skinsBuild.TabIndex = 3;
            this.skinsBuild.TabStop = true;
            this.skinsBuild.Text = "&Build";
            this.skinsBuild.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.skinBuild);
            // 
            // skinsList
            // 
            this.skinsList.FormattingEnabled = true;
            this.skinsList.Location = new System.Drawing.Point(0, 0);
            this.skinsList.Name = "skinsList";
            this.skinsList.Size = new System.Drawing.Size(160, 21);
            this.skinsList.TabIndex = 2;
            this.skinsList.SelectedIndexChanged += new System.EventHandler(this.skinSelect);
            // 
            // addonsTab
            // 
            this.addonsTab.Controls.Add(this.addonsSelectAll);
            this.addonsTab.Controls.Add(this.addonsDataGrid);
            this.addonsTab.Controls.Add(this.addonsDescription);
            this.addonsTab.Controls.Add(this.addonsPanel);
            this.addonsTab.Location = new System.Drawing.Point(4, 22);
            this.addonsTab.Name = "addonsTab";
            this.addonsTab.Padding = new System.Windows.Forms.Padding(3);
            this.addonsTab.Size = new System.Drawing.Size(572, 384);
            this.addonsTab.TabIndex = 1;
            this.addonsTab.Text = "Addons";
            this.addonsTab.UseVisualStyleBackColor = true;
            // 
            // addonsSelectAll
            // 
            this.addonsSelectAll.BackColor = System.Drawing.SystemColors.Control;
            this.addonsSelectAll.Location = new System.Drawing.Point(8, 30);
            this.addonsSelectAll.Name = "addonsSelectAll";
            this.addonsSelectAll.Size = new System.Drawing.Size(15, 13);
            this.addonsSelectAll.TabIndex = 15;
            this.addonsSelectAll.UseVisualStyleBackColor = false;
            this.addonsSelectAll.CheckedChanged += new System.EventHandler(this.addonSelectAll);
            // 
            // addonsDataGrid
            // 
            this.addonsDataGrid.AllowUserToAddRows = false;
            this.addonsDataGrid.AllowUserToDeleteRows = false;
            this.addonsDataGrid.AllowUserToOrderColumns = true;
            this.addonsDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.addonsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.addonsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.addonsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addonsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addonsSelected,
            this.addonsInstalled,
            this.addonsID,
            this.addonsAuthor,
            this.addonsName,
            this.addonsDesc,
            this.addonsVersion,
            this.addonsInstVer,
            this.addonsLink,
            this.addonsFile});
            this.addonsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addonsDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.addonsDataGrid.EnableHeadersVisualStyles = false;
            this.addonsDataGrid.Location = new System.Drawing.Point(3, 27);
            this.addonsDataGrid.MultiSelect = false;
            this.addonsDataGrid.Name = "addonsDataGrid";
            this.addonsDataGrid.RowHeadersVisible = false;
            this.addonsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.addonsDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.addonsDataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.addonsDataGrid.RowTemplate.Height = 21;
            this.addonsDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.addonsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addonsDataGrid.Size = new System.Drawing.Size(566, 254);
            this.addonsDataGrid.TabIndex = 18;
            this.addonsDataGrid.SelectionChanged += new System.EventHandler(this.addonSelectRow);
            // 
            // addonsSelected
            // 
            this.addonsSelected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.addonsSelected.HeaderText = "";
            this.addonsSelected.Name = "addonsSelected";
            this.addonsSelected.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.addonsSelected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.addonsSelected.Width = 20;
            // 
            // addonsInstalled
            // 
            this.addonsInstalled.HeaderText = "Installed";
            this.addonsInstalled.Name = "addonsInstalled";
            this.addonsInstalled.ReadOnly = true;
            this.addonsInstalled.Visible = false;
            // 
            // addonsID
            // 
            this.addonsID.HeaderText = "ID";
            this.addonsID.Name = "addonsID";
            this.addonsID.ReadOnly = true;
            this.addonsID.Visible = false;
            // 
            // addonsAuthor
            // 
            this.addonsAuthor.HeaderText = "Author";
            this.addonsAuthor.Name = "addonsAuthor";
            this.addonsAuthor.ReadOnly = true;
            this.addonsAuthor.Width = 138;
            // 
            // addonsName
            // 
            this.addonsName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addonsName.HeaderText = "Name";
            this.addonsName.Name = "addonsName";
            this.addonsName.ReadOnly = true;
            // 
            // addonsDesc
            // 
            this.addonsDesc.HeaderText = "Description";
            this.addonsDesc.Name = "addonsDesc";
            this.addonsDesc.ReadOnly = true;
            this.addonsDesc.Visible = false;
            // 
            // addonsVersion
            // 
            this.addonsVersion.HeaderText = "Latest Version";
            this.addonsVersion.Name = "addonsVersion";
            this.addonsVersion.ReadOnly = true;
            this.addonsVersion.Width = 98;
            // 
            // addonsInstVer
            // 
            this.addonsInstVer.HeaderText = "Installed Version";
            this.addonsInstVer.Name = "addonsInstVer";
            this.addonsInstVer.ReadOnly = true;
            this.addonsInstVer.Width = 108;
            // 
            // addonsLink
            // 
            this.addonsLink.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.addonsLink.DefaultCellStyle = dataGridViewCellStyle2;
            this.addonsLink.HeaderText = "Link";
            this.addonsLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.addonsLink.Name = "addonsLink";
            this.addonsLink.ReadOnly = true;
            this.addonsLink.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.addonsLink.Text = "Go";
            this.addonsLink.ToolTipText = "LotroInterface";
            this.addonsLink.TrackVisitedState = false;
            this.addonsLink.UseColumnTextForLinkValue = true;
            this.addonsLink.Width = 30;
            // 
            // addonsFile
            // 
            this.addonsFile.HeaderText = "File";
            this.addonsFile.Name = "addonsFile";
            this.addonsFile.ReadOnly = true;
            this.addonsFile.Visible = false;
            // 
            // addonsDescription
            // 
            this.addonsDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addonsDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addonsDescription.Location = new System.Drawing.Point(3, 281);
            this.addonsDescription.Multiline = true;
            this.addonsDescription.Name = "addonsDescription";
            this.addonsDescription.ReadOnly = true;
            this.addonsDescription.Size = new System.Drawing.Size(566, 100);
            this.addonsDescription.TabIndex = 17;
            // 
            // addonsPanel
            // 
            this.addonsPanel.Controls.Add(this.addonsDelete);
            this.addonsPanel.Controls.Add(this.addonsRefreshLabel);
            this.addonsPanel.Controls.Add(this.addonsFilter);
            this.addonsPanel.Controls.Add(this.addonsInstUpd);
            this.addonsPanel.Controls.Add(this.addonsRefreshLocal);
            this.addonsPanel.Controls.Add(this.addonsRefreshRemote);
            this.addonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addonsPanel.Location = new System.Drawing.Point(3, 3);
            this.addonsPanel.Name = "addonsPanel";
            this.addonsPanel.Size = new System.Drawing.Size(566, 24);
            this.addonsPanel.TabIndex = 0;
            // 
            // addonsDelete
            // 
            this.addonsDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addonsDelete.AutoSize = true;
            this.addonsDelete.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.addonsDelete.Location = new System.Drawing.Point(449, 3);
            this.addonsDelete.Name = "addonsDelete";
            this.addonsDelete.Size = new System.Drawing.Size(38, 13);
            this.addonsDelete.TabIndex = 13;
            this.addonsDelete.TabStop = true;
            this.addonsDelete.Text = "&Delete";
            this.addonsDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addonDelete);
            // 
            // addonsRefreshLabel
            // 
            this.addonsRefreshLabel.AutoSize = true;
            this.addonsRefreshLabel.Location = new System.Drawing.Point(166, 3);
            this.addonsRefreshLabel.Name = "addonsRefreshLabel";
            this.addonsRefreshLabel.Size = new System.Drawing.Size(47, 13);
            this.addonsRefreshLabel.TabIndex = 0;
            this.addonsRefreshLabel.Text = "Refresh:";
            // 
            // addonsFilter
            // 
            this.addonsFilter.Location = new System.Drawing.Point(0, 0);
            this.addonsFilter.Name = "addonsFilter";
            this.addonsFilter.Size = new System.Drawing.Size(160, 20);
            this.addonsFilter.TabIndex = 10;
            this.addonsFilter.TextChanged += new System.EventHandler(this.addonFilter);
            // 
            // addonsInstUpd
            // 
            this.addonsInstUpd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addonsInstUpd.AutoSize = true;
            this.addonsInstUpd.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.addonsInstUpd.Location = new System.Drawing.Point(489, 3);
            this.addonsInstUpd.Name = "addonsInstUpd";
            this.addonsInstUpd.Size = new System.Drawing.Size(74, 13);
            this.addonsInstUpd.TabIndex = 14;
            this.addonsInstUpd.TabStop = true;
            this.addonsInstUpd.Text = "Install/&Update";
            this.addonsInstUpd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addonInstUpd);
            // 
            // addonsRefreshLocal
            // 
            this.addonsRefreshLocal.AutoSize = true;
            this.addonsRefreshLocal.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.addonsRefreshLocal.Location = new System.Drawing.Point(261, 3);
            this.addonsRefreshLocal.Name = "addonsRefreshLocal";
            this.addonsRefreshLocal.Size = new System.Drawing.Size(33, 13);
            this.addonsRefreshLocal.TabIndex = 12;
            this.addonsRefreshLocal.TabStop = true;
            this.addonsRefreshLocal.Text = "&Local";
            this.addonsRefreshLocal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addonRefreshLocal);
            // 
            // addonsRefreshRemote
            // 
            this.addonsRefreshRemote.AutoSize = true;
            this.addonsRefreshRemote.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.addonsRefreshRemote.Location = new System.Drawing.Point(215, 3);
            this.addonsRefreshRemote.Name = "addonsRefreshRemote";
            this.addonsRefreshRemote.Size = new System.Drawing.Size(44, 13);
            this.addonsRefreshRemote.TabIndex = 11;
            this.addonsRefreshRemote.TabStop = true;
            this.addonsRefreshRemote.Text = "&Remote";
            this.addonsRefreshRemote.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addonRefreshRemote);
            // 
            // settingsTab
            // 
            this.settingsTab.Controls.Add(this.infoGroup);
            this.settingsTab.Controls.Add(this.settingsGroup);
            this.settingsTab.Controls.Add(this.settingsPanel);
            this.settingsTab.Location = new System.Drawing.Point(4, 22);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(572, 384);
            this.settingsTab.TabIndex = 2;
            this.settingsTab.Text = "Info/Settings";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // infoGroup
            // 
            this.infoGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.infoGroup.Controls.Add(this.infoCopyrightLabel);
            this.infoGroup.Controls.Add(this.infoAuthorsLabel);
            this.infoGroup.Controls.Add(this.infoReadMe);
            this.infoGroup.Controls.Add(this.infoReadMeLabel);
            this.infoGroup.Controls.Add(this.infoLILabel);
            this.infoGroup.Controls.Add(this.infoCreditsLabel);
            this.infoGroup.Controls.Add(this.infoCredits);
            this.infoGroup.Controls.Add(this.infoAuthors);
            this.infoGroup.Controls.Add(this.infoVersion);
            this.infoGroup.Controls.Add(this.infoVersionLabel);
            this.infoGroup.Controls.Add(this.infoCopyright);
            this.infoGroup.Controls.Add(this.infoLI);
            this.infoGroup.Location = new System.Drawing.Point(3, 27);
            this.infoGroup.Name = "infoGroup";
            this.infoGroup.Size = new System.Drawing.Size(362, 354);
            this.infoGroup.TabIndex = 2;
            this.infoGroup.TabStop = false;
            this.infoGroup.Text = "Information";
            // 
            // infoCopyrightLabel
            // 
            this.infoCopyrightLabel.AutoSize = true;
            this.infoCopyrightLabel.Location = new System.Drawing.Point(6, 20);
            this.infoCopyrightLabel.Name = "infoCopyrightLabel";
            this.infoCopyrightLabel.Size = new System.Drawing.Size(51, 13);
            this.infoCopyrightLabel.TabIndex = 19;
            this.infoCopyrightLabel.TabStop = true;
            this.infoCopyrightLabel.Text = "Copyright";
            this.infoCopyrightLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.goToMITLicense);
            // 
            // infoAuthorsLabel
            // 
            this.infoAuthorsLabel.AutoSize = true;
            this.infoAuthorsLabel.Location = new System.Drawing.Point(6, 65);
            this.infoAuthorsLabel.Name = "infoAuthorsLabel";
            this.infoAuthorsLabel.Size = new System.Drawing.Size(43, 13);
            this.infoAuthorsLabel.TabIndex = 22;
            this.infoAuthorsLabel.TabStop = true;
            this.infoAuthorsLabel.Text = "Authors";
            this.infoAuthorsLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.goToMevordel);
            // 
            // infoReadMe
            // 
            this.infoReadMe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.infoReadMe.Location = new System.Drawing.Point(63, 132);
            this.infoReadMe.Multiline = true;
            this.infoReadMe.Name = "infoReadMe";
            this.infoReadMe.ReadOnly = true;
            this.infoReadMe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infoReadMe.Size = new System.Drawing.Size(293, 206);
            this.infoReadMe.TabIndex = 28;
            this.infoReadMe.Text = resources.GetString("infoReadMe.Text");
            // 
            // infoReadMeLabel
            // 
            this.infoReadMeLabel.AutoSize = true;
            this.infoReadMeLabel.Location = new System.Drawing.Point(6, 135);
            this.infoReadMeLabel.Name = "infoReadMeLabel";
            this.infoReadMeLabel.Size = new System.Drawing.Size(48, 13);
            this.infoReadMeLabel.TabIndex = 27;
            this.infoReadMeLabel.TabStop = true;
            this.infoReadMeLabel.Text = "ReadMe";
            this.infoReadMeLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.openReadMe);
            // 
            // infoLILabel
            // 
            this.infoLILabel.AutoSize = true;
            this.infoLILabel.Location = new System.Drawing.Point(6, 112);
            this.infoLILabel.Name = "infoLILabel";
            this.infoLILabel.Size = new System.Drawing.Size(44, 13);
            this.infoLILabel.TabIndex = 25;
            this.infoLILabel.TabStop = true;
            this.infoLILabel.Text = "LI Page";
            this.infoLILabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.goToLI);
            // 
            // infoCreditsLabel
            // 
            this.infoCreditsLabel.AutoSize = true;
            this.infoCreditsLabel.Location = new System.Drawing.Point(6, 89);
            this.infoCreditsLabel.Name = "infoCreditsLabel";
            this.infoCreditsLabel.Size = new System.Drawing.Size(39, 13);
            this.infoCreditsLabel.TabIndex = 0;
            this.infoCreditsLabel.Text = "Credits";
            // 
            // infoCredits
            // 
            this.infoCredits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.infoCredits.Location = new System.Drawing.Point(63, 86);
            this.infoCredits.Name = "infoCredits";
            this.infoCredits.ReadOnly = true;
            this.infoCredits.Size = new System.Drawing.Size(293, 20);
            this.infoCredits.TabIndex = 24;
            this.infoCredits.Text = "The Old One, MrJackdaw, Adra, and Modnar";
            this.infoCredits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // infoAuthors
            // 
            this.infoAuthors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.infoAuthors.Location = new System.Drawing.Point(63, 63);
            this.infoAuthors.Name = "infoAuthors";
            this.infoAuthors.ReadOnly = true;
            this.infoAuthors.Size = new System.Drawing.Size(293, 20);
            this.infoAuthors.TabIndex = 23;
            this.infoAuthors.Text = "Mevordel and Telemachus";
            this.infoAuthors.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // infoVersion
            // 
            this.infoVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.infoVersion.Location = new System.Drawing.Point(63, 39);
            this.infoVersion.Name = "infoVersion";
            this.infoVersion.ReadOnly = true;
            this.infoVersion.Size = new System.Drawing.Size(293, 20);
            this.infoVersion.TabIndex = 21;
            this.infoVersion.Text = "0.99.9 (December 2012)";
            this.infoVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // infoVersionLabel
            // 
            this.infoVersionLabel.AutoSize = true;
            this.infoVersionLabel.Location = new System.Drawing.Point(6, 43);
            this.infoVersionLabel.Name = "infoVersionLabel";
            this.infoVersionLabel.Size = new System.Drawing.Size(42, 13);
            this.infoVersionLabel.TabIndex = 0;
            this.infoVersionLabel.Text = "Version";
            // 
            // infoCopyright
            // 
            this.infoCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.infoCopyright.Location = new System.Drawing.Point(63, 17);
            this.infoCopyright.Name = "infoCopyright";
            this.infoCopyright.ReadOnly = true;
            this.infoCopyright.Size = new System.Drawing.Size(293, 20);
            this.infoCopyright.TabIndex = 20;
            this.infoCopyright.Text = "2012 Mevordel (Released under the MIT License)";
            this.infoCopyright.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // infoLI
            // 
            this.infoLI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.infoLI.Location = new System.Drawing.Point(63, 109);
            this.infoLI.Name = "infoLI";
            this.infoLI.ReadOnly = true;
            this.infoLI.Size = new System.Drawing.Size(293, 20);
            this.infoLI.TabIndex = 26;
            this.infoLI.Text = "http://lotrointerface.com/downloads/info623";
            this.infoLI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // settingsGroup
            // 
            this.settingsGroup.Controls.Add(this.settingsResolution);
            this.settingsGroup.Controls.Add(this.settingsResolutionLabel);
            this.settingsGroup.Controls.Add(this.settingsEditorBrowse);
            this.settingsGroup.Controls.Add(this.settingsEditorPath);
            this.settingsGroup.Controls.Add(this.settingsEditorLabel);
            this.settingsGroup.Controls.Add(this.settingsTranslucent);
            this.settingsGroup.Controls.Add(this.settingsReadOnly);
            this.settingsGroup.Controls.Add(this.settingsTransMax);
            this.settingsGroup.Controls.Add(this.settingsAutoLoad);
            this.settingsGroup.Controls.Add(this.settingsConfirmation);
            this.settingsGroup.Controls.Add(this.settingsNoRecycle);
            this.settingsGroup.Dock = System.Windows.Forms.DockStyle.Right;
            this.settingsGroup.Location = new System.Drawing.Point(369, 27);
            this.settingsGroup.Name = "settingsGroup";
            this.settingsGroup.Size = new System.Drawing.Size(200, 354);
            this.settingsGroup.TabIndex = 3;
            this.settingsGroup.TabStop = false;
            this.settingsGroup.Text = "Settings";
            // 
            // settingsResolution
            // 
            this.settingsResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.settingsResolution.Items.AddRange(new object[] {
            "800x600",
            "1024x768",
            "1152x768",
            "1280x720",
            "1280x800",
            "1280x1024",
            "1366x768",
            "1440x900",
            "1600x900",
            "1680x1024",
            "1680x1050",
            "1920x1080",
            "1920x1200",
            "2048x1080",
            "2048x1536",
            "2560x1440",
            "2560x1600",
            "2560x2048"});
            this.settingsResolution.Location = new System.Drawing.Point(10, 217);
            this.settingsResolution.Name = "settingsResolution";
            this.settingsResolution.Size = new System.Drawing.Size(180, 21);
            this.settingsResolution.TabIndex = 37;
            // 
            // settingsResolutionLabel
            // 
            this.settingsResolutionLabel.AutoSize = true;
            this.settingsResolutionLabel.Location = new System.Drawing.Point(7, 201);
            this.settingsResolutionLabel.Name = "settingsResolutionLabel";
            this.settingsResolutionLabel.Size = new System.Drawing.Size(57, 13);
            this.settingsResolutionLabel.TabIndex = 0;
            this.settingsResolutionLabel.Text = "Resolution";
            // 
            // settingsEditorBrowse
            // 
            this.settingsEditorBrowse.AutoSize = true;
            this.settingsEditorBrowse.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.settingsEditorBrowse.Location = new System.Drawing.Point(148, 158);
            this.settingsEditorBrowse.Name = "settingsEditorBrowse";
            this.settingsEditorBrowse.Size = new System.Drawing.Size(42, 13);
            this.settingsEditorBrowse.TabIndex = 36;
            this.settingsEditorBrowse.TabStop = true;
            this.settingsEditorBrowse.Text = "&Browse";
            this.settingsEditorBrowse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.browseForXMLEditor);
            // 
            // settingsEditorPath
            // 
            this.settingsEditorPath.Location = new System.Drawing.Point(10, 174);
            this.settingsEditorPath.Name = "settingsEditorPath";
            this.settingsEditorPath.Size = new System.Drawing.Size(180, 20);
            this.settingsEditorPath.TabIndex = 35;
            this.settingsEditorPath.Text = "C:\\WINDOWS\\NOTEPAD.EXE";
            // 
            // settingsEditorLabel
            // 
            this.settingsEditorLabel.AutoSize = true;
            this.settingsEditorLabel.Location = new System.Drawing.Point(7, 158);
            this.settingsEditorLabel.Name = "settingsEditorLabel";
            this.settingsEditorLabel.Size = new System.Drawing.Size(84, 13);
            this.settingsEditorLabel.TabIndex = 0;
            this.settingsEditorLabel.Text = "XML Editor Path";
            // 
            // settingsTranslucent
            // 
            this.settingsTranslucent.AutoSize = true;
            this.settingsTranslucent.Checked = true;
            this.settingsTranslucent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.settingsTranslucent.Location = new System.Drawing.Point(10, 19);
            this.settingsTranslucent.Name = "settingsTranslucent";
            this.settingsTranslucent.Size = new System.Drawing.Size(125, 17);
            this.settingsTranslucent.TabIndex = 29;
            this.settingsTranslucent.Text = "Transparent Window";
            this.settingsTranslucent.UseVisualStyleBackColor = true;
            this.settingsTranslucent.CheckedChanged += new System.EventHandler(this.updateOpacity);
            // 
            // settingsReadOnly
            // 
            this.settingsReadOnly.AutoSize = true;
            this.settingsReadOnly.Checked = true;
            this.settingsReadOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.settingsReadOnly.Location = new System.Drawing.Point(10, 134);
            this.settingsReadOnly.Name = "settingsReadOnly";
            this.settingsReadOnly.Size = new System.Drawing.Size(162, 17);
            this.settingsReadOnly.TabIndex = 34;
            this.settingsReadOnly.Text = "Make Downloads Read-Only";
            this.settingsReadOnly.UseVisualStyleBackColor = true;
            this.settingsReadOnly.Visible = false;
            // 
            // settingsTransMax
            // 
            this.settingsTransMax.AutoSize = true;
            this.settingsTransMax.Location = new System.Drawing.Point(28, 42);
            this.settingsTransMax.Name = "settingsTransMax";
            this.settingsTransMax.Size = new System.Drawing.Size(107, 17);
            this.settingsTransMax.TabIndex = 30;
            this.settingsTransMax.Text = "When Maximized";
            this.settingsTransMax.UseVisualStyleBackColor = true;
            this.settingsTransMax.CheckedChanged += new System.EventHandler(this.updateOpacity);
            // 
            // settingsAutoLoad
            // 
            this.settingsAutoLoad.AutoSize = true;
            this.settingsAutoLoad.Location = new System.Drawing.Point(10, 111);
            this.settingsAutoLoad.Name = "settingsAutoLoad";
            this.settingsAutoLoad.Size = new System.Drawing.Size(122, 17);
            this.settingsAutoLoad.TabIndex = 33;
            this.settingsAutoLoad.Text = "Auto-Load Last Skin";
            this.settingsAutoLoad.UseVisualStyleBackColor = true;
            // 
            // settingsConfirmation
            // 
            this.settingsConfirmation.AutoSize = true;
            this.settingsConfirmation.Checked = true;
            this.settingsConfirmation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.settingsConfirmation.Location = new System.Drawing.Point(10, 65);
            this.settingsConfirmation.Name = "settingsConfirmation";
            this.settingsConfirmation.Size = new System.Drawing.Size(145, 17);
            this.settingsConfirmation.TabIndex = 31;
            this.settingsConfirmation.Text = "Confirm Overwrite/Delete";
            this.settingsConfirmation.UseVisualStyleBackColor = true;
            // 
            // settingsNoRecycle
            // 
            this.settingsNoRecycle.AutoSize = true;
            this.settingsNoRecycle.Location = new System.Drawing.Point(10, 88);
            this.settingsNoRecycle.Name = "settingsNoRecycle";
            this.settingsNoRecycle.Size = new System.Drawing.Size(107, 17);
            this.settingsNoRecycle.TabIndex = 32;
            this.settingsNoRecycle.Text = "Skip Recycle Bin";
            this.settingsNoRecycle.UseVisualStyleBackColor = true;
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.settingsReload);
            this.settingsPanel.Controls.Add(this.settingsSave);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsPanel.Location = new System.Drawing.Point(3, 3);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(566, 24);
            this.settingsPanel.TabIndex = 1;
            // 
            // settingsReload
            // 
            this.settingsReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsReload.AutoSize = true;
            this.settingsReload.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.settingsReload.Location = new System.Drawing.Point(488, 3);
            this.settingsReload.Name = "settingsReload";
            this.settingsReload.Size = new System.Drawing.Size(41, 13);
            this.settingsReload.TabIndex = 17;
            this.settingsReload.TabStop = true;
            this.settingsReload.Text = "&Reload";
            this.settingsReload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.settingLoad);
            // 
            // settingsSave
            // 
            this.settingsSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsSave.AutoSize = true;
            this.settingsSave.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.settingsSave.Location = new System.Drawing.Point(531, 3);
            this.settingsSave.Name = "settingsSave";
            this.settingsSave.Size = new System.Drawing.Size(32, 13);
            this.settingsSave.TabIndex = 18;
            this.settingsSave.TabStop = true;
            this.settingsSave.Text = "&Save";
            this.settingsSave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.settingSave);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusProgress,
            this.statusText});
            this.statusBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusBar.Location = new System.Drawing.Point(0, 414);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(584, 22);
            this.statusBar.TabIndex = 1;
            // 
            // statusProgress
            // 
            this.statusProgress.Name = "statusProgress";
            this.statusProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // statusText
            // 
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(39, 17);
            this.statusText.Text = "Ready";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 436);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(450, 200);
            this.Name = "mainForm";
            this.Text = "BuildSkin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainFormClose);
            this.Load += new System.EventHandler(this.mainFormLoad);
            this.Resize += new System.EventHandler(this.updateOpacity);
            this.mainTabs.ResumeLayout(false);
            this.skinsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinsCustomize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinsPreview)).EndInit();
            this.skinsPanel.ResumeLayout(false);
            this.skinsPanel.PerformLayout();
            this.addonsTab.ResumeLayout(false);
            this.addonsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addonsDataGrid)).EndInit();
            this.addonsPanel.ResumeLayout(false);
            this.addonsPanel.PerformLayout();
            this.settingsTab.ResumeLayout(false);
            this.infoGroup.ResumeLayout(false);
            this.infoGroup.PerformLayout();
            this.settingsGroup.ResumeLayout(false);
            this.settingsGroup.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabs;
        private System.Windows.Forms.TabPage skinsTab;
        private System.Windows.Forms.TabPage addonsTab;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripProgressBar statusProgress;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.Panel skinsPanel;
        private System.Windows.Forms.ComboBox skinsList;
        private System.Windows.Forms.LinkLabel skinsBuild;
        private System.Windows.Forms.LinkLabel skinsReload;
        private System.Windows.Forms.LinkLabel skinsClear;
        private System.Windows.Forms.LinkLabel skinsDelete;
        private System.Windows.Forms.LinkLabel skinsRename;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.LinkLabel settingsReload;
        private System.Windows.Forms.LinkLabel settingsSave;
        private System.Windows.Forms.CheckBox settingsTransMax;
        private System.Windows.Forms.CheckBox settingsTranslucent;
        private System.Windows.Forms.CheckBox settingsConfirmation;
        private System.Windows.Forms.CheckBox settingsReadOnly;
        private System.Windows.Forms.CheckBox settingsAutoLoad;
        private System.Windows.Forms.CheckBox settingsNoRecycle;
        private System.Windows.Forms.GroupBox settingsGroup;
        private System.Windows.Forms.TextBox settingsEditorPath;
        private System.Windows.Forms.Label settingsEditorLabel;
        private System.Windows.Forms.LinkLabel settingsEditorBrowse;
        private System.Windows.Forms.ComboBox settingsResolution;
        private System.Windows.Forms.Label settingsResolutionLabel;
        private System.Windows.Forms.GroupBox infoGroup;
        private System.Windows.Forms.LinkLabel skinsEditXML;
        private System.Windows.Forms.TextBox infoReadMe;
        private System.Windows.Forms.LinkLabel infoReadMeLabel;
        private System.Windows.Forms.LinkLabel infoLILabel;
        private System.Windows.Forms.Label infoCreditsLabel;
        private System.Windows.Forms.TextBox infoCredits;
        private System.Windows.Forms.TextBox infoAuthors;
        private System.Windows.Forms.TextBox infoVersion;
        private System.Windows.Forms.Label infoVersionLabel;
        private System.Windows.Forms.TextBox infoCopyright;
        private System.Windows.Forms.TextBox infoLI;
        private System.Windows.Forms.LinkLabel infoAuthorsLabel;
        private System.Windows.Forms.LinkLabel infoCopyrightLabel;
        private System.Windows.Forms.Panel addonsPanel;
        private System.Windows.Forms.TextBox addonsFilter;
        private System.Windows.Forms.LinkLabel addonsInstUpd;
        private System.Windows.Forms.LinkLabel addonsRefreshLocal;
        private System.Windows.Forms.LinkLabel addonsRefreshRemote;
        private System.Windows.Forms.LinkLabel addonsDelete;
        private System.Windows.Forms.Label addonsRefreshLabel;
        private System.Windows.Forms.CheckBox addonsSelectAll;
        private System.Windows.Forms.DataGridView addonsDataGrid;
        private System.Windows.Forms.TextBox addonsDescription;
        private System.Windows.Forms.DataGridView skinsCustomize;
        private System.Windows.Forms.DataGridViewTextBoxColumn customCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn customName;
        private System.Windows.Forms.DataGridViewComboBoxColumn customOptions;
        private System.Windows.Forms.PictureBox skinsPreview;
        private System.Windows.Forms.DataGridViewCheckBoxColumn addonsSelected;
        private System.Windows.Forms.DataGridViewCheckBoxColumn addonsInstalled;
        private System.Windows.Forms.DataGridViewTextBoxColumn addonsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn addonsAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn addonsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn addonsDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn addonsVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn addonsInstVer;
        private System.Windows.Forms.DataGridViewLinkColumn addonsLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn addonsFile;
    }
}

