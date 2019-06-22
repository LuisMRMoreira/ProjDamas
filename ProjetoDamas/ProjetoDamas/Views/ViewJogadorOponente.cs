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
    public partial class ViewJogadorOponente : Form
    {
        public event MetodosComDuasStrings PedidoVerificarUser;
        public event MetodosComUmUserEUMJogador PedidoComecarJogo;


        public ViewJogadorOponente()
        {
            InitializeComponent();
            Program.M_User.RespostaUsers += M_User_RespostaUsers;
        }

        /// <summary>
        /// Novos
        /// </summary>

        private void M_User_RespostaUsers(User u1, User u2)
        {
            cTBUsername.Text = "";
            cTBPassword.Text = "";
            this.Hide();

            Pessoa p = new Pessoa(u2, false, false);//TESTAR :::::: Problema com a organização das classes. Verificar se quando começar o jogo, a cor e a prioridade está bem 

            if (PedidoComecarJogo != null)
                PedidoComecarJogo(u1,p);

        }

        /// <summary>
        /// Fim novos
        /// </summary>


        private void bSelectUser_Click(object sender, EventArgs e)
        {
            //Verificar user na bd
            if (PedidoVerificarUser != null)
            {
                PedidoVerificarUser(cTBUsername.Text, cTBPassword.Text);
            }
            
        }


        private void pbReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_ModoJogo.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (cTBPassword.PasswordChar == '*')
            {
                ((PictureBox)sender).BorderStyle = BorderStyle.Fixed3D;
                cTBPassword.PasswordChar = '\0';
            }
            else
            {
                ((PictureBox)sender).BorderStyle = BorderStyle.None;
                cTBPassword.PasswordChar = '*';
            }

        }

    }
}
