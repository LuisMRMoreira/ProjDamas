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

        public event MetodosComUmInteiro PedidoModoEditar;

        bool saveChanges = false, change = false;

        public ViewProfileInfo()
        {
            InitializeComponent();
            Program.M_Gestor.PedidoMostrarPerfil += M_Gestor_PedidoMostrarPerfil;

        }

        private void M_Gestor_PedidoMostrarPerfil()
        {
            this.Show();
        }



        private void ViewProfileInfo_Load(object sender, EventArgs e)
        {
            var list = CultureInfo.GetCultures(CultureTypes.SpecificCultures).
                Select(p => new RegionInfo(p.Name).EnglishName).
                Distinct().OrderBy(s => s).ToList();
            cBCountries.DataSource = list;
            cBCountries.SelectedIndex = 177;

            pMoreInfo.BackColor = Color.FromArgb(200, 0, 0, 0);
        }



        private void pbReturn_Click(object sender, EventArgs e)
        {
            if (!saveChanges) // se for false -> Esta guardado
            {
                if (MessageBox.Show("Are you sure you want to leave without saving?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    saveChanges = true;
                }
            }


            this.Hide();
            Program.V_Menu.Show();
            //ViewMenu Menu = new ViewMenu();
            //Menu.Closed += (s, args) => this.Close();
            //Menu.Show();

        }




        private void pBUserEditar_Click(object sender, EventArgs e)
        {
            if (ctBUsername.Enabled)
                ((PictureBox)sender).BorderStyle = BorderStyle.None;
            else
                ((PictureBox)sender).BorderStyle = BorderStyle.Fixed3D;

            ctBUsername.Enabled = !ctBUsername.Enabled;

            pBCheckGuardado.Visible = false;
            saveChanges = true;
       
        }

  

        private void pBPasswordEditar_Click(object sender, EventArgs e)
        {
            if (cTBPassword.Enabled)
                ((PictureBox)sender).BorderStyle = BorderStyle.None;
            else
                ((PictureBox)sender).BorderStyle = BorderStyle.Fixed3D;

            cTBPassword.Enabled = !cTBPassword.Enabled;

            pBCheckGuardado.Visible = false;
            saveChanges = true;
        }

        private void pBVerPass_Click(object sender, EventArgs e)
        {
            if (cTBPassword.PasswordChar == '*') {
                ((PictureBox)sender).BorderStyle = BorderStyle.Fixed3D;
                cTBPassword.PasswordChar = '\0';
            }
            else {
                ((PictureBox)sender).BorderStyle = BorderStyle.None;
                cTBPassword.PasswordChar = '*';
            }

           
        }

        private void pBCountryEditar_Click(object sender, EventArgs e)
        {
            if (cBCountries.Enabled)
                ((PictureBox)sender).BorderStyle = BorderStyle.None;
            else
                ((PictureBox)sender).BorderStyle = BorderStyle.Fixed3D;

            cBCountries.Enabled = !cBCountries.Enabled;

            pBCheckGuardado.Visible = false;
            saveChanges = true;
        }

        private void pBGuardar_Click(object sender, EventArgs e)
        {
            saveChanges = true;
            pBCheckGuardado.Visible = true;
        }

        private void pBUser_Click(object sender, EventArgs e)
        {
            oFDImagemPerfil.Filter = "All Graphics Types | *.bmp; *.jpg; *.jpeg; *.png; *.tif; *.tiff";


            if (oFDImagemPerfil.ShowDialog() == DialogResult.OK)
            {
                pBUser.Image = new Bitmap(oFDImagemPerfil.FileName);
            }

            pBCheckGuardado.Visible = false;
            saveChanges = true;

        }

        private void pBNickEdit_Click(object sender, EventArgs e)
        {
            if (cTBNickname.Enabled)
                ((PictureBox)sender).BorderStyle = BorderStyle.None;
            else
                ((PictureBox)sender).BorderStyle = BorderStyle.Fixed3D;

            cTBNickname.Enabled = !cTBNickname.Enabled;

            pBCheckGuardado.Visible = false;
            saveChanges = true;

        }

        private void pBEmailEditar_Click(object sender, EventArgs e)
        {
            if (cTBEmail.Enabled)
                ((PictureBox)sender).BorderStyle = BorderStyle.None;
            else
                ((PictureBox)sender).BorderStyle = BorderStyle.Fixed3D;

            cTBEmail.Enabled = !cTBEmail.Enabled;

            pBCheckGuardado.Visible = false;
            saveChanges = true;
        }

        private void pBMoreInfo_Click(object sender, EventArgs e)
        {
            pMoreInfo.Visible = !pMoreInfo.Visible;
        }

        private void bConfirm_Click(object sender, EventArgs e)
        {
            ////TextBoxes: Edit
            //tBUsername.Visible = false;
            //tBPassword.Visible = false;
            //tbNickname.Visible = false;
            //tbEmail.Visible = false;
            ////Button Confirm: Confirmation
            //bConfirm.Visible = false;
            ////Labels: Information
            //lUsernameN.Visible = true;
            //lNicknameN.Visible = true;
            //lEmailN.Visible = true;
            ////depois da confirmação da alteração, o texto da lable passa a ser outro.
            //if (changedUser)
            //{
            //    lUsernameN.Text = tBUsername.Text;
            //    pBCheck1.Visible = true;
            //}

            //if (changedPassword)
            //{
            //    pBCheck2.Visible = true;
            //}

            //if (changedNickname)
            //{
            //    lNicknameN.Text = tbNickname.Text;
            //    pBCheck3.Visible = true;
            //}

            //if (changedEmail)
            //{
            //    lEmailN.Text = tbEmail.Text;
            //    pBCheck4.Visible = true;
            //}

            //if (changedCountry)
            //{
            //    pBCheck5.Visible = true;
            //    cBCountries.Enabled = false;
            //}


            //changedUser = false;
            //changedNickname = false;
            //changedPassword = false;
            //changedEmail = false;
            //changedCountry = false;

            ////Nickename alterado
            ////PictureBox Alterado (Check)
        }


    }
}
