namespace ProjetoDamas
{
    partial class ViewJogadorOponente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewJogadorOponente));
            this.lGameOponnent = new System.Windows.Forms.Label();
            this.pbReturn = new System.Windows.Forms.PictureBox();
            this.pOptionPlay = new System.Windows.Forms.Panel();
            this.pPassword = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cTBPassword = new ProjetoDamas.CueTextBox();
            this.bSelectUser = new System.Windows.Forms.Button();
            this.pNickname = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cTBUsername = new ProjetoDamas.CueTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).BeginInit();
            this.pOptionPlay.SuspendLayout();
            this.pPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pNickname.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lGameOponnent
            // 
            this.lGameOponnent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lGameOponnent.AutoSize = true;
            this.lGameOponnent.BackColor = System.Drawing.Color.Transparent;
            this.lGameOponnent.Font = new System.Drawing.Font("Matura MT Script Capitals", 25F);
            this.lGameOponnent.ForeColor = System.Drawing.Color.DimGray;
            this.lGameOponnent.Location = new System.Drawing.Point(174, 9);
            this.lGameOponnent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lGameOponnent.Name = "lGameOponnent";
            this.lGameOponnent.Size = new System.Drawing.Size(258, 45);
            this.lGameOponnent.TabIndex = 15;
            this.lGameOponnent.Text = "Game Oponnent";
            // 
            // pbReturn
            // 
            this.pbReturn.BackColor = System.Drawing.Color.Transparent;
            this.pbReturn.Image = global::ProjetoDamas.Properties.Resources.a429924cb33912470dd40d51a2f760ec_go_back_icon_clip_art_at_clkercom_vector_clip_art_online__300_300;
            this.pbReturn.Location = new System.Drawing.Point(12, 12);
            this.pbReturn.Name = "pbReturn";
            this.pbReturn.Size = new System.Drawing.Size(29, 28);
            this.pbReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbReturn.TabIndex = 24;
            this.pbReturn.TabStop = false;
            this.pbReturn.Click += new System.EventHandler(this.pbReturn_Click);
            // 
            // pOptionPlay
            // 
            this.pOptionPlay.BackColor = System.Drawing.Color.Transparent;
            this.pOptionPlay.Controls.Add(this.pPassword);
            this.pOptionPlay.Controls.Add(this.bSelectUser);
            this.pOptionPlay.Controls.Add(this.pNickname);
            this.pOptionPlay.Location = new System.Drawing.Point(140, 75);
            this.pOptionPlay.Name = "pOptionPlay";
            this.pOptionPlay.Size = new System.Drawing.Size(329, 301);
            this.pOptionPlay.TabIndex = 21;
            // 
            // pPassword
            // 
            this.pPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pPassword.BackColor = System.Drawing.Color.White;
            this.pPassword.Controls.Add(this.pictureBox1);
            this.pPassword.Controls.Add(this.panel6);
            this.pPassword.Controls.Add(this.cTBPassword);
            this.pPassword.Location = new System.Drawing.Point(15, 79);
            this.pPassword.Name = "pPassword";
            this.pPassword.Size = new System.Drawing.Size(302, 32);
            this.pPassword.TabIndex = 61;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoDamas.Properties.Resources.Olho_icon;
            this.pictureBox1.Location = new System.Drawing.Point(271, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(42, 32);
            this.panel6.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ProjetoDamas.Properties.Resources.Lock_transparente;
            this.pictureBox2.Location = new System.Drawing.Point(2, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // cTBPassword
            // 
            this.cTBPassword.BackColor = System.Drawing.SystemColors.Control;
            this.cTBPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cTBPassword.Cue = "Password";
            this.cTBPassword.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTBPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cTBPassword.Location = new System.Drawing.Point(45, 3);
            this.cTBPassword.MaxLength = 20;
            this.cTBPassword.Name = "cTBPassword";
            this.cTBPassword.PasswordChar = '*';
            this.cTBPassword.Size = new System.Drawing.Size(220, 22);
            this.cTBPassword.TabIndex = 16;
            // 
            // bSelectUser
            // 
            this.bSelectUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bSelectUser.BackColor = System.Drawing.Color.Transparent;
            this.bSelectUser.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.bSelectUser.FlatAppearance.BorderSize = 0;
            this.bSelectUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSelectUser.Font = new System.Drawing.Font("Kristen ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSelectUser.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bSelectUser.Location = new System.Drawing.Point(17, 180);
            this.bSelectUser.Margin = new System.Windows.Forms.Padding(2);
            this.bSelectUser.Name = "bSelectUser";
            this.bSelectUser.Size = new System.Drawing.Size(275, 38);
            this.bSelectUser.TabIndex = 18;
            this.bSelectUser.Text = "Select User";
            this.bSelectUser.UseVisualStyleBackColor = false;
            this.bSelectUser.Click += new System.EventHandler(this.bSelectUser_Click);
            // 
            // pNickname
            // 
            this.pNickname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pNickname.BackColor = System.Drawing.Color.White;
            this.pNickname.Controls.Add(this.panel8);
            this.pNickname.Controls.Add(this.cTBUsername);
            this.pNickname.Location = new System.Drawing.Point(15, 32);
            this.pNickname.Name = "pNickname";
            this.pNickname.Size = new System.Drawing.Size(302, 32);
            this.pNickname.TabIndex = 60;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel8.Controls.Add(this.pictureBox3);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(42, 32);
            this.panel8.TabIndex = 10;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(2, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // cTBUsername
            // 
            this.cTBUsername.BackColor = System.Drawing.SystemColors.Control;
            this.cTBUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cTBUsername.Cue = "Username";
            this.cTBUsername.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTBUsername.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cTBUsername.Location = new System.Drawing.Point(45, 3);
            this.cTBUsername.MaxLength = 20;
            this.cTBUsername.Name = "cTBUsername";
            this.cTBUsername.Size = new System.Drawing.Size(254, 22);
            this.cTBUsername.TabIndex = 16;
            // 
            // ViewJogadorOponente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoDamas.Properties.Resources.back_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.pbReturn);
            this.Controls.Add(this.pOptionPlay);
            this.Controls.Add(this.lGameOponnent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewJogadorOponente";
            this.Text = "Checkers";
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).EndInit();
            this.pOptionPlay.ResumeLayout(false);
            this.pPassword.ResumeLayout(false);
            this.pPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pNickname.ResumeLayout(false);
            this.pNickname.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lGameOponnent;
        private System.Windows.Forms.PictureBox pbReturn;
        private System.Windows.Forms.Panel pOptionPlay;
        private System.Windows.Forms.Panel pPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CueTextBox cTBPassword;
        private System.Windows.Forms.Button bSelectUser;
        private System.Windows.Forms.Panel pNickname;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private CueTextBox cTBUsername;
    }
}