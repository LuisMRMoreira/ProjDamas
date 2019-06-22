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

            Program.M_User.RespostaLogin += M_User_RespostaLogin;

            wepg = new WindowsMediaPlayer();
            wepg.URL = "Resources\\Minecraft-Theme Song.mp3";
        }


        private void M_User_RespostaLogin(User u)
        {
            lLogin.Text = u.Username;
            pBLogin.ImageLocation = u.Imagem;
            this.Show();
            Program.V_Login.Hide();
        }
        

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

        //FAZER:::: Provavelmente não vai ser preciso
        private void bTournament_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Program.V_Torneio.Show();
        }

        //FAZER:::: Provavelmente não vai ser preciso
        private void bContinueTournament_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Program.V_TorneiosInacabados.Show();
        }

        //FAZER:::: Provavelmente não vai ser preciso
        private void bSettings_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Program.V_Settings.Show();
        }

        //FAZER:::: Provavelmente não vai ser preciso
        private void bGameInfo_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Program.V_GameStatistics.Show();
        }


        private void pLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_Profile.Show();
        }


    }



}