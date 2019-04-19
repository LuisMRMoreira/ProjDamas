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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonsair = new System.Windows.Forms.Button();
            this.buttonregras = new System.Windows.Forms.Button();
            this.bMenu = new System.Windows.Forms.Button();
            this.cBJogador = new System.Windows.Forms.ComboBox();
            this.cBJogo = new System.Windows.Forms.ComboBox();
            this.bPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(87, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "GAME MODE";
            // 
            // buttonsair
            // 
            this.buttonsair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonsair.FlatAppearance.BorderSize = 2;
            this.buttonsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsair.Location = new System.Drawing.Point(197, 212);
            this.buttonsair.Name = "buttonsair";
            this.buttonsair.Size = new System.Drawing.Size(75, 23);
            this.buttonsair.TabIndex = 3;
            this.buttonsair.Text = "Exit";
            this.buttonsair.UseVisualStyleBackColor = true;
            // 
            // buttonregras
            // 
            this.buttonregras.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonregras.FlatAppearance.BorderSize = 2;
            this.buttonregras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonregras.Location = new System.Drawing.Point(116, 212);
            this.buttonregras.Name = "buttonregras";
            this.buttonregras.Size = new System.Drawing.Size(75, 23);
            this.buttonregras.TabIndex = 4;
            this.buttonregras.Text = "Rules";
            this.buttonregras.UseVisualStyleBackColor = true;
            this.buttonregras.Click += new System.EventHandler(this.buttonregras_Click);
            // 
            // bMenu
            // 
            this.bMenu.Location = new System.Drawing.Point(35, 212);
            this.bMenu.Name = "bMenu";
            this.bMenu.Size = new System.Drawing.Size(75, 22);
            this.bMenu.TabIndex = 5;
            this.bMenu.Text = "Menu";
            this.bMenu.UseVisualStyleBackColor = true;
            this.bMenu.Click += new System.EventHandler(this.bMenu_Click);
            // 
            // cBJogador
            // 
            this.cBJogador.FormattingEnabled = true;
            this.cBJogador.Items.AddRange(new object[] {
            "Multiplayer",
            "Robot"});
            this.cBJogador.Location = new System.Drawing.Point(90, 78);
            this.cBJogador.Name = "cBJogador";
            this.cBJogador.Size = new System.Drawing.Size(121, 21);
            this.cBJogador.TabIndex = 6;
            this.cBJogador.SelectionChangeCommitted += new System.EventHandler(this.cBJogador_SelectionChangeCommitted);
            // 
            // cBJogo
            // 
            this.cBJogo.FormattingEnabled = true;
            this.cBJogo.Items.AddRange(new object[] {
            "Local",
            "Online"});
            this.cBJogo.Location = new System.Drawing.Point(90, 123);
            this.cBJogo.Name = "cBJogo";
            this.cBJogo.Size = new System.Drawing.Size(121, 21);
            this.cBJogo.TabIndex = 7;
            // 
            // bPlay
            // 
            this.bPlay.Location = new System.Drawing.Point(116, 163);
            this.bPlay.Name = "bPlay";
            this.bPlay.Size = new System.Drawing.Size(75, 23);
            this.bPlay.TabIndex = 8;
            this.bPlay.Text = "Play";
            this.bPlay.UseVisualStyleBackColor = true;
            this.bPlay.Click += new System.EventHandler(this.bPlay_Click);
            // 
            // ViewModoJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(312, 262);
            this.Controls.Add(this.bPlay);
            this.Controls.Add(this.cBJogo);
            this.Controls.Add(this.cBJogador);
            this.Controls.Add(this.bMenu);
            this.Controls.Add(this.buttonregras);
            this.Controls.Add(this.buttonsair);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "ViewModoJogo";
            this.Text = "Viewmodojogo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonsair;
        private System.Windows.Forms.Button buttonregras;
        private System.Windows.Forms.Button bMenu;
        private System.Windows.Forms.ComboBox cBJogador;
        private System.Windows.Forms.ComboBox cBJogo;
        private System.Windows.Forms.Button bPlay;
    }
}