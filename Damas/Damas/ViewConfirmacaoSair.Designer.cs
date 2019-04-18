namespace Damas
{
    partial class ViewConfirmacaoSair
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
            this.label1 = new System.Windows.Forms.Label();
            this.bSim = new System.Windows.Forms.Button();
            this.bNao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pretende sair sem guardar?";
            // 
            // bSim
            // 
            this.bSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSim.Location = new System.Drawing.Point(59, 92);
            this.bSim.Name = "bSim";
            this.bSim.Size = new System.Drawing.Size(75, 23);
            this.bSim.TabIndex = 1;
            this.bSim.Text = "Sim";
            this.bSim.UseVisualStyleBackColor = true;
            // 
            // bNao
            // 
            this.bNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNao.Location = new System.Drawing.Point(182, 92);
            this.bNao.Name = "bNao";
            this.bNao.Size = new System.Drawing.Size(75, 23);
            this.bNao.TabIndex = 2;
            this.bNao.Text = "Não";
            this.bNao.UseVisualStyleBackColor = true;
            // 
            // ViewConfirmacaoSair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 159);
            this.Controls.Add(this.bNao);
            this.Controls.Add(this.bSim);
            this.Controls.Add(this.label1);
            this.Name = "ViewConfirmacaoSair";
            this.Text = "Confirmaçao de saída";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bSim;
        private System.Windows.Forms.Button bNao;
    }
}