﻿namespace ProjetoDamas
{
    partial class ViewProfile
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
            this.buttonCheckProfile = new System.Windows.Forms.Button();
            this.buttonChangeProfile = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCheckProfile
            // 
            this.buttonCheckProfile.Location = new System.Drawing.Point(69, 108);
            this.buttonCheckProfile.Name = "buttonCheckProfile";
            this.buttonCheckProfile.Size = new System.Drawing.Size(180, 58);
            this.buttonCheckProfile.TabIndex = 0;
            this.buttonCheckProfile.Text = "Check profile";
            this.buttonCheckProfile.UseVisualStyleBackColor = true;
            this.buttonCheckProfile.Click += new System.EventHandler(this.buttonCheckProfile_Click);
            // 
            // buttonChangeProfile
            // 
            this.buttonChangeProfile.Location = new System.Drawing.Point(69, 211);
            this.buttonChangeProfile.Name = "buttonChangeProfile";
            this.buttonChangeProfile.Size = new System.Drawing.Size(180, 60);
            this.buttonChangeProfile.TabIndex = 1;
            this.buttonChangeProfile.Text = "Make profile changes";
            this.buttonChangeProfile.UseVisualStyleBackColor = true;
            this.buttonChangeProfile.Click += new System.EventHandler(this.buttonChangeProfile_Click);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.Transparent;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.NavajoWhite;
            this.titulo.Location = new System.Drawing.Point(281, 41);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(247, 37);
            this.titulo.TabIndex = 2;
            this.titulo.Text = "Checkers Game";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoDamas.Properties.Resources.imagemDeFundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(553, 448);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.buttonChangeProfile);
            this.Controls.Add(this.buttonCheckProfile);
            this.DoubleBuffered = true;
            this.Name = "ViewProfile";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCheckProfile;
        private System.Windows.Forms.Button buttonChangeProfile;
        private System.Windows.Forms.Label titulo;
    }
}

