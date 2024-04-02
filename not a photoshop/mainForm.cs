using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace not_a_photoshop
{
    public partial class mainForm : Form
    {
        Image currentImage, imageOriginal;
        Img image;

        int toolPanelWidth = 0;
        int maxToolPanelWidth;
        int xPosition, yPosition;

        bool isDragging = false;
        bool isCropCheck = false;

        public mainForm()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.main;
            resetPictureLocationButton.BackgroundImage = Properties.Resources.reset3;

            maxToolPanelWidth = toolPanel.Width;
            toolPanel.Size = new Size(0, 476);

            toolsTimer.Interval = 1;
            toolsTimer.Tick += new EventHandler(toolPanelIn);

            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;

            rotateRightButton.BackgroundImageLayout = ImageLayout.Stretch;
            rotateLeftButton.BackgroundImageLayout = ImageLayout.Stretch;
            mirrorHorizontalButton.BackgroundImageLayout = ImageLayout.Stretch;
            mirrorVerticalButton.BackgroundImageLayout = ImageLayout.Stretch;
            resetPictureLocationButton.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void update()
        {
            currentImage = pictureBox.Image;

            cropWidthBox.Text = currentImage.Width.ToString();
            cropHeightBox.Text = currentImage.Height.ToString();

            pictureBox.Image = image.Zoom(currentImage, new Size(pictureSizeBar.Value, pictureSizeBar.Value));
        }

        private void fileOpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image files(*.png)|*.png|All files(*.*)|*.*";

            if (fileDialog.ShowDialog() == DialogResult.Cancel) return;
            string filename = fileDialog.FileName;
            toolsTimer.Start();

            image = new Img(filename); FitImageToSize(image);
            pictureBox.Image = image.Get();
            imageOriginal = pictureBox.Image;

            update();
        }

        private void FitImageToSize(Img image)
        {
            while (image.Width >= pictureBox.Width || image.Height >= pictureBox.Height) image.Fit(0.9);
        }

        private void toolPanelIn(object sender, EventArgs e)
        {
            toolPanelWidth += 5;

            if (toolPanelWidth > maxToolPanelWidth) { toolsTimer.Stop(); return; }

            toolPanel.Size = new Size(toolPanelWidth, 476);
        }

        private void pictureSizeBar_Scroll(object sender, EventArgs e)
        {
            if (pictureSizeBar.Value > 0)
            {
                pictureBox.Image = image.Zoom(currentImage, new Size(pictureSizeBar.Value * (pictureBox.Width / currentImage.Width), pictureSizeBar.Value * (pictureBox.Width / currentImage.Width)));
            }
        }

        private void cropWidthBox_TextChanged(object sender, EventArgs e)
        {
            if (cropWidthBox.Text != "")
            {
                int newWidth = int.Parse(cropWidthBox.Text);

                if (0 < newWidth && newWidth <= imageOriginal.Width && !isCropCheck)
                {
                    pictureBox.Image = image.cropImage(imageOriginal, new Rectangle(0, 0, newWidth, imageOriginal.Height));
                }
                else if (0 < newWidth && newWidth <= imageOriginal.Width && !isCropCheck)
                {
                    pictureBox.Image = image.cropImage(imageOriginal, new Rectangle(0, 0, newWidth, (imageOriginal.Height * newWidth) / imageOriginal.Width));
                }
                else { cropWidthBox.Text = currentImage.Width.ToString(); }

            }
            else cropWidthBox.Text = currentImage.Width.ToString();
            update();
        }

        private void cropHeightBox_TextChanged(object sender, EventArgs e)
        {
            if (cropHeightBox.Text != "")
            {
                int newHeight = int.Parse(cropHeightBox.Text);

                if (0 < newHeight && newHeight <= imageOriginal.Height && !isCropCheck)
                {
                    pictureBox.Image = image.cropImage(imageOriginal, new Rectangle(0, 0, currentImage.Width, newHeight));
                }
                else { cropHeightBox.Text = currentImage.Height.ToString(); }

            }
            else cropHeightBox.Text = currentImage.Height.ToString();
            update();
        }

        private void rotateRightButton_Click(object sender, EventArgs e)
        {
            pictureSizeBar.Value = 0;
            pictureBox.Image = image.RotateRight();
        }

        private void rotateLeftButton_Click(object sender, EventArgs e)
        {
            pictureSizeBar.Value = 0;
            pictureBox.Image = image.RotateLeft();
        }

        private void mirrorVerticalButton_Click(object sender, EventArgs e)
        {
            pictureSizeBar.Value = 0;
            pictureBox.Image = image.MirrorVertically();
        }

        private void mirrorHorizontalButton_Click(object sender, EventArgs e)
        {
            pictureSizeBar.Value = 0;
            pictureBox.Image = image.MirrorHorisontally();
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e) { isDragging = false; }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;

                xPosition = e.X;
                yPosition = e.Y;
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            Control control = sender as Control;

            if (isDragging && control != null)
            {
                control.Top = e.Y + control.Top - yPosition;
                control.Left = e.X + control.Left - xPosition;

                //resetPictureLocationButton.BackgroundImage = Properties.Resources.brightReset;
            }
        }

        private void resetPictureLocationButton_Click(object sender, EventArgs e)
        {
            pictureBox.Location = new Point(24, 31);
        }

        private void orintationLockCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!isCropCheck) isCropCheck = true;
            else if (isCropCheck) isCropCheck &= false;

            cropLabel.Text = "1";  
        }
    }
}
