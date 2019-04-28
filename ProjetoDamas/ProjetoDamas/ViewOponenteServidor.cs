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
    public partial class ViewOponenteServidor : Form
    {
        public ViewOponenteServidor()
        {
            InitializeComponent();
        }

        private void ctBServerIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


        }

        private void bSearchOppoent_Click(object sender, EventArgs e)
        {
            if (cBSearchInTheServer.Checked)//Se tiver selecionada Vamos pesquisar apenas numa tabela para ver quem são os jogadores que estão ligados ao servidor
            {
                this.Hide();
                Program.V_JogadoresNoServidor.Show();
                //----------------------------------------------------------------------------------------
            }
            else
            {
                pOpponent.Visible = true;
                pSeacrhOpponent.Visible = false;
                bSearchOppoent.Visible = false;
                bPlay.Visible = true;
            }


        }

        private void ViewOponenteServidor_Load(object sender, EventArgs e)
        {

            pBarraTranparentePreta.BackColor = Color.FromArgb(100, 0, 0, 0);


            ///
            /// Inicializar View
            ///
            

            bSearchOppoent.Visible = true;
            bPlay.Visible = false;
            pOpponent.Visible = false;
            pSeacrhOpponent.Visible = true;
            cTBOpponentNickname.Text = "";
            ctBServerIP.Text = "";
            cBSearchInTheServer.Checked = false;
            
        }

        private void pbReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_ModoJogo.Show();//------------------------------------------------------------------------------------
        }

        private void bPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_JogoMultiplayer.ShowDialog();//------------------------------------------------------------------------------------
        }



        private void cBSearchInTheServer_CheckedChanged(object sender, EventArgs e)
        {
            pOpponentNickname.Visible = !pOpponentNickname.Visible;
        }
    }
}
