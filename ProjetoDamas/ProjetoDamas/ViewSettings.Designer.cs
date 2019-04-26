namespace ProjetoDamas
{
    partial class ViewSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSettings));
            this.pBReturn = new System.Windows.Forms.PictureBox();
            this.lVolumeLevel = new System.Windows.Forms.Label();
            this.nUDVolumeLevel = new System.Windows.Forms.NumericUpDown();
            this.pUsername = new System.Windows.Forms.Panel();
            this.pUsernameImage = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lWindowSize = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cBWindowSize = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDVolumeLevel)).BeginInit();
            this.pUsername.SuspendLayout();
            this.pUsernameImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pBReturn
            // 
            this.pBReturn.BackColor = System.Drawing.Color.Transparent;
            this.pBReturn.Image = global::ProjetoDamas.Properties.Resources.a429924cb33912470dd40d51a2f760ec_go_back_icon_clip_art_at_clkercom_vector_clip_art_online__300_300;
            this.pBReturn.Location = new System.Drawing.Point(12, 12);
            this.pBReturn.Name = "pBReturn";
            this.pBReturn.Size = new System.Drawing.Size(29, 28);
            this.pBReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBReturn.TabIndex = 22;
            this.pBReturn.TabStop = false;
            this.pBReturn.Click += new System.EventHandler(this.pBReturn_Click);
            // 
            // lVolumeLevel
            // 
            this.lVolumeLevel.AutoSize = true;
            this.lVolumeLevel.BackColor = System.Drawing.Color.Transparent;
            this.lVolumeLevel.Font = new System.Drawing.Font("Kristen ITC", 15F);
            this.lVolumeLevel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lVolumeLevel.Location = new System.Drawing.Point(42, 52);
            this.lVolumeLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lVolumeLevel.Name = "lVolumeLevel";
            this.lVolumeLevel.Size = new System.Drawing.Size(139, 28);
            this.lVolumeLevel.TabIndex = 76;
            this.lVolumeLevel.Text = "Volume level:";
            // 
            // nUDVolumeLevel
            // 
            this.nUDVolumeLevel.BackColor = System.Drawing.SystemColors.Control;
            this.nUDVolumeLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nUDVolumeLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUDVolumeLevel.Location = new System.Drawing.Point(45, 0);
            this.nUDVolumeLevel.Name = "nUDVolumeLevel";
            this.nUDVolumeLevel.Size = new System.Drawing.Size(57, 26);
            this.nUDVolumeLevel.TabIndex = 77;
            this.nUDVolumeLevel.ValueChanged += new System.EventHandler(this.nUDVolumeLevel_ValueChanged);
            // 
            // pUsername
            // 
            this.pUsername.Controls.Add(this.pUsernameImage);
            this.pUsername.Controls.Add(this.nUDVolumeLevel);
            this.pUsername.Location = new System.Drawing.Point(196, 52);
            this.pUsername.Name = "pUsername";
            this.pUsername.Size = new System.Drawing.Size(102, 28);
            this.pUsername.TabIndex = 78;
            // 
            // pUsernameImage
            // 
            this.pUsernameImage.BackColor = System.Drawing.Color.IndianRed;
            this.pUsernameImage.Controls.Add(this.pictureBox3);
            this.pUsernameImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pUsernameImage.Location = new System.Drawing.Point(0, 0);
            this.pUsernameImage.Name = "pUsernameImage";
            this.pUsernameImage.Size = new System.Drawing.Size(35, 28);
            this.pUsernameImage.TabIndex = 10;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::ProjetoDamas.Properties.Resources.Volume_icon;
            this.pictureBox3.Location = new System.Drawing.Point(4, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // lWindowSize
            // 
            this.lWindowSize.AutoSize = true;
            this.lWindowSize.BackColor = System.Drawing.Color.Transparent;
            this.lWindowSize.Font = new System.Drawing.Font("Kristen ITC", 15F);
            this.lWindowSize.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lWindowSize.Location = new System.Drawing.Point(42, 100);
            this.lWindowSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lWindowSize.Name = "lWindowSize";
            this.lWindowSize.Size = new System.Drawing.Size(138, 28);
            this.lWindowSize.TabIndex = 79;
            this.lWindowSize.Text = "Window size:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cBWindowSize);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(196, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 28);
            this.panel1.TabIndex = 79;
            // 
            // cBWindowSize
            // 
            this.cBWindowSize.BackColor = System.Drawing.SystemColors.Control;
            this.cBWindowSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBWindowSize.Font = new System.Drawing.Font("Malgun Gothic", 10F);
            this.cBWindowSize.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cBWindowSize.FormattingEnabled = true;
            this.cBWindowSize.Items.AddRange(new object[] {
            "Short",
            "Medium",
            "Big"});
            this.cBWindowSize.Location = new System.Drawing.Point(34, 2);
            this.cBWindowSize.Name = "cBWindowSize";
            this.cBWindowSize.Size = new System.Drawing.Size(115, 25);
            this.cBWindowSize.TabIndex = 1;
            this.cBWindowSize.Text = "Medium";
            this.cBWindowSize.SelectedIndexChanged += new System.EventHandler(this.cBWindowSize_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(35, 28);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ProjetoDamas.Properties.Resources.Window_size;
            this.pictureBox2.Location = new System.Drawing.Point(4, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // ViewSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoDamas.Properties.Resources.back_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(522, 314);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lWindowSize);
            this.Controls.Add(this.pUsername);
            this.Controls.Add(this.lVolumeLevel);
            this.Controls.Add(this.pBReturn);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewSettings";
            this.Text = "Checkers";
            ((System.ComponentModel.ISupportInitialize)(this.pBReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDVolumeLevel)).EndInit();
            this.pUsername.ResumeLayout(false);
            this.pUsernameImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBReturn;
        private System.Windows.Forms.Label lVolumeLevel;
        private System.Windows.Forms.NumericUpDown nUDVolumeLevel;
        private System.Windows.Forms.Panel pUsername;
        private System.Windows.Forms.Panel pUsernameImage;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lWindowSize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cBWindowSize;
    }
}