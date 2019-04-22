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
            ViewMenu Menu = new ViewMenu();
            Menu.Closed += (s, args) => this.Close();
            Menu.Show();
        }
    }
}
