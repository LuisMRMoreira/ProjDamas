namespace ProjetoDamas
{
    partial class ViewTorneiosInacabados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTorneiosInacabados));
            this.pDataGridView = new System.Windows.Forms.Panel();
            this.dGVTorneiosInacabados = new System.Windows.Forms.DataGridView();
            this.cTournamentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNumPlayers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bProceed = new System.Windows.Forms.Button();
            this.pbReturn = new System.Windows.Forms.PictureBox();
            this.lTournamentGames = new System.Windows.Forms.Label();
            this.pDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTorneiosInacabados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // pDataGridView
            // 
            this.pDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pDataGridView.Controls.Add(this.dGVTorneiosInacabados);
            this.pDataGridView.Controls.Add(this.bProceed);
            this.pDataGridView.Location = new System.Drawing.Point(70, 70);
            this.pDataGridView.Name = "pDataGridView";
            this.pDataGridView.Size = new System.Drawing.Size(520, 318);
            this.pDataGridView.TabIndex = 92;
            // 
            // dGVTorneiosInacabados
            // 
            this.dGVTorneiosInacabados.AllowUserToAddRows = false;
            this.dGVTorneiosInacabados.AllowUserToDeleteRows = false;
            this.dGVTorneiosInacabados.AllowUserToOrderColumns = true;
            this.dGVTorneiosInacabados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVTorneiosInacabados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVTorneiosInacabados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVTorneiosInacabados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTorneiosInacabados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cTournamentName,
            this.cNumPlayers,
            this.cData});
            this.dGVTorneiosInacabados.Location = new System.Drawing.Point(5, 6);
            this.dGVTorneiosInacabados.MultiSelect = false;
            this.dGVTorneiosInacabados.Name = "dGVTorneiosInacabados";
            this.dGVTorneiosInacabados.ReadOnly = true;
            this.dGVTorneiosInacabados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dGVTorneiosInacabados.RowHeadersWidth = 40;
            this.dGVTorneiosInacabados.Size = new System.Drawing.Size(509, 252);
            this.dGVTorneiosInacabados.TabIndex = 25;
            // 
            // cTournamentName
            // 
            this.cTournamentName.HeaderText = "Tournament name";
            this.cTournamentName.Name = "cTournamentName";
            this.cTournamentName.ReadOnly = true;
            // 
            // cNumPlayers
            // 
            this.cNumPlayers.HeaderText = "Players";
            this.cNumPlayers.Name = "cNumPlayers";
            this.cNumPlayers.ReadOnly = true;
            // 
            // cData
            // 
            this.cData.HeaderText = "Date";
            this.cData.Name = "cData";
            this.cData.ReadOnly = true;
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
            this.bProceed.Location = new System.Drawing.Point(183, 270);
            this.bProceed.Margin = new System.Windows.Forms.Padding(2);
            this.bProceed.Name = "bProceed";
            this.bProceed.Size = new System.Drawing.Size(149, 39);
            this.bProceed.TabIndex = 0;
            this.bProceed.Text = "Proceed";
            this.bProceed.UseVisualStyleBackColor = false;
            this.bProceed.Click += new System.EventHandler(this.bProceed_Click);
            // 
            // pbReturn
            // 
            this.pbReturn.BackColor = System.Drawing.Color.Transparent;
            this.pbReturn.Image = global::ProjetoDamas.Properties.Resources.a429924cb33912470dd40d51a2f760ec_go_back_icon_clip_art_at_clkercom_vector_clip_art_online__300_300;
            this.pbReturn.Location = new System.Drawing.Point(12, 12);
            this.pbReturn.Name = "pbReturn";
            this.pbReturn.Size = new System.Drawing.Size(29, 28);
            this.pbReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbReturn.TabIndex = 93;
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
            this.lTournamentGames.Location = new System.Drawing.Point(166, 12);
            this.lTournamentGames.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lTournamentGames.Name = "lTournamentGames";
            this.lTournamentGames.Size = new System.Drawing.Size(374, 45);
            this.lTournamentGames.TabIndex = 94;
            this.lTournamentGames.Text = "Unfinished tournaments";
            // 
            // ViewTorneiosInacabados
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
            this.MinimumSize = new System.Drawing.Size(553, 297);
            this.Name = "ViewTorneiosInacabados";
            this.Text = "Checkers";
            this.Load += new System.EventHandler(this.ViewTorneiosInacabados_Load);
            this.pDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVTorneiosInacabados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pDataGridView;
        private System.Windows.Forms.DataGridView dGVTorneiosInacabados;
        private System.Windows.Forms.PictureBox pbReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTournamentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumPlayers;
        private System.Windows.Forms.Label lTournamentGames;
        private System.Windows.Forms.Button bProceed;
        private System.Windows.Forms.DataGridViewTextBoxColumn cData;
    }
}