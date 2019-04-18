namespace ProjetoDamas
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.titulo = new System.Windows.Forms.Label();
            this.buttonjogar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonregras = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.Transparent;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.MintCream;
            this.titulo.Location = new System.Drawing.Point(106, 38);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(210, 31);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Checkers Game";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonjogar
            // 
            this.buttonjogar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonjogar.Location = new System.Drawing.Point(103, 109);
            this.buttonjogar.Name = "buttonjogar";
            this.buttonjogar.Size = new System.Drawing.Size(102, 23);
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
            this.button1.Location = new System.Drawing.Point(309, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonregras
            // 
            this.buttonregras.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonregras.FlatAppearance.BorderSize = 2;
            this.buttonregras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonregras.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonregras.Location = new System.Drawing.Point(219, 225);
            this.buttonregras.Name = "buttonregras";
            this.buttonregras.Size = new System.Drawing.Size(75, 25);
            this.buttonregras.TabIndex = 3;
            this.buttonregras.Text = "Rules";
            this.buttonregras.UseVisualStyleBackColor = true;
            this.buttonregras.Click += new System.EventHandler(this.buttonregras_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(219, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Continue Game";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(413, 268);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonregras);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonjogar);
            this.Controls.Add(this.titulo);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Olive;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button buttonjogar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonregras;
        private System.Windows.Forms.Button button2;
    }
}

