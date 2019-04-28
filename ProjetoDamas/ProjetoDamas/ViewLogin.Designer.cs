namespace ProjetoDamas
{
    partial class ViewLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewLogin));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lUsername = new System.Windows.Forms.Label();
            this.pUsername = new System.Windows.Forms.Panel();
            this.pUsernameImage = new System.Windows.Forms.Panel();
            this.ctBUsername = new ProjetoDamas.CueTextBox();
            this.lMemberLogin = new System.Windows.Forms.Label();
            this.pPassword = new System.Windows.Forms.Panel();
            this.cTBPassword = new ProjetoDamas.CueTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pPasswordImage = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.pbReturn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pUsername.SuspendLayout();
            this.pUsernameImage.SuspendLayout();
            this.pPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pPasswordImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Kristen ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonLogin.Location = new System.Drawing.Point(181, 276);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(134, 38);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRegister.BackColor = System.Drawing.Color.Transparent;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Kristen ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonRegister.Location = new System.Drawing.Point(329, 276);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(119, 38);
            this.buttonRegister.TabIndex = 7;
            this.buttonRegister.Text = "Regist";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lUsername
            // 
            this.lUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lUsername.AutoSize = true;
            this.lUsername.BackColor = System.Drawing.Color.Transparent;
            this.lUsername.Font = new System.Drawing.Font("Kristen ITC", 15F);
            this.lUsername.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lUsername.Location = new System.Drawing.Point(176, 109);
            this.lUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(114, 28);
            this.lUsername.TabIndex = 11;
            this.lUsername.Text = "Username:";
            // 
            // pUsername
            // 
            this.pUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pUsername.Controls.Add(this.pUsernameImage);
            this.pUsername.Controls.Add(this.ctBUsername);
            this.pUsername.Location = new System.Drawing.Point(181, 138);
            this.pUsername.Name = "pUsername";
            this.pUsername.Size = new System.Drawing.Size(267, 32);
            this.pUsername.TabIndex = 12;
            // 
            // pUsernameImage
            // 
            this.pUsernameImage.BackColor = System.Drawing.Color.IndianRed;
            this.pUsernameImage.Controls.Add(this.pictureBox1);
            this.pUsernameImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pUsernameImage.Location = new System.Drawing.Point(0, 0);
            this.pUsernameImage.Name = "pUsernameImage";
            this.pUsernameImage.Size = new System.Drawing.Size(42, 32);
            this.pUsernameImage.TabIndex = 10;
            // 
            // ctBUsername
            // 
            this.ctBUsername.BackColor = System.Drawing.SystemColors.Control;
            this.ctBUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ctBUsername.Cue = "Username";
            this.ctBUsername.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctBUsername.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ctBUsername.Location = new System.Drawing.Point(45, 3);
            this.ctBUsername.MaxLength = 20;
            this.ctBUsername.Name = "ctBUsername";
            this.ctBUsername.Size = new System.Drawing.Size(219, 22);
            this.ctBUsername.TabIndex = 16;
            // 
            // lMemberLogin
            // 
            this.lMemberLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lMemberLogin.AutoSize = true;
            this.lMemberLogin.BackColor = System.Drawing.Color.Transparent;
            this.lMemberLogin.Font = new System.Drawing.Font("Matura MT Script Capitals", 25F);
            this.lMemberLogin.ForeColor = System.Drawing.Color.DimGray;
            this.lMemberLogin.Location = new System.Drawing.Point(183, 9);
            this.lMemberLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lMemberLogin.Name = "lMemberLogin";
            this.lMemberLogin.Size = new System.Drawing.Size(262, 45);
            this.lMemberLogin.TabIndex = 14;
            this.lMemberLogin.Text = "Member Login";
            // 
            // pPassword
            // 
            this.pPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pPassword.Controls.Add(this.cTBPassword);
            this.pPassword.Controls.Add(this.pictureBox2);
            this.pPassword.Controls.Add(this.pPasswordImage);
            this.pPassword.Location = new System.Drawing.Point(181, 220);
            this.pPassword.Name = "pPassword";
            this.pPassword.Size = new System.Drawing.Size(267, 32);
            this.pPassword.TabIndex = 13;
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
            this.cTBPassword.Size = new System.Drawing.Size(185, 22);
            this.cTBPassword.TabIndex = 17;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjetoDamas.Properties.Resources.Olho_icon;
            this.pictureBox2.Location = new System.Drawing.Point(236, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // pPasswordImage
            // 
            this.pPasswordImage.BackColor = System.Drawing.Color.NavajoWhite;
            this.pPasswordImage.Controls.Add(this.pictureBox3);
            this.pPasswordImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pPasswordImage.Location = new System.Drawing.Point(0, 0);
            this.pPasswordImage.Name = "pPasswordImage";
            this.pPasswordImage.Size = new System.Drawing.Size(42, 32);
            this.pPasswordImage.TabIndex = 10;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::ProjetoDamas.Properties.Resources.Lock_transparente;
            this.pictureBox3.Location = new System.Drawing.Point(2, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Kristen ITC", 15F);
            this.labelPassword.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelPassword.Location = new System.Drawing.Point(180, 191);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(111, 28);
            this.labelPassword.TabIndex = 15;
            this.labelPassword.Text = "Password:";
            // 
            // pbReturn
            // 
            this.pbReturn.BackColor = System.Drawing.Color.Transparent;
            this.pbReturn.Image = global::ProjetoDamas.Properties.Resources.a429924cb33912470dd40d51a2f760ec_go_back_icon_clip_art_at_clkercom_vector_clip_art_online__300_300;
            this.pbReturn.Location = new System.Drawing.Point(12, 12);
            this.pbReturn.Name = "pbReturn";
            this.pbReturn.Size = new System.Drawing.Size(29, 28);
            this.pbReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReturn.TabIndex = 22;
            this.pbReturn.TabStop = false;
            this.pbReturn.Click += new System.EventHandler(this.pbReturn_Click);
            // 
            // ViewLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::ProjetoDamas.Properties.Resources.back_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.pbReturn);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.pPassword);
            this.Controls.Add(this.lMemberLogin);
            this.Controls.Add(this.pUsername);
            this.Controls.Add(this.lUsername);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonLogin);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(374, 342);
            this.Name = "ViewLogin";
            this.Text = "Checkers";
            this.Load += new System.EventHandler(this.ViewLogin_Load);
            this.Shown += new System.EventHandler(this.ViewLogin_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pUsername.ResumeLayout(false);
            this.pUsername.PerformLayout();
            this.pUsernameImage.ResumeLayout(false);
            this.pPassword.ResumeLayout(false);
            this.pPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pPasswordImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.Panel pUsername;
        private System.Windows.Forms.Panel pUsernameImage;
        private System.Windows.Forms.Label lMemberLogin;
        private System.Windows.Forms.Panel pPassword;
        private System.Windows.Forms.Panel pPasswordImage;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelPassword;
        private CueTextBox ctBUsername;
        private CueTextBox cTBPassword;
        private System.Windows.Forms.PictureBox pbReturn;
    }
}

