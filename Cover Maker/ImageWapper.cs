using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cover_Maker
{
    public class ImageWapper
    {
        public Image<Bgr, byte> originalImage;
        public List<Rectangle> originalFaces = new List<Rectangle>();
        public List<bool> bChecked = new List<bool>();

        public Image<Bgr, byte> resizedImage;
        public List<Rectangle> resizedFaces;


        public string filepath;
    }
}
