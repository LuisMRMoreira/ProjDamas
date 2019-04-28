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
        public event MetodosSemParametros PedidoAlterarLableVmenu;

        public ViewLogin()
        {
            InitializeComponent();
            Program.M_Gestor.PedidoMostrarLogin += M_Gestor_PedidoMostrarLogin;
            Program.M_Jogador.ContaCriada += M_Jogador_ContaCriada;

        }

        private void M_Jogador_ContaCriada()
        {
            this.ShowDialog();
        }

        private void M_Gestor_PedidoMostrarLogin()
        {
            this.ShowDialog();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_Register.ShowDialog();


        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (PedidoAlterarLableVmenu != null)
            {
                PedidoAlterarLableVmenu();
            }

            //evia evento para 
            
            
            //Menu menu = new Menu
            //this.Hide();
            //iewMenu Menu = new ViewMenu();
            //Menu.Size = this.Size;
            //Menu.Location = this.Location;// new Point(this.Left, this.Top);            
            //Menu.Show();            
            //Menu.Closed += (s, args) => this.Close();

            
            
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

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            cTBPassword.PasswordChar = '\0';
            ((PictureBox)(sender)).BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            cTBPassword.PasswordChar = '*';
            ((PictureBox)(sender)).BorderStyle = BorderStyle.None;
        }

        private void ViewLogin_Load(object sender, EventArgs e)
        {
            cTBPassword.Text = "";
            ctBUsername.Text = "";
        }

        private void ViewLogin_Shown(object sender, EventArgs e)
        {
            cTBPassword.Text = "";
            ctBUsername.Text = "";
        }

        private void pbReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_Menu.Show();
        }
    }

}

