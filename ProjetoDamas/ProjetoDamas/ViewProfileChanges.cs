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
    public partial class ViewProfileChanges : Form
    {
        public ViewProfileChanges()
        {
            InitializeComponent();
        }

        private void buttonNexPC_Click(object sender, EventArgs e)
        {
            ViewMakeProfileChanges vmpc = new ViewMakeProfileChanges();
            vmpc.Show();
        }

        private void ViewProfileChanges_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsername1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
