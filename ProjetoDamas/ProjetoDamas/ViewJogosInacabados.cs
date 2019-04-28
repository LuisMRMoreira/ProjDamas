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
    public partial class ViewJogosInacabados : Form
    {
        public ViewJogosInacabados()
        {
            InitializeComponent();
        }

        private void bLeave_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewMenu menu = new ViewMenu();
            menu.Closed += (s, args) => this.Close();
            menu.ShowDialog();
        }

        private void pbReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_Menu.ShowDialog();
        }

        private void rBNone_CheckedChanged(object sender, EventArgs e)
        {
            cBCountries.Visible = false;
            dTPDataDeJogo.Visible = false;
            cTBNickname.Visible = false;
        }

        private void rBName_CheckedChanged(object sender, EventArgs e)
        {
            cBCountries.Visible = false;
            dTPDataDeJogo.Visible = false;
            cTBNickname.Visible = true;
        }

        private void rBDate_CheckedChanged(object sender, EventArgs e)
        {
            cBCountries.Visible = false;
            dTPDataDeJogo.Visible = true;
            cTBNickname.Visible = false;
        }

        private void rBCountry_CheckedChanged(object sender, EventArgs e)
        {
            cBCountries.Visible = true;
            dTPDataDeJogo.Visible = false;
            cTBNickname.Visible = false;
        }

        private void ViewJogosInacabados_Load(object sender, EventArgs e)
        {
            ///
            ///Cor do painel
            ///

            pDataGridView.BackColor = Color.FromArgb(150, 0, 0, 0);


            ///
            /// Inicializar componente
            ///

            
        }
    }
}
