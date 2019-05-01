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
    public partial class ViewJogadoresNoServidor : Form
    {
        //Vai para a ViewOponenteServidor
        public event MetodosComDuasStrings PedidoAlterarOponenteOnline;

        string value1, value2;

        public ViewJogadoresNoServidor()
        {
            InitializeComponent();
        }


        private void rBCountry_CheckedChanged(object sender, EventArgs e)
        {
            cTBNickname.Visible = false;
            cBCountries.Visible = true;
        }

        private void rBName_CheckedChanged(object sender, EventArgs e)
        {
            cTBNickname.Visible = true;
            cBCountries.Visible = false;
        }

        private void rBBestStatus_CheckedChanged(object sender, EventArgs e)
        {
            cTBNickname.Visible = false;
            cBCountries.Visible = false;
        }

        private void rBNone_CheckedChanged(object sender, EventArgs e)
        {
            cTBNickname.Visible = false;
            cBCountries.Visible = false;
        }

        private void pbReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_OponenteServidor.ShowDialog();
        }

        private void ViewJogadoresNoServidor_Load(object sender, EventArgs e)
        {
            pDataGridView.BackColor = Color.FromArgb(150, 0, 0, 0);

            ///
            ///Inicialização dos componentes da form
            ///

            cTBNickname.Visible = false;
            cBCountries.Visible = false;
            rBNone.Checked = true;
            cTBNickname.Text = "";
            //bSelect.Enabled = false;
            cBCountries.Text = "Portugal";

            var list = CultureInfo.GetCultures(CultureTypes.SpecificCultures).
            Select(p => new RegionInfo(p.Name).EnglishName).
            Distinct().OrderBy(s => s).ToList();
            cBCountries.DataSource = list;
            cBCountries.SelectedIndex = 177;


            ///
            ///inicializar a DataGridView
            ///


            dGVServerOpponent.Rows.Add("Luis", "10", "20", "192.098.123.123");
            dGVServerOpponent.Rows.Add("Carlos", "10", "23", "052.244.165.025");
            dGVServerOpponent.Rows.Add("Diogo", "15", "17", "122.099.012.124");

        }

        private void dGVServerOpponent_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dGVServerOpponent.Rows.Count == 1)
            {
                bSelect.Enabled = true;
            }
        }

        private void bSelect_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dGVServerOpponent.SelectedRows)
            {
                //Enviar para a ViewOponenteServidor
                value1 = row.Cells[0].Value.ToString();
                value2 = row.Cells[3].Value.ToString();

                //Enviado para o ControllerJogo -> Jogo (Model) -> ViewOponenteServidor

            }

            this.Hide();
            //Program.V_OponenteServidor.ShowDialog();

            if (PedidoAlterarOponenteOnline != null)
            {
                PedidoAlterarOponenteOnline(value1, value2);
            }
        }


    }
}
