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
    public partial class Viewmodojogo : Form
    {
        public Viewmodojogo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //instanciar login
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttoncliente_Click(object sender, EventArgs e)
        {
            //instanciar login
        }

        private void buttonregras_Click(object sender, EventArgs e)
        {
            Rules option_rules = new Rules();
            option_rules.Show();
        }
    }
}
