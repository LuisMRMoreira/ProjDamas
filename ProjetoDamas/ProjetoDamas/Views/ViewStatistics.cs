﻿using System;
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


            ///
            ///Cor do painel
            ///

            pDataGridView.BackColor = Color.FromArgb(150, 0, 0, 0);

            ///
            /// Definição do conteudo da comboBox (Paises)
            ///

            var list = CultureInfo.GetCultures(CultureTypes.SpecificCultures).
            Select(p => new RegionInfo(p.Name).EnglishName).
            Distinct().OrderBy(s => s).ToList();
            cBCountries.DataSource = list;
            cBCountries.SelectedIndex = 177;



            ///
            ///Inilcializar componentes da View
            ///
            rBNone.Checked = true;



            dGVEstatisticas.Rows.Add("Nome", "12", "2","14");
            dGVEstatisticas.Rows.Add("Outro nome", "2", "5", "7");
            dGVEstatisticas.Rows.Add("Nick", "15", "0", "15");
            dGVEstatisticas.Rows.Add("Nome do nome", "0", "1", "1");
            dGVEstatisticas.Rows.Add("Boyyyyy", "7", "7", "14");
            dGVEstatisticas.Rows.Add("Finiii", "15", "5", "20");


        }

        private void pbReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_Menu.Show();
        }


        private void cTBTimePlayed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;

            }
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

        private void rBNone_CheckedChanged(object sender, EventArgs e)
        {
            cTBNickname.Visible = false;
            cBCountries.Visible = false;
            cTBTimePlayed.Visible = false;
            dTPDataNascimento.Visible = false;
        }
    }
}
