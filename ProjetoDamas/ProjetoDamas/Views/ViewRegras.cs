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
    public partial class ViewRegras : Form
    {
        public bool jogo = false;

        public ViewRegras()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lCondicoesGanhar_MouseHover(object sender, EventArgs e)
        {
            lCondicoesGanhar2.Visible = true;
        }

        private void lCondicoesPerder_MouseHover(object sender, EventArgs e)
        {
            lCondicoesPerder2.Visible = true;
        }

        private void llaws_MouseHover(object sender, EventArgs e)
        {
            llaws2.Visible = true;
        }

        private void llaws_MouseLeave(object sender, EventArgs e)
        {
            llaws2.Visible = false;
        }

        private void lCondicoesPerder_MouseLeave(object sender, EventArgs e)
        {
            lCondicoesPerder2.Visible = false;
        }

        private void lCondicoesGanhar_MouseLeave(object sender, EventArgs e)
        {
            lCondicoesGanhar2.Visible = false;
        }

        private void ViewRegras_Load(object sender, EventArgs e)
        {
            pUp.BackColor = Color.FromArgb(170, 0, 0, 0);
            pDown.BackColor = Color.FromArgb(170, 0, 0, 0);

        }

        private void lDrawConditions_MouseHover(object sender, EventArgs e)
        {
            lDrawConditions2.Visible = true;
        }

        private void lDrawConditions_MouseLeave(object sender, EventArgs e)
        {
            lDrawConditions2.Visible = false;
        }



        private void pBReturn_Click(object sender, EventArgs e)
        {
            if (jogo)
            {
                this.Hide();
                Program.V_Tabuleiro.Show();
                jogo = false;
            }
            else
            {
                this.Hide();
                Program.V_Menu.Show();
            }

        }


    }
}
