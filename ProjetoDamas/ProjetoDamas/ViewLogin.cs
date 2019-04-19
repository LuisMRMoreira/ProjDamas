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
            this.Hide();
            ViewRegister registar = new ViewRegister();
            registar.Closed += (s, args) => this.Close();
            registar.Show();

            ////this.Hide();
            ////var form2 = new Form2();
            ////form2.Closed += (s, args) => this.Close();
            ////form2.Show();


        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //Menu menu = new Menu
            this.Hide();
            ViewMenu Menu = new ViewMenu();
            Menu.Closed += (s, args) => this.Close();
            Menu.Show();

        }

        private void buttonLeave_Click(object sender, EventArgs e)
        {
            //this.Close();

            //if (System.Windows.Forms.Application.MessageLoop)
            //{
            //    // WinForms app
            //    System.Windows.Forms.Application.Exit();
            //}
            //else
            //{
            //    // Console app
            //    System.Environment.Exit(1);
            //}

            if (MessageBox.Show("You sure you wanna leave the aplicattion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application designed by Carlos Nunes, Diogo Fidalgo, Luis Moreira. \nAll rights reserved.",
                               "About the application: ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }

}

