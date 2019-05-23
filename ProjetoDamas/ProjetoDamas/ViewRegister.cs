using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Collections;

namespace ProjetoDamas
{
    public partial class ViewRegister : Form
    {
        public event MetodosComInfoJogador PedidoCriarJogador; //ModelJogador

        public ViewRegister()
        {
            InitializeComponent();
            Program.M_Jogador.ErroPassDiferente += M_Jogador_ErroPassDiferente;
            Program.M_Jogador.ContaCriada += M_Jogador_ContaCriada; 
        }

        private void M_Jogador_ContaCriada()
        {
            this.Hide();
        }

        private void M_Jogador_ErroPassDiferente()
        {
            MessageBox.Show("Passwords doesn't match!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("You sure you wanna leave the regist?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Program.V_Login.Show();
            }
        }

        private void ViewRegister_Load(object sender, EventArgs e)
        {
                var list = CultureInfo.GetCultures(CultureTypes.SpecificCultures).
            Select(p => new RegionInfo(p.Name).EnglishName).
            Distinct().OrderBy(s => s).ToList();
                cBCountries.DataSource = list;
            cBCountries.SelectedIndex = 177;
         
        }

        private void pBAvatar_Click(object sender, EventArgs e)
        {
            oFDImagemPerfil.Filter = "All Graphics Types | *.bmp; *.jpg; *.jpeg; *.png; *.tif; *.tiff";


            if (oFDImagemPerfil.ShowDialog() == DialogResult.OK)
            {
                pBAvatar.Image = new Bitmap(oFDImagemPerfil.FileName);
            }
        }

        private void bCreateAccount_Click(object sender, EventArgs e)
        {
            if (PedidoCriarJogador != null)
            {
                PedidoCriarJogador(this.ctBUsername.Text, this.cTBPassword.Text, this.cTBConfirmPass.Text, this.cTBNickname.Text, this.cTBEmail.Text, this.cBCountries.Text, this.pBAvatar.ImageLocation, this.dTPDataNascimento.Text);
            }
        }

        private void pBVerPass_Click(object sender, EventArgs e)
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

        private void pBConfirmPassSee_Click(object sender, EventArgs e)
        {
            if (cTBConfirmPass.PasswordChar == '*')
            {
                ((PictureBox)sender).BorderStyle = BorderStyle.Fixed3D;
                cTBConfirmPass.PasswordChar = '\0';
            }
            else
            {
                ((PictureBox)sender).BorderStyle = BorderStyle.None;
                cTBConfirmPass.PasswordChar = '*';
            }
        }

        private void ViewRegister_VisibleChanged(object sender, EventArgs e)
        {
            //Sempre que a visibilidade muda, os valores voltam a estar nulos
            if (this.Visible)
            {
                ctBUsername.Text = "";
                cTBPassword.Text = "";
                cTBConfirmPass.Text = "";
                cTBNickname.Text = "";
                cTBEmail.Text = "";
                cBCountries.Text = "Portugal";
                //pBAvatar
                dTPDataNascimento.Value = DateTime.Today;
            }
            
        }
    }
}
