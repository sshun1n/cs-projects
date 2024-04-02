using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace not_a_photoshop
{
    internal class Img
    {
        private Image img;

        public int Width;
        public int Height;

        public Img(string filename)
        {
            this.img = Image.FromFile(filename);

            this.Width = img.Width;
            this.Height = img.Height;
        }

        public void Fit(double factor)
        {
            this.img = resizeImage(img, new Size(Convert.ToInt32(img.Width * factor), Convert.ToInt32(img.Height * factor)));

            this.Width = img.Width;
            this.Height = img.Height;
        }

        public Image Zoom(Image img, Size size)
        {
            Bitmap bmp = new Bitmap(img, img.Width + (img.Width * size.Width / 100), img.Height + (img.Height * size.Height / 100));
            Graphics g = Graphics.FromImage(bmp);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            
            return bmp;
        }

        public Image cropImage(Image image, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(image);
            this.img = bmpImage.Clone(cropArea, bmpImage.PixelFormat);
            return img;
        }

        public Image RotateRight() { img.RotateFlip(RotateFlipType.Rotate90FlipNone); return this.img; }
        public Image RotateLeft() { img.RotateFlip(RotateFlipType.Rotate270FlipNone); return this.img; }
        public Image MirrorVertically() { img.RotateFlip(RotateFlipType.RotateNoneFlipX); return this.img; }
        public Image MirrorHorisontally() { img.RotateFlip(RotateFlipType.RotateNoneFlipY); return this.img; }

        public Image Get() { return this.img; }

        private static Image resizeImage(Image imgToResize, Size size) {
            Bitmap newImage = new Bitmap(size.Width, size.Height);
            using (Graphics gr = Graphics.FromImage(newImage))

            {
                gr.SmoothingMode = SmoothingMode.HighQuality;
                gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                gr.DrawImage(imgToResize, new Rectangle(0, 0, size.Width, size.Height));
            }

            return newImage;
        }
    }
}
