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
            this.bLeave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bLeave
            // 
            this.bLeave.Location = new System.Drawing.Point(356, 207);
            this.bLeave.Name = "bLeave";
            this.bLeave.Size = new System.Drawing.Size(75, 23);
            this.bLeave.TabIndex = 0;
            this.bLeave.Text = "Leave";
            this.bLeave.UseVisualStyleBackColor = true;
            this.bLeave.Click += new System.EventHandler(this.bLeave_Click);
            // 
            // ViewJogosInacabados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 277);
            this.Controls.Add(this.bLeave);
            this.Name = "ViewJogosInacabados";
            this.Text = "ViewJogosInacabados";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bLeave;
    }
}