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
    public partial class ViewStatistics : Form
    {
        public ViewStatistics()
        {
            InitializeComponent();
        }

        private void ViewStatistics_Load(object sender, EventArgs e)
        {
            pDataGridView.BackColor = Color.FromArgb(150, 0, 0, 0);

            ///
            ///Cor do painel
            ///

            ///
            /// Definição do conteudo da comboBox (Paises)
            ///

            var list = CultureInfo.GetCultures(CultureTypes.SpecificCultures).
            Select(p => new RegionInfo(p.Name).EnglishName).
            Distinct().OrderBy(s => s).ToList();
            cBCountries.DataSource = list;
            cBCountries.SelectedIndex = 177;

        }

        private void pbReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_Menu.Show();
        }

        private void rBCountry_CheckedChanged(object sender, EventArgs e)
        {            
            cBCountries.Visible = true;
            cTBTimePlayed.Visible = false;
            dTPDataNascimento.Visible = false;
            cTBNickname.Visible = false;
        }

        private void rBTimePlayed_CheckedChanged(object sender, EventArgs e)
        {
            cBCountries.Visible = false;
            cTBTimePlayed.Visible = true;
            dTPDataNascimento.Visible = false;
            cTBNickname.Visible = false;
        }

        private void rBBirthDate_CheckedChanged(object sender, EventArgs e)
        {
            cBCountries.Visible = false;
            cTBTimePlayed.Visible = false;
            dTPDataNascimento.Visible = true;
            cTBNickname.Visible = false;
        }

        private void rBName_CheckedChanged(object sender, EventArgs e)
        {
            cTBNickname.Visible = true;
            cBCountries.Visible = false;
            cTBTimePlayed.Visible = false;
            dTPDataNascimento.Visible = false;
        }
    }
}
