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
            this.titulo = new System.Windows.Forms.Label();
            this.buttonjogar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bRegras = new System.Windows.Forms.Button();
            this.bContinueGame = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.Transparent;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.NavajoWhite;
            this.titulo.Location = new System.Drawing.Point(203, 9);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(247, 37);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Checkers Game";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonjogar
            // 
            this.buttonjogar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonjogar.Location = new System.Drawing.Point(25, 71);
            this.buttonjogar.Name = "buttonjogar";
            this.buttonjogar.Size = new System.Drawing.Size(116, 34);
            this.buttonjogar.TabIndex = 1;
            this.buttonjogar.Text = "New Game";
            this.buttonjogar.UseVisualStyleBackColor = true;
            this.buttonjogar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(393, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bRegras
            // 
            this.bRegras.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bRegras.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bRegras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRegras.ForeColor = System.Drawing.Color.Black;
            this.bRegras.Location = new System.Drawing.Point(26, 196);
            this.bRegras.Name = "bRegras";
            this.bRegras.Size = new System.Drawing.Size(115, 37);
            this.bRegras.TabIndex = 3;
            this.bRegras.Text = "Rules";
            this.bRegras.UseVisualStyleBackColor = false;
            this.bRegras.Click += new System.EventHandler(this.buttonregras_Click);
            // 
            // bContinueGame
            // 
            this.bContinueGame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bContinueGame.Location = new System.Drawing.Point(25, 111);
            this.bContinueGame.Name = "bContinueGame";
            this.bContinueGame.Size = new System.Drawing.Size(116, 36);
            this.bContinueGame.TabIndex = 4;
            this.bContinueGame.Text = "Continue Game";
            this.bContinueGame.UseVisualStyleBackColor = true;
            this.bContinueGame.Click += new System.EventHandler(this.bContinueGame_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.ForeColor = System.Drawing.Color.Black;
            this.buttonProfile.Location = new System.Drawing.Point(26, 153);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(115, 37);
            this.buttonProfile.TabIndex = 5;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // ViewMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(480, 300);
            this.Controls.Add(this.buttonProfile);
            this.Controls.Add(this.bContinueGame);
            this.Controls.Add(this.bRegras);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonjogar);
            this.Controls.Add(this.titulo);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Olive;
            this.Name = "ViewMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button buttonjogar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bRegras;
        private System.Windows.Forms.Button bContinueGame;
        private System.Windows.Forms.Button buttonProfile;
    }
}

