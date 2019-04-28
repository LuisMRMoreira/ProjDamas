namespace ProjetoDamas
{
    partial class ViewStatistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStatistics));
            this.pbReturn = new System.Windows.Forms.PictureBox();
            this.lStatistics = new System.Windows.Forms.Label();
            this.pDataGridView = new System.Windows.Forms.Panel();
            this.rBNone = new System.Windows.Forms.RadioButton();
            this.cTBNickname = new ProjetoDamas.CueTextBox();
            this.dTPDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.cTBTimePlayed = new ProjetoDamas.CueTextBox();
            this.rBName = new System.Windows.Forms.RadioButton();
            this.cBCountries = new System.Windows.Forms.ComboBox();
            this.rBBirthDate = new System.Windows.Forms.RadioButton();
            this.rBTimePlayed = new System.Windows.Forms.RadioButton();
            this.rBCountry = new System.Windows.Forms.RadioButton();
            this.lSearchBy = new System.Windows.Forms.Label();
            this.dGVEstatisticas = new System.Windows.Forms.DataGridView();
            this.cNickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cWins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDefeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTotalGames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).BeginInit();
            this.pDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEstatisticas)).BeginInit();
            this.SuspendLayout();
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
            // lStatistics
            // 
            this.lStatistics.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lStatistics.AutoSize = true;
            this.lStatistics.BackColor = System.Drawing.Color.Transparent;
            this.lStatistics.Font = new System.Drawing.Font("Matura MT Script Capitals", 25F);
            this.lStatistics.ForeColor = System.Drawing.Color.DimGray;
            this.lStatistics.Location = new System.Drawing.Point(232, 12);
            this.lStatistics.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lStatistics.Name = "lStatistics";
            this.lStatistics.Size = new System.Drawing.Size(171, 45);
            this.lStatistics.TabIndex = 29;
            this.lStatistics.Text = "Statistics";
            // 
            // pDataGridView
            // 
            this.pDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pDataGridView.Controls.Add(this.rBNone);
            this.pDataGridView.Controls.Add(this.cTBNickname);
            this.pDataGridView.Controls.Add(this.dTPDataNascimento);
            this.pDataGridView.Controls.Add(this.cTBTimePlayed);
            this.pDataGridView.Controls.Add(this.rBName);
            this.pDataGridView.Controls.Add(this.cBCountries);
            this.pDataGridView.Controls.Add(this.rBBirthDate);
            this.pDataGridView.Controls.Add(this.rBTimePlayed);
            this.pDataGridView.Controls.Add(this.rBCountry);
            this.pDataGridView.Controls.Add(this.lSearchBy);
            this.pDataGridView.Controls.Add(this.dGVEstatisticas);
            this.pDataGridView.Location = new System.Drawing.Point(36, 75);
            this.pDataGridView.Name = "pDataGridView";
            this.pDataGridView.Size = new System.Drawing.Size(561, 308);
            this.pDataGridView.TabIndex = 28;
            // 
            // rBNone
            // 
            this.rBNone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rBNone.AutoSize = true;
            this.rBNone.BackColor = System.Drawing.Color.Transparent;
            this.rBNone.Checked = true;
            this.rBNone.Font = new System.Drawing.Font("Kristen ITC", 9F);
            this.rBNone.ForeColor = System.Drawing.Color.DimGray;
            this.rBNone.Location = new System.Drawing.Point(403, 227);
            this.rBNone.Name = "rBNone";
            this.rBNone.Size = new System.Drawing.Size(58, 21);
            this.rBNone.TabIndex = 86;
            this.rBNone.TabStop = true;
            this.rBNone.Text = "None";
            this.rBNone.UseVisualStyleBackColor = false;
            // 
            // cTBNickname
            // 
            this.cTBNickname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cTBNickname.Cue = "Nickname";
            this.cTBNickname.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.cTBNickname.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cTBNickname.Location = new System.Drawing.Point(100, 222);
            this.cTBNickname.Name = "cTBNickname";
            this.cTBNickname.Size = new System.Drawing.Size(199, 29);
            this.cTBNickname.TabIndex = 85;
            this.cTBNickname.Visible = false;
            // 
            // dTPDataNascimento
            // 
            this.dTPDataNascimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dTPDataNascimento.CalendarForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dTPDataNascimento.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.dTPDataNascimento.CalendarTitleBackColor = System.Drawing.SystemColors.WindowFrame;
            this.dTPDataNascimento.CalendarTitleForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dTPDataNascimento.CalendarTrailingForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dTPDataNascimento.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.dTPDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPDataNascimento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dTPDataNascimento.Location = new System.Drawing.Point(100, 222);
            this.dTPDataNascimento.Name = "dTPDataNascimento";
            this.dTPDataNascimento.Size = new System.Drawing.Size(199, 29);
            this.dTPDataNascimento.TabIndex = 84;
            this.dTPDataNascimento.Visible = false;
            // 
            // cTBTimePlayed
            // 
            this.cTBTimePlayed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cTBTimePlayed.Cue = "Time played";
            this.cTBTimePlayed.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.cTBTimePlayed.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cTBTimePlayed.Location = new System.Drawing.Point(100, 222);
            this.cTBTimePlayed.Name = "cTBTimePlayed";
            this.cTBTimePlayed.Size = new System.Drawing.Size(199, 29);
            this.cTBTimePlayed.TabIndex = 83;
            this.cTBTimePlayed.Visible = false;
            // 
            // rBName
            // 
            this.rBName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rBName.AutoSize = true;
            this.rBName.BackColor = System.Drawing.Color.Transparent;
            this.rBName.Font = new System.Drawing.Font("Kristen ITC", 9F);
            this.rBName.ForeColor = System.Drawing.Color.DimGray;
            this.rBName.Location = new System.Drawing.Point(403, 188);
            this.rBName.Name = "rBName";
            this.rBName.Size = new System.Drawing.Size(85, 21);
            this.rBName.TabIndex = 81;
            this.rBName.Text = "Nickname";
            this.rBName.UseVisualStyleBackColor = false;
            // 
            // cBCountries
            // 
            this.cBCountries.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBCountries.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.cBCountries.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cBCountries.FormattingEnabled = true;
            this.cBCountries.Location = new System.Drawing.Point(100, 222);
            this.cBCountries.Name = "cBCountries";
            this.cBCountries.Size = new System.Drawing.Size(199, 29);
            this.cBCountries.TabIndex = 80;
            this.cBCountries.Visible = false;
            // 
            // rBBirthDate
            // 
            this.rBBirthDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rBBirthDate.AutoSize = true;
            this.rBBirthDate.BackColor = System.Drawing.Color.Transparent;
            this.rBBirthDate.Font = new System.Drawing.Font("Kristen ITC", 9F);
            this.rBBirthDate.ForeColor = System.Drawing.Color.DimGray;
            this.rBBirthDate.Location = new System.Drawing.Point(298, 189);
            this.rBBirthDate.Name = "rBBirthDate";
            this.rBBirthDate.Size = new System.Drawing.Size(88, 21);
            this.rBBirthDate.TabIndex = 79;
            this.rBBirthDate.Text = "Birth date";
            this.rBBirthDate.UseVisualStyleBackColor = false;
            // 
            // rBTimePlayed
            // 
            this.rBTimePlayed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rBTimePlayed.AutoSize = true;
            this.rBTimePlayed.BackColor = System.Drawing.Color.Transparent;
            this.rBTimePlayed.Font = new System.Drawing.Font("Kristen ITC", 9F);
            this.rBTimePlayed.ForeColor = System.Drawing.Color.DimGray;
            this.rBTimePlayed.Location = new System.Drawing.Point(186, 189);
            this.rBTimePlayed.Name = "rBTimePlayed";
            this.rBTimePlayed.Size = new System.Drawing.Size(96, 21);
            this.rBTimePlayed.TabIndex = 78;
            this.rBTimePlayed.Text = "Time played";
            this.rBTimePlayed.UseVisualStyleBackColor = false;
            // 
            // rBCountry
            // 
            this.rBCountry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rBCountry.AutoSize = true;
            this.rBCountry.BackColor = System.Drawing.Color.Transparent;
            this.rBCountry.Font = new System.Drawing.Font("Kristen ITC", 8F);
            this.rBCountry.ForeColor = System.Drawing.Color.DimGray;
            this.rBCountry.Location = new System.Drawing.Point(100, 189);
            this.rBCountry.Name = "rBCountry";
            this.rBCountry.Size = new System.Drawing.Size(71, 20);
            this.rBCountry.TabIndex = 77;
            this.rBCountry.Text = "Country";
            this.rBCountry.UseVisualStyleBackColor = false;
            // 
            // lSearchBy
            // 
            this.lSearchBy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lSearchBy.AutoSize = true;
            this.lSearchBy.BackColor = System.Drawing.Color.Transparent;
            this.lSearchBy.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Bold);
            this.lSearchBy.ForeColor = System.Drawing.Color.DimGray;
            this.lSearchBy.Location = new System.Drawing.Point(56, 165);
            this.lSearchBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lSearchBy.Name = "lSearchBy";
            this.lSearchBy.Size = new System.Drawing.Size(90, 19);
            this.lSearchBy.TabIndex = 76;
            this.lSearchBy.Text = "Search by:";
            // 
            // dGVEstatisticas
            // 
            this.dGVEstatisticas.AllowUserToAddRows = false;
            this.dGVEstatisticas.AllowUserToDeleteRows = false;
            this.dGVEstatisticas.AllowUserToOrderColumns = true;
            this.dGVEstatisticas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVEstatisticas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVEstatisticas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVEstatisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVEstatisticas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNickname,
            this.cWins,
            this.cDefeats,
            this.cTotalGames});
            this.dGVEstatisticas.Location = new System.Drawing.Point(5, 6);
            this.dGVEstatisticas.MultiSelect = false;
            this.dGVEstatisticas.Name = "dGVEstatisticas";
            this.dGVEstatisticas.ReadOnly = true;
            this.dGVEstatisticas.Size = new System.Drawing.Size(550, 108);
            this.dGVEstatisticas.TabIndex = 25;
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
            // cDefeats
            // 
            this.cDefeats.HeaderText = "Defeats";
            this.cDefeats.Name = "cDefeats";
            this.cDefeats.ReadOnly = true;
            // 
            // cTotalGames
            // 
            this.cTotalGames.HeaderText = "Total Games";
            this.cTotalGames.Name = "cTotalGames";
            this.cTotalGames.ReadOnly = true;
            // 
            // ViewStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoDamas.Properties.Resources.back_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.lStatistics);
            this.Controls.Add(this.pDataGridView);
            this.Controls.Add(this.pbReturn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(557, 366);
            this.Name = "ViewStatistics";
            this.Text = "Checkers";
            this.Load += new System.EventHandler(this.ViewStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).EndInit();
            this.pDataGridView.ResumeLayout(false);
            this.pDataGridView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEstatisticas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbReturn;
        private System.Windows.Forms.Label lStatistics;
        private System.Windows.Forms.Panel pDataGridView;
        private System.Windows.Forms.RadioButton rBNone;
        private CueTextBox cTBNickname;
        private System.Windows.Forms.DateTimePicker dTPDataNascimento;
        private CueTextBox cTBTimePlayed;
        private System.Windows.Forms.RadioButton rBName;
        private System.Windows.Forms.ComboBox cBCountries;
        private System.Windows.Forms.RadioButton rBBirthDate;
        private System.Windows.Forms.RadioButton rBTimePlayed;
        private System.Windows.Forms.RadioButton rBCountry;
        private System.Windows.Forms.Label lSearchBy;
        private System.Windows.Forms.DataGridView dGVEstatisticas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cWins;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDefeats;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTotalGames;
    }
}