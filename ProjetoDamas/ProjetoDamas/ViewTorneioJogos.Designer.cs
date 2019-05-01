﻿namespace ProjetoDamas
{
    partial class ViewTorneioJogos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTorneioJogos));
            this.pDataGridView = new System.Windows.Forms.Panel();
            this.bProceed = new System.Windows.Forms.Button();
            this.dGVJogosTorneio = new System.Windows.Forms.DataGridView();
            this.pbReturn = new System.Windows.Forms.PictureBox();
            this.lTournamentGames = new System.Windows.Forms.Label();
            this.cPlayerOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPlayerTwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGameStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVJogosTorneio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // pDataGridView
            // 
            this.pDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pDataGridView.Controls.Add(this.bProceed);
            this.pDataGridView.Controls.Add(this.dGVJogosTorneio);
            this.pDataGridView.Location = new System.Drawing.Point(59, 72);
            this.pDataGridView.Name = "pDataGridView";
            this.pDataGridView.Size = new System.Drawing.Size(515, 244);
            this.pDataGridView.TabIndex = 91;
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
            this.bProceed.Location = new System.Drawing.Point(182, 200);
            this.bProceed.Margin = new System.Windows.Forms.Padding(2);
            this.bProceed.Name = "bProceed";
            this.bProceed.Size = new System.Drawing.Size(134, 38);
            this.bProceed.TabIndex = 0;
            this.bProceed.Text = "Play";
            this.bProceed.UseVisualStyleBackColor = false;
            this.bProceed.Click += new System.EventHandler(this.bProceed_Click);
            // 
            // dGVJogosTorneio
            // 
            this.dGVJogosTorneio.AllowUserToAddRows = false;
            this.dGVJogosTorneio.AllowUserToDeleteRows = false;
            this.dGVJogosTorneio.AllowUserToOrderColumns = true;
            this.dGVJogosTorneio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVJogosTorneio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVJogosTorneio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVJogosTorneio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVJogosTorneio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cPlayerOne,
            this.cPlayerTwo,
            this.cGameStatus});
            this.dGVJogosTorneio.Location = new System.Drawing.Point(5, 6);
            this.dGVJogosTorneio.MultiSelect = false;
            this.dGVJogosTorneio.Name = "dGVJogosTorneio";
            this.dGVJogosTorneio.ReadOnly = true;
            this.dGVJogosTorneio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dGVJogosTorneio.RowHeadersWidth = 40;
            this.dGVJogosTorneio.Size = new System.Drawing.Size(504, 174);
            this.dGVJogosTorneio.TabIndex = 25;
            // 
            // pbReturn
            // 
            this.pbReturn.BackColor = System.Drawing.Color.Transparent;
            this.pbReturn.Image = global::ProjetoDamas.Properties.Resources.a429924cb33912470dd40d51a2f760ec_go_back_icon_clip_art_at_clkercom_vector_clip_art_online__300_300;
            this.pbReturn.Location = new System.Drawing.Point(12, 12);
            this.pbReturn.Name = "pbReturn";
            this.pbReturn.Size = new System.Drawing.Size(29, 28);
            this.pbReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbReturn.TabIndex = 92;
            this.pbReturn.TabStop = false;
            this.pbReturn.Click += new System.EventHandler(this.pbReturn_Click);
            // 
            // lTournamentGames
            // 
            this.lTournamentGames.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lTournamentGames.AutoSize = true;
            this.lTournamentGames.BackColor = System.Drawing.Color.Transparent;
            this.lTournamentGames.Font = new System.Drawing.Font("Matura MT Script Capitals", 25F);
            this.lTournamentGames.ForeColor = System.Drawing.Color.DimGray;
            this.lTournamentGames.Location = new System.Drawing.Point(147, 9);
            this.lTournamentGames.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lTournamentGames.Name = "lTournamentGames";
            this.lTournamentGames.Size = new System.Drawing.Size(306, 45);
            this.lTournamentGames.TabIndex = 93;
            this.lTournamentGames.Text = "Tournament Games";
            // 
            // cPlayerOne
            // 
            this.cPlayerOne.HeaderText = "Player One";
            this.cPlayerOne.Name = "cPlayerOne";
            this.cPlayerOne.ReadOnly = true;
            // 
            // cPlayerTwo
            // 
            this.cPlayerTwo.HeaderText = "Player Two";
            this.cPlayerTwo.Name = "cPlayerTwo";
            this.cPlayerTwo.ReadOnly = true;
            // 
            // cGameStatus
            // 
            this.cGameStatus.HeaderText = "Satus";
            this.cGameStatus.Name = "cGameStatus";
            this.cGameStatus.ReadOnly = true;
            // 
            // ViewTorneioJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoDamas.Properties.Resources.back_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.lTournamentGames);
            this.Controls.Add(this.pbReturn);
            this.Controls.Add(this.pDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(484, 246);
            this.Name = "ViewTorneioJogos";
            this.Text = "Checkers";
            this.Load += new System.EventHandler(this.ViewTorneioJogos_Load);
            this.pDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVJogosTorneio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pDataGridView;
        private System.Windows.Forms.DataGridView dGVJogosTorneio;
        private System.Windows.Forms.PictureBox pbReturn;
        private System.Windows.Forms.Label lTournamentGames;
        private System.Windows.Forms.Button bProceed;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPlayerOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPlayerTwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGameStatus;
    }
}