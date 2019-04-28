namespace ProjetoDamas
{
    partial class ViewJogadoresNoServidor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewJogadoresNoServidor));
            this.pDataGridView = new System.Windows.Forms.Panel();
            this.rBBestStatus = new System.Windows.Forms.RadioButton();
            this.rBNone = new System.Windows.Forms.RadioButton();
            this.cTBNickname = new ProjetoDamas.CueTextBox();
            this.rBName = new System.Windows.Forms.RadioButton();
            this.cBCountries = new System.Windows.Forms.ComboBox();
            this.rBCountry = new System.Windows.Forms.RadioButton();
            this.lSearchBy = new System.Windows.Forms.Label();
            this.dGVServerOpponent = new System.Windows.Forms.DataGridView();
            this.cNickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cWins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTotalGames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIPAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbReturn = new System.Windows.Forms.PictureBox();
            this.lStatistics = new System.Windows.Forms.Label();
            this.bSelect = new System.Windows.Forms.Button();
            this.pDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVServerOpponent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // pDataGridView
            // 
            this.pDataGridView.Controls.Add(this.rBBestStatus);
            this.pDataGridView.Controls.Add(this.rBNone);
            this.pDataGridView.Controls.Add(this.cTBNickname);
            this.pDataGridView.Controls.Add(this.rBName);
            this.pDataGridView.Controls.Add(this.cBCountries);
            this.pDataGridView.Controls.Add(this.rBCountry);
            this.pDataGridView.Controls.Add(this.lSearchBy);
            this.pDataGridView.Controls.Add(this.dGVServerOpponent);
            this.pDataGridView.Location = new System.Drawing.Point(101, 67);
            this.pDataGridView.Name = "pDataGridView";
            this.pDataGridView.Size = new System.Drawing.Size(454, 300);
            this.pDataGridView.TabIndex = 27;
            // 
            // rBBestStatus
            // 
            this.rBBestStatus.AutoSize = true;
            this.rBBestStatus.BackColor = System.Drawing.Color.Transparent;
            this.rBBestStatus.Font = new System.Drawing.Font("Kristen ITC", 9F);
            this.rBBestStatus.ForeColor = System.Drawing.Color.DimGray;
            this.rBBestStatus.Location = new System.Drawing.Point(250, 228);
            this.rBBestStatus.Name = "rBBestStatus";
            this.rBBestStatus.Size = new System.Drawing.Size(93, 21);
            this.rBBestStatus.TabIndex = 87;
            this.rBBestStatus.Text = "Best status";
            this.rBBestStatus.UseVisualStyleBackColor = false;
            this.rBBestStatus.CheckedChanged += new System.EventHandler(this.rBBestStatus_CheckedChanged);
            // 
            // rBNone
            // 
            this.rBNone.AutoSize = true;
            this.rBNone.BackColor = System.Drawing.Color.Transparent;
            this.rBNone.Checked = true;
            this.rBNone.Font = new System.Drawing.Font("Kristen ITC", 9F);
            this.rBNone.ForeColor = System.Drawing.Color.DimGray;
            this.rBNone.Location = new System.Drawing.Point(373, 228);
            this.rBNone.Name = "rBNone";
            this.rBNone.Size = new System.Drawing.Size(58, 21);
            this.rBNone.TabIndex = 86;
            this.rBNone.TabStop = true;
            this.rBNone.Text = "None";
            this.rBNone.UseVisualStyleBackColor = false;
            this.rBNone.CheckedChanged += new System.EventHandler(this.rBNone_CheckedChanged);
            // 
            // cTBNickname
            // 
            this.cTBNickname.Cue = "Nickname";
            this.cTBNickname.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.cTBNickname.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cTBNickname.Location = new System.Drawing.Point(46, 255);
            this.cTBNickname.Name = "cTBNickname";
            this.cTBNickname.Size = new System.Drawing.Size(199, 29);
            this.cTBNickname.TabIndex = 85;
            this.cTBNickname.Visible = false;
            // 
            // rBName
            // 
            this.rBName.AutoSize = true;
            this.rBName.BackColor = System.Drawing.Color.Transparent;
            this.rBName.Font = new System.Drawing.Font("Kristen ITC", 9F);
            this.rBName.ForeColor = System.Drawing.Color.DimGray;
            this.rBName.Location = new System.Drawing.Point(144, 229);
            this.rBName.Name = "rBName";
            this.rBName.Size = new System.Drawing.Size(85, 21);
            this.rBName.TabIndex = 81;
            this.rBName.Text = "Nickname";
            this.rBName.UseVisualStyleBackColor = false;
            this.rBName.CheckedChanged += new System.EventHandler(this.rBName_CheckedChanged);
            // 
            // cBCountries
            // 
            this.cBCountries.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.cBCountries.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cBCountries.FormattingEnabled = true;
            this.cBCountries.Location = new System.Drawing.Point(46, 255);
            this.cBCountries.Name = "cBCountries";
            this.cBCountries.Size = new System.Drawing.Size(199, 29);
            this.cBCountries.TabIndex = 80;
            this.cBCountries.Visible = false;
            // 
            // rBCountry
            // 
            this.rBCountry.AutoSize = true;
            this.rBCountry.BackColor = System.Drawing.Color.Transparent;
            this.rBCountry.Font = new System.Drawing.Font("Kristen ITC", 8F);
            this.rBCountry.ForeColor = System.Drawing.Color.DimGray;
            this.rBCountry.Location = new System.Drawing.Point(46, 229);
            this.rBCountry.Name = "rBCountry";
            this.rBCountry.Size = new System.Drawing.Size(71, 20);
            this.rBCountry.TabIndex = 77;
            this.rBCountry.Text = "Country";
            this.rBCountry.UseVisualStyleBackColor = false;
            this.rBCountry.CheckedChanged += new System.EventHandler(this.rBCountry_CheckedChanged);
            // 
            // lSearchBy
            // 
            this.lSearchBy.AutoSize = true;
            this.lSearchBy.BackColor = System.Drawing.Color.Transparent;
            this.lSearchBy.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Bold);
            this.lSearchBy.ForeColor = System.Drawing.Color.DimGray;
            this.lSearchBy.Location = new System.Drawing.Point(2, 205);
            this.lSearchBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lSearchBy.Name = "lSearchBy";
            this.lSearchBy.Size = new System.Drawing.Size(90, 19);
            this.lSearchBy.TabIndex = 76;
            this.lSearchBy.Text = "Search by:";
            // 
            // dGVServerOpponent
            // 
            this.dGVServerOpponent.AllowUserToAddRows = false;
            this.dGVServerOpponent.AllowUserToDeleteRows = false;
            this.dGVServerOpponent.AllowUserToOrderColumns = true;
            this.dGVServerOpponent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVServerOpponent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVServerOpponent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNickname,
            this.cWins,
            this.cTotalGames,
            this.cIPAdress});
            this.dGVServerOpponent.Location = new System.Drawing.Point(5, 6);
            this.dGVServerOpponent.MultiSelect = false;
            this.dGVServerOpponent.Name = "dGVServerOpponent";
            this.dGVServerOpponent.ReadOnly = true;
            this.dGVServerOpponent.Size = new System.Drawing.Size(443, 196);
            this.dGVServerOpponent.TabIndex = 25;
            this.dGVServerOpponent.SelectionChanged += new System.EventHandler(this.dGVEstatisticas_SelectionChanged);
            // 
            // cNickname
            // 
            this.cNickname.HeaderText = "Nickname";
            this.cNickname.Name = "cNickname";
            this.cNickname.ReadOnly = true;
            // 
            // cWins
            // 
            this.cWins.HeaderText = "Wins";
            this.cWins.Name = "cWins";
            this.cWins.ReadOnly = true;
            // 
            // cTotalGames
            // 
            this.cTotalGames.HeaderText = "Total Games";
            this.cTotalGames.Name = "cTotalGames";
            this.cTotalGames.ReadOnly = true;
            // 
            // cIPAdress
            // 
            this.cIPAdress.HeaderText = "IP Adress";
            this.cIPAdress.Name = "cIPAdress";
            this.cIPAdress.ReadOnly = true;
            // 
            // pbReturn
            // 
            this.pbReturn.BackColor = System.Drawing.Color.Transparent;
            this.pbReturn.Image = global::ProjetoDamas.Properties.Resources.a429924cb33912470dd40d51a2f760ec_go_back_icon_clip_art_at_clkercom_vector_clip_art_online__300_300;
            this.pbReturn.Location = new System.Drawing.Point(12, 12);
            this.pbReturn.Name = "pbReturn";
            this.pbReturn.Size = new System.Drawing.Size(29, 28);
            this.pbReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbReturn.TabIndex = 28;
            this.pbReturn.TabStop = false;
            this.pbReturn.Click += new System.EventHandler(this.pbReturn_Click);
            // 
            // lStatistics
            // 
            this.lStatistics.AutoSize = true;
            this.lStatistics.BackColor = System.Drawing.Color.Transparent;
            this.lStatistics.Font = new System.Drawing.Font("Matura MT Script Capitals", 25F);
            this.lStatistics.ForeColor = System.Drawing.Color.DimGray;
            this.lStatistics.Location = new System.Drawing.Point(191, 12);
            this.lStatistics.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lStatistics.Name = "lStatistics";
            this.lStatistics.Size = new System.Drawing.Size(271, 45);
            this.lStatistics.TabIndex = 29;
            this.lStatistics.Text = "Server opponents";
            // 
            // bSelect
            // 
            this.bSelect.BackColor = System.Drawing.Color.Transparent;
            this.bSelect.FlatAppearance.BorderSize = 0;
            this.bSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSelect.Font = new System.Drawing.Font("Kristen ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSelect.ForeColor = System.Drawing.Color.DimGray;
            this.bSelect.Location = new System.Drawing.Point(199, 383);
            this.bSelect.Margin = new System.Windows.Forms.Padding(2);
            this.bSelect.Name = "bSelect";
            this.bSelect.Size = new System.Drawing.Size(210, 38);
            this.bSelect.TabIndex = 97;
            this.bSelect.Text = "Select";
            this.bSelect.UseVisualStyleBackColor = false;
            this.bSelect.Visible = false;
            this.bSelect.Click += new System.EventHandler(this.bSelect_Click);
            // 
            // ViewJogadoresNoServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoDamas.Properties.Resources.back_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(673, 432);
            this.Controls.Add(this.bSelect);
            this.Controls.Add(this.lStatistics);
            this.Controls.Add(this.pbReturn);
            this.Controls.Add(this.pDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewJogadoresNoServidor";
            this.Text = "Checkers";
            this.Load += new System.EventHandler(this.ViewJogadoresNoServidor_Load);
            this.pDataGridView.ResumeLayout(false);
            this.pDataGridView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVServerOpponent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pDataGridView;
        private System.Windows.Forms.RadioButton rBBestStatus;
        private System.Windows.Forms.RadioButton rBNone;
        private CueTextBox cTBNickname;
        private System.Windows.Forms.RadioButton rBName;
        private System.Windows.Forms.ComboBox cBCountries;
        private System.Windows.Forms.RadioButton rBCountry;
        private System.Windows.Forms.Label lSearchBy;
        private System.Windows.Forms.DataGridView dGVServerOpponent;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cWins;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTotalGames;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIPAdress;
        private System.Windows.Forms.PictureBox pbReturn;
        private System.Windows.Forms.Label lStatistics;
        private System.Windows.Forms.Button bSelect;
    }
}