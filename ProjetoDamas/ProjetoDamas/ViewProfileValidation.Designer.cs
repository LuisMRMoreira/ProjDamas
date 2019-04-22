namespace ProjetoDamas
{
    partial class ViewProfileValidation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProfileValidation));
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPasswordPC = new System.Windows.Forms.TextBox();
            this.textBoxUsernamePC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonNexPC = new System.Windows.Forms.Button();
            this.pbReturn = new System.Windows.Forms.PictureBox();
            this.lValidation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(156, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Please confirm your login and password in order to \r\nchange your account settings" +
    "..";
            // 
            // textBoxPasswordPC
            // 
            this.textBoxPasswordPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxPasswordPC.ForeColor = System.Drawing.Color.Black;
            this.textBoxPasswordPC.Location = new System.Drawing.Point(248, 143);
            this.textBoxPasswordPC.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPasswordPC.Name = "textBoxPasswordPC";
            this.textBoxPasswordPC.PasswordChar = '*';
            this.textBoxPasswordPC.Size = new System.Drawing.Size(162, 20);
            this.textBoxPasswordPC.TabIndex = 13;
            // 
            // textBoxUsernamePC
            // 
            this.textBoxUsernamePC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxUsernamePC.ForeColor = System.Drawing.Color.Black;
            this.textBoxUsernamePC.Location = new System.Drawing.Point(248, 68);
            this.textBoxUsernamePC.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUsernamePC.Name = "textBoxUsernamePC";
            this.textBoxUsernamePC.Size = new System.Drawing.Size(162, 20);
            this.textBoxUsernamePC.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(156, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(156, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Username:";
            // 
            // buttonNexPC
            // 
            this.buttonNexPC.Location = new System.Drawing.Point(225, 274);
            this.buttonNexPC.Name = "buttonNexPC";
            this.buttonNexPC.Size = new System.Drawing.Size(133, 46);
            this.buttonNexPC.TabIndex = 16;
            this.buttonNexPC.Text = "Confirm";
            this.buttonNexPC.UseVisualStyleBackColor = true;
            this.buttonNexPC.Click += new System.EventHandler(this.buttonNexPC_Click);
            // 
            // pbReturn
            // 
            this.pbReturn.BackColor = System.Drawing.Color.Transparent;
            this.pbReturn.Image = global::ProjetoDamas.Properties.Resources.a429924cb33912470dd40d51a2f760ec_go_back_icon_clip_art_at_clkercom_vector_clip_art_online__300_300;
            this.pbReturn.Location = new System.Drawing.Point(12, 12);
            this.pbReturn.Name = "pbReturn";
            this.pbReturn.Size = new System.Drawing.Size(29, 28);
            this.pbReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReturn.TabIndex = 22;
            this.pbReturn.TabStop = false;
            this.pbReturn.Click += new System.EventHandler(this.pbReturn_Click);
            // 
            // lValidation
            // 
            this.lValidation.AutoSize = true;
            this.lValidation.BackColor = System.Drawing.Color.Transparent;
            this.lValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lValidation.ForeColor = System.Drawing.Color.White;
            this.lValidation.Location = new System.Drawing.Point(243, 15);
            this.lValidation.Name = "lValidation";
            this.lValidation.Size = new System.Drawing.Size(108, 25);
            this.lValidation.TabIndex = 23;
            this.lValidation.Text = "Validation";
            // 
            // ViewProfileValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoDamas.Properties.Resources.imagemDeFundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(548, 342);
            this.Controls.Add(this.lValidation);
            this.Controls.Add(this.pbReturn);
            this.Controls.Add(this.buttonNexPC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUsernamePC);
            this.Controls.Add(this.textBoxPasswordPC);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewProfileValidation";
            this.Text = "Checkers";
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPasswordPC;
        private System.Windows.Forms.TextBox textBoxUsernamePC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonNexPC;
        private System.Windows.Forms.PictureBox pbReturn;
        private System.Windows.Forms.Label lValidation;
    }
}