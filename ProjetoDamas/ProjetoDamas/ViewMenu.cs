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

namespace ProjetoDamas
{
    public partial class ViewMenu : Form
    {
        public ViewMenu()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ViewMoDoJogo option_gamemode = new ViewMoDoJogo(); 
            //option_gamemode.Show();
            this.Hide();
            ViewModoJogo option_gamemode = new ViewModoJogo();
            option_gamemode.Closed += (s, args) => this.Close();
            option_gamemode.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("You sure you wanna leave the aplicattion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonregras_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewRegras option_regras = new ViewRegras();
            option_regras.Closed += (s, args) => this.Close();
            option_regras.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //instanciar login
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewProfileInfo prof = new ViewProfileInfo();
            prof.Closed += (s, args) => this.Close();
            prof.Show();
        }

        private void bContinueGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewJogosInacabados jogos_inacabados = new ViewJogosInacabados();
            jogos_inacabados.Closed += (s, args) => this.Close();
            jogos_inacabados.Show();
        }


        private void ViewMenu_Load(object sender, EventArgs e)
        {
            pPainelOpcoes.BackColor = Color.FromArgb(80, 0, 0, 0);
        }

        private void bGameInfo_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ViewMenuMoreInfo menu = new ViewMenuMoreInfo();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }

        private void bGameInfo_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            ViewMenuMoreInfo menu = new ViewMenuMoreInfo();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
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