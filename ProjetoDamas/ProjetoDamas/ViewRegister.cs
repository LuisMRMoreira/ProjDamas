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
        public ViewRegister()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter= "All Graphics Types | *.bmp; *.jpg; *.jpeg; *.png; *.tif; *.tiff";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                /*if (PedidoAbrirPic != null)
                    PedidoAbrirPic(openFileDialog1.FileName);*/
            }
        }

        private void buttonProceed_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewLogin login = new ViewLogin();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void bMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewMenu Menu = new ViewMenu();
            Menu.Closed += (s, args) => this.Close();
            Menu.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Graphics Types | *.bmp; *.jpg; *.jpeg; *.png; *.tif; *.tiff";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                /*if (PedidoAbrirPic != null)
                    PedidoAbrirPic(openFileDialog1.FileName);*/
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("You sure you wanna leave the regist?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                ViewLogin login = new ViewLogin();
                login.Closed += (s, args) => this.Close();
                login.Show();
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
    }
}
