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
            System.Windows.Forms.ColumnHeader fileNameHeader;
            System.Windows.Forms.ColumnHeader folderParrentHeader;
            System.Windows.Forms.ColumnHeader dimensionHeader;
            System.Windows.Forms.ColumnHeader extensionHeader;
            System.Windows.Forms.ColumnHeader roiHeader;
            System.Windows.Forms.TabControl tabControl;
            System.Windows.Forms.GroupBox generalGroup;
            System.Windows.Forms.Label heightLabel;
            System.Windows.Forms.Label widthLabel;
            this.originalImageBox = new Emgu.CV.UI.ImageBox();
            this.findAllFacesBtn = new System.Windows.Forms.Button();
            this.findFaceBtn = new System.Windows.Forms.Button();
            this.faceImageBox = new Emgu.CV.UI.ImageBox();
            this.imageManagerTab = new System.Windows.Forms.TabPage();
            this.imageFileListView = new System.Windows.Forms.ListView();
            this.fileListMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coverCreatorTab = new System.Windows.Forms.TabPage();
            this.coverPreview = new Emgu.CV.UI.ImageBox();
            this.createCover = new System.Windows.Forms.Button();
            this.fbCoverBtn = new System.Windows.Forms.Button();
            this.heightEdit = new System.Windows.Forms.NumericUpDown();
            this.widthEdit = new System.Windows.Forms.NumericUpDown();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.labelPostionXY = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.openImageFilesDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            splitContainer = new System.Windows.Forms.SplitContainer();
            fileNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            folderParrentHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            dimensionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            extensionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            roiHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            tabControl = new System.Windows.Forms.TabControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.coverPreview)).BeginInit();
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
            // findAllFacesBtn
            // 
            this.findAllFacesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            // roiHeader
            // 
            roiHeader.Text = "ROI";
            roiHeader.Width = 254;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(this.imageManagerTab);
            tabControl.Controls.Add(this.coverCreatorTab);
            tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl.Location = new System.Drawing.Point(0, 0);
            tabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new System.Drawing.Size(1068, 675);
            tabControl.TabIndex = 2;
            // 
            // imageManagerTab
            // 
            this.imageManagerTab.Controls.Add(this.imageFileListView);
            this.imageManagerTab.Controls.Add(splitContainer);
            this.imageManagerTab.Location = new System.Drawing.Point(4, 22);
            this.imageManagerTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imageManagerTab.Name = "imageManagerTab";
            this.imageManagerTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imageManagerTab.Size = new System.Drawing.Size(1060, 649);
            this.imageManagerTab.TabIndex = 0;
            this.imageManagerTab.Text = "Images";
            this.imageManagerTab.UseVisualStyleBackColor = true;
            // 
            // imageFileListView
            // 
            this.imageFileListView.AllowDrop = true;
            this.imageFileListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageFileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            fileNameHeader,
            folderParrentHeader,
            dimensionHeader,
            extensionHeader,
            roiHeader});
            this.imageFileListView.ContextMenuStrip = this.fileListMenuStrip;
            this.imageFileListView.FullRowSelect = true;
            this.imageFileListView.HideSelection = false;
            this.imageFileListView.Location = new System.Drawing.Point(3, 6);
            this.imageFileListView.MultiSelect = false;
            this.imageFileListView.Name = "imageFileListView";
            this.imageFileListView.Size = new System.Drawing.Size(1054, 176);
            this.imageFileListView.TabIndex = 0;
            this.imageFileListView.UseCompatibleStateImageBehavior = false;
            this.imageFileListView.View = System.Windows.Forms.View.Details;
            this.imageFileListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.imageFileListView_ItemSelectionChanged);
            this.imageFileListView.DragDrop += new System.Windows.Forms.DragEventHandler(this.imageFileListView_DragDrop);
            this.imageFileListView.DragEnter += new System.Windows.Forms.DragEventHandler(this.imageFileListView_DragEnter);
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
            this.coverCreatorTab.Controls.Add(this.coverPreview);
            this.coverCreatorTab.Controls.Add(generalGroup);
            this.coverCreatorTab.Location = new System.Drawing.Point(4, 22);
            this.coverCreatorTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.coverCreatorTab.Name = "coverCreatorTab";
            this.coverCreatorTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.coverCreatorTab.Size = new System.Drawing.Size(906, 510);
            this.coverCreatorTab.TabIndex = 1;
            this.coverCreatorTab.Text = "Create Cover";
            this.coverCreatorTab.UseVisualStyleBackColor = true;
            // 
            // coverPreview
            // 
            this.coverPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coverPreview.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.PanAndZoom;
            this.coverPreview.Location = new System.Drawing.Point(257, 12);
            this.coverPreview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.coverPreview.Name = "coverPreview";
            this.coverPreview.Size = new System.Drawing.Size(647, 481);
            this.coverPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coverPreview.TabIndex = 2;
            this.coverPreview.TabStop = false;
            // 
            // generalGroup
            // 
            generalGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            generalGroup.Controls.Add(this.createCover);
            generalGroup.Controls.Add(this.fbCoverBtn);
            generalGroup.Controls.Add(this.heightEdit);
            generalGroup.Controls.Add(this.widthEdit);
            generalGroup.Controls.Add(heightLabel);
            generalGroup.Controls.Add(widthLabel);
            generalGroup.Location = new System.Drawing.Point(6, 5);
            generalGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            generalGroup.Name = "generalGroup";
            generalGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            generalGroup.Size = new System.Drawing.Size(247, 488);
            generalGroup.TabIndex = 1;
            generalGroup.TabStop = false;
            generalGroup.Text = "General setting";
            // 
            // createCover
            // 
            this.createCover.Location = new System.Drawing.Point(7, 75);
            this.createCover.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createCover.Name = "createCover";
            this.createCover.Size = new System.Drawing.Size(68, 25);
            this.createCover.TabIndex = 7;
            this.createCover.Text = "Create";
            this.createCover.UseVisualStyleBackColor = true;
            this.createCover.Click += new System.EventHandler(this.createCover_Click);
            // 
            // fbCoverBtn
            // 
            this.fbCoverBtn.Location = new System.Drawing.Point(7, 51);
            this.fbCoverBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.heightEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.widthEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
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
            this.Text = "Main Form";
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
            ((System.ComponentModel.ISupportInitialize)(this.coverPreview)).EndInit();
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

        private System.Windows.Forms.ListView imageFileListView;
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
        private Emgu.CV.UI.ImageBox coverPreview;
        private System.Windows.Forms.Button createCover;
        private System.Windows.Forms.ImageList imageList1;
    }
}

