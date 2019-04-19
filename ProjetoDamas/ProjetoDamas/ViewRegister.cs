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
    public partial class ViewRegister : Form
    {
        public ViewRegister()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter= "All Graphics Types | *.bmp; *.jpg; *.jpeg; *.png; *.tif; *.tiff";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                /*if (PedidoAbrirPic != null)
                    PedidoAbrirPic(openFileDialog1.FileName);*/
            }
        }

        private void buttonProceed_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewLogin login = new ViewLogin();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void bMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewMenu Menu = new ViewMenu();
            Menu.Closed += (s, args) => this.Close();
            Menu.Show();
        }
    }
}
