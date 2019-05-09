namespace ProjetoDamas
{
    partial class ViewModoJogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewModoJogo));
            this.pbReturn = new System.Windows.Forms.PictureBox();
            this.lGameMode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pJogo = new System.Windows.Forms.Panel();
            this.lOnlineInfo = new System.Windows.Forms.Label();
            this.lLocalInfo = new System.Windows.Forms.Label();
            this.lRobotInfo = new System.Windows.Forms.Label();
            this.lMultiplayerInfo = new System.Windows.Forms.Label();
            this.lRobot = new System.Windows.Forms.Label();
            this.lMultiplayer = new System.Windows.Forms.Label();
            this.lLocal = new System.Windows.Forms.Label();
            this.lOnline = new System.Windows.Forms.Label();
            this.lPlayGame = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).BeginInit();
            this.pJogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbReturn
            // 
            this.pbReturn.BackColor = System.Drawing.Color.Transparent;
            this.pbReturn.Image = global::ProjetoDamas.Properties.Resources.a429924cb33912470dd40d51a2f760ec_go_back_icon_clip_art_at_clkercom_vector_clip_art_online__300_300;
            this.pbReturn.Location = new System.Drawing.Point(12, 12);
            this.pbReturn.Name = "pbReturn";
            this.pbReturn.Size = new System.Drawing.Size(29, 28);
            this.pbReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReturn.TabIndex = 21;
            this.pbReturn.TabStop = false;
            this.pbReturn.Click += new System.EventHandler(this.pbReturn_Click);
            // 
            // lGameMode
            // 
            this.lGameMode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lGameMode.AutoSize = true;
            this.lGameMode.BackColor = System.Drawing.Color.Transparent;
            this.lGameMode.Font = new System.Drawing.Font("Matura MT Script Capitals", 25F);
            this.lGameMode.ForeColor = System.Drawing.Color.DimGray;
            this.lGameMode.Location = new System.Drawing.Point(219, 12);
            this.lGameMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lGameMode.Name = "lGameMode";
            this.lGameMode.Size = new System.Drawing.Size(185, 45);
            this.lGameMode.TabIndex = 24;
            this.lGameMode.Text = "Game mode";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 20F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(110, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 36);
            this.label1.TabIndex = 27;
            this.label1.Text = "Jogador:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Matura MT Script Capitals", 20F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(120, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 36);
            this.label3.TabIndex = 30;
            this.label3.Text = "Jogo:";
            // 
            // pJogo
            // 
            this.pJogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pJogo.Controls.Add(this.lOnlineInfo);
            this.pJogo.Controls.Add(this.lLocalInfo);
            this.pJogo.Controls.Add(this.lRobotInfo);
            this.pJogo.Controls.Add(this.lMultiplayerInfo);
            this.pJogo.Location = new System.Drawing.Point(-1, 358);
            this.pJogo.Name = "pJogo";
            this.pJogo.Size = new System.Drawing.Size(635, 53);
            this.pJogo.TabIndex = 32;
            // 
            // lOnlineInfo
            // 
            this.lOnlineInfo.BackColor = System.Drawing.Color.Transparent;
            this.lOnlineInfo.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Bold);
            this.lOnlineInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lOnlineInfo.Location = new System.Drawing.Point(13, 6);
            this.lOnlineInfo.Name = "lOnlineInfo";
            this.lOnlineInfo.Size = new System.Drawing.Size(487, 38);
            this.lOnlineInfo.TabIndex = 40;
            this.lOnlineInfo.Text = "Play with persons all over the world once you dont have physical friends";
            this.lOnlineInfo.Visible = false;
            // 
            // lLocalInfo
            // 
            this.lLocalInfo.BackColor = System.Drawing.Color.Transparent;
            this.lLocalInfo.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Bold);
            this.lLocalInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lLocalInfo.Location = new System.Drawing.Point(22, 15);
            this.lLocalInfo.Name = "lLocalInfo";
            this.lLocalInfo.Size = new System.Drawing.Size(478, 29);
            this.lLocalInfo.TabIndex = 39;
            this.lLocalInfo.Text = "You can play with you physical friends if you selec \"Local\"";
            this.lLocalInfo.Visible = false;
            // 
            // lRobotInfo
            // 
            this.lRobotInfo.BackColor = System.Drawing.Color.Transparent;
            this.lRobotInfo.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Bold);
            this.lRobotInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lRobotInfo.Location = new System.Drawing.Point(22, 6);
            this.lRobotInfo.Name = "lRobotInfo";
            this.lRobotInfo.Size = new System.Drawing.Size(478, 47);
            this.lRobotInfo.TabIndex = 38;
            this.lRobotInfo.Text = "If you dont have friends you are even more welcom. Play with our Robot \"Joaquim\"";
            this.lRobotInfo.Visible = false;
            // 
            // lMultiplayerInfo
            // 
            this.lMultiplayerInfo.AutoSize = true;
            this.lMultiplayerInfo.BackColor = System.Drawing.Color.Transparent;
            this.lMultiplayerInfo.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Bold);
            this.lMultiplayerInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lMultiplayerInfo.Location = new System.Drawing.Point(22, 16);
            this.lMultiplayerInfo.Name = "lMultiplayerInfo";
            this.lMultiplayerInfo.Size = new System.Drawing.Size(321, 19);
            this.lMultiplayerInfo.TabIndex = 37;
            this.lMultiplayerInfo.Text = "Play with your friends Online on in local";
            this.lMultiplayerInfo.Visible = false;
            // 
            // lRobot
            // 
            this.lRobot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lRobot.AutoSize = true;
            this.lRobot.BackColor = System.Drawing.Color.Transparent;
            this.lRobot.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Bold);
            this.lRobot.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lRobot.Location = new System.Drawing.Point(366, 140);
            this.lRobot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lRobot.Name = "lRobot";
            this.lRobot.Size = new System.Drawing.Size(77, 28);
            this.lRobot.TabIndex = 33;
            this.lRobot.Text = "Robot";
            this.lRobot.Click += new System.EventHandler(this.lRobot_Click);
            this.lRobot.MouseLeave += new System.EventHandler(this.lRobot_MouseLeave);
            this.lRobot.MouseHover += new System.EventHandler(this.lRobot_MouseHover);
            // 
            // lMultiplayer
            // 
            this.lMultiplayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lMultiplayer.AutoSize = true;
            this.lMultiplayer.BackColor = System.Drawing.Color.Transparent;
            this.lMultiplayer.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Bold);
            this.lMultiplayer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lMultiplayer.Location = new System.Drawing.Point(206, 140);
            this.lMultiplayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lMultiplayer.Name = "lMultiplayer";
            this.lMultiplayer.Size = new System.Drawing.Size(134, 28);
            this.lMultiplayer.TabIndex = 34;
            this.lMultiplayer.Text = "Multiplayer";
            this.lMultiplayer.Click += new System.EventHandler(this.lMultiplayer_Click);
            this.lMultiplayer.MouseLeave += new System.EventHandler(this.lMultiplayer_MouseLeave);
            this.lMultiplayer.MouseHover += new System.EventHandler(this.lMultiplayer_MouseHover);
            // 
            // lLocal
            // 
            this.lLocal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lLocal.AutoSize = true;
            this.lLocal.BackColor = System.Drawing.Color.Transparent;
            this.lLocal.Enabled = false;
            this.lLocal.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Bold);
            this.lLocal.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lLocal.Location = new System.Drawing.Point(218, 223);
            this.lLocal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lLocal.Name = "lLocal";
            this.lLocal.Size = new System.Drawing.Size(72, 28);
            this.lLocal.TabIndex = 36;
            this.lLocal.Text = "Local";
            this.lLocal.Click += new System.EventHandler(this.lLocal_Click);
            this.lLocal.MouseLeave += new System.EventHandler(this.lLocal_MouseLeave);
            this.lLocal.MouseHover += new System.EventHandler(this.lLocal_MouseHover);
            // 
            // lOnline
            // 
            this.lOnline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lOnline.AutoSize = true;
            this.lOnline.BackColor = System.Drawing.Color.Transparent;
            this.lOnline.Enabled = false;
            this.lOnline.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Bold);
            this.lOnline.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lOnline.Location = new System.Drawing.Point(378, 223);
            this.lOnline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lOnline.Name = "lOnline";
            this.lOnline.Size = new System.Drawing.Size(82, 28);
            this.lOnline.TabIndex = 35;
            this.lOnline.Text = "Online";
            this.lOnline.Click += new System.EventHandler(this.lOnline_Click);
            this.lOnline.MouseLeave += new System.EventHandler(this.lOnline_MouseLeave);
            this.lOnline.MouseHover += new System.EventHandler(this.lOnline_MouseHover);
            // 
            // lPlayGame
            // 
            this.lPlayGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lPlayGame.AutoSize = true;
            this.lPlayGame.BackColor = System.Drawing.Color.Transparent;
            this.lPlayGame.Enabled = false;
            this.lPlayGame.Font = new System.Drawing.Font("Matura MT Script Capitals", 25F);
            this.lPlayGame.ForeColor = System.Drawing.Color.Brown;
            this.lPlayGame.Location = new System.Drawing.Point(215, 273);
            this.lPlayGame.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lPlayGame.Name = "lPlayGame";
            this.lPlayGame.Size = new System.Drawing.Size(216, 45);
            this.lPlayGame.TabIndex = 78;
            this.lPlayGame.Text = "Let\'s Goooo";
            this.lPlayGame.Visible = false;
            this.lPlayGame.Click += new System.EventHandler(this.lPlayGame_Click);
            // 
            // ViewModoJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoDamas.Properties.Resources.back_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.lPlayGame);
            this.Controls.Add(this.lLocal);
            this.Controls.Add(this.lMultiplayer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lOnline);
            this.Controls.Add(this.lRobot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lGameMode);
            this.Controls.Add(this.pbReturn);
            this.Controls.Add(this.pJogo);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(470, 374);
            this.Name = "ViewModoJogo";
            this.Text = "Checkers";
            this.Load += new System.EventHandler(this.ViewModoJogo_Load);
            this.VisibleChanged += new System.EventHandler(this.ViewModoJogo_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).EndInit();
            this.pJogo.ResumeLayout(false);
            this.pJogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbReturn;
        private System.Windows.Forms.Label lGameMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pJogo;
        private System.Windows.Forms.Label lRobot;
        private System.Windows.Forms.Label lMultiplayer;
        private System.Windows.Forms.Label lLocal;
        private System.Windows.Forms.Label lOnline;
        private System.Windows.Forms.Label lOnlineInfo;
        private System.Windows.Forms.Label lLocalInfo;
        private System.Windows.Forms.Label lRobotInfo;
        private System.Windows.Forms.Label lMultiplayerInfo;
        private System.Windows.Forms.Label lPlayGame;
    }
}