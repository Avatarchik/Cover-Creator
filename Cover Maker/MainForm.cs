using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System.IO;
using System.Diagnostics;

namespace Cover_Maker
{
    public partial class MainForm : Form
    {
        private HashSet<string> filepathSet = new HashSet<string>();
        private Boolean bFaceCheckedChangedBySystem = false;
        private int nFaces = 0;

        public MainForm()
        {
            InitializeComponent();
            if (Properties.Settings.Default.filepaths == null)
                Properties.Settings.Default.filepaths = new System.Collections.Specialized.StringCollection();
            foreach (string filepath in Properties.Settings.Default.filepaths)
            {
                addFile(filepath);
            }

            fbCoverBtn_Click(null, null);
        }

        int iCurrentSelectedItem = -1;

        #region EVENT FILE LIST
        private void imageFileListView_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void imageFileListView_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileList = (string[])e.Data.GetData(System.Windows.Forms.DataFormats.FileDrop);
            if (fileList != null && fileList.Length > 0)
            {
                foreach (var filePath in fileList)
                {
                    addFile(filePath);
                }
            }
            Properties.Settings.Default.Save();
        }

        private void imageFileListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!e.IsSelected)
            {
                return;
            }
            if (e.Item != null)
            {
                iCurrentSelectedItem = e.ItemIndex;

                // draw the rectangle on the image
                bFaceCheckedChangedBySystem = true;

                ImageWapper imageWapper = (ImageWapper)e.Item.Tag;
                var image = imageWapper.originalImage.Clone();
                faceImageList.Images.Clear();
                faceListView.Items.Clear();
                for (int i = 0; i < imageWapper.originalFaces.Count; i++)
                {
                    Rectangle face = imageWapper.originalFaces[i];
                    image.Draw(face, new Bgr(0, 0, 255), image.Width > image.Height ? image.Height / 200 : image.Width / 200);
                    Image<Bgr, byte> aFace = new Image<Bgr, byte>(new Size(face.Width, face.Height));
                    image.ROI = face;
                    image.CopyTo(aFace);
                    image.ROI = Rectangle.Empty;
                    faceImageList.Images.Add(aFace.ToBitmap());

                    ListViewItem item = new ListViewItem();
                    item.ImageIndex = faceImageList.Images.Count - 1; // use the last inserted
                    item.Checked = imageWapper.bChecked[i];
                    faceListView.Items.Add(item);
                }


                originalImageBox.Image = image;
                bFaceCheckedChangedBySystem = false;
            }
        }

        private void addFile(string filePath)
        {
            try
            {
                if (filepathSet.Add(filePath))
                {
                    Image<Bgr, byte> image = new Image<Bgr, byte>(filePath);
                    if (image != null)
                    {
                        string dimension = String.Format("{0}x{1}", image.Width, image.Height);
                        FileInfo info = new FileInfo(filePath);
                        ListViewItem item = new ListViewItem(new string[] { info.Name, info.Directory.FullName, dimension, info.Extension, "" });
                        ImageWapper imageWapper = new ImageWapper();
                        imageWapper.filepath = filePath;
                        imageWapper.originalImage = image;
                        item.Tag = imageWapper;
                        inputFileListView.Items.Add(item);
                    }
                    else
                        filepathSet.Remove(filePath);
                }
            }
            catch (Exception ex)
            {
                statusLabel.Text = "Cannot open file " + filePath;
            }
        }

        private void removeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputFileListView.Items.Clear();
            filepathSet.Clear();
        }

        private void openFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openImageFilesDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var filePath in openImageFilesDialog.FileNames)
                {
                    addFile(filePath);
                }
            }
        }

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var files = Directory.GetFiles(folderBrowserDialog.SelectedPath);
                foreach (var file in files)
                {
                    addFile(file);
                }
            }
        }

        #endregion


        #region SELECT ROI
        private Image<Bgr, byte> imgEntrada;

        private void imageBox_MouseDown(object sender, MouseEventArgs e)
        {
            RectStartPoint = e.Location;
            Invalidate();
        }

        private void imageBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (iCurrentSelectedItem < 0)
                return;
            int X0, Y0;
            Utilities.ConvertCoordinates(originalImageBox, out X0, out Y0, e.X, e.Y);
            labelPostionXY.Text = String.Format("Last Position: X:{0}  Y:{1}", X0, Y0);

            //Coordinates at input picture box
            if (e.Button != MouseButtons.Left)
                return;
            Point tempEndPoint = e.Location;
            Rect.Location = new Point(Math.Min(RectStartPoint.X, tempEndPoint.X), Math.Min(RectStartPoint.Y, tempEndPoint.Y));
            Rect.Size = new Size(Math.Abs(RectStartPoint.X - tempEndPoint.X), Math.Abs(RectStartPoint.Y - tempEndPoint.Y));

            //Coordinates at real image - Create ROI
            Utilities.ConvertCoordinates(originalImageBox, out X0, out Y0, RectStartPoint.X, RectStartPoint.Y);
            int X1, Y1;
            Utilities.ConvertCoordinates(originalImageBox, out X1, out Y1, tempEndPoint.X, tempEndPoint.Y);
            RealImageRect.Location = new Point(Math.Min(X0, X1), Math.Min(Y0, Y1));
            RealImageRect.Size = new Size(Math.Abs(X0 - X1), Math.Abs(Y0 - Y1));

            imgEntrada = ((ImageWapper)inputFileListView.SelectedItems[0].Tag).originalImage.Clone();
            imgEntrada.Draw(RealImageRect, new Bgr(Color.Red), thickness);
            originalImageBox.Image = imgEntrada;
            ((PictureBox)sender).Invalidate();
        }

        private void imageBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (RealImageRect.Width > 0 && RealImageRect.Height > 0)
            {
                imgEntrada.ROI = RealImageRect;
                faceImageBox.Image = imgEntrada;
                inputFileListView.Items[iCurrentSelectedItem].SubItems[4].Text = imgEntrada.ROI.ToString();
                inputFileListView.Items[iCurrentSelectedItem].SubItems[4].Tag = imgEntrada.ROI;
            }
        }

        private Point RectStartPoint;
        private Rectangle Rect = new Rectangle();
        private Rectangle RealImageRect = new Rectangle();
        private Brush selectionBrush = new SolidBrush(Color.FromArgb(128, 64, 64, 64));
        private const int thickness = 1;
        #endregion


        #region DETECT FACE
        private void findFaceBtn_Click(object sender, EventArgs e)
        {
            if (inputFileListView.SelectedItems.Count > 0)
            {
                var item = inputFileListView.SelectedItems[0];
                DetectFace(item);
            }
        }

        private void DetectFace(ListViewItem item)
        {
            BackgroundWorker bw = new BackgroundWorker();
            item.SubItems[4].Text = "Finding...";
            bw.DoWork += detectFaceBackgroundWork_DoWork;
            bw.RunWorkerCompleted += detectFaceBackgroundWork_RunWorkerCompleted;
            bw.RunWorkerAsync(item);
        }

        void detectFaceBackgroundWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ListViewItem item = (ListViewItem)e.Result;
            int nFaces = (int)item.SubItems[4].Tag;
            item.SubItems[4].Text = item.SubItems[4].Tag + " / " + item.SubItems[4].Tag;
        }

        void detectFaceBackgroundWork_DoWork(object sender, DoWorkEventArgs e)
        {
            ListViewItem item = (ListViewItem)e.Argument;
            List<Rectangle> faces = null;
            Utilities.DetectFace(((ImageWapper)item.Tag).originalImage, out faces);
            ((ImageWapper)item.Tag).originalFaces = faces;
            for (int i = 0; i < faces.Count; i++)
                ((ImageWapper)item.Tag).bChecked.Add(true);
            item.SubItems[4].Tag = faces.Count;
            e.Result = item;

        }

        private void findAllFacesBtn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in inputFileListView.Items)
            {
                DetectFace(item);
            }
        }

        #endregion


        private void createCover_Click(object sender, EventArgs e)
        {
            int nFaces = 0;
            foreach (ListViewItem item in inputFileListView.Items)
            {
                if (item.SubItems[4].Tag == null)
                    continue;
                nFaces += (int)item.SubItems[4].Tag;
            }

            int w = (int)widthEdit.Value / nFaces;

            int iFace = 0;

            croppedFaceImageList.Images.Clear();
            croppeFaceListView.Items.Clear();
            for (int i = 0; i < inputFileListView.Items.Count; i++)
            {
                ImageWapper item = (ImageWapper)inputFileListView.Items[i].Tag;
                foreach (Rectangle rectFace in item.originalFaces)
                {
                    if (rectFace == null)
                        continue;
                    var image = item.originalImage;
                    int tempW = (int)(rectFace.Width * Constants.FACE_RATIO_HORIZONTAL);

                    double r = (double)w / tempW;
                    image = image.Resize(r, Inter.Cubic);
                    Rectangle rectCrop = new Rectangle((int)(rectFace.Right * r + rectFace.Left * r - w) / 2, 0, w, image.Height);
                    image.ROI = rectCrop;
                    //ImageShowcase showCase = new ImageShowcase();
                    //showCase.imageBox.Image = image;
                    //showCase.Size = new Size(image.Size.Width + 50, image.Size.Height + 50);
                    //showCase.Show();
                    croppedFaceImageList.Images.Add(image.ToBitmap());
                    ListViewItem it = new ListViewItem();
                    it.ImageIndex = croppedFaceImageList.Images.Count - 1;
                    croppeFaceListView.Items.Add(it);
                    iFace++;
                }
            }
        }

        private void fbCoverBtn_Click(object sender, EventArgs e)
        {
            heightEdit.Value = Constants.FB_COVER_HEIGHT;
            widthEdit.Value = Constants.FB_COVER_WIDTH;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.filepaths.Clear();
            foreach (ListViewItem item in inputFileListView.Items)
            {
                Properties.Settings.Default.filepaths.Add(((ImageWapper)item.Tag).filepath);
            }
            Properties.Settings.Default.Save();
        }

        #region FACE LIST VIEW
        private void faceListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

        }

        private void faceListView_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void deleteFaceBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < faceListView.Items.Count; i++)
            {
                ListViewItem item = faceListView.Items[i];
                if (item.Selected)
                {
                    faceListView.Items.Remove(item);
                    faceImageList.Images.RemoveAt(i);
                    Debug.Assert(inputFileListView.SelectedItems.Count == 1);
                    ((ImageWapper)inputFileListView.SelectedItems[0].Tag).originalFaces.RemoveAt(i);
                    ((ImageWapper)inputFileListView.SelectedItems[0].Tag).bChecked.RemoveAt(i);
                    i--;
                }
            }
        }

        private void addFaceBtn_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void faceListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (bFaceCheckedChangedBySystem)
                return;
            Debug.Assert(inputFileListView.SelectedItems.Count == 1);
            ImageWapper imageWapper = (ImageWapper)inputFileListView.SelectedItems[0].Tag;
            imageWapper.bChecked[e.Item.Index] = e.Item.Checked;
            int nChecked = (int)inputFileListView.SelectedItems[0].SubItems[4].Tag;
            if (e.Item.Checked)
                nChecked++;
            else
                nChecked--;
            inputFileListView.SelectedItems[0].SubItems[4].Text = nChecked + " / " + imageWapper.bChecked.Count;
            inputFileListView.SelectedItems[0].SubItems[4].Tag = nChecked;
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 1)
            {
                createCoverBtn.PerformClick();
                numberOfSelecedFacesEdit.Text = "" + nFaces;
            }
        }
    }
}
