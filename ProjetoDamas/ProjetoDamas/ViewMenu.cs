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

        public event MetodosSemParametros PedidoLogin;
        public WindowsMediaPlayer wepg;

        public ViewMenu()
        {
            InitializeComponent();
            Program.M_Gestor.PedidoAlterarLogin += M_Gestor_PedidoAlterarLogin;
            Program.M_Gestor.PedidoTerminarSessaoNaView += M_Gestor_PedidoTerminarSessaoNaView;
            wepg = new WindowsMediaPlayer();
            wepg.URL = "Resources\\Minecraft-Theme Song.mp3";
        }

        private void M_Gestor_PedidoTerminarSessaoNaView()
        {
            lLogin.Text = "Login";
            pBLogin.Image = Properties.Resources.user_interface_login_icon__12_1_;
            //pBLogin.ImageLocation = @"C:\Users\lmr_m\Desktop\Temporario\Laboratorio\ProjDamas\ProjetoDamas\ProjetoDamas\Resources";
            this.Show();
        }

        private void M_Gestor_PedidoAlterarLogin(string imagem, string nome)
        {
            lLogin.Text = "Grupo";
            pBLogin.Image = Properties.Resources.DamaBranca;
            //pBLogin.ImageLocation = @"C:\Users\lmr_m\Desktop\Temporario\Laboratorio\ProjDamas\ProjetoDamas\ProjetoDamas\Resources";
            this.Show();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("You sure you wanna leave the aplicattion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


 
        private void buttonProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_Settings.ShowDialog();
        }



        private void ViewMenu_Load(object sender, EventArgs e)
        {
            pPainelOpcoes.BackColor = Color.FromArgb(80, 0, 0, 0);

            if (wepg.controls.currentPosition == 0)
            {
                wepg.controls.play();
            }

        }



        private void bGameInfo_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_GameStatistics.ShowDialog();
        }



        private void pLoginOrUsername_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Program.V_Login.Show();

            if (PedidoLogin != null)
            {
                PedidoLogin();
            }

            //Program.M_Gestor.Login

            //this.Hide();
            //ViewLogin login = new ViewLogin();
            //login.Closed += (s, args) => this.Close();
            //login.Show();

        }



        private void buttonjogar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_ModoJogo.ShowDialog();
        }

        private void bRules_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_Rules.ShowDialog();
        }

        private void bContinueGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_JogosInacabados.ShowDialog();
        }

        private void bTournament_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_Torneio.ShowDialog();
        }

        private void bContinueTournament_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_TorneiosInacabados.ShowDialog();
        }








        /*
         
         
                     //Graphics graphics = e.Graphics;

            ////the rectangle, the same size as our Form
            //Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);

            ////define gradient's properties
            //Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 0, 0), Color.FromArgb(227,128, 57), 100f);

            ////apply gradient         
            //graphics.FillRectangle(b, gradient_rectangle);

            LinearGradientBrush linearGradientBrush =
   new LinearGradientBrush(pPainelOpcoes.ClientRectangle, Color.Red, Color.Yellow, 45);

            ColorBlend cblend = new ColorBlend(3);
            cblend.Colors = new Color[3] { Color.Red, Color.Yellow, Color.Green };
            cblend.Positions = new float[3] { 0f, 0.5f, 1f };

            linearGradientBrush.InterpolationColors = cblend;

            e.Graphics.FillRectangle(linearGradientBrush, pPainelOpcoes.ClientRectangle);
         
         
         
         
         
         
         */







    }



}