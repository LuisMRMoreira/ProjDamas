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
        public event MetodosComDuasStrings PedidoLogin;

        public ViewLogin()
        {
            InitializeComponent();
            //Program.M_Jogador.ContaCriada += M_Jogador_ContaCriada;
            //Program.M_Gestor.RespostaLoginInvalido += M_Gestor_RespostaLoginInvalido;
            //Program.M_Gestor.RespostaTerminarSessao += M_Gestor_RespostaTerminarSessao;
            //Program.M_Gestor.RespostaPedidoLoginSucesso += M_Gestor_RespostaPedidoLoginSucesso;

        }

        /// <summary>
        /// Parte nova
        /// </summary>
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_Register.Show();

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (PedidoLogin != null)
                PedidoLogin(ctBUsername.Text, cTBPassword.Text);
        }

        /// <summary>
        /// Fim Parte nova
        /// </summary>



        private void M_Gestor_RespostaPedidoLoginSucesso(User u)
        {
            this.Hide();
            Program.V_Menu.Show();
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


        private void ViewLogin_VisibleChanged(object sender, EventArgs e)
        {
            cTBPassword.Text = "";
            ctBUsername.Text = "";
        }
    }

}

