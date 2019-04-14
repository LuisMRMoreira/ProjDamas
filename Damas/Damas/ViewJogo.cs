using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Damas
{
    public partial class ViewJogo : Form
    {

        public PictureBox[][] PictureBoxDoPanel;

        public ViewJogo()
        {
            InitializeComponent();
            PictureBoxDoPanel = new PictureBox[8][];
            for (int i = 0; i < 8; i++)
            {
                PictureBoxDoPanel[i] = new PictureBox[8];
            }

            InicializarMatrizPB(PictureBoxDoPanel);
            GerarPecasNoTabuleiro(false);
            //pB00.Image = Properties.Resources.PecaBranca;
            
            //InicializarMatrizPB(PictureBoxDoPanel);
            //GerarPecasNoTabuleiro(false);

        }

        private void InicializarMatrizPB(PictureBox[][] pb)
        {
            pb[0][0] = pB00; pb[1][0] = pB10; pb[2][0] = pB20; pb[3][0] = pB30; pb[4][0] = pB40; pb[5][0] = pB50; pb[6][0] = pB60; pb[7][0] = pB70;
            pb[0][1] = pB01; pb[1][1] = pB11; pb[2][1] = pB21; pb[3][1] = pB31; pb[4][1] = pB41; pb[5][1] = pB51; pb[6][1] = pB61; pb[7][1] = pB71;
            pb[0][2] = pB02; pb[1][2] = pB12; pb[2][2] = pB22; pb[3][2] = pB32; pb[4][2] = pB42; pb[5][2] = pB52; pb[6][2] = pB62; pb[7][2] = pB72;
            pb[0][3] = pB03; pb[1][3] = pB13; pb[2][3] = pB23; pb[3][3] = pB33; pb[4][3] = pB43; pb[5][3] = pB53; pb[6][3] = pB63; pb[7][3] = pB73;
            pb[0][4] = pB04; pb[1][4] = pB14; pb[2][4] = pB24; pb[3][4] = pB34; pb[4][4] = pB44; pb[5][4] = pB54; pb[6][4] = pB64; pb[7][4] = pB74;
            pb[0][5] = pB05; pb[1][5] = pB15; pb[2][5] = pB25; pb[3][5] = pB35; pb[4][5] = pB45; pb[5][5] = pB55; pb[6][5] = pB65; pb[7][5] = pB75;
            pb[0][6] = pB06; pb[1][6] = pB16; pb[2][6] = pB26; pb[3][6] = pB36; pb[4][6] = pB46; pb[5][6] = pB56; pb[6][6] = pB66; pb[7][6] = pB76;
            pb[0][7] = pB07; pb[1][7] = pB17; pb[2][7] = pB27; pb[3][7] = pB37; pb[4][7] = pB47; pb[5][7] = pB57; pb[6][7] = pB67; pb[7][7] = pB77;
        }

        private void tLPTabuleiro_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if ((e.Column + e.Row) % 2 == 1)
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
            else
                e.Graphics.FillRectangle(Brushes.Black, e.CellBounds);            
        }


        private void ViewJogo_Load(object sender, EventArgs e)
        {
            //pB00.Image = Image.FromFile(@"C: \Users\lmr_m\Desktop\Temporario\Laboratorio\ProjDamas\Damas\Damas\bin\Debug\" + "PecaBranca.png");
            

        }

        private void GerarPecasNoTabuleiro(bool corCima)
        {
            //https://softwaredevelopmentforecm.wordpress.com/2011/01/18/dynamically-generating-a-tablelayoutpanel/

            Imagens imagens = new Imagens();

            for (int x = 0; x < tLPTabuleiro.ColumnCount; x++)
            {
                for (int y = 0; y < tLPTabuleiro.RowCount; y++)
                {
                    if (corCima) //0 branco, 1 preto
                    {
                        if ((x + y) % 2 == 0 && y < 3)
                        {
                            PictureBoxDoPanel[x][y].Image = Image.FromFile("PecaPreta.png");
                            PictureBoxDoPanel[x][y].BringToFront();
                        }
                        else if ((x + y) % 2 == 0 && y >= 5)
                        {
                            //meter a outra côr
                            PictureBoxDoPanel[x][y].Image = Image.FromFile("PecaBranca.png");
                            PictureBoxDoPanel[x][y].BringToFront();
                        }
                    }
                    else
                    {
                        if ((x + y) % 2 == 0 && y < 3)
                        {
                            PictureBoxDoPanel[x][y].Image = Image.FromFile("PecaBranca.png");
                            PictureBoxDoPanel[x][y].BringToFront();
                            //pbBranco.BackColor = Color.Transparent;
                            //pbBranco.Image = imagens.Branca;

                            //tLPTabuleiro.Controls.Add(im, x, y);
                        }
                        else if ((x + y) % 2 == 0 && y >= 5)
                        {
                            //meter a outra côr
                            PictureBoxDoPanel[x][y].Image = Image.FromFile("PecaPreta.png");
                            PictureBoxDoPanel[x][y].BringToFront();
                        }
                    }


                    //Button cmd = new Button();
                    //Imagens
                    //cmd.Text = string.Format("({0}, {1})", x, y);         //Finally, add the control to the correct location in the table
                    //tableLayoutPanel1.Controls.Add(cmd, x, y);
                    //tLPTabuleiro.SetCellPosition 

                }
            }
        }

    }
}
