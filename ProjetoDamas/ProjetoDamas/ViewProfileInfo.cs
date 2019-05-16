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
        public event MetodosSemParametros PedidoTerminarSessao;

        bool saveChanges = false;

        public ViewProfileInfo()
        {
            InitializeComponent();

        }


        private void ViewProfileInfo_Load(object sender, EventArgs e)
        {
            var list = CultureInfo.GetCultures(CultureTypes.SpecificCultures).
                Select(p => new RegionInfo(p.Name).EnglishName).
                Distinct().OrderBy(s => s).ToList();
            cBCountries.DataSource = list;
            cBCountries.SelectedIndex = 177;

            pMoreInfo.BackColor = Color.FromArgb(170, 0, 0, 0);




            ///
            /// Inicialização da View
            ///

            saveChanges = false;
        }



        private void pbReturn_Click(object sender, EventArgs e)
        {
            if (saveChanges) // se for false -> Esta guardado. Se for true é porque tem alguma coisa para guardar
            {
                if (MessageBox.Show("Do you want to save the changes?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    saveChanges = false;
                }

            }

            this.Hide();
            Program.V_Menu.Show();
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
        {//vai ser de ser um metodo que vai criar um jogador (metodo da classe model jogador)


            saveChanges = false;
            pBCheckGuardado.Visible = true;



            pBUserEditar.BorderStyle = BorderStyle.None;
            ctBUsername.Enabled = false;

            pBPasswordEditar.BorderStyle = BorderStyle.None;
            cTBPassword.Enabled = false;

            pBNickEdit.BorderStyle = BorderStyle.None;
            cTBNickname.Enabled = false;

            pBEmailEditar.BorderStyle = BorderStyle.None;
            cTBEmail.Enabled = false;

            pBCountryEditar.BorderStyle = BorderStyle.None;
            cBCountries.Enabled = false;

            pBDateTimePickerEditar.BorderStyle = BorderStyle.None;
            dTPDataNascimento.Enabled = false;
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

        private void pBDateTimePickerEditar_Click(object sender, EventArgs e)
        {
            if (dTPDataNascimento.Enabled)
                ((PictureBox)sender).BorderStyle = BorderStyle.None;
            else
                ((PictureBox)sender).BorderStyle = BorderStyle.Fixed3D;

            dTPDataNascimento.Enabled = !dTPDataNascimento.Enabled;

            pBCheckGuardado.Visible = false;
            saveChanges = true;
        }



        private void pBMoreInfo_Click(object sender, EventArgs e)
        {
            pMoreInfo.Visible = !pMoreInfo.Visible;
        }

        private void pBLogout_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (PedidoTerminarSessao != null)
            {
                PedidoTerminarSessao();
            }
        }


    }
}
