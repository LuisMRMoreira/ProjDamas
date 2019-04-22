namespace ProjetoDamas
{
    partial class ViewMenuMoreInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMenuMoreInfo));
            this.bHistory = new System.Windows.Forms.Button();
            this.bRanks = new System.Windows.Forms.Button();
            this.bRegras = new System.Windows.Forms.Button();
            this.bSettings = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bHistory
            // 
            this.bHistory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bHistory.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHistory.ForeColor = System.Drawing.Color.Black;
            this.bHistory.Location = new System.Drawing.Point(239, 66);
            this.bHistory.Name = "bHistory";
            this.bHistory.Size = new System.Drawing.Size(115, 37);
            this.bHistory.TabIndex = 11;
            this.bHistory.Text = "History";
            this.bHistory.UseVisualStyleBackColor = false;
            this.bHistory.Click += new System.EventHandler(this.bHistory_Click);
            // 
            // bRanks
            // 
            this.bRanks.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bRanks.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bRanks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRanks.ForeColor = System.Drawing.Color.Black;
            this.bRanks.Location = new System.Drawing.Point(34, 66);
            this.bRanks.Name = "bRanks";
            this.bRanks.Size = new System.Drawing.Size(115, 37);
            this.bRanks.TabIndex = 12;
            this.bRanks.Text = "Ranks";
            this.bRanks.UseVisualStyleBackColor = false;
            this.bRanks.Click += new System.EventHandler(this.bRanks_Click);
            // 
            // bRegras
            // 
            this.bRegras.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bRegras.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bRegras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRegras.ForeColor = System.Drawing.Color.Black;
            this.bRegras.Location = new System.Drawing.Point(34, 142);
            this.bRegras.Name = "bRegras";
            this.bRegras.Size = new System.Drawing.Size(115, 37);
            this.bRegras.TabIndex = 13;
            this.bRegras.Text = "Rules";
            this.bRegras.UseVisualStyleBackColor = false;
            this.bRegras.Click += new System.EventHandler(this.bRegras_Click);
            // 
            // bSettings
            // 
            this.bSettings.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bSettings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSettings.ForeColor = System.Drawing.Color.Black;
            this.bSettings.Location = new System.Drawing.Point(239, 142);
            this.bSettings.Name = "bSettings";
            this.bSettings.Size = new System.Drawing.Size(115, 37);
            this.bSettings.TabIndex = 14;
            this.bSettings.Text = "Settings";
            this.bSettings.UseVisualStyleBackColor = false;
            this.bSettings.Click += new System.EventHandler(this.bSettings_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProjetoDamas.Properties.Resources.a429924cb33912470dd40d51a2f760ec_go_back_icon_clip_art_at_clkercom_vector_clip_art_online__300_300;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ViewMenuMoreInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoDamas.Properties.Resources.imagemDeFundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 337);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bSettings);
            this.Controls.Add(this.bRegras);
            this.Controls.Add(this.bRanks);
            this.Controls.Add(this.bHistory);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewMenuMoreInfo";
            this.Text = "Checkers";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bHistory;
        private System.Windows.Forms.Button bRanks;
        private System.Windows.Forms.Button bRegras;
        private System.Windows.Forms.Button bSettings;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}