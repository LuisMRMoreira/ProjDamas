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
                this.Hide();
                ViewJogoRobot robot = new ViewJogoRobot();
                robot.Closed += (s, args) => this.Close();
                robot.Show();
            }
            else
            {
                if (cBJogo.SelectedIndex == 1)//Online
                {
                    this.Hide();
                    ViewJogoOnline online = new ViewJogoOnline();
                    online.Closed += (s, args) => this.Close();
                    online.Show();
                }
                else//local
                {
                    this.Hide();
                    ViewJogo local = new ViewJogo();
                    local.Closed += (s, args) => this.Close();
                    local.Show();
                }
            }
        }

        private void pbReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewMenu Menu = new ViewMenu();
            Menu.Closed += (s, args) => this.Close();
            Menu.Show();
        }
    }
}
