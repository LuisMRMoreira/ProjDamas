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
    public partial class ViewTorneio : Form
    {
        public ViewTorneio()
        {
            InitializeComponent();
        }

        private void pbReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_Menu.Show();
        }

        private void bAddPlayer_Click(object sender, EventArgs e)
        {
            if (rBLocalGame.Checked)
            {
                if (cTBNickname.Text == "")
                {
                    if (MessageBox.Show("Nickname isn't valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {

                    }
                    
                }
                else
                {
                    this.dGVJogadoresTorneio.Rows.Add(cTBNickname.Text, "Local");
                }
                
            }
            else
            {
                if (cTBNickname.Text == "" || cTBServerIP.Text == "")
                {
                    if (MessageBox.Show("Nickname or ServerIP invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {

                    }

                }
                else
                {
                    this.dGVJogadoresTorneio.Rows.Add(cTBNickname.Text, "Servidor");
                }
            }

            cTBServerIP.Text = "";
            cTBNickname.Text = "";

        }

        private void rBOnlineGame_CheckedChanged(object sender, EventArgs e)
        {
            pConeccaoServidor.Visible = !pConeccaoServidor.Visible;
        }

        private void ViewTorneio_Load(object sender, EventArgs e)
        {
            pDataGridView.BackColor = Color.FromArgb(150, 0, 0, 0);
            pConeccaoServidor.BackColor = Color.FromArgb(150, 0, 0, 0);
            pInfo.BackColor = Color.FromArgb(150, 0, 0, 0);



            ///
            ///Inicializar a view
            ///

            cTBNickname.Text = "";
            cTBServerIP.Text = "";
            cTBTournamentName.Text = "";
            rBLocalGame.Checked = true;
            dGVJogadoresTorneio.Rows.Clear();
        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            if (dGVJogadoresTorneio.SelectedRows != null)
            {
                MessageBox.Show("No players selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (DataGridViewRow item in this.dGVJogadoresTorneio.SelectedRows)
            {
                dGVJogadoresTorneio.Rows.RemoveAt(item.Index);
            }
        }



        private void bProceed_Click(object sender, EventArgs e)
        {
            if (cTBTournamentName.Text == "")
            {
                MessageBox.Show("Invalid tournament name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dGVJogadoresTorneio.Rows.Count == 0)
            {
                MessageBox.Show("No player added to the tournament!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                //this.Hide();
                //Program.V_JogosTorneio.ShowDialog();
                //-------------------------------------------------------------------------------------------------
            }
        }

        private void cTBServerIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

    }
}
