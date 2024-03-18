using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace not_a_photoshop
{
    public partial class mainForm : Form
    {
        Image imgOriginal;

        public mainForm()
        {
            InitializeComponent();

            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void fileOpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image files(*.png)|*.png|All files(*.*)|*.*";

            if (fileDialog.ShowDialog() == DialogResult.Cancel) return;
            string filename = fileDialog.FileName;

            pictureBox.Image = Image.FromFile(filename);
            imgOriginal = pictureBox.Image;
        }

        Image Zoom(Image img, Size size)
        {
            Bitmap bmp = new Bitmap(img, img.Width + (img.Width * size.Width / 100), img.Height + (img.Height * size.Height / 100));
            Graphics g = Graphics.FromImage(bmp);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bmp;
        }

        private void pictureSizeBar_Scroll(object sender, EventArgs e)
        {
            if (pictureSizeBar.Value > 0)
            {
                pictureBox.Image = Zoom(imgOriginal, new Size(pictureSizeBar.Value, pictureSizeBar.Value));
            }
        }
    }
}
