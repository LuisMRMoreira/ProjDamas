namespace ProjetoDamas
{
    partial class ViewTorneio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTorneio));
            this.lTournament = new System.Windows.Forms.Label();
            this.pbReturn = new System.Windows.Forms.PictureBox();
            this.pDataGridView = new System.Windows.Forms.Panel();
            this.cTBTournamentName = new ProjetoDamas.CueTextBox();
            this.bRemove = new System.Windows.Forms.Button();
            this.bAddPlayer = new System.Windows.Forms.Button();
            this.cTBNickname = new ProjetoDamas.CueTextBox();
            this.rBOnlineGame = new System.Windows.Forms.RadioButton();
            this.rBLocalGame = new System.Windows.Forms.RadioButton();
            this.lAddToTournament = new System.Windows.Forms.Label();
            this.dGVJogadoresTorneio = new System.Windows.Forms.DataGridView();
            this.cNickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cConnectivity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bProceed = new System.Windows.Forms.Button();
            this.pInfo = new System.Windows.Forms.Panel();
            this.lTournamentInfo = new System.Windows.Forms.Label();
            this.pConeccaoServidor = new System.Windows.Forms.Panel();
            this.cTBServerIP = new ProjetoDamas.CueTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).BeginInit();
            this.pDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVJogadoresTorneio)).BeginInit();
            this.pInfo.SuspendLayout();
            this.pConeccaoServidor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lTournament
            // 
            this.lTournament.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lTournament.AutoSize = true;
            this.lTournament.BackColor = System.Drawing.Color.Transparent;
            this.lTournament.Font = new System.Drawing.Font("Matura MT Script Capitals", 25F);
            this.lTournament.ForeColor = System.Drawing.Color.DimGray;
            this.lTournament.Location = new System.Drawing.Point(216, 9);
            this.lTournament.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lTournament.Name = "lTournament";
            this.lTournament.Size = new System.Drawing.Size(196, 45);
            this.lTournament.TabIndex = 88;
            this.lTournament.Text = "Tournament";
            // 
            // pbReturn
            // 
            this.pbReturn.BackColor = System.Drawing.Color.Transparent;
            this.pbReturn.Image = global::ProjetoDamas.Properties.Resources.a429924cb33912470dd40d51a2f760ec_go_back_icon_clip_art_at_clkercom_vector_clip_art_online__300_300;
            this.pbReturn.Location = new System.Drawing.Point(12, 12);
            this.pbReturn.Name = "pbReturn";
            this.pbReturn.Size = new System.Drawing.Size(29, 28);
            this.pbReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbReturn.TabIndex = 89;
            this.pbReturn.TabStop = false;
            this.pbReturn.Click += new System.EventHandler(this.pbReturn_Click);
            // 
            // pDataGridView
            // 
            this.pDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pDataGridView.Controls.Add(this.cTBTournamentName);
            this.pDataGridView.Controls.Add(this.bRemove);
            this.pDataGridView.Controls.Add(this.bAddPlayer);
            this.pDataGridView.Controls.Add(this.cTBNickname);
            this.pDataGridView.Controls.Add(this.rBOnlineGame);
            this.pDataGridView.Controls.Add(this.rBLocalGame);
            this.pDataGridView.Controls.Add(this.lAddToTournament);
            this.pDataGridView.Controls.Add(this.dGVJogadoresTorneio);
            this.pDataGridView.Location = new System.Drawing.Point(65, 57);
            this.pDataGridView.Name = "pDataGridView";
            this.pDataGridView.Size = new System.Drawing.Size(521, 211);
            this.pDataGridView.TabIndex = 90;
            // 
            // cTBTournamentName
            // 
            this.cTBTournamentName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cTBTournamentName.Cue = "Tournament name";
            this.cTBTournamentName.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.cTBTournamentName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cTBTournamentName.Location = new System.Drawing.Point(77, 103);
            this.cTBTournamentName.Name = "cTBTournamentName";
            this.cTBTournamentName.Size = new System.Drawing.Size(201, 29);
            this.cTBTournamentName.TabIndex = 0;
            // 
            // bRemove
            // 
            this.bRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bRemove.Font = new System.Drawing.Font("Kristen ITC", 12F);
            this.bRemove.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bRemove.Location = new System.Drawing.Point(347, 146);
            this.bRemove.Name = "bRemove";
            this.bRemove.Size = new System.Drawing.Size(105, 41);
            this.bRemove.TabIndex = 87;
            this.bRemove.Text = "Remove";
            this.bRemove.UseVisualStyleBackColor = true;
            this.bRemove.Click += new System.EventHandler(this.bRemove_Click);
            // 
            // bAddPlayer
            // 
            this.bAddPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bAddPlayer.Font = new System.Drawing.Font("Kristen ITC", 12F);
            this.bAddPlayer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bAddPlayer.Location = new System.Drawing.Point(347, 96);
            this.bAddPlayer.Name = "bAddPlayer";
            this.bAddPlayer.Size = new System.Drawing.Size(105, 41);
            this.bAddPlayer.TabIndex = 2;
            this.bAddPlayer.Text = "Add";
            this.bAddPlayer.UseVisualStyleBackColor = true;
            this.bAddPlayer.Click += new System.EventHandler(this.bAddPlayer_Click);
            // 
            // cTBNickname
            // 
            this.cTBNickname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cTBNickname.Cue = "Nickname";
            this.cTBNickname.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.cTBNickname.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cTBNickname.Location = new System.Drawing.Point(77, 138);
            this.cTBNickname.Name = "cTBNickname";
            this.cTBNickname.Size = new System.Drawing.Size(201, 29);
            this.cTBNickname.TabIndex = 1;
            // 
            // rBOnlineGame
            // 
            this.rBOnlineGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rBOnlineGame.AutoSize = true;
            this.rBOnlineGame.BackColor = System.Drawing.Color.Transparent;
            this.rBOnlineGame.Font = new System.Drawing.Font("Kristen ITC", 9F);
            this.rBOnlineGame.ForeColor = System.Drawing.Color.DimGray;
            this.rBOnlineGame.Location = new System.Drawing.Point(195, 178);
            this.rBOnlineGame.Name = "rBOnlineGame";
            this.rBOnlineGame.Size = new System.Drawing.Size(64, 21);
            this.rBOnlineGame.TabIndex = 81;
            this.rBOnlineGame.Text = "Online";
            this.rBOnlineGame.UseVisualStyleBackColor = false;
            this.rBOnlineGame.CheckedChanged += new System.EventHandler(this.rBOnlineGame_CheckedChanged);
            // 
            // rBLocalGame
            // 
            this.rBLocalGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rBLocalGame.AutoSize = true;
            this.rBLocalGame.BackColor = System.Drawing.Color.Transparent;
            this.rBLocalGame.Checked = true;
            this.rBLocalGame.Font = new System.Drawing.Font("Kristen ITC", 9F);
            this.rBLocalGame.ForeColor = System.Drawing.Color.DimGray;
            this.rBLocalGame.Location = new System.Drawing.Point(77, 178);
            this.rBLocalGame.Name = "rBLocalGame";
            this.rBLocalGame.Size = new System.Drawing.Size(59, 21);
            this.rBLocalGame.TabIndex = 79;
            this.rBLocalGame.TabStop = true;
            this.rBLocalGame.Text = "Local";
            this.rBLocalGame.UseVisualStyleBackColor = false;
            // 
            // lAddToTournament
            // 
            this.lAddToTournament.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lAddToTournament.AutoSize = true;
            this.lAddToTournament.BackColor = System.Drawing.Color.Transparent;
            this.lAddToTournament.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Bold);
            this.lAddToTournament.ForeColor = System.Drawing.Color.DimGray;
            this.lAddToTournament.Location = new System.Drawing.Point(54, 80);
            this.lAddToTournament.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lAddToTournament.Name = "lAddToTournament";
            this.lAddToTournament.Size = new System.Drawing.Size(108, 19);
            this.lAddToTournament.TabIndex = 76;
            this.lAddToTournament.Text = "Tournament:";
            // 
            // dGVJogadoresTorneio
            // 
            this.dGVJogadoresTorneio.AllowUserToAddRows = false;
            this.dGVJogadoresTorneio.AllowUserToDeleteRows = false;
            this.dGVJogadoresTorneio.AllowUserToOrderColumns = true;
            this.dGVJogadoresTorneio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVJogadoresTorneio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVJogadoresTorneio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVJogadoresTorneio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVJogadoresTorneio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNickname,
            this.cConnectivity});
            this.dGVJogadoresTorneio.Location = new System.Drawing.Point(5, 6);
            this.dGVJogadoresTorneio.MultiSelect = false;
            this.dGVJogadoresTorneio.Name = "dGVJogadoresTorneio";
            this.dGVJogadoresTorneio.ReadOnly = true;
            this.dGVJogadoresTorneio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dGVJogadoresTorneio.RowHeadersWidth = 40;
            this.dGVJogadoresTorneio.Size = new System.Drawing.Size(511, 62);
            this.dGVJogadoresTorneio.TabIndex = 25;
            // 
            // cNickname
            // 
            this.cNickname.HeaderText = "Nickname";
            this.cNickname.Name = "cNickname";
            this.cNickname.ReadOnly = true;
            // 
            // cConnectivity
            // 
            this.cConnectivity.HeaderText = "Connectivity";
            this.cConnectivity.Name = "cConnectivity";
            this.cConnectivity.ReadOnly = true;
            // 
            // bProceed
            // 
            this.bProceed.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bProceed.BackColor = System.Drawing.Color.Transparent;
            this.bProceed.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.bProceed.FlatAppearance.BorderSize = 0;
            this.bProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bProceed.Font = new System.Drawing.Font("Kristen ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bProceed.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bProceed.Location = new System.Drawing.Point(239, 330);
            this.bProceed.Margin = new System.Windows.Forms.Padding(2);
            this.bProceed.Name = "bProceed";
            this.bProceed.Size = new System.Drawing.Size(134, 38);
            this.bProceed.TabIndex = 0;
            this.bProceed.Text = "Proceed";
            this.bProceed.UseVisualStyleBackColor = false;
            this.bProceed.Click += new System.EventHandler(this.bProceed_Click);
            // 
            // pInfo
            // 
            this.pInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pInfo.Controls.Add(this.lTournamentInfo);
            this.pInfo.Location = new System.Drawing.Point(0, 380);
            this.pInfo.Name = "pInfo";
            this.pInfo.Size = new System.Drawing.Size(634, 31);
            this.pInfo.TabIndex = 92;
            // 
            // lTournamentInfo
            // 
            this.lTournamentInfo.AutoSize = true;
            this.lTournamentInfo.BackColor = System.Drawing.Color.Transparent;
            this.lTournamentInfo.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Bold);
            this.lTournamentInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lTournamentInfo.Location = new System.Drawing.Point(22, 8);
            this.lTournamentInfo.Name = "lTournamentInfo";
            this.lTournamentInfo.Size = new System.Drawing.Size(424, 19);
            this.lTournamentInfo.TabIndex = 37;
            this.lTournamentInfo.Text = "You can add either local or Server connected players";
            // 
            // pConeccaoServidor
            // 
            this.pConeccaoServidor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pConeccaoServidor.Controls.Add(this.cTBServerIP);
            this.pConeccaoServidor.Location = new System.Drawing.Point(65, 267);
            this.pConeccaoServidor.Name = "pConeccaoServidor";
            this.pConeccaoServidor.Size = new System.Drawing.Size(521, 58);
            this.pConeccaoServidor.TabIndex = 93;
            this.pConeccaoServidor.Visible = false;
            // 
            // cTBServerIP
            // 
            this.cTBServerIP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cTBServerIP.Cue = "Server IP";
            this.cTBServerIP.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.cTBServerIP.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cTBServerIP.Location = new System.Drawing.Point(61, 13);
            this.cTBServerIP.Name = "cTBServerIP";
            this.cTBServerIP.Size = new System.Drawing.Size(223, 29);
            this.cTBServerIP.TabIndex = 87;
            this.cTBServerIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cTBServerIP_KeyPress);
            // 
            // ViewTorneio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoDamas.Properties.Resources.back_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.pConeccaoServidor);
            this.Controls.Add(this.pInfo);
            this.Controls.Add(this.bProceed);
            this.Controls.Add(this.pDataGridView);
            this.Controls.Add(this.pbReturn);
            this.Controls.Add(this.lTournament);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(548, 426);
            this.Name = "ViewTorneio";
            this.Text = "Checkers";
            this.Load += new System.EventHandler(this.ViewTorneio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).EndInit();
            this.pDataGridView.ResumeLayout(false);
            this.pDataGridView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVJogadoresTorneio)).EndInit();
            this.pInfo.ResumeLayout(false);
            this.pInfo.PerformLayout();
            this.pConeccaoServidor.ResumeLayout(false);
            this.pConeccaoServidor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTournament;
        private System.Windows.Forms.PictureBox pbReturn;
        private System.Windows.Forms.Panel pDataGridView;
        private CueTextBox cTBNickname;
        private System.Windows.Forms.RadioButton rBOnlineGame;
        private System.Windows.Forms.RadioButton rBLocalGame;
        private System.Windows.Forms.Label lAddToTournament;
        private System.Windows.Forms.DataGridView dGVJogadoresTorneio;
        private System.Windows.Forms.Button bAddPlayer;
        private System.Windows.Forms.Button bProceed;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cConnectivity;
        private System.Windows.Forms.Panel pInfo;
        private System.Windows.Forms.Label lTournamentInfo;
        private System.Windows.Forms.Panel pConeccaoServidor;
        private CueTextBox cTBServerIP;
        private System.Windows.Forms.Button bRemove;
        private CueTextBox cTBTournamentName;
    }
}