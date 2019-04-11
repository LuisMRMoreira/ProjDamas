using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class ViewLogin : Form
    {
        public ViewLogin()
        {
            InitializeComponent();
            textBoxUsername.Text = "username";
            textBoxPassword.Text = "password";

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            ViewRegister registar = new ViewRegister();
            registar.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonLeave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application designed by Carlos Nunes, Diogo Fidalgo, Luis Moreira. \nAll rights reserved.",
                               "About the application: ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }

}

