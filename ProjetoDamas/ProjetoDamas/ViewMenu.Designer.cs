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
            this.pPainelOpcoes = new System.Windows.Forms.Panel();
            this.bGameInfo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pPainelOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonjogar
            // 
            this.buttonjogar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonjogar.FlatAppearance.BorderSize = 0;
            this.buttonjogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonjogar.Font = new System.Drawing.Font("Matura MT Script Capitals", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonjogar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonjogar.Location = new System.Drawing.Point(0, 25);
            this.buttonjogar.Name = "buttonjogar";
            this.buttonjogar.Size = new System.Drawing.Size(203, 44);
            this.buttonjogar.TabIndex = 1;
            this.buttonjogar.Text = "New Game";
            this.buttonjogar.UseVisualStyleBackColor = true;
            this.buttonjogar.Click += new System.EventHandler(this.button1_Click);
            // 
            // bContinueGame
            // 
            this.bContinueGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bContinueGame.FlatAppearance.BorderSize = 0;
            this.bContinueGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bContinueGame.Font = new System.Drawing.Font("Matura MT Script Capitals", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bContinueGame.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bContinueGame.Location = new System.Drawing.Point(0, 75);
            this.bContinueGame.Name = "bContinueGame";
            this.bContinueGame.Size = new System.Drawing.Size(203, 47);
            this.bContinueGame.TabIndex = 4;
            this.bContinueGame.Text = "Continue Game";
            this.bContinueGame.UseVisualStyleBackColor = true;
            this.bContinueGame.Click += new System.EventHandler(this.bContinueGame_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonProfile.FlatAppearance.BorderSize = 0;
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Font = new System.Drawing.Font("Matura MT Script Capitals", 20F);
            this.buttonProfile.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonProfile.Location = new System.Drawing.Point(0, 128);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(203, 37);
            this.buttonProfile.TabIndex = 5;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // pPainelOpcoes
            // 
            this.pPainelOpcoes.BackColor = System.Drawing.Color.Transparent;
            this.pPainelOpcoes.Controls.Add(this.bGameInfo);
            this.pPainelOpcoes.Controls.Add(this.buttonjogar);
            this.pPainelOpcoes.Controls.Add(this.bContinueGame);
            this.pPainelOpcoes.Controls.Add(this.buttonProfile);
            this.pPainelOpcoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.pPainelOpcoes.Location = new System.Drawing.Point(0, 0);
            this.pPainelOpcoes.Name = "pPainelOpcoes";
            this.pPainelOpcoes.Size = new System.Drawing.Size(203, 301);
            this.pPainelOpcoes.TabIndex = 13;
            // 
            // bGameInfo
            // 
            this.bGameInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bGameInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bGameInfo.FlatAppearance.BorderSize = 0;
            this.bGameInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGameInfo.Font = new System.Drawing.Font("Matura MT Script Capitals", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGameInfo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bGameInfo.Location = new System.Drawing.Point(0, 181);
            this.bGameInfo.Name = "bGameInfo";
            this.bGameInfo.Size = new System.Drawing.Size(203, 37);
            this.bGameInfo.TabIndex = 6;
            this.bGameInfo.Text = "Game Info";
            this.bGameInfo.UseVisualStyleBackColor = true;
            this.bGameInfo.Click += new System.EventHandler(this.bGameInfo_Click_2);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Matura MT Script Capitals", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.Location = new System.Drawing.Point(439, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ViewMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = global::ProjetoDamas.Properties.Resources.back_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(543, 301);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pPainelOpcoes);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Olive;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewMenu";
            this.Text = "Checkers";
            this.Load += new System.EventHandler(this.ViewMenu_Load);
            this.pPainelOpcoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonjogar;
        private System.Windows.Forms.Button bContinueGame;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Panel pPainelOpcoes;
        private System.Windows.Forms.Button bGameInfo;
        private System.Windows.Forms.Button button1;
    }
}

