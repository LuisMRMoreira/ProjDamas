namespace Menu
{
    partial class Viewmodojogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Viewmodojogo));
            this.buttonstandalone = new System.Windows.Forms.Button();
            this.buttoncliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonsair = new System.Windows.Forms.Button();
            this.buttonregras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonstandalone
            // 
            this.buttonstandalone.Location = new System.Drawing.Point(50, 95);
            this.buttonstandalone.Name = "buttonstandalone";
            this.buttonstandalone.Size = new System.Drawing.Size(75, 23);
            this.buttonstandalone.TabIndex = 0;
            this.buttonstandalone.Text = "Standalone";
            this.buttonstandalone.UseVisualStyleBackColor = true;
            this.buttonstandalone.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttoncliente
            // 
            this.buttoncliente.Location = new System.Drawing.Point(142, 95);
            this.buttoncliente.Name = "buttoncliente";
            this.buttoncliente.Size = new System.Drawing.Size(75, 23);
            this.buttoncliente.TabIndex = 1;
            this.buttoncliente.Text = "Client";
            this.buttoncliente.UseVisualStyleBackColor = true;
            this.buttoncliente.Click += new System.EventHandler(this.buttoncliente_Click);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.buttonsair.Click += new System.EventHandler(this.button1_Click_1);
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
            // Viewmodojogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonregras);
            this.Controls.Add(this.buttonsair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttoncliente);
            this.Controls.Add(this.buttonstandalone);
            this.DoubleBuffered = true;
            this.Name = "Viewmodojogo";
            this.Text = "Viewmodojogo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonstandalone;
        private System.Windows.Forms.Button buttoncliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonsair;
        private System.Windows.Forms.Button buttonregras;
    }
}