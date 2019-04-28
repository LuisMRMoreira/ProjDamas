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
    public partial class ViewJogadoresNoServidor : Form
    {
        //Vai para a ViewOponenteServidor
        public event MetodosComDuasStrings PedidoAlterarOponenteOnline;

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
            Program.V_OponenteServidor.Show();
        }

        private void ViewJogadoresNoServidor_Load(object sender, EventArgs e)
        {
            cTBNickname.Visible = false;
            cBCountries.Visible = false;
            rBNone.Checked = true;
        }

        private void bSelect_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dGVServerOpponent.SelectedRows)
            {
                //Enviar para a ViewOponenteServidor
                string value1 = row.Cells[0].Value.ToString();
                string value2 = row.Cells[1].Value.ToString();

                //Enviado para o ControllerJogo -> Jogo (Model) -> ViewOponenteServidor
                if (PedidoAlterarOponenteOnline != null)
                {
                    PedidoAlterarOponenteOnline(value1, value2);
                }
            }

            this.Hide();
            Program.V_OponenteServidor.Show();
        }

        private void dGVEstatisticas_SelectionChanged(object sender, EventArgs e)
        {
            bSelect.Visible = !bSelect.Visible;//-------------------------------------------------------------------------
        }
    }
}
