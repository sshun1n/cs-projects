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
            fileOpenButton = new Button();
            fileSaveButton = new Button();
            pictureBox = new PictureBox();
            pictureSizeBar = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureSizeBar).BeginInit();
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
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
            pictureBox.Location = new Point(12, 30);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(747, 434);
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            // 
            // pictureSizeBar
            // 
            pictureSizeBar.AutoSize = false;
            pictureSizeBar.BackColor = Color.FromArgb(50, 50, 50);
            pictureSizeBar.Location = new Point(765, 50);
            pictureSizeBar.Maximum = 100;
            pictureSizeBar.Name = "pictureSizeBar";
            pictureSizeBar.Size = new Size(253, 23);
            pictureSizeBar.TabIndex = 3;
            pictureSizeBar.TickStyle = TickStyle.None;
            pictureSizeBar.Scroll += pictureSizeBar_Scroll;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(1025, 476);
            Controls.Add(pictureSizeBar);
            Controls.Add(pictureBox);
            Controls.Add(fileSaveButton);
            Controls.Add(fileOpenButton);
            Name = "mainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureSizeBar).EndInit();
            ResumeLayout(false);
        }

        private void PictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button fileOpenButton;
        private Button fileSaveButton;
        private PictureBox pictureBox;
        private TrackBar pictureSizeBar;
    }
}
