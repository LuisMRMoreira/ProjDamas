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
    public partial class ViewTorneiosInacabados : Form
    {
        public ViewTorneiosInacabados()
        {
            InitializeComponent();
        }

        private void ViewTorneiosInacabados_Load(object sender, EventArgs e)
        {
            pDataGridView.BackColor = Color.FromArgb(150, 0, 0, 0);

            ///
            //Inicializar DataGridView
            ///

            dGVTorneiosInacabados.Rows.Add("O torneio", "10", "15/04/2019");
            dGVTorneiosInacabados.Rows.Add("Nome", "2", "30/03/2019");
            dGVTorneiosInacabados.Rows.Add("Torneio de hoje", "4", "22/04/2019");

        }

        private void bProceed_Click(object sender, EventArgs e)
        {
            if (this.dGVTorneiosInacabados.SelectedRows != null)
            {
                // Eventos para levar a info até ao jogo -----------------------------------------------------------------------------------------------
                //this.Hide();
                //Program.V_JogosTorneio.returnAvalable = false;// retira a imagem return da View dos jogos do torneio -------------------------------------
                //Program.V_JogosTorneio.ShowDialog();//??
            }
            else
            {
                MessageBox.Show("Select a game!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void pbReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_Menu.Show();
        }




    }
}
