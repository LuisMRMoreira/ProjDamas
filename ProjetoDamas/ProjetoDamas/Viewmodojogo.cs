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
    public partial class ViewModoJogo : Form
    {
        public ViewModoJogo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //instanciar login
        }


        private void buttonregras_Click(object sender, EventArgs e)
        {
            ViewRegras option_rules = new ViewRegras();
            option_rules.Show();
        }

        private void bMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewMenu Menu = new ViewMenu();
            Menu.Closed += (s, args) => this.Close();
            Menu.Show();
        }



        private void cBJogador_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cBJogador.SelectedIndex == 1)//robot
            {
                cBJogo.SelectedIndex = 0;
                cBJogo.Enabled = false;
            }
            else
            {
                cBJogo.Enabled = true;
            }
        }

        private void bPlay_Click(object sender, EventArgs e)
        {
            if (cBJogador.SelectedIndex == 1)//robot
            {

            }
            else
            {
                if (cBJogo.SelectedIndex == 1)//Online
                {

                }
                else//local
                {

                }
            }
        }
    }
}
