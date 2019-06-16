using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using WMPLib;

namespace ProjetoDamas
{
    public partial class ViewMenu : Form
    {
        public WindowsMediaPlayer wepg;

        public ViewMenu()
        {
            InitializeComponent();


            

            Program.M_Gestor.RespostaPedidoLoginSucesso += M_Gestor_RespostaPedidoLoginSucesso;

            wepg = new WindowsMediaPlayer();
            wepg.URL = "Resources\\Minecraft-Theme Song.mp3";
        }




        /// <summary>
        /// Eventos na ViewMenu
        /// </summary>
        /// <param name="nickname"></param>
        /// <param name="imagem"></param>

        ///Login bem sucedido. Muda a label para o nickname do jogador e a imagem para a imgame do jogador. 

        private void M_Gestor_RespostaPedidoLoginSucesso(User u)
        {
            lLogin.Text = u.Username;
            pBLogin.Image = u.Imagem;
        }

        /// <summary>
        /// Inicialização da ViewMenu. Cor de fundo e Musica.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ViewMenu_Load(object sender, EventArgs e)
        {
            pPainelOpcoes.BackColor = Color.FromArgb(80, 0, 0, 0);

            if (wepg.controls.currentPosition == 0)
            {
                wepg.controls.play();
            }

        }



        /// <summary>
        /// Evento Click do butões 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonjogar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_ModoJogo.Show();
        }

        private void bRules_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_Rules.Show();
        }

        private void bContinueGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_JogosInacabados.Show();
        }

        private void bTournament_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_Torneio.Show();
        }

        private void bContinueTournament_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_TorneiosInacabados.Show();
        }

        private void bSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_Settings.Show();
        }

        private void bGameInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_GameStatistics.Show();
        }

        private void pLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            //PERGUNTA: é necessario fazer um evento que chame o Show dentro da ViewLogin()????????????
            Program.V_Profile.Show();
        }


    }



}