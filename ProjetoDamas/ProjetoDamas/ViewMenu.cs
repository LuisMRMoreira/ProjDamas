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
    public partial class ViewMenu : Form
    {
        public ViewMenu()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ViewMoDoJogo option_gamemode = new ViewMoDoJogo(); 
            //option_gamemode.Show();
            this.Hide();
            ViewModoJogo option_gamemode = new ViewModoJogo();
            option_gamemode.Closed += (s, args) => this.Close();
            option_gamemode.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("You sure you wanna leave the aplicattion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonregras_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewRegras option_regras = new ViewRegras();
            option_regras.Closed += (s, args) => this.Close();
            option_regras.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //instanciar login
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewProfile prof = new ViewProfile();
            prof.Closed += (s, args) => this.Close();
            prof.Show();
        }

        private void bContinueGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewJogosInacabados jogos_inacabados = new ViewJogosInacabados();
            jogos_inacabados.Closed += (s, args) => this.Close();
            jogos_inacabados.Show();
        }
    }
}