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
        public event MetodosComDuasStrings PedidoLoginJogador;

        public ViewLogin()
        {
            InitializeComponent();
            Program.M_Jogador.ContaCriada += M_Jogador_ContaCriada;




            Program.M_Gestor.RespostaLoginInvalido += M_Gestor_RespostaLoginInvalido;
            Program.M_Gestor.RespostaTerminarSessao += M_Gestor_RespostaTerminarSessao;

        }

        private void M_Gestor_RespostaTerminarSessao()
        {
            this.Show();
            MessageBox.Show("The session has ended successfully", "Successfull logout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            ctBUsername.Text = "";
            cTBPassword.Text = "";
        }

        private void M_Gestor_RespostaLoginInvalido()
        {
            this.Show();
            MessageBox.Show("Invalid username or password. Please try again.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            ctBUsername.Text = "";
            cTBPassword.Text = "";
        }





        private void M_Jogador_ContaCriada()
        {
            this.Show();
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

            if (PedidoLoginJogador != null)
            {
                PedidoLoginJogador(ctBUsername.Text, cTBPassword.Text);
            }
            
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

