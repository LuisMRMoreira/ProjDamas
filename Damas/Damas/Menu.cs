using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Menu : Form
    {
        public Menu()
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
            Viewmodojogo option_gamemode = new Viewmodojogo(); 
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
            Rules option_regras = new Rules();
            option_regras.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //instanciar login
        }
    }
}