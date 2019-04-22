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
        public ViewRegras()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewMenuMoreInfo Menu = new ViewMenuMoreInfo();
            Menu.Closed += (s, args) => this.Close();
            Menu.Show();
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
    }
}
