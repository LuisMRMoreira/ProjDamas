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
    public partial class ViewModoJogo : Form
    {
        bool robot = false, local = false;

        public ViewModoJogo()
        {
            InitializeComponent();
        }

        private void pbReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_Menu.Show();
        }

        private void ViewModoJogo_Load(object sender, EventArgs e)
        {
            pJogo.BackColor = Color.FromArgb(170, 0, 0, 0);


            
        }

        /// <summary>
        /// Click na label serve como botão e altera o fundo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void lRobot_Click(object sender, EventArgs e)
        {
            lMultiplayer.BackColor = Color.Transparent;
            lLocal.BackColor = Color.Transparent;
            lOnline.BackColor = Color.Transparent;
            lRobot.BackColor = Color.FromArgb(150, 0, 0, 0);



            lLocal.Enabled = false;
            lOnline.Enabled = false;

            lPlayGame.Enabled = true;
            lPlayGame.Visible = true;

            robot = true;

        }

        private void lMultiplayer_Click(object sender, EventArgs e)
        {
            lLocal.BackColor = Color.Transparent;
            lOnline.BackColor = Color.Transparent;
            lRobot.BackColor = Color.Transparent;
            lMultiplayer.BackColor = Color.FromArgb(150, 0, 0, 0);



            lLocal.Enabled = true;
            lOnline.Enabled = true;
            lPlayGame.Enabled = false;

            robot = false;
        }

        private void lLocal_Click(object sender, EventArgs e)
        {
            lOnline.BackColor = Color.Transparent;
            lLocal.BackColor = Color.FromArgb(150, 0, 0, 0);

            //quando se carrega na label Local. A label que fica visivel no fundo (informação) é a informação da label  "local"



            lPlayGame.Enabled = true;
            lPlayGame.Visible = true;

            local = true;
        }

        private void lOnline_Click(object sender, EventArgs e)
        {
            lLocal.BackColor = Color.Transparent;
            lOnline.BackColor = Color.FromArgb(150, 0, 0, 0);




            lPlayGame.Enabled = true;
            lPlayGame.Visible = true;

            local = false;
        }


        /// <summary>
        /// Secção para mostar a info dos modos com o mouseHover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        //Multiplayer
        private void lMultiplayer_MouseHover(object sender, EventArgs e)
        {
            lMultiplayerInfo.Visible = true;
        }


        private void lMultiplayer_MouseLeave(object sender, EventArgs e)
        {
            lMultiplayerInfo.Visible = false;
        }
        
        //Robot
        private void lRobot_MouseHover(object sender, EventArgs e)
        {
            lRobotInfo.Visible = true;
        }

        private void lRobot_MouseLeave(object sender, EventArgs e)
        {
            lRobotInfo.Visible = false;
        }

        //Local
        private void lLocal_MouseHover(object sender, EventArgs e)
        {
            lLocalInfo.Visible = true;
        }

        private void lLocal_MouseLeave(object sender, EventArgs e)
        {
            lLocalInfo.Visible = false;
        }

        //Online
        private void lOnline_MouseHover(object sender, EventArgs e)
        {
            lOnlineInfo.Visible = true;
        }
               
        private void lOnline_MouseLeave(object sender, EventArgs e)
        {
            lOnlineInfo.Visible = false;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void lPlayGame_Click(object sender, EventArgs e)
        {
            if (robot)
            {
                this.Hide();
                Program.V_JogoRobot.Show();
            }
            else
            {
                if (local)
                {
                    this.Hide();
                    Program.V_JogoMultiplayerLocal.Show();
                }
                else
                {
                    this.Close();
                    Program.V_JogoMultiplayerOnline.Show();
                }
            }
        }

    }
}
