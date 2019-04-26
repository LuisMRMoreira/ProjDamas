namespace ProjetoDamas
{
    partial class ViewRegras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewRegras));
            this.lCondicoesGanhar2 = new System.Windows.Forms.Label();
            this.lCondicoesPerder2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.llaws2 = new System.Windows.Forms.Label();
            this.lRegras = new System.Windows.Forms.Label();
            this.lWinConditions = new System.Windows.Forms.Label();
            this.lDrawConditions = new System.Windows.Forms.Label();
            this.lDefeatConditions = new System.Windows.Forms.Label();
            this.lLaws = new System.Windows.Forms.Label();
            this.pUp = new System.Windows.Forms.Panel();
            this.pDown = new System.Windows.Forms.Panel();
            this.lDrawConditions2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pUp.SuspendLayout();
            this.pDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // lCondicoesGanhar2
            // 
            this.lCondicoesGanhar2.AutoSize = true;
            this.lCondicoesGanhar2.BackColor = System.Drawing.Color.Transparent;
            this.lCondicoesGanhar2.Font = new System.Drawing.Font("Kristen ITC", 10F);
            this.lCondicoesGanhar2.ForeColor = System.Drawing.SystemColors.Control;
            this.lCondicoesGanhar2.Location = new System.Drawing.Point(18, 128);
            this.lCondicoesGanhar2.Name = "lCondicoesGanhar2";
            this.lCondicoesGanhar2.Size = new System.Drawing.Size(568, 76);
            this.lCondicoesGanhar2.TabIndex = 2;
            this.lCondicoesGanhar2.Text = "a) The player captures all the pieces of the opponent;\r\nb) The opponent keeps the" +
    " pieces \"prisoners\" at the time of play and can not make\r\nthrow;\r\nc) The opponen" +
    "t declares abandonment;\r\n";
            this.lCondicoesGanhar2.Visible = false;
            // 
            // lCondicoesPerder2
            // 
            this.lCondicoesPerder2.AutoSize = true;
            this.lCondicoesPerder2.BackColor = System.Drawing.Color.Transparent;
            this.lCondicoesPerder2.Font = new System.Drawing.Font("Kristen ITC", 10F);
            this.lCondicoesPerder2.ForeColor = System.Drawing.SystemColors.Control;
            this.lCondicoesPerder2.Location = new System.Drawing.Point(22, 128);
            this.lCondicoesPerder2.Name = "lCondicoesPerder2";
            this.lCondicoesPerder2.Size = new System.Drawing.Size(500, 171);
            this.lCondicoesPerder2.TabIndex = 4;
            this.lCondicoesPerder2.Text = resources.GetString("lCondicoesPerder2.Text");
            this.lCondicoesPerder2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProjetoDamas.Properties.Resources.Icon_return;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // llaws2
            // 
            this.llaws2.AutoSize = true;
            this.llaws2.BackColor = System.Drawing.Color.Transparent;
            this.llaws2.Font = new System.Drawing.Font("Kristen ITC", 10F);
            this.llaws2.ForeColor = System.Drawing.SystemColors.Control;
            this.llaws2.Location = new System.Drawing.Point(22, 128);
            this.llaws2.Name = "llaws2";
            this.llaws2.Size = new System.Drawing.Size(579, 152);
            this.llaws2.TabIndex = 7;
            this.llaws2.Text = resources.GetString("llaws2.Text");
            this.llaws2.Visible = false;
            // 
            // lRegras
            // 
            this.lRegras.AutoSize = true;
            this.lRegras.BackColor = System.Drawing.Color.Transparent;
            this.lRegras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRegras.ForeColor = System.Drawing.Color.White;
            this.lRegras.Location = new System.Drawing.Point(266, 13);
            this.lRegras.Name = "lRegras";
            this.lRegras.Size = new System.Drawing.Size(66, 25);
            this.lRegras.TabIndex = 8;
            this.lRegras.Text = "Rules";
            // 
            // lWinConditions
            // 
            this.lWinConditions.AutoSize = true;
            this.lWinConditions.BackColor = System.Drawing.Color.Transparent;
            this.lWinConditions.Font = new System.Drawing.Font("Kristen ITC", 15F);
            this.lWinConditions.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lWinConditions.Location = new System.Drawing.Point(43, 12);
            this.lWinConditions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lWinConditions.Name = "lWinConditions";
            this.lWinConditions.Size = new System.Drawing.Size(164, 28);
            this.lWinConditions.TabIndex = 12;
            this.lWinConditions.Text = "Win conditions:";
            this.lWinConditions.MouseLeave += new System.EventHandler(this.lCondicoesGanhar_MouseLeave);
            this.lWinConditions.MouseHover += new System.EventHandler(this.lCondicoesGanhar_MouseHover);
            // 
            // lDrawConditions
            // 
            this.lDrawConditions.AutoSize = true;
            this.lDrawConditions.BackColor = System.Drawing.Color.Transparent;
            this.lDrawConditions.Font = new System.Drawing.Font("Kristen ITC", 15F);
            this.lDrawConditions.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lDrawConditions.Location = new System.Drawing.Point(43, 16);
            this.lDrawConditions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lDrawConditions.Name = "lDrawConditions";
            this.lDrawConditions.Size = new System.Drawing.Size(181, 28);
            this.lDrawConditions.TabIndex = 13;
            this.lDrawConditions.Text = "Draw conditions:";
            // 
            // lDefeatConditions
            // 
            this.lDefeatConditions.AutoSize = true;
            this.lDefeatConditions.BackColor = System.Drawing.Color.Transparent;
            this.lDefeatConditions.Font = new System.Drawing.Font("Kristen ITC", 15F);
            this.lDefeatConditions.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lDefeatConditions.Location = new System.Drawing.Point(364, 12);
            this.lDefeatConditions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lDefeatConditions.Name = "lDefeatConditions";
            this.lDefeatConditions.Size = new System.Drawing.Size(197, 28);
            this.lDefeatConditions.TabIndex = 14;
            this.lDefeatConditions.Text = "Defeat conditions:";
            this.lDefeatConditions.MouseLeave += new System.EventHandler(this.lCondicoesPerder_MouseLeave);
            this.lDefeatConditions.MouseHover += new System.EventHandler(this.lCondicoesPerder_MouseHover);
            // 
            // lLaws
            // 
            this.lLaws.AutoSize = true;
            this.lLaws.BackColor = System.Drawing.Color.Transparent;
            this.lLaws.Font = new System.Drawing.Font("Kristen ITC", 15F);
            this.lLaws.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lLaws.Location = new System.Drawing.Point(432, 16);
            this.lLaws.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lLaws.Name = "lLaws";
            this.lLaws.Size = new System.Drawing.Size(69, 28);
            this.lLaws.TabIndex = 15;
            this.lLaws.Text = "Laws:";
            this.lLaws.MouseLeave += new System.EventHandler(this.llaws_MouseLeave);
            this.lLaws.MouseHover += new System.EventHandler(this.llaws_MouseHover);
            // 
            // pUp
            // 
            this.pUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pUp.Controls.Add(this.lWinConditions);
            this.pUp.Controls.Add(this.lDefeatConditions);
            this.pUp.Location = new System.Drawing.Point(0, 61);
            this.pUp.Name = "pUp";
            this.pUp.Size = new System.Drawing.Size(586, 51);
            this.pUp.TabIndex = 16;
            // 
            // pDown
            // 
            this.pDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pDown.Controls.Add(this.lLaws);
            this.pDown.Controls.Add(this.lDrawConditions);
            this.pDown.Location = new System.Drawing.Point(0, 315);
            this.pDown.Name = "pDown";
            this.pDown.Size = new System.Drawing.Size(586, 51);
            this.pDown.TabIndex = 17;
            // 
            // lDrawConditions2
            // 
            this.lDrawConditions2.BackColor = System.Drawing.Color.Transparent;
            this.lDrawConditions2.Font = new System.Drawing.Font("Kristen ITC", 10F);
            this.lDrawConditions2.ForeColor = System.Drawing.SystemColors.Control;
            this.lDrawConditions2.Location = new System.Drawing.Point(18, 128);
            this.lDrawConditions2.Name = "lDrawConditions2";
            this.lDrawConditions2.Size = new System.Drawing.Size(579, 152);
            this.lDrawConditions2.TabIndex = 18;
            this.lDrawConditions2.Text = resources.GetString("lDrawConditions2.Text");
            this.lDrawConditions2.Visible = false;
            // 
            // ViewRegras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::ProjetoDamas.Properties.Resources.back_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(586, 378);
            this.Controls.Add(this.lDrawConditions2);
            this.Controls.Add(this.lRegras);
            this.Controls.Add(this.llaws2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lCondicoesPerder2);
            this.Controls.Add(this.lCondicoesGanhar2);
            this.Controls.Add(this.pUp);
            this.Controls.Add(this.pDown);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewRegras";
            this.Text = "Checkers";
            this.Load += new System.EventHandler(this.ViewRegras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pUp.ResumeLayout(false);
            this.pUp.PerformLayout();
            this.pDown.ResumeLayout(false);
            this.pDown.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lCondicoesGanhar2;
        private System.Windows.Forms.Label lCondicoesPerder2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label llaws2;
        private System.Windows.Forms.Label lRegras;
        private System.Windows.Forms.Label lWinConditions;
        private System.Windows.Forms.Label lDrawConditions;
        private System.Windows.Forms.Label lDefeatConditions;
        private System.Windows.Forms.Label lLaws;
        private System.Windows.Forms.Panel pUp;
        private System.Windows.Forms.Panel pDown;
        private System.Windows.Forms.Label lDrawConditions2;
    }
}