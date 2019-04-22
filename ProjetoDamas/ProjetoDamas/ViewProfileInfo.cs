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
    public partial class ViewProfileInfo : Form
    {
        bool changedUser = false, changedPassword = false, changedNickname = false, changedEmail = false, changedCountry = false;

        public ViewProfileInfo()
        {
            InitializeComponent();
        }

        private void lLEditUnsername_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {//Butão editar Username
            //TextBox: aparece
            tBUsername.Visible = true;
            //A label desaparece
            lUsernameN.Visible = false;
            //Como tem informação para alterar, o butão confirmar aparece
            bConfirm.Visible = true;
            //O texto da textBox é igual ao que estava na lable.
            tBUsername.Text = lUsernameN.Text;

            changedUser = true;
        }

        private void ViewProfileInfo_Load(object sender, EventArgs e)
        {
            var list = CultureInfo.GetCultures(CultureTypes.SpecificCultures).
                Select(p => new RegionInfo(p.Name).EnglishName).
                Distinct().OrderBy(s => s).ToList();
            cBCountries.DataSource = list;
            cBCountries.SelectedIndex = 177;
        }

        private void lLCountry_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Butão editar Country
            cBCountries.Enabled = true;
            bConfirm.Visible = true;

            changedCountry = true;
        }

        private void pbReturn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wanna save the changes?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
            }
            this.Hide();
            ViewMenu Menu = new ViewMenu();
            Menu.Closed += (s, args) => this.Close();
            Menu.Show();

        }

        private void bChangeLogin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You sure you wanna end session?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                ViewLogin login = new ViewLogin();
                login.Closed += (s, args) => this.Close();
                login.Show();
            }
        }

        private void bConfirm_Click(object sender, EventArgs e)
        {
            //TextBoxes: Edit
            tBUsername.Visible = false;
            tBPassword.Visible = false;
            tbNickname.Visible = false;
            tbEmail.Visible = false;
            //Button Confirm: Confirmation
            bConfirm.Visible = false;
            //Labels: Information
            lUsernameN.Visible = true;
            lNicknameN.Visible = true;
            lEmailN.Visible = true;
            //depois da confirmação da alteração, o texto da lable passa a ser outro.
            if (changedUser)
            {
                lUsernameN.Text = tBUsername.Text;
                pBCheck1.Visible = true;
            }

            if (changedPassword)
            {
                pBCheck2.Visible = true;
            }

            if (changedNickname)
            {
                lNicknameN.Text = tbNickname.Text;
                pBCheck3.Visible = true;
            }

            if (changedEmail)
            {
                lEmailN.Text = tbEmail.Text;
                pBCheck4.Visible = true;
            }

            if (changedCountry)
            {
                pBCheck5.Visible = true;
                cBCountries.Enabled = false;
            }


            changedUser = false;
            changedNickname = false;
            changedPassword = false;
            changedEmail = false;
            changedCountry = false;

            //Nickename alterado
            //PictureBox Alterado (Check)
        }

        private void lLEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Butão editar Email
            //TextBox: aparece
            tbEmail.Visible = true;
            //A label desaparece
            lEmailN.Visible = false;
            //Como tem informação para alterar, o butão confirmar aparece
            bConfirm.Visible = true;
            //O texto da textBox é igual ao que estava na lable.
            tbEmail.Text = lEmailN.Text;

            changedEmail = true;
        }

        private void lLPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {//Butão editar Password
            //Como tem informação para alterar, o butão confirmar aparece
            bConfirm.Visible = true;
            //O texto da textBox é igual ao que estava na lable.
            tBPassword.Visible = true;

            changedPassword = true;

            //Base de dados password!!!!!!!!!!!!!!!
        }

        private void lLNickname_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Butão editar Nickname
            //TextBox: aparece
            tbNickname.Visible = true; 
            //A label desaparece
            lNicknameN.Visible = false;
            //Como tem informação para alterar, o butão confirmar aparece
            bConfirm.Visible = true;
            //O texto da textBox é igual ao que estava na lable.
            tbNickname.Text = lNicknameN.Text;

            changedNickname = true;
        }
    }
}
