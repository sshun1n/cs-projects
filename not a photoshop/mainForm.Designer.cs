namespace not_a_photoshop
{
    partial class mainForm
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
            components = new System.ComponentModel.Container();
            fileOpenButton = new Button();
            fileSaveButton = new Button();
            toolPanel = new Panel();
            zoomPanel = new Panel();
            pictureSizeBar = new TrackBar();
            zoomLabel = new Label();
            cropPanel = new Panel();
            rotateMirrorLabel = new Label();
            mirrorVerticalButton = new Button();
            mirrorHorizontalButton = new Button();
            rotateLeftButton = new Button();
            panel3 = new Panel();
            orintationLockIconBox = new PictureBox();
            orintationLockCheckBox = new CheckBox();
            rotateRightButton = new Button();
            cropWidthLabel = new Label();
            cropHeightLabel = new Label();
            cropHeightBox = new TextBox();
            cropWidthBox = new TextBox();
            cropLabel = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            toolsTimer = new System.Windows.Forms.Timer(components);
            mainPanel = new Panel();
            panel4 = new Panel();
            resetPictureLocationButton = new Button();
            pictureBox = new PictureBox();
            toolPanel.SuspendLayout();
            zoomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureSizeBar).BeginInit();
            cropPanel.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orintationLockIconBox).BeginInit();
            mainPanel.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // fileOpenButton
            // 
            fileOpenButton.BackColor = Color.FromArgb(50, 50, 50);
            fileOpenButton.Cursor = Cursors.Hand;
            fileOpenButton.FlatAppearance.BorderSize = 0;
            fileOpenButton.FlatStyle = FlatStyle.Flat;
            fileOpenButton.ForeColor = Color.White;
            fileOpenButton.Location = new Point(1, 1);
            fileOpenButton.Name = "fileOpenButton";
            fileOpenButton.Size = new Size(107, 23);
            fileOpenButton.TabIndex = 0;
            fileOpenButton.Text = "Открыть файл";
            fileOpenButton.UseVisualStyleBackColor = false;
            fileOpenButton.Click += fileOpenButton_Click;
            // 
            // fileSaveButton
            // 
            fileSaveButton.BackColor = Color.FromArgb(50, 50, 50);
            fileSaveButton.Cursor = Cursors.Hand;
            fileSaveButton.FlatAppearance.BorderSize = 0;
            fileSaveButton.FlatStyle = FlatStyle.Flat;
            fileSaveButton.ForeColor = Color.White;
            fileSaveButton.Location = new Point(110, 1);
            fileSaveButton.Name = "fileSaveButton";
            fileSaveButton.Size = new Size(107, 23);
            fileSaveButton.TabIndex = 1;
            fileSaveButton.Text = "Сохранить";
            fileSaveButton.UseVisualStyleBackColor = false;
            // 
            // toolPanel
            // 
            toolPanel.BackColor = Color.FromArgb(50, 50, 50);
            toolPanel.Controls.Add(zoomPanel);
            toolPanel.Controls.Add(cropPanel);
            toolPanel.Dock = DockStyle.Right;
            toolPanel.Location = new Point(1540, 0);
            toolPanel.Name = "toolPanel";
            toolPanel.Size = new Size(364, 1045);
            toolPanel.TabIndex = 4;
            // 
            // zoomPanel
            // 
            zoomPanel.BackColor = Color.FromArgb(33, 33, 33);
            zoomPanel.Controls.Add(pictureSizeBar);
            zoomPanel.Controls.Add(zoomLabel);
            zoomPanel.Location = new Point(10, 30);
            zoomPanel.Name = "zoomPanel";
            zoomPanel.Size = new Size(344, 63);
            zoomPanel.TabIndex = 0;
            // 
            // pictureSizeBar
            // 
            pictureSizeBar.AutoSize = false;
            pictureSizeBar.BackColor = Color.FromArgb(50, 50, 50);
            pictureSizeBar.Cursor = Cursors.Hand;
            pictureSizeBar.Location = new Point(11, 27);
            pictureSizeBar.Maximum = 100;
            pictureSizeBar.Name = "pictureSizeBar";
            pictureSizeBar.Size = new Size(321, 25);
            pictureSizeBar.TabIndex = 5;
            pictureSizeBar.TickStyle = TickStyle.None;
            pictureSizeBar.Scroll += pictureSizeBar_Scroll;
            // 
            // zoomLabel
            // 
            zoomLabel.AutoSize = true;
            zoomLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            zoomLabel.ForeColor = Color.White;
            zoomLabel.Location = new Point(7, 5);
            zoomLabel.Name = "zoomLabel";
            zoomLabel.Size = new Size(159, 17);
            zoomLabel.TabIndex = 0;
            zoomLabel.Text = "Приблизить \\ Отдалить";
            // 
            // cropPanel
            // 
            cropPanel.BackColor = Color.FromArgb(33, 33, 33);
            cropPanel.Controls.Add(rotateMirrorLabel);
            cropPanel.Controls.Add(mirrorVerticalButton);
            cropPanel.Controls.Add(mirrorHorizontalButton);
            cropPanel.Controls.Add(rotateLeftButton);
            cropPanel.Controls.Add(panel3);
            cropPanel.Controls.Add(rotateRightButton);
            cropPanel.Controls.Add(cropWidthLabel);
            cropPanel.Controls.Add(cropHeightLabel);
            cropPanel.Controls.Add(cropHeightBox);
            cropPanel.Controls.Add(cropWidthBox);
            cropPanel.Controls.Add(cropLabel);
            cropPanel.Controls.Add(panel2);
            cropPanel.Controls.Add(panel1);
            cropPanel.Location = new Point(10, 120);
            cropPanel.Name = "cropPanel";
            cropPanel.Size = new Size(344, 63);
            cropPanel.TabIndex = 1;
            // 
            // rotateMirrorLabel
            // 
            rotateMirrorLabel.AutoSize = true;
            rotateMirrorLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            rotateMirrorLabel.ForeColor = Color.White;
            rotateMirrorLabel.Location = new Point(226, 7);
            rotateMirrorLabel.Name = "rotateMirrorLabel";
            rotateMirrorLabel.Size = new Size(62, 17);
            rotateMirrorLabel.TabIndex = 7;
            rotateMirrorLabel.Text = "Править";
            // 
            // mirrorVerticalButton
            // 
            mirrorVerticalButton.BackColor = Color.FromArgb(50, 50, 50);
            mirrorVerticalButton.BackgroundImage = Properties.Resources.mirrorVertical1;
            mirrorVerticalButton.Cursor = Cursors.Hand;
            mirrorVerticalButton.FlatAppearance.BorderColor = Color.White;
            mirrorVerticalButton.FlatAppearance.BorderSize = 0;
            mirrorVerticalButton.FlatStyle = FlatStyle.Flat;
            mirrorVerticalButton.Location = new Point(282, 28);
            mirrorVerticalButton.Name = "mirrorVerticalButton";
            mirrorVerticalButton.Size = new Size(24, 24);
            mirrorVerticalButton.TabIndex = 6;
            mirrorVerticalButton.UseVisualStyleBackColor = false;
            mirrorVerticalButton.Click += mirrorVerticalButton_Click;
            // 
            // mirrorHorizontalButton
            // 
            mirrorHorizontalButton.BackColor = Color.FromArgb(50, 50, 50);
            mirrorHorizontalButton.BackgroundImage = Properties.Resources.mirrorHorizontal1;
            mirrorHorizontalButton.Cursor = Cursors.Hand;
            mirrorHorizontalButton.FlatAppearance.BorderColor = Color.White;
            mirrorHorizontalButton.FlatAppearance.BorderSize = 0;
            mirrorHorizontalButton.FlatStyle = FlatStyle.Flat;
            mirrorHorizontalButton.Location = new Point(308, 28);
            mirrorHorizontalButton.Name = "mirrorHorizontalButton";
            mirrorHorizontalButton.Size = new Size(24, 24);
            mirrorHorizontalButton.TabIndex = 5;
            mirrorHorizontalButton.UseVisualStyleBackColor = false;
            mirrorHorizontalButton.Click += mirrorHorizontalButton_Click;
            // 
            // rotateLeftButton
            // 
            rotateLeftButton.BackColor = Color.FromArgb(50, 50, 50);
            rotateLeftButton.BackgroundImage = Properties.Resources.rotateLeft;
            rotateLeftButton.Cursor = Cursors.Hand;
            rotateLeftButton.FlatAppearance.BorderColor = Color.White;
            rotateLeftButton.FlatAppearance.BorderSize = 0;
            rotateLeftButton.FlatStyle = FlatStyle.Flat;
            rotateLeftButton.Location = new Point(230, 28);
            rotateLeftButton.Name = "rotateLeftButton";
            rotateLeftButton.Size = new Size(24, 24);
            rotateLeftButton.TabIndex = 4;
            rotateLeftButton.UseVisualStyleBackColor = false;
            rotateLeftButton.Click += rotateLeftButton_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(50, 50, 50);
            panel3.Controls.Add(orintationLockIconBox);
            panel3.Controls.Add(orintationLockCheckBox);
            panel3.Location = new Point(72, 7);
            panel3.Name = "panel3";
            panel3.Size = new Size(35, 19);
            panel3.TabIndex = 4;
            // 
            // orintationLockIconBox
            // 
            orintationLockIconBox.BackColor = Color.FromArgb(50, 50, 50);
            orintationLockIconBox.Image = Properties.Resources.orintationLockWhite;
            orintationLockIconBox.Location = new Point(1, 1);
            orintationLockIconBox.Name = "orintationLockIconBox";
            orintationLockIconBox.Size = new Size(15, 15);
            orintationLockIconBox.SizeMode = PictureBoxSizeMode.Zoom;
            orintationLockIconBox.TabIndex = 2;
            orintationLockIconBox.TabStop = false;
            // 
            // orintationLockCheckBox
            // 
            orintationLockCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            orintationLockCheckBox.Cursor = Cursors.Hand;
            orintationLockCheckBox.Location = new Point(13, -3);
            orintationLockCheckBox.Name = "orintationLockCheckBox";
            orintationLockCheckBox.Size = new Size(20, 25);
            orintationLockCheckBox.TabIndex = 2;
            orintationLockCheckBox.UseVisualStyleBackColor = true;
            orintationLockCheckBox.CheckedChanged += orintationLockCheckBox_CheckedChanged;
            // 
            // rotateRightButton
            // 
            rotateRightButton.BackColor = Color.FromArgb(50, 50, 50);
            rotateRightButton.BackgroundImage = Properties.Resources.rotateRight;
            rotateRightButton.Cursor = Cursors.Hand;
            rotateRightButton.FlatAppearance.BorderColor = Color.White;
            rotateRightButton.FlatAppearance.BorderSize = 0;
            rotateRightButton.FlatStyle = FlatStyle.Flat;
            rotateRightButton.Location = new Point(256, 28);
            rotateRightButton.Name = "rotateRightButton";
            rotateRightButton.Size = new Size(24, 24);
            rotateRightButton.TabIndex = 2;
            rotateRightButton.UseVisualStyleBackColor = false;
            rotateRightButton.Click += rotateRightButton_Click;
            // 
            // cropWidthLabel
            // 
            cropWidthLabel.BackColor = Color.FromArgb(50, 50, 50);
            cropWidthLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cropWidthLabel.ForeColor = Color.White;
            cropWidthLabel.Location = new Point(11, 28);
            cropWidthLabel.Name = "cropWidthLabel";
            cropWidthLabel.Size = new Size(63, 24);
            cropWidthLabel.TabIndex = 2;
            cropWidthLabel.Text = "Ширина:";
            cropWidthLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cropHeightLabel
            // 
            cropHeightLabel.BackColor = Color.FromArgb(50, 50, 50);
            cropHeightLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cropHeightLabel.ForeColor = Color.White;
            cropHeightLabel.Location = new Point(109, 28);
            cropHeightLabel.Name = "cropHeightLabel";
            cropHeightLabel.Size = new Size(56, 24);
            cropHeightLabel.TabIndex = 2;
            cropHeightLabel.Text = "Высота:";
            cropHeightLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cropHeightBox
            // 
            cropHeightBox.BackColor = Color.FromArgb(50, 50, 50);
            cropHeightBox.BorderStyle = BorderStyle.None;
            cropHeightBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cropHeightBox.ForeColor = Color.White;
            cropHeightBox.Location = new Point(160, 32);
            cropHeightBox.MaxLength = 5;
            cropHeightBox.Multiline = true;
            cropHeightBox.Name = "cropHeightBox";
            cropHeightBox.Size = new Size(39, 20);
            cropHeightBox.TabIndex = 3;
            cropHeightBox.TextAlign = HorizontalAlignment.Center;
            cropHeightBox.TextChanged += cropHeightBox_TextChanged;
            // 
            // cropWidthBox
            // 
            cropWidthBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cropWidthBox.BackColor = Color.FromArgb(50, 50, 50);
            cropWidthBox.BorderStyle = BorderStyle.None;
            cropWidthBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cropWidthBox.ForeColor = Color.White;
            cropWidthBox.Location = new Point(69, 32);
            cropWidthBox.MaxLength = 5;
            cropWidthBox.Multiline = true;
            cropWidthBox.Name = "cropWidthBox";
            cropWidthBox.Size = new Size(38, 18);
            cropWidthBox.TabIndex = 2;
            cropWidthBox.TextAlign = HorizontalAlignment.Center;
            cropWidthBox.TextChanged += cropWidthBox_TextChanged;
            // 
            // cropLabel
            // 
            cropLabel.AutoSize = true;
            cropLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cropLabel.ForeColor = Color.White;
            cropLabel.Location = new Point(7, 7);
            cropLabel.Name = "cropLabel";
            cropLabel.Size = new Size(67, 17);
            cropLabel.TabIndex = 0;
            cropLabel.Text = "Обрезать";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 50, 50);
            panel2.Location = new Point(46, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(61, 24);
            panel2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 50, 50);
            panel1.Location = new Point(138, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(61, 24);
            panel1.TabIndex = 3;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(panel4);
            mainPanel.Controls.Add(pictureBox);
            mainPanel.Dock = DockStyle.Bottom;
            mainPanel.Location = new Point(0, 30);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1540, 1015);
            mainPanel.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(50, 50, 50);
            panel4.Controls.Add(resetPictureLocationButton);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1540, 25);
            panel4.TabIndex = 9;
            // 
            // resetPictureLocationButton
            // 
            resetPictureLocationButton.BackColor = Color.FromArgb(50, 50, 50);
            resetPictureLocationButton.BackgroundImage = Properties.Resources.reset;
            resetPictureLocationButton.Cursor = Cursors.Hand;
            resetPictureLocationButton.FlatAppearance.BorderColor = Color.White;
            resetPictureLocationButton.FlatAppearance.BorderSize = 0;
            resetPictureLocationButton.FlatStyle = FlatStyle.Flat;
            resetPictureLocationButton.Location = new Point(1510, 0);
            resetPictureLocationButton.Name = "resetPictureLocationButton";
            resetPictureLocationButton.Size = new Size(24, 24);
            resetPictureLocationButton.TabIndex = 8;
            resetPictureLocationButton.UseVisualStyleBackColor = false;
            resetPictureLocationButton.Click += resetPictureLocationButton_Click;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.FromArgb(44, 44, 44);
            pictureBox.Location = new Point(24, 31);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(1510, 956);
            pictureBox.TabIndex = 3;
            pictureBox.TabStop = false;
            pictureBox.MouseDown += pictureBox_MouseDown;
            pictureBox.MouseMove += pictureBox_MouseMove;
            pictureBox.MouseUp += pictureBox_MouseUp;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(1904, 1045);
            Controls.Add(mainPanel);
            Controls.Add(fileSaveButton);
            Controls.Add(fileOpenButton);
            Controls.Add(toolPanel);
            DoubleBuffered = true;
            Name = "mainForm";
            Text = "Not a Photoshop";
            toolPanel.ResumeLayout(false);
            zoomPanel.ResumeLayout(false);
            zoomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureSizeBar).EndInit();
            cropPanel.ResumeLayout(false);
            cropPanel.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)orintationLockIconBox).EndInit();
            mainPanel.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        private void PictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button fileOpenButton;
        private Button fileSaveButton;
        private Panel toolPanel;
        private Panel zoomPanel;
        private Label zoomLabel;
        private Panel cropPanel;
        private Label cropLabel;
        private TextBox cropHeightBox;
        private TextBox cropWidthBox;
        private Label cropHeightLabel;
        private Label cropWidthLabel;
        private PictureBox orintationLockIconBox;
        private CheckBox orintationLockCheckBox;
        private TrackBar pictureSizeBar;
        private System.Windows.Forms.Timer toolsTimer;
        private Panel mainPanel;
        private PictureBox pictureBox;
        private Button rotateRightButton;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Button rotateLeftButton;
        private Button mirrorVerticalButton;
        private Button mirrorHorizontalButton;
        private Label rotateMirrorLabel;
        private Button resetPictureLocationButton;
        private Panel panel4;
    }
}
