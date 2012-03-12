namespace BuildSkin
{
    partial class mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.tabPresets = new System.Windows.Forms.TabPage();
            this.presetPreview = new System.Windows.Forms.WebBrowser();
            this.presetList = new System.Windows.Forms.ListBox();
            this.presetTopBox = new System.Windows.Forms.Panel();
            this.presetAdd = new System.Windows.Forms.LinkLabel();
            this.presetDelete = new System.Windows.Forms.LinkLabel();
            this.presetRename = new System.Windows.Forms.LinkLabel();
            this.presetCopy = new System.Windows.Forms.LinkLabel();
            this.presetFilter = new System.Windows.Forms.TextBox();
            this.tabCustom = new System.Windows.Forms.TabPage();
            this.customDataGrid = new System.Windows.Forms.DataGridView();
            this.customTopBox = new System.Windows.Forms.Panel();
            this.customReload = new System.Windows.Forms.LinkLabel();
            this.customSave = new System.Windows.Forms.LinkLabel();
            this.customFilter = new System.Windows.Forms.TextBox();
            this.tabAddons = new System.Windows.Forms.TabPage();
            this.addonDataGrid = new System.Windows.Forms.DataGridView();
            this.addonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addonAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addonVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addonInstalled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.addonActions = new System.Windows.Forms.DataGridViewLinkColumn();
            this.addonTopBox = new System.Windows.Forms.Panel();
            this.addonDeleteAll = new System.Windows.Forms.LinkLabel();
            this.addonRefreshList = new System.Windows.Forms.LinkLabel();
            this.addonUpdate = new System.Windows.Forms.LinkLabel();
            this.addonFilter = new System.Windows.Forms.TextBox();
            this.tabOptions = new System.Windows.Forms.TabPage();
            this.optionTopBox = new System.Windows.Forms.Panel();
            this.optionReload = new System.Windows.Forms.LinkLabel();
            this.optionSave = new System.Windows.Forms.LinkLabel();
            this.optionFilter = new System.Windows.Forms.TextBox();
            this.optionReadOnly = new System.Windows.Forms.CheckBox();
            this.optionEditorBrowse = new System.Windows.Forms.Button();
            this.optionEditorLabel = new System.Windows.Forms.Label();
            this.optionEditorPath = new System.Windows.Forms.TextBox();
            this.optionAutoLoad = new System.Windows.Forms.CheckBox();
            this.optionConfirmation = new System.Windows.Forms.CheckBox();
            this.optionTransMax = new System.Windows.Forms.CheckBox();
            this.optionTranslucent = new System.Windows.Forms.CheckBox();
            this.optionDefResLabel = new System.Windows.Forms.Label();
            this.optionDefaultRes = new System.Windows.Forms.ComboBox();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.mainContainer = new System.Windows.Forms.ToolStripContainer();
            this.optionNoRecycle = new System.Windows.Forms.CheckBox();
            this.customOption = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.customName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusBar.SuspendLayout();
            this.mainTabs.SuspendLayout();
            this.tabPresets.SuspendLayout();
            this.presetTopBox.SuspendLayout();
            this.tabCustom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customDataGrid)).BeginInit();
            this.customTopBox.SuspendLayout();
            this.tabAddons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addonDataGrid)).BeginInit();
            this.addonTopBox.SuspendLayout();
            this.tabOptions.SuspendLayout();
            this.optionTopBox.SuspendLayout();
            this.mainContainer.BottomToolStripPanel.SuspendLayout();
            this.mainContainer.ContentPanel.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Dock = System.Windows.Forms.DockStyle.None;
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.statusProgress});
            this.statusBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusBar.Location = new System.Drawing.Point(0, 0);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(584, 22);
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "Status";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Ready";
            // 
            // statusProgress
            // 
            this.statusProgress.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.statusProgress.Name = "statusProgress";
            this.statusProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // mainTabs
            // 
            this.mainTabs.Controls.Add(this.tabPresets);
            this.mainTabs.Controls.Add(this.tabCustom);
            this.mainTabs.Controls.Add(this.tabAddons);
            this.mainTabs.Controls.Add(this.tabOptions);
            this.mainTabs.Controls.Add(this.tabInfo);
            this.mainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabs.Location = new System.Drawing.Point(0, 0);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(584, 389);
            this.mainTabs.TabIndex = 1;
            // 
            // tabPresets
            // 
            this.tabPresets.Controls.Add(this.presetPreview);
            this.tabPresets.Controls.Add(this.presetList);
            this.tabPresets.Controls.Add(this.presetTopBox);
            this.tabPresets.Location = new System.Drawing.Point(4, 22);
            this.tabPresets.Name = "tabPresets";
            this.tabPresets.Size = new System.Drawing.Size(576, 363);
            this.tabPresets.TabIndex = 0;
            this.tabPresets.Text = "Presets";
            this.tabPresets.UseVisualStyleBackColor = true;
            // 
            // presetPreview
            // 
            this.presetPreview.AllowNavigation = false;
            this.presetPreview.AllowWebBrowserDrop = false;
            this.presetPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presetPreview.IsWebBrowserContextMenuEnabled = false;
            this.presetPreview.Location = new System.Drawing.Point(228, 22);
            this.presetPreview.MinimumSize = new System.Drawing.Size(20, 20);
            this.presetPreview.Name = "presetPreview";
            this.presetPreview.ScriptErrorsSuppressed = true;
            this.presetPreview.ScrollBarsEnabled = false;
            this.presetPreview.Size = new System.Drawing.Size(348, 341);
            this.presetPreview.TabIndex = 5;
            this.presetPreview.Url = new System.Uri("C:\\Users\\Samuel\\Documents\\Visual Studio 2010\\Projects\\BuildSkin (beta)\\BuildSkin " +
                    "(beta)\\bin\\Release\\welcome.html", System.UriKind.Absolute);
            // 
            // presetList
            // 
            this.presetList.Dock = System.Windows.Forms.DockStyle.Left;
            this.presetList.FormattingEnabled = true;
            this.presetList.IntegralHeight = false;
            this.presetList.Location = new System.Drawing.Point(0, 22);
            this.presetList.Name = "presetList";
            this.presetList.Size = new System.Drawing.Size(228, 341);
            this.presetList.TabIndex = 4;
            this.presetList.SelectedIndexChanged += new System.EventHandler(this.SelectPreset);
            // 
            // presetTopBox
            // 
            this.presetTopBox.Controls.Add(this.presetAdd);
            this.presetTopBox.Controls.Add(this.presetDelete);
            this.presetTopBox.Controls.Add(this.presetRename);
            this.presetTopBox.Controls.Add(this.presetCopy);
            this.presetTopBox.Controls.Add(this.presetFilter);
            this.presetTopBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.presetTopBox.Location = new System.Drawing.Point(0, 0);
            this.presetTopBox.Name = "presetTopBox";
            this.presetTopBox.Size = new System.Drawing.Size(576, 22);
            this.presetTopBox.TabIndex = 3;
            // 
            // presetAdd
            // 
            this.presetAdd.AutoSize = true;
            this.presetAdd.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.presetAdd.Location = new System.Drawing.Point(234, 4);
            this.presetAdd.Name = "presetAdd";
            this.presetAdd.Size = new System.Drawing.Size(26, 13);
            this.presetAdd.TabIndex = 14;
            this.presetAdd.TabStop = true;
            this.presetAdd.Text = "&Add";
            this.presetAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddPreset);
            // 
            // presetDelete
            // 
            this.presetDelete.AutoSize = true;
            this.presetDelete.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.presetDelete.Location = new System.Drawing.Point(266, 4);
            this.presetDelete.Name = "presetDelete";
            this.presetDelete.Size = new System.Drawing.Size(38, 13);
            this.presetDelete.TabIndex = 13;
            this.presetDelete.TabStop = true;
            this.presetDelete.Text = "&Delete";
            this.presetDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeletePreset);
            // 
            // presetRename
            // 
            this.presetRename.AutoSize = true;
            this.presetRename.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.presetRename.Location = new System.Drawing.Point(310, 4);
            this.presetRename.Name = "presetRename";
            this.presetRename.Size = new System.Drawing.Size(47, 13);
            this.presetRename.TabIndex = 12;
            this.presetRename.TabStop = true;
            this.presetRename.Text = "&Rename";
            this.presetRename.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RenamePreset);
            // 
            // presetCopy
            // 
            this.presetCopy.AutoSize = true;
            this.presetCopy.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.presetCopy.Location = new System.Drawing.Point(363, 4);
            this.presetCopy.Name = "presetCopy";
            this.presetCopy.Size = new System.Drawing.Size(31, 13);
            this.presetCopy.TabIndex = 11;
            this.presetCopy.TabStop = true;
            this.presetCopy.Text = "&Copy";
            this.presetCopy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CopyPreset);
            // 
            // presetFilter
            // 
            this.presetFilter.Location = new System.Drawing.Point(0, 1);
            this.presetFilter.Name = "presetFilter";
            this.presetFilter.Size = new System.Drawing.Size(228, 20);
            this.presetFilter.TabIndex = 9;
            this.presetFilter.TextChanged += new System.EventHandler(this.FilterPresets);
            // 
            // tabCustom
            // 
            this.tabCustom.Controls.Add(this.customDataGrid);
            this.tabCustom.Controls.Add(this.customTopBox);
            this.tabCustom.Location = new System.Drawing.Point(4, 22);
            this.tabCustom.Name = "tabCustom";
            this.tabCustom.Size = new System.Drawing.Size(576, 363);
            this.tabCustom.TabIndex = 1;
            this.tabCustom.Text = "Customize";
            this.tabCustom.UseVisualStyleBackColor = true;
            // 
            // customDataGrid
            // 
            this.customDataGrid.AllowUserToDeleteRows = false;
            this.customDataGrid.AllowUserToResizeColumns = false;
            this.customDataGrid.AllowUserToResizeRows = false;
            this.customDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customDataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.customDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customCategory,
            this.customName,
            this.customOption});
            this.customDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customDataGrid.EnableHeadersVisualStyles = false;
            this.customDataGrid.Location = new System.Drawing.Point(0, 22);
            this.customDataGrid.Name = "customDataGrid";
            this.customDataGrid.RowHeadersVisible = false;
            this.customDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.customDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.customDataGrid.Size = new System.Drawing.Size(576, 341);
            this.customDataGrid.TabIndex = 3;
            // 
            // customTopBox
            // 
            this.customTopBox.Controls.Add(this.customReload);
            this.customTopBox.Controls.Add(this.customSave);
            this.customTopBox.Controls.Add(this.customFilter);
            this.customTopBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.customTopBox.Location = new System.Drawing.Point(0, 0);
            this.customTopBox.Name = "customTopBox";
            this.customTopBox.Size = new System.Drawing.Size(576, 22);
            this.customTopBox.TabIndex = 1;
            // 
            // customReload
            // 
            this.customReload.AutoSize = true;
            this.customReload.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.customReload.Location = new System.Drawing.Point(234, 4);
            this.customReload.Name = "customReload";
            this.customReload.Size = new System.Drawing.Size(41, 13);
            this.customReload.TabIndex = 12;
            this.customReload.TabStop = true;
            this.customReload.Text = "&Reload";
            this.customReload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoadCustom);
            // 
            // customSave
            // 
            this.customSave.AutoSize = true;
            this.customSave.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.customSave.Location = new System.Drawing.Point(281, 4);
            this.customSave.Name = "customSave";
            this.customSave.Size = new System.Drawing.Size(32, 13);
            this.customSave.TabIndex = 11;
            this.customSave.TabStop = true;
            this.customSave.Text = "&Save";
            this.customSave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SaveCustom);
            // 
            // customFilter
            // 
            this.customFilter.Location = new System.Drawing.Point(0, 1);
            this.customFilter.Name = "customFilter";
            this.customFilter.Size = new System.Drawing.Size(228, 20);
            this.customFilter.TabIndex = 9;
            this.customFilter.TextChanged += new System.EventHandler(this.FilterElements);
            // 
            // tabAddons
            // 
            this.tabAddons.Controls.Add(this.addonDataGrid);
            this.tabAddons.Controls.Add(this.addonTopBox);
            this.tabAddons.Location = new System.Drawing.Point(4, 22);
            this.tabAddons.Name = "tabAddons";
            this.tabAddons.Size = new System.Drawing.Size(576, 363);
            this.tabAddons.TabIndex = 2;
            this.tabAddons.Text = "Manage Addons";
            this.tabAddons.UseVisualStyleBackColor = true;
            // 
            // addonDataGrid
            // 
            this.addonDataGrid.AllowUserToDeleteRows = false;
            this.addonDataGrid.AllowUserToResizeRows = false;
            this.addonDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addonDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addonDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addonName,
            this.addonAuthor,
            this.addonVersion,
            this.addonInstalled,
            this.addonActions});
            this.addonDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addonDataGrid.EnableHeadersVisualStyles = false;
            this.addonDataGrid.Location = new System.Drawing.Point(0, 22);
            this.addonDataGrid.MultiSelect = false;
            this.addonDataGrid.Name = "addonDataGrid";
            this.addonDataGrid.RowHeadersVisible = false;
            this.addonDataGrid.Size = new System.Drawing.Size(576, 341);
            this.addonDataGrid.TabIndex = 3;
            // 
            // addonName
            // 
            this.addonName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.addonName.FillWeight = 110F;
            this.addonName.HeaderText = "Name";
            this.addonName.Name = "addonName";
            this.addonName.ReadOnly = true;
            this.addonName.Width = 227;
            // 
            // addonAuthor
            // 
            this.addonAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addonAuthor.HeaderText = "Author";
            this.addonAuthor.Name = "addonAuthor";
            this.addonAuthor.ReadOnly = true;
            // 
            // addonVersion
            // 
            this.addonVersion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.addonVersion.HeaderText = "Version";
            this.addonVersion.Name = "addonVersion";
            this.addonVersion.ReadOnly = true;
            this.addonVersion.Width = 21;
            // 
            // addonInstalled
            // 
            this.addonInstalled.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.addonInstalled.HeaderText = "Installed";
            this.addonInstalled.Name = "addonInstalled";
            this.addonInstalled.ReadOnly = true;
            this.addonInstalled.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.addonInstalled.Width = 21;
            // 
            // addonActions
            // 
            this.addonActions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.addonActions.HeaderText = "Actions";
            this.addonActions.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.addonActions.Name = "addonActions";
            this.addonActions.ReadOnly = true;
            this.addonActions.Width = 48;
            // 
            // addonTopBox
            // 
            this.addonTopBox.Controls.Add(this.addonDeleteAll);
            this.addonTopBox.Controls.Add(this.addonRefreshList);
            this.addonTopBox.Controls.Add(this.addonUpdate);
            this.addonTopBox.Controls.Add(this.addonFilter);
            this.addonTopBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.addonTopBox.Location = new System.Drawing.Point(0, 0);
            this.addonTopBox.Name = "addonTopBox";
            this.addonTopBox.Size = new System.Drawing.Size(576, 22);
            this.addonTopBox.TabIndex = 2;
            // 
            // addonDeleteAll
            // 
            this.addonDeleteAll.AutoSize = true;
            this.addonDeleteAll.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.addonDeleteAll.Location = new System.Drawing.Point(332, 4);
            this.addonDeleteAll.Name = "addonDeleteAll";
            this.addonDeleteAll.Size = new System.Drawing.Size(52, 13);
            this.addonDeleteAll.TabIndex = 13;
            this.addonDeleteAll.TabStop = true;
            this.addonDeleteAll.Text = "&Delete All";
            this.addonDeleteAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeleteAllAddons);
            // 
            // addonRefreshList
            // 
            this.addonRefreshList.AutoSize = true;
            this.addonRefreshList.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.addonRefreshList.Location = new System.Drawing.Point(234, 4);
            this.addonRefreshList.Name = "addonRefreshList";
            this.addonRefreshList.Size = new System.Drawing.Size(44, 13);
            this.addonRefreshList.TabIndex = 12;
            this.addonRefreshList.TabStop = true;
            this.addonRefreshList.Text = "&Refresh";
            this.addonRefreshList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RefreshAddons);
            // 
            // addonUpdate
            // 
            this.addonUpdate.AutoSize = true;
            this.addonUpdate.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.addonUpdate.Location = new System.Drawing.Point(284, 4);
            this.addonUpdate.Name = "addonUpdate";
            this.addonUpdate.Size = new System.Drawing.Size(42, 13);
            this.addonUpdate.TabIndex = 11;
            this.addonUpdate.TabStop = true;
            this.addonUpdate.Text = "&Update";
            this.addonUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UpdateAddons);
            // 
            // addonFilter
            // 
            this.addonFilter.Location = new System.Drawing.Point(0, 1);
            this.addonFilter.Name = "addonFilter";
            this.addonFilter.Size = new System.Drawing.Size(228, 20);
            this.addonFilter.TabIndex = 9;
            this.addonFilter.TextChanged += new System.EventHandler(this.FilterAddons);
            // 
            // tabOptions
            // 
            this.tabOptions.AutoScroll = true;
            this.tabOptions.Controls.Add(this.optionNoRecycle);
            this.tabOptions.Controls.Add(this.optionTopBox);
            this.tabOptions.Controls.Add(this.optionReadOnly);
            this.tabOptions.Controls.Add(this.optionEditorBrowse);
            this.tabOptions.Controls.Add(this.optionEditorLabel);
            this.tabOptions.Controls.Add(this.optionEditorPath);
            this.tabOptions.Controls.Add(this.optionAutoLoad);
            this.tabOptions.Controls.Add(this.optionConfirmation);
            this.tabOptions.Controls.Add(this.optionTransMax);
            this.tabOptions.Controls.Add(this.optionTranslucent);
            this.tabOptions.Controls.Add(this.optionDefResLabel);
            this.tabOptions.Controls.Add(this.optionDefaultRes);
            this.tabOptions.Location = new System.Drawing.Point(4, 22);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Size = new System.Drawing.Size(576, 363);
            this.tabOptions.TabIndex = 4;
            this.tabOptions.Text = "Settings";
            this.tabOptions.UseVisualStyleBackColor = true;
            // 
            // optionTopBox
            // 
            this.optionTopBox.Controls.Add(this.optionReload);
            this.optionTopBox.Controls.Add(this.optionSave);
            this.optionTopBox.Controls.Add(this.optionFilter);
            this.optionTopBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.optionTopBox.Location = new System.Drawing.Point(0, 0);
            this.optionTopBox.Name = "optionTopBox";
            this.optionTopBox.Size = new System.Drawing.Size(576, 22);
            this.optionTopBox.TabIndex = 15;
            // 
            // optionReload
            // 
            this.optionReload.AutoSize = true;
            this.optionReload.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.optionReload.Location = new System.Drawing.Point(234, 4);
            this.optionReload.Name = "optionReload";
            this.optionReload.Size = new System.Drawing.Size(41, 13);
            this.optionReload.TabIndex = 12;
            this.optionReload.TabStop = true;
            this.optionReload.Text = "&Reload";
            this.optionReload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ReloadSettings);
            // 
            // optionSave
            // 
            this.optionSave.AutoSize = true;
            this.optionSave.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.optionSave.Location = new System.Drawing.Point(281, 4);
            this.optionSave.Name = "optionSave";
            this.optionSave.Size = new System.Drawing.Size(32, 13);
            this.optionSave.TabIndex = 11;
            this.optionSave.TabStop = true;
            this.optionSave.Text = "&Save";
            this.optionSave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SaveSettings);
            // 
            // optionFilter
            // 
            this.optionFilter.Location = new System.Drawing.Point(0, 1);
            this.optionFilter.Name = "optionFilter";
            this.optionFilter.Size = new System.Drawing.Size(228, 20);
            this.optionFilter.TabIndex = 9;
            // 
            // optionReadOnly
            // 
            this.optionReadOnly.AutoSize = true;
            this.optionReadOnly.Checked = true;
            this.optionReadOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.optionReadOnly.Location = new System.Drawing.Point(8, 123);
            this.optionReadOnly.Name = "optionReadOnly";
            this.optionReadOnly.Size = new System.Drawing.Size(217, 17);
            this.optionReadOnly.TabIndex = 14;
            this.optionReadOnly.Text = "Prevent changes to downloaded presets";
            this.optionReadOnly.UseVisualStyleBackColor = true;
            // 
            // optionEditorBrowse
            // 
            this.optionEditorBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optionEditorBrowse.Location = new System.Drawing.Point(513, 95);
            this.optionEditorBrowse.Name = "optionEditorBrowse";
            this.optionEditorBrowse.Size = new System.Drawing.Size(55, 24);
            this.optionEditorBrowse.TabIndex = 13;
            this.optionEditorBrowse.Text = "Browse";
            this.optionEditorBrowse.UseVisualStyleBackColor = true;
            this.optionEditorBrowse.Click += new System.EventHandler(this.BrowseForEditor);
            // 
            // optionEditorLabel
            // 
            this.optionEditorLabel.AutoSize = true;
            this.optionEditorLabel.Location = new System.Drawing.Point(229, 78);
            this.optionEditorLabel.Name = "optionEditorLabel";
            this.optionEditorLabel.Size = new System.Drawing.Size(80, 13);
            this.optionEditorLabel.TabIndex = 12;
            this.optionEditorLabel.Text = "Preferred Editor";
            // 
            // optionEditorPath
            // 
            this.optionEditorPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.optionEditorPath.Location = new System.Drawing.Point(232, 98);
            this.optionEditorPath.Name = "optionEditorPath";
            this.optionEditorPath.Size = new System.Drawing.Size(275, 20);
            this.optionEditorPath.TabIndex = 11;
            this.optionEditorPath.Text = "C:\\Windows\\Notepad.exe";
            // 
            // optionAutoLoad
            // 
            this.optionAutoLoad.AutoSize = true;
            this.optionAutoLoad.Location = new System.Drawing.Point(8, 100);
            this.optionAutoLoad.Name = "optionAutoLoad";
            this.optionAutoLoad.Size = new System.Drawing.Size(152, 17);
            this.optionAutoLoad.TabIndex = 10;
            this.optionAutoLoad.Text = "Automatically load last skin";
            this.optionAutoLoad.UseVisualStyleBackColor = true;
            // 
            // optionConfirmation
            // 
            this.optionConfirmation.AutoSize = true;
            this.optionConfirmation.Checked = true;
            this.optionConfirmation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.optionConfirmation.Location = new System.Drawing.Point(8, 77);
            this.optionConfirmation.Name = "optionConfirmation";
            this.optionConfirmation.Size = new System.Drawing.Size(176, 17);
            this.optionConfirmation.TabIndex = 9;
            this.optionConfirmation.Text = "Confirm deleting and overwriting";
            this.optionConfirmation.UseVisualStyleBackColor = true;
            // 
            // optionTransMax
            // 
            this.optionTransMax.AutoSize = true;
            this.optionTransMax.Location = new System.Drawing.Point(28, 54);
            this.optionTransMax.Name = "optionTransMax";
            this.optionTransMax.Size = new System.Drawing.Size(131, 17);
            this.optionTransMax.TabIndex = 8;
            this.optionTransMax.Text = "Even when maximized";
            this.optionTransMax.UseVisualStyleBackColor = true;
            this.optionTransMax.CheckedChanged += new System.EventHandler(this.UpdateTransparency);
            // 
            // optionTranslucent
            // 
            this.optionTranslucent.AutoSize = true;
            this.optionTranslucent.Checked = true;
            this.optionTranslucent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.optionTranslucent.Location = new System.Drawing.Point(8, 31);
            this.optionTranslucent.Name = "optionTranslucent";
            this.optionTranslucent.Size = new System.Drawing.Size(121, 17);
            this.optionTranslucent.TabIndex = 7;
            this.optionTranslucent.Text = "Translucent window";
            this.optionTranslucent.UseVisualStyleBackColor = true;
            this.optionTranslucent.CheckedChanged += new System.EventHandler(this.UpdateTransparency);
            // 
            // optionDefResLabel
            // 
            this.optionDefResLabel.AutoSize = true;
            this.optionDefResLabel.Location = new System.Drawing.Point(229, 32);
            this.optionDefResLabel.Name = "optionDefResLabel";
            this.optionDefResLabel.Size = new System.Drawing.Size(94, 13);
            this.optionDefResLabel.TabIndex = 6;
            this.optionDefResLabel.Text = "Default Resolution";
            // 
            // optionDefaultRes
            // 
            this.optionDefaultRes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.optionDefaultRes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.optionDefaultRes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.optionDefaultRes.FormattingEnabled = true;
            this.optionDefaultRes.Items.AddRange(new object[] {
            "800x600",
            "1024x768",
            "1280x800",
            "1280x960",
            "1280x1024",
            "1360x768",
            "1366x768",
            "1440x900",
            "1600x900",
            "1920x1080",
            "1920x1200"});
            this.optionDefaultRes.Location = new System.Drawing.Point(232, 52);
            this.optionDefaultRes.Name = "optionDefaultRes";
            this.optionDefaultRes.Size = new System.Drawing.Size(336, 21);
            this.optionDefaultRes.TabIndex = 5;
            // 
            // tabInfo
            // 
            this.tabInfo.Location = new System.Drawing.Point(4, 22);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Size = new System.Drawing.Size(576, 363);
            this.tabInfo.TabIndex = 3;
            this.tabInfo.Text = "Information";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // mainContainer
            // 
            // 
            // mainContainer.BottomToolStripPanel
            // 
            this.mainContainer.BottomToolStripPanel.BackColor = System.Drawing.SystemColors.Menu;
            this.mainContainer.BottomToolStripPanel.Controls.Add(this.statusBar);
            // 
            // mainContainer.ContentPanel
            // 
            this.mainContainer.ContentPanel.AutoScroll = true;
            this.mainContainer.ContentPanel.Controls.Add(this.mainTabs);
            this.mainContainer.ContentPanel.Size = new System.Drawing.Size(584, 389);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // mainContainer.LeftToolStripPanel
            // 
            this.mainContainer.LeftToolStripPanel.BackColor = System.Drawing.SystemColors.Menu;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            // 
            // mainContainer.RightToolStripPanel
            // 
            this.mainContainer.RightToolStripPanel.BackColor = System.Drawing.SystemColors.Menu;
            this.mainContainer.Size = new System.Drawing.Size(584, 411);
            this.mainContainer.TabIndex = 2;
            this.mainContainer.Text = "toolStripContainer1";
            // 
            // mainContainer.TopToolStripPanel
            // 
            this.mainContainer.TopToolStripPanel.BackColor = System.Drawing.SystemColors.Menu;
            // 
            // optionNoRecycle
            // 
            this.optionNoRecycle.AutoSize = true;
            this.optionNoRecycle.Location = new System.Drawing.Point(232, 123);
            this.optionNoRecycle.Name = "optionNoRecycle";
            this.optionNoRecycle.Size = new System.Drawing.Size(120, 17);
            this.optionNoRecycle.TabIndex = 16;
            this.optionNoRecycle.Text = "Bypass Recycle Bin";
            this.optionNoRecycle.UseVisualStyleBackColor = true;
            // 
            // customOption
            // 
            this.customOption.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customOption.FillWeight = 100.2105F;
            this.customOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customOption.HeaderText = "Option";
            this.customOption.Name = "customOption";
            this.customOption.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // customName
            // 
            this.customName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.customName.FillWeight = 99.78947F;
            this.customName.HeaderText = "Element Name";
            this.customName.Name = "customName";
            this.customName.ReadOnly = true;
            this.customName.Width = 127;
            // 
            // customCategory
            // 
            this.customCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.customCategory.HeaderText = "Category";
            this.customCategory.Name = "customCategory";
            this.customCategory.ReadOnly = true;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.mainContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 230);
            this.Name = "mainWindow";
            this.Text = "BuildSkin BETA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClose);
            this.SizeChanged += new System.EventHandler(this.UpdateTransparency);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.mainTabs.ResumeLayout(false);
            this.tabPresets.ResumeLayout(false);
            this.presetTopBox.ResumeLayout(false);
            this.presetTopBox.PerformLayout();
            this.tabCustom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customDataGrid)).EndInit();
            this.customTopBox.ResumeLayout(false);
            this.customTopBox.PerformLayout();
            this.tabAddons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addonDataGrid)).EndInit();
            this.addonTopBox.ResumeLayout(false);
            this.addonTopBox.PerformLayout();
            this.tabOptions.ResumeLayout(false);
            this.tabOptions.PerformLayout();
            this.optionTopBox.ResumeLayout(false);
            this.optionTopBox.PerformLayout();
            this.mainContainer.BottomToolStripPanel.ResumeLayout(false);
            this.mainContainer.BottomToolStripPanel.PerformLayout();
            this.mainContainer.ContentPanel.ResumeLayout(false);
            this.mainContainer.ResumeLayout(false);
            this.mainContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.TabControl mainTabs;
        private System.Windows.Forms.TabPage tabPresets;
        private System.Windows.Forms.TabPage tabCustom;
        private System.Windows.Forms.TabPage tabAddons;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.ToolStripContainer mainContainer;
        private System.Windows.Forms.ToolStripProgressBar statusProgress;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.TabPage tabOptions;
        private System.Windows.Forms.Label optionDefResLabel;
        private System.Windows.Forms.Button optionEditorBrowse;
        private System.Windows.Forms.Label optionEditorLabel;
        private System.Windows.Forms.Panel customTopBox;
        private System.Windows.Forms.TextBox customFilter;
        private System.Windows.Forms.DataGridView customDataGrid;
        private System.Windows.Forms.LinkLabel customReload;
        private System.Windows.Forms.LinkLabel customSave;
        private System.Windows.Forms.Panel addonTopBox;
        private System.Windows.Forms.LinkLabel addonRefreshList;
        private System.Windows.Forms.LinkLabel addonUpdate;
        private System.Windows.Forms.TextBox addonFilter;
        private System.Windows.Forms.Panel optionTopBox;
        private System.Windows.Forms.LinkLabel optionReload;
        private System.Windows.Forms.LinkLabel optionSave;
        private System.Windows.Forms.TextBox optionFilter;
        private System.Windows.Forms.Panel presetTopBox;
        private System.Windows.Forms.LinkLabel presetRename;
        private System.Windows.Forms.LinkLabel presetCopy;
        private System.Windows.Forms.TextBox presetFilter;
        private System.Windows.Forms.LinkLabel presetAdd;
        private System.Windows.Forms.LinkLabel presetDelete;
        private System.Windows.Forms.WebBrowser presetPreview;
        private System.Windows.Forms.ListBox presetList;
        private System.Windows.Forms.LinkLabel addonDeleteAll;
        private System.Windows.Forms.DataGridView addonDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn addonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn addonAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn addonVersion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn addonInstalled;
        private System.Windows.Forms.DataGridViewLinkColumn addonActions;
        private System.Windows.Forms.ComboBox optionDefaultRes;
        private System.Windows.Forms.CheckBox optionAutoLoad;
        private System.Windows.Forms.CheckBox optionConfirmation;
        private System.Windows.Forms.CheckBox optionTransMax;
        private System.Windows.Forms.CheckBox optionTranslucent;
        private System.Windows.Forms.TextBox optionEditorPath;
        private System.Windows.Forms.CheckBox optionReadOnly;
        private System.Windows.Forms.CheckBox optionNoRecycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn customCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn customName;
        private System.Windows.Forms.DataGridViewComboBoxColumn customOption;
    }
}

