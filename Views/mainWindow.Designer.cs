namespace tagify
{
    partial class mainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.uiButtonIcons = new System.Windows.Forms.ImageList(this.components);
            this.searchBar = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.notification = new System.Windows.Forms.NotifyIcon(this.components);
            this.searchingAnimation = new System.Windows.Forms.PictureBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.treeViewIcons = new System.Windows.Forms.ImageList(this.components);
            this.mainViewIcons = new System.Windows.Forms.ImageList(this.components);
            this.mainView = new System.Windows.Forms.ListView();
            this.mainColumn = new System.Windows.Forms.ColumnHeader();
            this.listViewItemOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openInExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileNameText = new System.Windows.Forms.Label();
            this.fileTypeLabel = new System.Windows.Forms.Label();
            this.fileTypeText = new System.Windows.Forms.Label();
            this.tagsLabel = new System.Windows.Forms.Label();
            this.editTagsButton = new System.Windows.Forms.Button();
            this.tagsBar = new System.Windows.Forms.TextBox();
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.deleteTagsButton = new System.Windows.Forms.Button();
            this.databaseConnector = new System.ComponentModel.BackgroundWorker();
            this.tagSearcher = new System.ComponentModel.BackgroundWorker();
            this.searchProgressBar = new System.Windows.Forms.ProgressBar();
            this.searchResults = new System.Windows.Forms.Panel();
            this.timeTakenLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.resultsFoundLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.filesScannedLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchResultsHeading = new System.Windows.Forms.Label();
            this.resultsTimer = new System.Windows.Forms.Timer(this.components);
            this.filePathLabel = new System.Windows.Forms.Label();
            this.filePathText = new System.Windows.Forms.TextBox();
            this.addressBar = new System.Windows.Forms.TextBox();
            this.homeButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.reloadButton = new System.Windows.Forms.Button();
            this.sortMainViewItems = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.searchingAnimation)).BeginInit();
            this.listViewItemOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.searchResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiButtonIcons
            // 
            this.uiButtonIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.uiButtonIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("uiButtonIcons.ImageStream")));
            this.uiButtonIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.uiButtonIcons.Images.SetKeyName(0, "back.png");
            this.uiButtonIcons.Images.SetKeyName(1, "delete.png");
            this.uiButtonIcons.Images.SetKeyName(2, "home.png");
            this.uiButtonIcons.Images.SetKeyName(3, "reload.png");
            this.uiButtonIcons.Images.SetKeyName(4, "search.png");
            this.uiButtonIcons.Images.SetKeyName(5, "cancel.png");
            this.uiButtonIcons.Images.SetKeyName(6, "sort_items.png");
            this.uiButtonIcons.Images.SetKeyName(7, "edit.png");
            // 
            // searchBar
            // 
            this.searchBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.searchBar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBar.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.searchBar.Location = new System.Drawing.Point(924, 21);
            this.searchBar.MinimumSize = new System.Drawing.Size(0, 40);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(600, 40);
            this.searchBar.TabIndex = 4;
            this.searchBar.Text = " Search your Tag";
            this.searchBar.Enter += new System.EventHandler(this.searchBar_Enter);
            this.searchBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBar_KeyDown);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.searchButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.ImageIndex = 4;
            this.searchButton.ImageList = this.uiButtonIcons;
            this.searchButton.Location = new System.Drawing.Point(1530, 21);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(40, 40);
            this.searchButton.TabIndex = 5;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // notification
            // 
            this.notification.Icon = ((System.Drawing.Icon)(resources.GetObject("notification.Icon")));
            this.notification.Text = "Tagify";
            this.notification.Visible = true;
            this.notification.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notification_MouseClick);
            // 
            // searchingAnimation
            // 
            this.searchingAnimation.BackColor = System.Drawing.Color.Transparent;
            this.searchingAnimation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchingAnimation.Image = global::tagify.Properties.Resources.searching;
            this.searchingAnimation.Location = new System.Drawing.Point(-31, 663);
            this.searchingAnimation.Name = "searchingAnimation";
            this.searchingAnimation.Size = new System.Drawing.Size(427, 397);
            this.searchingAnimation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchingAnimation.TabIndex = 16;
            this.searchingAnimation.TabStop = false;
            this.searchingAnimation.Visible = false;
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.SystemColors.Window;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.treeViewIcons;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 0;
            this.treeView.ShowPlusMinus = false;
            this.treeView.Size = new System.Drawing.Size(347, 692);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // treeViewIcons
            // 
            this.treeViewIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.treeViewIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("treeViewIcons.ImageStream")));
            this.treeViewIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.treeViewIcons.Images.SetKeyName(0, "folder.png");
            this.treeViewIcons.Images.SetKeyName(1, "hard-drive.png");
            // 
            // mainViewIcons
            // 
            this.mainViewIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.mainViewIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("mainViewIcons.ImageStream")));
            this.mainViewIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.mainViewIcons.Images.SetKeyName(0, "3ds.png");
            this.mainViewIcons.Images.SetKeyName(1, "aac.png");
            this.mainViewIcons.Images.SetKeyName(2, "avi.png");
            this.mainViewIcons.Images.SetKeyName(3, "bmp.png");
            this.mainViewIcons.Images.SetKeyName(4, "cad.png");
            this.mainViewIcons.Images.SetKeyName(5, "cdr.png");
            this.mainViewIcons.Images.SetKeyName(6, "css.png");
            this.mainViewIcons.Images.SetKeyName(7, "dat.png");
            this.mainViewIcons.Images.SetKeyName(8, "dll.png");
            this.mainViewIcons.Images.SetKeyName(9, "dmg.png");
            this.mainViewIcons.Images.SetKeyName(10, "doc.png");
            this.mainViewIcons.Images.SetKeyName(11, "eps.png");
            this.mainViewIcons.Images.SetKeyName(12, "file.png");
            this.mainViewIcons.Images.SetKeyName(13, "fla.png");
            this.mainViewIcons.Images.SetKeyName(14, "flv.png");
            this.mainViewIcons.Images.SetKeyName(15, "gif.png");
            this.mainViewIcons.Images.SetKeyName(16, "html.png");
            this.mainViewIcons.Images.SetKeyName(17, "indd.png");
            this.mainViewIcons.Images.SetKeyName(18, "iso.png");
            this.mainViewIcons.Images.SetKeyName(19, "jpg.png");
            this.mainViewIcons.Images.SetKeyName(20, "js.png");
            this.mainViewIcons.Images.SetKeyName(21, "midi.png");
            this.mainViewIcons.Images.SetKeyName(22, "mov.png");
            this.mainViewIcons.Images.SetKeyName(23, "mp3.png");
            this.mainViewIcons.Images.SetKeyName(24, "mp4.png");
            this.mainViewIcons.Images.SetKeyName(25, "mpg.png");
            this.mainViewIcons.Images.SetKeyName(26, "pdf.png");
            this.mainViewIcons.Images.SetKeyName(27, "php.png");
            this.mainViewIcons.Images.SetKeyName(28, "png.png");
            this.mainViewIcons.Images.SetKeyName(29, "ppt.png");
            this.mainViewIcons.Images.SetKeyName(30, "ps.png");
            this.mainViewIcons.Images.SetKeyName(31, "psd.png");
            this.mainViewIcons.Images.SetKeyName(32, "raw.png");
            this.mainViewIcons.Images.SetKeyName(33, "sql.png");
            this.mainViewIcons.Images.SetKeyName(34, "svg.png");
            this.mainViewIcons.Images.SetKeyName(35, "tif.png");
            this.mainViewIcons.Images.SetKeyName(36, "txt.png");
            this.mainViewIcons.Images.SetKeyName(37, "wmv.png");
            this.mainViewIcons.Images.SetKeyName(38, "xls.png");
            this.mainViewIcons.Images.SetKeyName(39, "xml.png");
            this.mainViewIcons.Images.SetKeyName(40, "zip.png");
            this.mainViewIcons.Images.SetKeyName(41, "folder.png");
            this.mainViewIcons.Images.SetKeyName(42, "hard-drive.png");
            // 
            // mainView
            // 
            this.mainView.BackColor = System.Drawing.SystemColors.Window;
            this.mainView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mainColumn});
            this.mainView.ContextMenuStrip = this.listViewItemOptions;
            this.mainView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainView.LargeImageList = this.mainViewIcons;
            this.mainView.Location = new System.Drawing.Point(0, 0);
            this.mainView.Name = "mainView";
            this.mainView.Size = new System.Drawing.Size(1205, 692);
            this.mainView.SmallImageList = this.mainViewIcons;
            this.mainView.TabIndex = 0;
            this.mainView.Tag = "1";
            this.mainView.UseCompatibleStateImageBehavior = false;
            this.mainView.SelectedIndexChanged += new System.EventHandler(this.mainView_SelectedIndexChanged);
            this.mainView.DoubleClick += new System.EventHandler(this.mainView_DoubleClick);
            this.mainView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainView_KeyDown);
            // 
            // listViewItemOptions
            // 
            this.listViewItemOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listViewItemOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openInExplorer});
            this.listViewItemOptions.Name = "listViewItemOptions";
            this.listViewItemOptions.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.listViewItemOptions.Size = new System.Drawing.Size(190, 52);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openInExplorer
            // 
            this.openInExplorer.Name = "openInExplorer";
            this.openInExplorer.Size = new System.Drawing.Size(189, 24);
            this.openInExplorer.Text = "Open In Explorer";
            this.openInExplorer.Click += new System.EventHandler(this.openInExplorer_Click);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileNameLabel.Location = new System.Drawing.Point(371, 801);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(126, 35);
            this.fileNameLabel.TabIndex = 15;
            this.fileNameLabel.Text = "File Name";
            // 
            // fileNameText
            // 
            this.fileNameText.AutoSize = true;
            this.fileNameText.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileNameText.Location = new System.Drawing.Point(503, 801);
            this.fileNameText.Name = "fileNameText";
            this.fileNameText.Size = new System.Drawing.Size(35, 35);
            this.fileNameText.TabIndex = 14;
            this.fileNameText.Text = "--";
            // 
            // fileTypeLabel
            // 
            this.fileTypeLabel.AutoSize = true;
            this.fileTypeLabel.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileTypeLabel.Location = new System.Drawing.Point(371, 898);
            this.fileTypeLabel.Name = "fileTypeLabel";
            this.fileTypeLabel.Size = new System.Drawing.Size(111, 35);
            this.fileTypeLabel.TabIndex = 13;
            this.fileTypeLabel.Text = "File Type";
            // 
            // fileTypeText
            // 
            this.fileTypeText.AutoSize = true;
            this.fileTypeText.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileTypeText.Location = new System.Drawing.Point(503, 898);
            this.fileTypeText.Name = "fileTypeText";
            this.fileTypeText.Size = new System.Drawing.Size(35, 35);
            this.fileTypeText.TabIndex = 12;
            this.fileTypeText.Text = "--";
            // 
            // tagsLabel
            // 
            this.tagsLabel.AutoSize = true;
            this.tagsLabel.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tagsLabel.Location = new System.Drawing.Point(938, 801);
            this.tagsLabel.Name = "tagsLabel";
            this.tagsLabel.Size = new System.Drawing.Size(64, 35);
            this.tagsLabel.TabIndex = 11;
            this.tagsLabel.Text = "Tags";
            // 
            // editTagsButton
            // 
            this.editTagsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editTagsButton.FlatAppearance.BorderSize = 0;
            this.editTagsButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.editTagsButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.editTagsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editTagsButton.ImageIndex = 7;
            this.editTagsButton.ImageList = this.uiButtonIcons;
            this.editTagsButton.Location = new System.Drawing.Point(996, 801);
            this.editTagsButton.Name = "editTagsButton";
            this.editTagsButton.Size = new System.Drawing.Size(40, 40);
            this.editTagsButton.TabIndex = 6;
            this.editTagsButton.UseVisualStyleBackColor = true;
            this.editTagsButton.Click += new System.EventHandler(this.editTagsButton_Click);
            // 
            // tagsBar
            // 
            this.tagsBar.BackColor = System.Drawing.SystemColors.Control;
            this.tagsBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tagsBar.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tagsBar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tagsBar.Location = new System.Drawing.Point(1055, 803);
            this.tagsBar.Name = "tagsBar";
            this.tagsBar.ReadOnly = true;
            this.tagsBar.Size = new System.Drawing.Size(515, 33);
            this.tagsBar.TabIndex = 10;
            this.tagsBar.TabStop = false;
            this.tagsBar.Text = "--";
            // 
            // mainContainer
            // 
            this.mainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainContainer.Location = new System.Drawing.Point(14, 76);
            this.mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.Controls.Add(this.treeView);
            this.mainContainer.Panel1MinSize = 300;
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.Controls.Add(this.mainView);
            this.mainContainer.Panel2MinSize = 600;
            this.mainContainer.Size = new System.Drawing.Size(1556, 692);
            this.mainContainer.SplitterDistance = 347;
            this.mainContainer.TabIndex = 9;
            // 
            // deleteTagsButton
            // 
            this.deleteTagsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteTagsButton.FlatAppearance.BorderSize = 0;
            this.deleteTagsButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.deleteTagsButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.deleteTagsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTagsButton.ImageIndex = 1;
            this.deleteTagsButton.ImageList = this.uiButtonIcons;
            this.deleteTagsButton.Location = new System.Drawing.Point(996, 847);
            this.deleteTagsButton.Name = "deleteTagsButton";
            this.deleteTagsButton.Size = new System.Drawing.Size(40, 40);
            this.deleteTagsButton.TabIndex = 7;
            this.deleteTagsButton.UseVisualStyleBackColor = true;
            this.deleteTagsButton.Click += new System.EventHandler(this.deleteTagsButton_Click);
            // 
            // databaseConnector
            // 
            this.databaseConnector.WorkerSupportsCancellation = true;
            this.databaseConnector.DoWork += new System.ComponentModel.DoWorkEventHandler(this.databaseConnector_DoWork);
            this.databaseConnector.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.databaseConnector_RunWorkerCompleted);
            // 
            // tagSearcher
            // 
            this.tagSearcher.WorkerReportsProgress = true;
            this.tagSearcher.WorkerSupportsCancellation = true;
            this.tagSearcher.DoWork += new System.ComponentModel.DoWorkEventHandler(this.tagSearcher_DoWork);
            this.tagSearcher.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.tagSearcher_ProgressChanged);
            this.tagSearcher.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.tagSearcher_RunWorkerCompleted);
            // 
            // searchProgressBar
            // 
            this.searchProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchProgressBar.Location = new System.Drawing.Point(924, 21);
            this.searchProgressBar.Name = "searchProgressBar";
            this.searchProgressBar.Size = new System.Drawing.Size(600, 40);
            this.searchProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.searchProgressBar.TabIndex = 18;
            this.searchProgressBar.Value = 50;
            this.searchProgressBar.Visible = false;
            // 
            // searchResults
            // 
            this.searchResults.Controls.Add(this.timeTakenLabel);
            this.searchResults.Controls.Add(this.label6);
            this.searchResults.Controls.Add(this.resultsFoundLabel);
            this.searchResults.Controls.Add(this.label4);
            this.searchResults.Controls.Add(this.filesScannedLabel);
            this.searchResults.Controls.Add(this.label2);
            this.searchResults.Controls.Add(this.searchResultsHeading);
            this.searchResults.Location = new System.Drawing.Point(14, 780);
            this.searchResults.Name = "searchResults";
            this.searchResults.Size = new System.Drawing.Size(357, 161);
            this.searchResults.TabIndex = 19;
            this.searchResults.Visible = false;
            // 
            // timeTakenLabel
            // 
            this.timeTakenLabel.AutoSize = true;
            this.timeTakenLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeTakenLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeTakenLabel.Location = new System.Drawing.Point(101, 125);
            this.timeTakenLabel.Margin = new System.Windows.Forms.Padding(0);
            this.timeTakenLabel.Name = "timeTakenLabel";
            this.timeTakenLabel.Size = new System.Drawing.Size(264, 28);
            this.timeTakenLabel.TabIndex = 6;
            this.timeTakenLabel.Text = "999999999999999999999";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Time Taken";
            // 
            // resultsFoundLabel
            // 
            this.resultsFoundLabel.AutoSize = true;
            this.resultsFoundLabel.BackColor = System.Drawing.Color.Transparent;
            this.resultsFoundLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultsFoundLabel.Location = new System.Drawing.Point(101, 85);
            this.resultsFoundLabel.Margin = new System.Windows.Forms.Padding(0);
            this.resultsFoundLabel.Name = "resultsFoundLabel";
            this.resultsFoundLabel.Size = new System.Drawing.Size(264, 28);
            this.resultsFoundLabel.TabIndex = 4;
            this.resultsFoundLabel.Text = "999999999999999999999";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Results Found";
            // 
            // filesScannedLabel
            // 
            this.filesScannedLabel.AutoSize = true;
            this.filesScannedLabel.BackColor = System.Drawing.Color.Transparent;
            this.filesScannedLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.filesScannedLabel.Location = new System.Drawing.Point(101, 45);
            this.filesScannedLabel.Margin = new System.Windows.Forms.Padding(0);
            this.filesScannedLabel.Name = "filesScannedLabel";
            this.filesScannedLabel.Size = new System.Drawing.Size(276, 28);
            this.filesScannedLabel.TabIndex = 2;
            this.filesScannedLabel.Text = "9999999999999999999999\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Files Scanned";
            // 
            // searchResultsHeading
            // 
            this.searchResultsHeading.AutoSize = true;
            this.searchResultsHeading.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchResultsHeading.Location = new System.Drawing.Point(0, 0);
            this.searchResultsHeading.Name = "searchResultsHeading";
            this.searchResultsHeading.Size = new System.Drawing.Size(161, 23);
            this.searchResultsHeading.TabIndex = 0;
            this.searchResultsHeading.Text = "Last Search Results";
            // 
            // resultsTimer
            // 
            this.resultsTimer.Interval = 10000;
            this.resultsTimer.Tick += new System.EventHandler(this.resultsTimer_Tick);
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filePathLabel.Location = new System.Drawing.Point(938, 898);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(107, 35);
            this.filePathLabel.TabIndex = 21;
            this.filePathLabel.Text = "File Path";
            // 
            // filePathText
            // 
            this.filePathText.BackColor = System.Drawing.SystemColors.Control;
            this.filePathText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filePathText.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filePathText.Location = new System.Drawing.Point(1055, 900);
            this.filePathText.Name = "filePathText";
            this.filePathText.ReadOnly = true;
            this.filePathText.Size = new System.Drawing.Size(515, 33);
            this.filePathText.TabIndex = 23;
            this.filePathText.Text = "--";
            // 
            // addressBar
            // 
            this.addressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressBar.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressBar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.addressBar.Location = new System.Drawing.Point(104, 21);
            this.addressBar.MinimumSize = new System.Drawing.Size(0, 40);
            this.addressBar.Name = "addressBar";
            this.addressBar.Size = new System.Drawing.Size(706, 40);
            this.addressBar.TabIndex = 2;
            this.addressBar.Text = " home";
            this.addressBar.Enter += new System.EventHandler(this.addressBar_Enter);
            this.addressBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressBar_KeyDown);
            this.addressBar.Leave += new System.EventHandler(this.addressBar_Leave);
            // 
            // homeButton
            // 
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.homeButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.ImageIndex = 2;
            this.homeButton.ImageList = this.uiButtonIcons;
            this.homeButton.Location = new System.Drawing.Point(12, 21);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(40, 40);
            this.homeButton.TabIndex = 0;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ImageIndex = 0;
            this.backButton.ImageList = this.uiButtonIcons;
            this.backButton.Location = new System.Drawing.Point(58, 21);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(40, 40);
            this.backButton.TabIndex = 1;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // reloadButton
            // 
            this.reloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reloadButton.FlatAppearance.BorderSize = 0;
            this.reloadButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.reloadButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.reloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reloadButton.ImageIndex = 3;
            this.reloadButton.ImageList = this.uiButtonIcons;
            this.reloadButton.Location = new System.Drawing.Point(816, 21);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(40, 40);
            this.reloadButton.TabIndex = 17;
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // sortMainViewItems
            // 
            this.sortMainViewItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sortMainViewItems.FlatAppearance.BorderSize = 0;
            this.sortMainViewItems.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sortMainViewItems.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.sortMainViewItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortMainViewItems.ImageIndex = 6;
            this.sortMainViewItems.ImageList = this.uiButtonIcons;
            this.sortMainViewItems.Location = new System.Drawing.Point(862, 21);
            this.sortMainViewItems.Name = "sortMainViewItems";
            this.sortMainViewItems.Size = new System.Drawing.Size(40, 40);
            this.sortMainViewItems.TabIndex = 20;
            this.sortMainViewItems.UseVisualStyleBackColor = true;
            this.sortMainViewItems.Click += new System.EventHandler(this.sortMainViewItems_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1582, 953);
            this.Controls.Add(this.filePathText);
            this.Controls.Add(this.filePathLabel);
            this.Controls.Add(this.sortMainViewItems);
            this.Controls.Add(this.searchResults);
            this.Controls.Add(this.searchProgressBar);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.deleteTagsButton);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.tagsBar);
            this.Controls.Add(this.editTagsButton);
            this.Controls.Add(this.tagsLabel);
            this.Controls.Add(this.fileTypeText);
            this.Controls.Add(this.fileTypeLabel);
            this.Controls.Add(this.fileNameText);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.addressBar);
            this.Controls.Add(this.searchingAnimation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tagify";
            ((System.ComponentModel.ISupportInitialize)(this.searchingAnimation)).EndInit();
            this.listViewItemOptions.ResumeLayout(false);
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.searchResults.ResumeLayout(false);
            this.searchResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal Button goButton;
        protected internal TextBox searchBar;
        protected internal ImageList uiButtonIcons;
        protected internal Button searchButton;
        protected internal NotifyIcon notification;
        protected internal PictureBox searchingAnimation;
        protected internal TreeView treeView;
        protected internal ListView mainView;
        protected internal Label fileNameLabel;
        protected internal Label fileNameText;
        protected internal Label fileTypeLabel;
        protected internal Label fileTypeText;
        protected internal Label tagsLabel;
        protected internal Button editTagsButton;
        protected internal TextBox tagsBar;
        protected internal ImageList mainViewIcons;
        protected internal ImageList treeViewIcons;
        protected internal SplitContainer mainContainer;
        protected internal ContextMenuStrip listViewItemOptions;
        protected internal ToolStripMenuItem openInExplorer;
        protected internal Button deleteTagsButton;
        protected internal System.ComponentModel.BackgroundWorker databaseConnector;
        protected internal System.ComponentModel.BackgroundWorker tagSearcher;
        protected internal ProgressBar searchProgressBar;
        protected internal Label label2;
        protected internal Label searchResultsHeading;
        protected internal Label filesScannedLabel;
        protected internal Label timeTakenLabel;
        protected internal Label label6;
        protected internal Label resultsFoundLabel;
        protected internal Label label4;
        protected internal Panel searchResults;
        protected internal System.Windows.Forms.Timer resultsTimer;
        private ColumnHeader mainColumn;
        protected internal Label filePathLabel;
        protected internal TextBox filePathText;
        private ToolStripMenuItem openToolStripMenuItem;
        protected internal TextBox addressBar;
        protected internal Button homeButton;
        protected internal Button backButton;
        protected internal Button reloadButton;
        protected internal Button sortMainViewItems;
    }
}