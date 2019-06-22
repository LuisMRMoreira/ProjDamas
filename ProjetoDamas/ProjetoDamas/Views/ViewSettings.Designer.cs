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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSettings));
            this.pBReturn = new System.Windows.Forms.PictureBox();
            this.lVolumeLevel = new System.Windows.Forms.Label();
            this.pVolumeLevel = new System.Windows.Forms.Panel();
            this.tBVolumeLevel = new System.Windows.Forms.TrackBar();
            this.pVolumeLevelImage = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lWindowSize = new System.Windows.Forms.Label();
            this.pWindowSize = new System.Windows.Forms.Panel();
            this.cBWindowSize = new System.Windows.Forms.ComboBox();
            this.pWindowSizeImage = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pBGuardar = new System.Windows.Forms.PictureBox();
            this.pBCheckGuardado = new System.Windows.Forms.PictureBox();
            this.tTReturn = new System.Windows.Forms.ToolTip(this.components);
            this.tTSaved = new System.Windows.Forms.ToolTip(this.components);
            this.tTSave = new System.Windows.Forms.ToolTip(this.components);
            this.lBotLevel = new System.Windows.Forms.Label();
            this.pBotLevel = new System.Windows.Forms.Panel();
            this.cBBotLevel = new System.Windows.Forms.ComboBox();
            this.pBotLevelImage = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBReturn)).BeginInit();
            this.pVolumeLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBVolumeLevel)).BeginInit();
            this.pVolumeLevelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pWindowSize.SuspendLayout();
            this.pWindowSizeImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCheckGuardado)).BeginInit();
            this.pBotLevel.SuspendLayout();
            this.pBotLevelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tTSaved.SetToolTip(this.pBReturn, "Return");
            this.pBReturn.Click += new System.EventHandler(this.pBReturn_Click);
            // 
            // lVolumeLevel
            // 
            this.lVolumeLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lVolumeLevel.AutoSize = true;
            this.lVolumeLevel.BackColor = System.Drawing.Color.Transparent;
            this.lVolumeLevel.Font = new System.Drawing.Font("Kristen ITC", 15F);
            this.lVolumeLevel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lVolumeLevel.Location = new System.Drawing.Point(155, 132);
            this.lVolumeLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lVolumeLevel.Name = "lVolumeLevel";
            this.lVolumeLevel.Size = new System.Drawing.Size(139, 28);
            this.lVolumeLevel.TabIndex = 76;
            this.lVolumeLevel.Text = "Volume level:";
            // 
            // pVolumeLevel
            // 
            this.pVolumeLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pVolumeLevel.Controls.Add(this.tBVolumeLevel);
            this.pVolumeLevel.Controls.Add(this.pVolumeLevelImage);
            this.pVolumeLevel.Location = new System.Drawing.Point(309, 132);
            this.pVolumeLevel.Name = "pVolumeLevel";
            this.pVolumeLevel.Size = new System.Drawing.Size(149, 47);
            this.pVolumeLevel.TabIndex = 78;
            // 
            // tBVolumeLevel
            // 
            this.tBVolumeLevel.Location = new System.Drawing.Point(35, 1);
            this.tBVolumeLevel.Name = "tBVolumeLevel";
            this.tBVolumeLevel.Size = new System.Drawing.Size(113, 45);
            this.tBVolumeLevel.TabIndex = 84;
            this.tBVolumeLevel.ValueChanged += new System.EventHandler(this.tBVolumeLevel_ValueChanged);
            // 
            // pVolumeLevelImage
            // 
            this.pVolumeLevelImage.BackColor = System.Drawing.Color.IndianRed;
            this.pVolumeLevelImage.Controls.Add(this.pictureBox3);
            this.pVolumeLevelImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pVolumeLevelImage.Location = new System.Drawing.Point(0, 0);
            this.pVolumeLevelImage.Name = "pVolumeLevelImage";
            this.pVolumeLevelImage.Size = new System.Drawing.Size(35, 47);
            this.pVolumeLevelImage.TabIndex = 10;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::ProjetoDamas.Properties.Resources.Volume_icon;
            this.pictureBox3.Location = new System.Drawing.Point(4, 8);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // lWindowSize
            // 
            this.lWindowSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lWindowSize.AutoSize = true;
            this.lWindowSize.BackColor = System.Drawing.Color.Transparent;
            this.lWindowSize.Font = new System.Drawing.Font("Kristen ITC", 15F);
            this.lWindowSize.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lWindowSize.Location = new System.Drawing.Point(155, 200);
            this.lWindowSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lWindowSize.Name = "lWindowSize";
            this.lWindowSize.Size = new System.Drawing.Size(138, 28);
            this.lWindowSize.TabIndex = 79;
            this.lWindowSize.Text = "Window size:";
            // 
            // pWindowSize
            // 
            this.pWindowSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pWindowSize.Controls.Add(this.cBWindowSize);
            this.pWindowSize.Controls.Add(this.pWindowSizeImage);
            this.pWindowSize.Location = new System.Drawing.Point(309, 200);
            this.pWindowSize.Name = "pWindowSize";
            this.pWindowSize.Size = new System.Drawing.Size(149, 36);
            this.pWindowSize.TabIndex = 79;
            // 
            // cBWindowSize
            // 
            this.cBWindowSize.BackColor = System.Drawing.SystemColors.Control;
            this.cBWindowSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBWindowSize.Font = new System.Drawing.Font("Malgun Gothic", 14F);
            this.cBWindowSize.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cBWindowSize.FormattingEnabled = true;
            this.cBWindowSize.Items.AddRange(new object[] {
            "Short",
            "Medium",
            "Big"});
            this.cBWindowSize.Location = new System.Drawing.Point(34, 2);
            this.cBWindowSize.Name = "cBWindowSize";
            this.cBWindowSize.Size = new System.Drawing.Size(115, 33);
            this.cBWindowSize.TabIndex = 1;
            this.cBWindowSize.Text = "Medium";
            this.cBWindowSize.SelectedIndexChanged += new System.EventHandler(this.cBWindowSize_SelectedIndexChanged);
            // 
            // pWindowSizeImage
            // 
            this.pWindowSizeImage.BackColor = System.Drawing.Color.NavajoWhite;
            this.pWindowSizeImage.Controls.Add(this.pictureBox2);
            this.pWindowSizeImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pWindowSizeImage.Location = new System.Drawing.Point(0, 0);
            this.pWindowSizeImage.Name = "pWindowSizeImage";
            this.pWindowSizeImage.Size = new System.Drawing.Size(35, 36);
            this.pWindowSizeImage.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ProjetoDamas.Properties.Resources.Window_size;
            this.pictureBox2.Location = new System.Drawing.Point(4, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pBGuardar
            // 
            this.pBGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pBGuardar.BackColor = System.Drawing.Color.Transparent;
            this.pBGuardar.Image = global::ProjetoDamas.Properties.Resources.Save_icon;
            this.pBGuardar.Location = new System.Drawing.Point(591, 12);
            this.pBGuardar.Name = "pBGuardar";
            this.pBGuardar.Size = new System.Drawing.Size(31, 29);
            this.pBGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBGuardar.TabIndex = 80;
            this.pBGuardar.TabStop = false;
            this.tTSave.SetToolTip(this.pBGuardar, "Save");
            this.pBGuardar.Click += new System.EventHandler(this.pBGuardar_Click);
            // 
            // pBCheckGuardado
            // 
            this.pBCheckGuardado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pBCheckGuardado.BackColor = System.Drawing.Color.Transparent;
            this.pBCheckGuardado.Image = global::ProjetoDamas.Properties.Resources.Check1;
            this.pBCheckGuardado.Location = new System.Drawing.Point(554, 11);
            this.pBCheckGuardado.Name = "pBCheckGuardado";
            this.pBCheckGuardado.Size = new System.Drawing.Size(31, 29);
            this.pBCheckGuardado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBCheckGuardado.TabIndex = 81;
            this.pBCheckGuardado.TabStop = false;
            this.tTSaved.SetToolTip(this.pBCheckGuardado, "Saved");
            // 
            // lBotLevel
            // 
            this.lBotLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lBotLevel.AutoSize = true;
            this.lBotLevel.BackColor = System.Drawing.Color.Transparent;
            this.lBotLevel.Font = new System.Drawing.Font("Kristen ITC", 15F);
            this.lBotLevel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lBotLevel.Location = new System.Drawing.Point(155, 262);
            this.lBotLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lBotLevel.Name = "lBotLevel";
            this.lBotLevel.Size = new System.Drawing.Size(102, 28);
            this.lBotLevel.TabIndex = 82;
            this.lBotLevel.Text = "Bot level:";
            // 
            // pBotLevel
            // 
            this.pBotLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pBotLevel.Controls.Add(this.cBBotLevel);
            this.pBotLevel.Controls.Add(this.pBotLevelImage);
            this.pBotLevel.Location = new System.Drawing.Point(308, 262);
            this.pBotLevel.Name = "pBotLevel";
            this.pBotLevel.Size = new System.Drawing.Size(150, 36);
            this.pBotLevel.TabIndex = 83;
            // 
            // cBBotLevel
            // 
            this.cBBotLevel.BackColor = System.Drawing.SystemColors.Control;
            this.cBBotLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBBotLevel.Font = new System.Drawing.Font("Malgun Gothic", 14F);
            this.cBBotLevel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cBBotLevel.FormattingEnabled = true;
            this.cBBotLevel.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "Hard",
            "Thank you next"});
            this.cBBotLevel.Location = new System.Drawing.Point(34, 2);
            this.cBBotLevel.Name = "cBBotLevel";
            this.cBBotLevel.Size = new System.Drawing.Size(115, 33);
            this.cBBotLevel.TabIndex = 1;
            this.cBBotLevel.Text = "Medium";
            this.cBBotLevel.SelectedIndexChanged += new System.EventHandler(this.cBBotLevel_SelectedIndexChanged);
            // 
            // pBotLevelImage
            // 
            this.pBotLevelImage.BackColor = System.Drawing.Color.LightSlateGray;
            this.pBotLevelImage.Controls.Add(this.pictureBox1);
            this.pBotLevelImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pBotLevelImage.Location = new System.Drawing.Point(0, 0);
            this.pBotLevelImage.Name = "pBotLevelImage";
            this.pBotLevelImage.Size = new System.Drawing.Size(35, 36);
            this.pBotLevelImage.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProjetoDamas.Properties.Resources.Icon_Level_icon;
            this.pictureBox1.Location = new System.Drawing.Point(4, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // ViewSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoDamas.Properties.Resources.back_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.pBotLevel);
            this.Controls.Add(this.lBotLevel);
            this.Controls.Add(this.pBCheckGuardado);
            this.Controls.Add(this.pBGuardar);
            this.Controls.Add(this.pWindowSize);
            this.Controls.Add(this.lWindowSize);
            this.Controls.Add(this.pVolumeLevel);
            this.Controls.Add(this.lVolumeLevel);
            this.Controls.Add(this.pBReturn);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(362, 286);
            this.Name = "ViewSettings";
            this.Text = "Checkers";
            this.Load += new System.EventHandler(this.ViewSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBReturn)).EndInit();
            this.pVolumeLevel.ResumeLayout(false);
            this.pVolumeLevel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBVolumeLevel)).EndInit();
            this.pVolumeLevelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pWindowSize.ResumeLayout(false);
            this.pWindowSizeImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCheckGuardado)).EndInit();
            this.pBotLevel.ResumeLayout(false);
            this.pBotLevelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBReturn;
        private System.Windows.Forms.Label lVolumeLevel;
        private System.Windows.Forms.Panel pVolumeLevel;
        private System.Windows.Forms.Panel pVolumeLevelImage;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lWindowSize;
        private System.Windows.Forms.Panel pWindowSize;
        private System.Windows.Forms.Panel pWindowSizeImage;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cBWindowSize;
        private System.Windows.Forms.PictureBox pBGuardar;
        private System.Windows.Forms.PictureBox pBCheckGuardado;
        private System.Windows.Forms.ToolTip tTSaved;
        private System.Windows.Forms.ToolTip tTSave;
        private System.Windows.Forms.ToolTip tTReturn;
        private System.Windows.Forms.Label lBotLevel;
        private System.Windows.Forms.Panel pBotLevel;
        private System.Windows.Forms.ComboBox cBBotLevel;
        private System.Windows.Forms.Panel pBotLevelImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar tBVolumeLevel;
    }
}