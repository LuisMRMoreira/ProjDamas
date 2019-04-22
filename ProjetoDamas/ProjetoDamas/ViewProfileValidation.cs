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
    public partial class ViewProfileValidation : Form
    {
        public ViewProfileValidation()
        {
            InitializeComponent();
        }

        private void buttonNexPC_Click(object sender, EventArgs e)
        {
            ViewMakeProfileChanges vmpc = new ViewMakeProfileChanges();
            vmpc.Show();
        }


        private void pbReturn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You sure you wanna leave?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                ViewProfile profile = new ViewProfile();
                profile.Closed += (s, args) => this.Close();
                profile.Show();
            }
        }
    }
}
