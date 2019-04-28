namespace ProjetoDamas
{
    partial class ViewJogosInacabados
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewJogosInacabados));
            this.pbReturn = new System.Windows.Forms.PictureBox();
            this.pDataGridView = new System.Windows.Forms.Panel();
            this.rBNone = new System.Windows.Forms.RadioButton();
            this.cTBNickname = new ProjetoDamas.CueTextBox();
            this.dTPDataDeJogo = new System.Windows.Forms.DateTimePicker();
            this.rBName = new System.Windows.Forms.RadioButton();
            this.cBCountries = new System.Windows.Forms.ComboBox();
            this.rBDate = new System.Windows.Forms.RadioButton();
            this.rBCountry = new System.Windows.Forms.RadioButton();
            this.lSearchBy = new System.Windows.Forms.Label();
            this.dGVJogosInacabados = new System.Windows.Forms.DataGridView();
            this.cPlayerOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPlayerTwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lUnfinishedGames = new System.Windows.Forms.Label();
            this.tTJogoInacabados = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).BeginInit();
            this.pDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVJogosInacabados)).BeginInit();
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
            this.pbReturn.TabIndex = 24;
            this.pbReturn.TabStop = false;
            this.pbReturn.Click += new System.EventHandler(this.pbReturn_Click);
            // 
            // pDataGridView
            // 
            this.pDataGridView.Controls.Add(this.rBNone);
            this.pDataGridView.Controls.Add(this.cTBNickname);
            this.pDataGridView.Controls.Add(this.dTPDataDeJogo);
            this.pDataGridView.Controls.Add(this.rBName);
            this.pDataGridView.Controls.Add(this.cBCountries);
            this.pDataGridView.Controls.Add(this.rBDate);
            this.pDataGridView.Controls.Add(this.rBCountry);
            this.pDataGridView.Controls.Add(this.lSearchBy);
            this.pDataGridView.Controls.Add(this.dGVJogosInacabados);
            this.pDataGridView.Location = new System.Drawing.Point(69, 70);
            this.pDataGridView.Name = "pDataGridView";
            this.pDataGridView.Size = new System.Drawing.Size(454, 262);
            this.pDataGridView.TabIndex = 27;
            this.tTJogoInacabados.SetToolTip(this.pDataGridView, "Unfineshed local games");
            // 
            // rBNone
            // 
            this.rBNone.AutoSize = true;
            this.rBNone.BackColor = System.Drawing.Color.Transparent;
            this.rBNone.Checked = true;
            this.rBNone.Font = new System.Drawing.Font("Kristen ITC", 9F);
            this.rBNone.ForeColor = System.Drawing.Color.DimGray;
            this.rBNone.Location = new System.Drawing.Point(361, 191);
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
            this.cTBNickname.Location = new System.Drawing.Point(130, 221);
            this.cTBNickname.Name = "cTBNickname";
            this.cTBNickname.Size = new System.Drawing.Size(199, 29);
            this.cTBNickname.TabIndex = 85;
            this.cTBNickname.Visible = false;
            // 
            // dTPDataDeJogo
            // 
            this.dTPDataDeJogo.CalendarForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dTPDataDeJogo.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.dTPDataDeJogo.CalendarTitleBackColor = System.Drawing.SystemColors.WindowFrame;
            this.dTPDataDeJogo.CalendarTitleForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dTPDataDeJogo.CalendarTrailingForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dTPDataDeJogo.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.dTPDataDeJogo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPDataDeJogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dTPDataDeJogo.Location = new System.Drawing.Point(130, 221);
            this.dTPDataDeJogo.Name = "dTPDataDeJogo";
            this.dTPDataDeJogo.Size = new System.Drawing.Size(199, 29);
            this.dTPDataDeJogo.TabIndex = 84;
            this.dTPDataDeJogo.Visible = false;
            // 
            // rBName
            // 
            this.rBName.AutoSize = true;
            this.rBName.BackColor = System.Drawing.Color.Transparent;
            this.rBName.Font = new System.Drawing.Font("Kristen ITC", 9F);
            this.rBName.ForeColor = System.Drawing.Color.DimGray;
            this.rBName.Location = new System.Drawing.Point(244, 191);
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
            this.cBCountries.Location = new System.Drawing.Point(130, 221);
            this.cBCountries.Name = "cBCountries";
            this.cBCountries.Size = new System.Drawing.Size(199, 29);
            this.cBCountries.TabIndex = 80;
            this.cBCountries.Visible = false;
            // 
            // rBDate
            // 
            this.rBDate.AutoSize = true;
            this.rBDate.BackColor = System.Drawing.Color.Transparent;
            this.rBDate.Font = new System.Drawing.Font("Kristen ITC", 9F);
            this.rBDate.ForeColor = System.Drawing.Color.DimGray;
            this.rBDate.Location = new System.Drawing.Point(157, 190);
            this.rBDate.Name = "rBDate";
            this.rBDate.Size = new System.Drawing.Size(57, 21);
            this.rBDate.TabIndex = 79;
            this.rBDate.Text = "Date";
            this.rBDate.UseVisualStyleBackColor = false;
            this.rBDate.CheckedChanged += new System.EventHandler(this.rBDate_CheckedChanged);
            // 
            // rBCountry
            // 
            this.rBCountry.AutoSize = true;
            this.rBCountry.BackColor = System.Drawing.Color.Transparent;
            this.rBCountry.Font = new System.Drawing.Font("Kristen ITC", 8F);
            this.rBCountry.ForeColor = System.Drawing.Color.DimGray;
            this.rBCountry.Location = new System.Drawing.Point(45, 191);
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
            this.lSearchBy.Location = new System.Drawing.Point(1, 167);
            this.lSearchBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lSearchBy.Name = "lSearchBy";
            this.lSearchBy.Size = new System.Drawing.Size(90, 19);
            this.lSearchBy.TabIndex = 76;
            this.lSearchBy.Text = "Search by:";
            // 
            // dGVJogosInacabados
            // 
            this.dGVJogosInacabados.AllowUserToAddRows = false;
            this.dGVJogosInacabados.AllowUserToDeleteRows = false;
            this.dGVJogosInacabados.AllowUserToOrderColumns = true;
            this.dGVJogosInacabados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVJogosInacabados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVJogosInacabados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cPlayerOne,
            this.cPlayerTwo,
            this.cTime,
            this.cDate});
            this.dGVJogosInacabados.Location = new System.Drawing.Point(5, 6);
            this.dGVJogosInacabados.Name = "dGVJogosInacabados";
            this.dGVJogosInacabados.ReadOnly = true;
            this.dGVJogosInacabados.Size = new System.Drawing.Size(443, 143);
            this.dGVJogosInacabados.TabIndex = 25;
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
            // cTime
            // 
            this.cTime.HeaderText = "Time";
            this.cTime.Name = "cTime";
            this.cTime.ReadOnly = true;
            // 
            // cDate
            // 
            this.cDate.HeaderText = "Date";
            this.cDate.Name = "cDate";
            this.cDate.ReadOnly = true;
            this.cDate.ToolTipText = "Date";
            // 
            // lUnfinishedGames
            // 
            this.lUnfinishedGames.AutoSize = true;
            this.lUnfinishedGames.BackColor = System.Drawing.Color.Transparent;
            this.lUnfinishedGames.Font = new System.Drawing.Font("Matura MT Script Capitals", 25F);
            this.lUnfinishedGames.ForeColor = System.Drawing.Color.DimGray;
            this.lUnfinishedGames.Location = new System.Drawing.Point(154, 12);
            this.lUnfinishedGames.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lUnfinishedGames.Name = "lUnfinishedGames";
            this.lUnfinishedGames.Size = new System.Drawing.Size(299, 45);
            this.lUnfinishedGames.TabIndex = 28;
            this.lUnfinishedGames.Text = "Unfinished Games";
            // 
            // ViewJogosInacabados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoDamas.Properties.Resources.back_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(577, 382);
            this.Controls.Add(this.lUnfinishedGames);
            this.Controls.Add(this.pDataGridView);
            this.Controls.Add(this.pbReturn);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewJogosInacabados";
            this.Text = "Checkers";
            this.Load += new System.EventHandler(this.ViewJogosInacabados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).EndInit();
            this.pDataGridView.ResumeLayout(false);
            this.pDataGridView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVJogosInacabados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbReturn;
        private System.Windows.Forms.Panel pDataGridView;
        private System.Windows.Forms.RadioButton rBNone;
        private CueTextBox cTBNickname;
        private System.Windows.Forms.DateTimePicker dTPDataDeJogo;
        private System.Windows.Forms.RadioButton rBName;
        private System.Windows.Forms.ComboBox cBCountries;
        private System.Windows.Forms.RadioButton rBDate;
        private System.Windows.Forms.RadioButton rBCountry;
        private System.Windows.Forms.Label lSearchBy;
        private System.Windows.Forms.DataGridView dGVJogosInacabados;
        private System.Windows.Forms.Label lUnfinishedGames;
        private System.Windows.Forms.ToolTip tTJogoInacabados;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPlayerOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPlayerTwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDate;
    }
}