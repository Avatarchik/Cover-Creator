namespace Cover_Maker
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.SplitContainer splitContainer;
            System.Windows.Forms.Button addFaceBtn;
            System.Windows.Forms.Button deleteFaceBtn;
            System.Windows.Forms.ColumnHeader fileNameHeader;
            System.Windows.Forms.ColumnHeader folderParrentHeader;
            System.Windows.Forms.ColumnHeader dimensionHeader;
            System.Windows.Forms.ColumnHeader extensionHeader;
            System.Windows.Forms.ColumnHeader faceHeader;
            System.Windows.Forms.TabControl tabControl;
            System.Windows.Forms.GroupBox previewGroupBox;
            System.Windows.Forms.GroupBox generalGroup;
            System.Windows.Forms.Label heightLabel;
            System.Windows.Forms.Label widthLabel;
            this.originalImageBox = new Emgu.CV.UI.ImageBox();
            this.faceListView = new System.Windows.Forms.ListView();
            this.faceImageList = new System.Windows.Forms.ImageList(this.components);
            this.findAllFacesBtn = new System.Windows.Forms.Button();
            this.findFaceBtn = new System.Windows.Forms.Button();
            this.faceImageBox = new Emgu.CV.UI.ImageBox();
            this.imageManagerTab = new System.Windows.Forms.TabPage();
            this.inputFileListView = new System.Windows.Forms.ListView();
            this.fileListMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coverCreatorTab = new System.Windows.Forms.TabPage();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.croppeFaceListView = new System.Windows.Forms.ListView();
            this.croppedFaceImageList = new System.Windows.Forms.ImageList(this.components);
            this.selecedFaceLabel = new System.Windows.Forms.Label();
            this.numberOfSelecedFacesEdit = new System.Windows.Forms.TextBox();
            this.createCoverBtn = new System.Windows.Forms.Button();
            this.fbCoverBtn = new System.Windows.Forms.Button();
            this.heightEdit = new System.Windows.Forms.NumericUpDown();
            this.widthEdit = new System.Windows.Forms.NumericUpDown();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.labelPostionXY = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.openImageFilesDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.detectFaceBackgroundWork = new System.ComponentModel.BackgroundWorker();
            splitContainer = new System.Windows.Forms.SplitContainer();
            addFaceBtn = new System.Windows.Forms.Button();
            deleteFaceBtn = new System.Windows.Forms.Button();
            fileNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            folderParrentHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            dimensionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            extensionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            faceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            tabControl = new System.Windows.Forms.TabControl();
            previewGroupBox = new System.Windows.Forms.GroupBox();
            generalGroup = new System.Windows.Forms.GroupBox();
            heightLabel = new System.Windows.Forms.Label();
            widthLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(splitContainer)).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faceImageBox)).BeginInit();
            tabControl.SuspendLayout();
            this.imageManagerTab.SuspendLayout();
            this.fileListMenuStrip.SuspendLayout();
            this.coverCreatorTab.SuspendLayout();
            previewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            generalGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthEdit)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            splitContainer.IsSplitterFixed = true;
            splitContainer.Location = new System.Drawing.Point(5, 188);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(this.originalImageBox);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(addFaceBtn);
            splitContainer.Panel2.Controls.Add(deleteFaceBtn);
            splitContainer.Panel2.Controls.Add(this.faceListView);
            splitContainer.Panel2.Controls.Add(this.findAllFacesBtn);
            splitContainer.Panel2.Controls.Add(this.findFaceBtn);
            splitContainer.Panel2.Controls.Add(this.faceImageBox);
            splitContainer.Size = new System.Drawing.Size(1051, 443);
            splitContainer.SplitterDistance = 549;
            splitContainer.TabIndex = 1;
            // 
            // originalImageBox
            // 
            this.originalImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.originalImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalImageBox.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.originalImageBox.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.originalImageBox.Location = new System.Drawing.Point(0, 0);
            this.originalImageBox.Name = "originalImageBox";
            this.originalImageBox.Size = new System.Drawing.Size(549, 443);
            this.originalImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.originalImageBox.TabIndex = 2;
            this.originalImageBox.TabStop = false;
            this.originalImageBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseDown);
            this.originalImageBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseMove);
            this.originalImageBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseUp);
            // 
            // addFaceBtn
            // 
            addFaceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            addFaceBtn.Location = new System.Drawing.Point(401, 45);
            addFaceBtn.Name = "addFaceBtn";
            addFaceBtn.Size = new System.Drawing.Size(98, 24);
            addFaceBtn.TabIndex = 8;
            addFaceBtn.Text = "Add";
            addFaceBtn.UseVisualStyleBackColor = true;
            addFaceBtn.Click += new System.EventHandler(this.addFaceBtn_Click);
            // 
            // deleteFaceBtn
            // 
            deleteFaceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            deleteFaceBtn.Location = new System.Drawing.Point(401, 0);
            deleteFaceBtn.Name = "deleteFaceBtn";
            deleteFaceBtn.Size = new System.Drawing.Size(98, 24);
            deleteFaceBtn.TabIndex = 7;
            deleteFaceBtn.Text = "Delete Selected";
            deleteFaceBtn.UseVisualStyleBackColor = true;
            deleteFaceBtn.Click += new System.EventHandler(this.deleteFaceBtn_Click);
            // 
            // faceListView
            // 
            this.faceListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.faceListView.CheckBoxes = true;
            this.faceListView.LargeImageList = this.faceImageList;
            this.faceListView.Location = new System.Drawing.Point(3, 0);
            this.faceListView.Name = "faceListView";
            this.faceListView.Size = new System.Drawing.Size(392, 212);
            this.faceListView.SmallImageList = this.faceImageList;
            this.faceListView.TabIndex = 6;
            this.faceListView.UseCompatibleStateImageBehavior = false;
            this.faceListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.faceListView_ItemChecked);
            this.faceListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.faceListView_ItemSelectionChanged);
            this.faceListView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.faceListView_KeyPress);
            // 
            // faceImageList
            // 
            this.faceImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.faceImageList.ImageSize = new System.Drawing.Size(64, 64);
            this.faceImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // findAllFacesBtn
            // 
            this.findAllFacesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.findAllFacesBtn.Location = new System.Drawing.Point(381, 228);
            this.findAllFacesBtn.Name = "findAllFacesBtn";
            this.findAllFacesBtn.Size = new System.Drawing.Size(112, 23);
            this.findAllFacesBtn.TabIndex = 5;
            this.findAllFacesBtn.Text = "Find all faces";
            this.findAllFacesBtn.UseVisualStyleBackColor = true;
            this.findAllFacesBtn.Click += new System.EventHandler(this.findAllFacesBtn_Click);
            // 
            // findFaceBtn
            // 
            this.findFaceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.findFaceBtn.Location = new System.Drawing.Point(176, 228);
            this.findFaceBtn.Name = "findFaceBtn";
            this.findFaceBtn.Size = new System.Drawing.Size(75, 23);
            this.findFaceBtn.TabIndex = 4;
            this.findFaceBtn.Text = "Find face";
            this.findFaceBtn.UseVisualStyleBackColor = true;
            this.findFaceBtn.Click += new System.EventHandler(this.findFaceBtn_Click);
            // 
            // faceImageBox
            // 
            this.faceImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.faceImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.faceImageBox.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.faceImageBox.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.faceImageBox.Location = new System.Drawing.Point(2, 218);
            this.faceImageBox.Name = "faceImageBox";
            this.faceImageBox.Size = new System.Drawing.Size(162, 219);
            this.faceImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.faceImageBox.TabIndex = 2;
            this.faceImageBox.TabStop = false;
            // 
            // fileNameHeader
            // 
            fileNameHeader.Text = "Name";
            fileNameHeader.Width = 454;
            // 
            // folderParrentHeader
            // 
            folderParrentHeader.Text = "Folder";
            folderParrentHeader.Width = 192;
            // 
            // dimensionHeader
            // 
            dimensionHeader.Text = "Dimension";
            dimensionHeader.Width = 139;
            // 
            // extensionHeader
            // 
            extensionHeader.Text = "Extension";
            extensionHeader.Width = 93;
            // 
            // faceHeader
            // 
            faceHeader.Text = "Face details";
            faceHeader.Width = 254;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(this.imageManagerTab);
            tabControl.Controls.Add(this.coverCreatorTab);
            tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl.Location = new System.Drawing.Point(0, 0);
            tabControl.Margin = new System.Windows.Forms.Padding(2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new System.Drawing.Size(1068, 675);
            tabControl.TabIndex = 2;
            tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // imageManagerTab
            // 
            this.imageManagerTab.Controls.Add(this.inputFileListView);
            this.imageManagerTab.Controls.Add(splitContainer);
            this.imageManagerTab.Location = new System.Drawing.Point(4, 22);
            this.imageManagerTab.Margin = new System.Windows.Forms.Padding(2);
            this.imageManagerTab.Name = "imageManagerTab";
            this.imageManagerTab.Padding = new System.Windows.Forms.Padding(2);
            this.imageManagerTab.Size = new System.Drawing.Size(1060, 649);
            this.imageManagerTab.TabIndex = 0;
            this.imageManagerTab.Text = "Images";
            this.imageManagerTab.UseVisualStyleBackColor = true;
            // 
            // inputFileListView
            // 
            this.inputFileListView.AllowDrop = true;
            this.inputFileListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputFileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            fileNameHeader,
            folderParrentHeader,
            dimensionHeader,
            extensionHeader,
            faceHeader});
            this.inputFileListView.ContextMenuStrip = this.fileListMenuStrip;
            this.inputFileListView.FullRowSelect = true;
            this.inputFileListView.HideSelection = false;
            this.inputFileListView.Location = new System.Drawing.Point(3, 6);
            this.inputFileListView.MultiSelect = false;
            this.inputFileListView.Name = "inputFileListView";
            this.inputFileListView.Size = new System.Drawing.Size(1054, 176);
            this.inputFileListView.TabIndex = 0;
            this.inputFileListView.UseCompatibleStateImageBehavior = false;
            this.inputFileListView.View = System.Windows.Forms.View.Details;
            this.inputFileListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.imageFileListView_ItemSelectionChanged);
            this.inputFileListView.DragDrop += new System.Windows.Forms.DragEventHandler(this.imageFileListView_DragDrop);
            this.inputFileListView.DragEnter += new System.Windows.Forms.DragEventHandler(this.imageFileListView_DragEnter);
            // 
            // fileListMenuStrip
            // 
            this.fileListMenuStrip.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.fileListMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFilesToolStripMenuItem,
            this.openFolderToolStripMenuItem,
            this.removeAllToolStripMenuItem});
            this.fileListMenuStrip.Name = "fileListMenuStrip";
            this.fileListMenuStrip.Size = new System.Drawing.Size(138, 70);
            // 
            // openFilesToolStripMenuItem
            // 
            this.openFilesToolStripMenuItem.Name = "openFilesToolStripMenuItem";
            this.openFilesToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.openFilesToolStripMenuItem.Text = "Open files";
            this.openFilesToolStripMenuItem.Click += new System.EventHandler(this.openFilesToolStripMenuItem_Click);
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.openFolderToolStripMenuItem.Text = "Open folder";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // removeAllToolStripMenuItem
            // 
            this.removeAllToolStripMenuItem.Name = "removeAllToolStripMenuItem";
            this.removeAllToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.removeAllToolStripMenuItem.Text = "Remove all";
            this.removeAllToolStripMenuItem.Click += new System.EventHandler(this.removeAllToolStripMenuItem_Click);
            // 
            // coverCreatorTab
            // 
            this.coverCreatorTab.Controls.Add(previewGroupBox);
            this.coverCreatorTab.Controls.Add(generalGroup);
            this.coverCreatorTab.Location = new System.Drawing.Point(4, 22);
            this.coverCreatorTab.Margin = new System.Windows.Forms.Padding(2);
            this.coverCreatorTab.Name = "coverCreatorTab";
            this.coverCreatorTab.Padding = new System.Windows.Forms.Padding(2);
            this.coverCreatorTab.Size = new System.Drawing.Size(1060, 649);
            this.coverCreatorTab.TabIndex = 1;
            this.coverCreatorTab.Text = "Create Cover";
            this.coverCreatorTab.UseVisualStyleBackColor = true;
            // 
            // previewGroupBox
            // 
            previewGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            previewGroupBox.Controls.Add(this.imageBox1);
            previewGroupBox.Controls.Add(this.croppeFaceListView);
            previewGroupBox.Location = new System.Drawing.Point(258, 5);
            previewGroupBox.Name = "previewGroupBox";
            previewGroupBox.Size = new System.Drawing.Size(794, 620);
            previewGroupBox.TabIndex = 2;
            previewGroupBox.TabStop = false;
            previewGroupBox.Text = "Preview";
            // 
            // imageBox1
            // 
            this.imageBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBox1.Location = new System.Drawing.Point(6, 299);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(782, 315);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // croppeFaceListView
            // 
            this.croppeFaceListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.croppeFaceListView.LargeImageList = this.croppedFaceImageList;
            this.croppeFaceListView.Location = new System.Drawing.Point(6, 19);
            this.croppeFaceListView.Name = "croppeFaceListView";
            this.croppeFaceListView.Size = new System.Drawing.Size(782, 274);
            this.croppeFaceListView.SmallImageList = this.croppedFaceImageList;
            this.croppeFaceListView.TabIndex = 0;
            this.croppeFaceListView.UseCompatibleStateImageBehavior = false;
            // 
            // croppedFaceImageList
            // 
            this.croppedFaceImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.croppedFaceImageList.ImageSize = new System.Drawing.Size(32, 128);
            this.croppedFaceImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // generalGroup
            // 
            generalGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            generalGroup.Controls.Add(this.selecedFaceLabel);
            generalGroup.Controls.Add(this.numberOfSelecedFacesEdit);
            generalGroup.Controls.Add(this.createCoverBtn);
            generalGroup.Controls.Add(this.fbCoverBtn);
            generalGroup.Controls.Add(this.heightEdit);
            generalGroup.Controls.Add(this.widthEdit);
            generalGroup.Controls.Add(heightLabel);
            generalGroup.Controls.Add(widthLabel);
            generalGroup.Location = new System.Drawing.Point(6, 5);
            generalGroup.Margin = new System.Windows.Forms.Padding(2);
            generalGroup.Name = "generalGroup";
            generalGroup.Padding = new System.Windows.Forms.Padding(2);
            generalGroup.Size = new System.Drawing.Size(247, 621);
            generalGroup.TabIndex = 1;
            generalGroup.TabStop = false;
            generalGroup.Text = "General setting";
            // 
            // selecedFaceLabel
            // 
            this.selecedFaceLabel.AutoSize = true;
            this.selecedFaceLabel.Location = new System.Drawing.Point(5, 58);
            this.selecedFaceLabel.Name = "selecedFaceLabel";
            this.selecedFaceLabel.Size = new System.Drawing.Size(78, 13);
            this.selecedFaceLabel.TabIndex = 9;
            this.selecedFaceLabel.Text = "Selected faces";
            // 
            // numberOfSelecedFacesEdit
            // 
            this.numberOfSelecedFacesEdit.Location = new System.Drawing.Point(127, 55);
            this.numberOfSelecedFacesEdit.Name = "numberOfSelecedFacesEdit";
            this.numberOfSelecedFacesEdit.ReadOnly = true;
            this.numberOfSelecedFacesEdit.Size = new System.Drawing.Size(100, 20);
            this.numberOfSelecedFacesEdit.TabIndex = 8;
            // 
            // createCoverBtn
            // 
            this.createCoverBtn.Location = new System.Drawing.Point(7, 126);
            this.createCoverBtn.Margin = new System.Windows.Forms.Padding(2);
            this.createCoverBtn.Name = "createCoverBtn";
            this.createCoverBtn.Size = new System.Drawing.Size(68, 25);
            this.createCoverBtn.TabIndex = 7;
            this.createCoverBtn.Text = "Create";
            this.createCoverBtn.UseVisualStyleBackColor = true;
            this.createCoverBtn.Click += new System.EventHandler(this.createCover_Click);
            // 
            // fbCoverBtn
            // 
            this.fbCoverBtn.Location = new System.Drawing.Point(7, 102);
            this.fbCoverBtn.Margin = new System.Windows.Forms.Padding(2);
            this.fbCoverBtn.Name = "fbCoverBtn";
            this.fbCoverBtn.Size = new System.Drawing.Size(130, 19);
            this.fbCoverBtn.TabIndex = 6;
            this.fbCoverBtn.Text = "Facebook Cover";
            this.fbCoverBtn.UseVisualStyleBackColor = true;
            this.fbCoverBtn.Click += new System.EventHandler(this.fbCoverBtn_Click);
            // 
            // heightEdit
            // 
            this.heightEdit.Location = new System.Drawing.Point(162, 21);
            this.heightEdit.Margin = new System.Windows.Forms.Padding(2);
            this.heightEdit.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.heightEdit.Name = "heightEdit";
            this.heightEdit.Size = new System.Drawing.Size(67, 20);
            this.heightEdit.TabIndex = 5;
            // 
            // widthEdit
            // 
            this.widthEdit.Location = new System.Drawing.Point(44, 21);
            this.widthEdit.Margin = new System.Windows.Forms.Padding(2);
            this.widthEdit.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.widthEdit.Name = "widthEdit";
            this.widthEdit.Size = new System.Drawing.Size(67, 20);
            this.widthEdit.TabIndex = 4;
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new System.Drawing.Point(124, 21);
            heightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new System.Drawing.Size(35, 13);
            heightLabel.TabIndex = 3;
            heightLabel.Text = "Heigh";
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Location = new System.Drawing.Point(4, 21);
            widthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new System.Drawing.Size(35, 13);
            widthLabel.TabIndex = 1;
            widthLabel.Text = "Width";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelPostionXY,
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 650);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1068, 25);
            this.statusStrip.TabIndex = 6;
            this.statusStrip.Text = "statusStrip1";
            // 
            // labelPostionXY
            // 
            this.labelPostionXY.AutoSize = false;
            this.labelPostionXY.Name = "labelPostionXY";
            this.labelPostionXY.Size = new System.Drawing.Size(200, 20);
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 20);
            // 
            // openImageFilesDialog
            // 
            this.openImageFilesDialog.Filter = "Image Files (*.bmp, *.jpg)|*.bmp;*.jpg|All files (*.*)|*.*";
            this.openImageFilesDialog.FilterIndex = 0;
            this.openImageFilesDialog.Multiselect = true;
            this.openImageFilesDialog.Title = "Choose image file(s)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1068, 675);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(tabControl);
            this.Name = "MainForm";
            this.Text = "Cover Maker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(splitContainer)).EndInit();
            splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.originalImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faceImageBox)).EndInit();
            tabControl.ResumeLayout(false);
            this.imageManagerTab.ResumeLayout(false);
            this.fileListMenuStrip.ResumeLayout(false);
            this.coverCreatorTab.ResumeLayout(false);
            previewGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            generalGroup.ResumeLayout(false);
            generalGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthEdit)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView inputFileListView;
        private Emgu.CV.UI.ImageBox originalImageBox;
        private Emgu.CV.UI.ImageBox faceImageBox;
        private System.Windows.Forms.Button findAllFacesBtn;
        private System.Windows.Forms.Button findFaceBtn;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel labelPostionXY;
        private System.Windows.Forms.ContextMenuStrip fileListMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAllToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openImageFilesDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.TabPage imageManagerTab;
        private System.Windows.Forms.TabPage coverCreatorTab;
        private System.Windows.Forms.Button fbCoverBtn;
        private System.Windows.Forms.NumericUpDown heightEdit;
        private System.Windows.Forms.NumericUpDown widthEdit;
        private System.Windows.Forms.ListView faceListView;
        private System.Windows.Forms.ImageList faceImageList;
        private System.Windows.Forms.ListView croppeFaceListView;
        private System.Windows.Forms.ImageList croppedFaceImageList;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Label selecedFaceLabel;
        private System.Windows.Forms.TextBox numberOfSelecedFacesEdit;
        private System.Windows.Forms.Button createCoverBtn;
        private System.ComponentModel.BackgroundWorker detectFaceBackgroundWork;
    }
}

