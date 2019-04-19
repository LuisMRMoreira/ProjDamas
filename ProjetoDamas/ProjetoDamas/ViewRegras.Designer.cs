namespace ProjetoDamas
{
    partial class Rules
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
            this.textBoxrules = new System.Windows.Forms.TextBox();
            this.bLeave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxrules
            // 
            this.textBoxrules.Location = new System.Drawing.Point(-1, 0);
            this.textBoxrules.Multiline = true;
            this.textBoxrules.Name = "textBoxrules";
            this.textBoxrules.Size = new System.Drawing.Size(285, 261);
            this.textBoxrules.TabIndex = 0;
            this.textBoxrules.TextChanged += new System.EventHandler(this.textBoxrules_TextChanged);
            // 
            // bLeave
            // 
            this.bLeave.Location = new System.Drawing.Point(197, 227);
            this.bLeave.Name = "bLeave";
            this.bLeave.Size = new System.Drawing.Size(75, 23);
            this.bLeave.TabIndex = 1;
            this.bLeave.Text = "Leave";
            this.bLeave.UseVisualStyleBackColor = true;
            this.bLeave.Click += new System.EventHandler(this.bLeave_Click);
            // 
            // Rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.bLeave);
            this.Controls.Add(this.textBoxrules);
            this.Name = "Rules";
            this.Text = "Regras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxrules;
        private System.Windows.Forms.Button bLeave;
    }
}