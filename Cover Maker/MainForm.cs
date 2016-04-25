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

namespace Cover_Maker
{
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();

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
                originalImageBox.Image = (Mat)e.Item.Tag;
                if (e.Item.SubItems[4].Tag != null)
                {
                    imgEntrada = ((Mat)e.Item.Tag).ToImage<Bgr, byte>();
                    imgEntrada.ROI = (Rectangle)e.Item.SubItems[4].Tag;
                    faceImageBox.Image = imgEntrada;
                }
                else
                {
                    faceImageBox.Image = null;
                }
            }
        }

        private void addFile(string filePath)
        {
            try
            {
                Mat img = CvInvoke.Imread(filePath, Emgu.CV.CvEnum.LoadImageType.AnyColor);
                if (img != null)
                {
                    string dimension = String.Format("{0}x{1}", img.Width, img.Height);
                    FileInfo info = new FileInfo(filePath);
                    ListViewItem item = new ListViewItem(new string[] { info.Name, info.Directory.FullName, dimension, info.Extension, "" });
                    item.Tag = img;
                    imageFileListView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                statusLabel.Text = "Cannot open file " + filePath;
            }
        }

        private void removeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageFileListView.Items.Clear();
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
            #region SETS COORDINATES AT INPUT IMAGE BOX
            int X0, Y0;
            Utilities.ConvertCoordinates(originalImageBox, out X0, out Y0, e.X, e.Y);
            labelPostionXY.Text = String.Format("Last Position: X:{0}  Y:{1}", X0, Y0);

            //Coordinates at input picture box
            if (e.Button != MouseButtons.Left)
                return;
            Point tempEndPoint = e.Location;
            Rect.Location = new Point(Math.Min(RectStartPoint.X, tempEndPoint.X), Math.Min(RectStartPoint.Y, tempEndPoint.Y));
            Rect.Size = new Size(Math.Abs(RectStartPoint.X - tempEndPoint.X), Math.Abs(RectStartPoint.Y - tempEndPoint.Y));
            #endregion

            #region SETS COORDINATES AT REAL IMAGE
            //Coordinates at real image - Create ROI
            Utilities.ConvertCoordinates(originalImageBox, out X0, out Y0, RectStartPoint.X, RectStartPoint.Y);
            int X1, Y1;
            Utilities.ConvertCoordinates(originalImageBox, out X1, out Y1, tempEndPoint.X, tempEndPoint.Y);
            RealImageRect.Location = new Point(Math.Min(X0, X1), Math.Min(Y0, Y1));
            RealImageRect.Size = new Size(Math.Abs(X0 - X1), Math.Abs(Y0 - Y1));

            imgEntrada = ((Mat)imageFileListView.SelectedItems[0].Tag).ToImage<Bgr, Byte>();
            imgEntrada.Draw(RealImageRect, new Bgr(Color.Red), thickness);
            originalImageBox.Image = imgEntrada;
            #endregion

            ((PictureBox)sender).Invalidate();
        }

        private void imageBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (RealImageRect.Width > 0 && RealImageRect.Height > 0)
            {
                imgEntrada.ROI = RealImageRect;
                faceImageBox.Image = imgEntrada;
                imageFileListView.Items[iCurrentSelectedItem].SubItems[4].Text = imgEntrada.ROI.ToString();
                imageFileListView.Items[iCurrentSelectedItem].SubItems[4].Tag = imgEntrada.ROI;
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
            if (imageFileListView.SelectedItems.Count > 0)
            {
                var item = imageFileListView.SelectedItems[0];
                DetectFace(item);
            }
        }

        private void DetectFace(ListViewItem item)
        {
            item.SubItems[4].Text = "Finding...";

            Rectangle[] faces = null;
            Utilities.DetectFace((Mat)item.Tag, out faces);

            if (faces != null && faces.Length > 0)
            {
                item.SubItems[4].Tag = faces[0];
                item.SubItems[4].Text = faces[0].ToString();
                imageBox_MouseUp(null, null);
            }
            else
            {
                item.SubItems[4].Tag = null;
                item.SubItems[4].Text = "Not found";
            }
        }

        private void findAllFacesBtn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in imageFileListView.Items)
            {
                DetectFace(item);
            }
        }

        #endregion


        private void createCover_Click(object sender, EventArgs e)
        {
            Image<Bgr, byte> cover = new Image<Bgr, byte>(new Size((int)widthEdit.Value, (int)heightEdit.Value));
            int nFaces = 0;
            foreach (ListViewItem item in imageFileListView.Items)
            {
                Rectangle roi = (Rectangle)item.SubItems[4].Tag;
                if (roi == null)
                    continue;
                else nFaces++;
            }

            int w = (int)widthEdit.Value / nFaces;

            int iFace = 0;
            foreach (ListViewItem item in imageFileListView.Items)
            {
                Rectangle rectFace = (Rectangle)item.SubItems[4].Tag;
                if (rectFace == null)
                    continue;
                var image = ((Mat)item.Tag).ToImage<Bgr, byte>();
                int tempW = (int)(rectFace.Width * Constants.FACE_RATIO_HORIZONTAL);

                double r = w / tempW;
                image = image.Resize(r, Inter.Cubic);
                Rectangle rectCrop = new Rectangle((int)(rectFace.Right * r + rectFace.Left * r - w) / 2, 0, w, image.Height);
                image.ROI = rectCrop;
                ImageShowcase showCase = new ImageShowcase();
                showCase.imageBox.Image = image;
                showCase.Size = new Size(image.Size.Width + 50, image.Size.Height + 50);
                showCase.Show();

                cover.ROI = new Rectangle(iFace * w, 0, w, image.Height);
                Image<Gray, byte> mask = new Image<Gray, byte>(cover.ROI.Width, cover.ROI.Height);
                mask.SetValue(1);
                CvInvoke.cvCopy(image, cover, mask);
                iFace++;
            }
        }

        private void fbCoverBtn_Click(object sender, EventArgs e)
        {
            heightEdit.Value = Constants.FB_COVER_HEIGHT;
            widthEdit.Value = Constants.FB_COVER_WIDTH;
        }
    }
}
