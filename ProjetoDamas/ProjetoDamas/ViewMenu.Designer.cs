namespace ProjetoDamas
{
    partial class ViewMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMenu));
            this.buttonjogar = new System.Windows.Forms.Button();
            this.bContinueGame = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.lInfo = new System.Windows.Forms.Label();
            this.bGameInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonjogar
            // 
            this.buttonjogar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonjogar.Location = new System.Drawing.Point(27, 37);
            this.buttonjogar.Name = "buttonjogar";
            this.buttonjogar.Size = new System.Drawing.Size(116, 34);
            this.buttonjogar.TabIndex = 1;
            this.buttonjogar.Text = "New Game";
            this.buttonjogar.UseVisualStyleBackColor = true;
            this.buttonjogar.Click += new System.EventHandler(this.button1_Click);
            // 
            // bContinueGame
            // 
            this.bContinueGame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bContinueGame.Location = new System.Drawing.Point(27, 77);
            this.bContinueGame.Name = "bContinueGame";
            this.bContinueGame.Size = new System.Drawing.Size(116, 36);
            this.bContinueGame.TabIndex = 4;
            this.bContinueGame.Text = "Continue Game";
            this.bContinueGame.UseVisualStyleBackColor = true;
            this.bContinueGame.Click += new System.EventHandler(this.bContinueGame_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.ForeColor = System.Drawing.Color.Black;
            this.buttonProfile.Location = new System.Drawing.Point(28, 119);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(115, 37);
            this.buttonProfile.TabIndex = 5;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // lInfo
            // 
            this.lInfo.AutoSize = true;
            this.lInfo.Location = new System.Drawing.Point(161, 77);
            this.lInfo.Name = "lInfo";
            this.lInfo.Size = new System.Drawing.Size(495, 13);
            this.lInfo.TabIndex = 6;
            this.lInfo.Text = "Informações de jogos. Quem ganhou o último jogo, entre quem foi jogado. Ranking. " +
    "E histotico de jogos";
            // 
            // bGameInfo
            // 
            this.bGameInfo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bGameInfo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bGameInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGameInfo.ForeColor = System.Drawing.Color.Black;
            this.bGameInfo.Location = new System.Drawing.Point(28, 162);
            this.bGameInfo.Name = "bGameInfo";
            this.bGameInfo.Size = new System.Drawing.Size(115, 37);
            this.bGameInfo.TabIndex = 12;
            this.bGameInfo.Text = "Game Info";
            this.bGameInfo.UseVisualStyleBackColor = false;
            this.bGameInfo.Click += new System.EventHandler(this.bGameInfo_Click);
            // 
            // ViewMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(509, 305);
            this.Controls.Add(this.bGameInfo);
            this.Controls.Add(this.lInfo);
            this.Controls.Add(this.buttonProfile);
            this.Controls.Add(this.bContinueGame);
            this.Controls.Add(this.buttonjogar);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Olive;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewMenu";
            this.Text = "Checkers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonjogar;
        private System.Windows.Forms.Button bContinueGame;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Label lInfo;
        private System.Windows.Forms.Button bGameInfo;
    }
}

