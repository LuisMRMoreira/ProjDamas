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
    public partial class ViewTorneioJogos : Form
    {

        public bool returnAvalable = true;

        public ViewTorneioJogos()
        {
            InitializeComponent();
        }

        private void bProceed_Click(object sender, EventArgs e)
        {
            if (this.dGVJogosTorneio.SelectedRows != null)
            {
                // Eventos para levar a info até ao jogo -----------------------------------------------------------------------------------------------
                this.Hide();
                Program.V_JogoMultiplayer.ShowDialog();//??
            }
            else
            {
                MessageBox.Show("Select a game!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            pbReturn.Visible = true;

        }

        private void pbReturn_Click(object sender, EventArgs e)
        {

            if (!returnAvalable)
            {
                this.Hide();
                Program.V_TorneiosInacabados.Show();//------------------------------
            }
            else
            {
                this.Hide();
                Program.V_Torneio.Show();//-------------------------------------------
            }
            
        }

        private void ViewTorneioJogos_Load(object sender, EventArgs e)
        {
            pDataGridView.BackColor = Color.FromArgb(150, 0, 0, 0);

            dGVJogosTorneio.Rows.Add("Luis", "Diogo", "15 min");
            dGVJogosTorneio.Rows.Add("Carlos", "Jose", "not started");
            dGVJogosTorneio.Rows.Add("Manuel", "Robot", "not started");

        }
    }
}
