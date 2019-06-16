using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDamas
{
    public partial class ViewJogadorOponente : Form
    {
        public event MetodosSemParametros PedidoComecarJogo;

        public ViewJogadorOponente()
        {
            InitializeComponent();
        }

        private void bSelectUser_Click(object sender, EventArgs e)
        {
            //Verificar user na bd
            if (/*Válido*/true)
            {
                this.Hide();
                Program.V_Tabuleiro.Show();
                if (PedidoComecarJogo != null)
                {
                    PedidoComecarJogo();
                }
            }

            
        }


        private void pbReturn_Click(object sender, EventArgs e)
        {

                this.Hide();
                Program.V_ModoJogo.Show();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (cueTextBox1.PasswordChar == '*')
            {
                ((PictureBox)sender).BorderStyle = BorderStyle.Fixed3D;
                cueTextBox1.PasswordChar = '\0';
            }
            else
            {
                ((PictureBox)sender).BorderStyle = BorderStyle.None;
                cueTextBox1.PasswordChar = '*';
            }

        }
    }
}
