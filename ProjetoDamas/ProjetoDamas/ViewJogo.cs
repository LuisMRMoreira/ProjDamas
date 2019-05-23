﻿using System;
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
    public partial class ViewJogo : Form
    {
        public event MetodosSemParametros PedidoRetirarReturnSettings;
        public event MetodosSemParametros PedidoRetirarReturnRegras;


        public event MetodosComUmaPosicao PedidoMostarPossiveisJogadas;

        public PictureBox[,] PictureBoxDoPanel;
        PictureBox selected;

        public ViewJogo()//attache image to cursor
        {
            InitializeComponent();
            PictureBoxDoPanel = new PictureBox[8, 4] { { pB00, pB20, pB40, pB60 },
                                                       { pB11, pB31, pB51, pB71 },
                                                       { pB02, pB22, pB42, pB62 },
                                                       { pB13, pB33, pB53, pB73 },
                                                       { pB04, pB24, pB44, pB64 },
                                                       { pB15, pB35, pB55, pB75 },
                                                       { pB06, pB26, pB46, pB66 },
                                                       { pB17, pB37, pB57, pB77 }};

            foreach (var box in PictureBoxDoPanel)
            {
                box.AllowDrop = true;
                box.DragDrop += PictureBox_DragDrop;
                box.DragEnter += PictureBox_DragEnter;
                box.MouseClick += PictureBox_MouseClick;
                box.MouseMove += PictureBox_MouseMove;
                //box.Paint += PictureBox_Paint;
            }



            Program.M_Tabuleiro.RespostaPossiveisJogadas += M_Tabuleiro_RespostaPossiveisJogadas;
            

        }

        private void M_Tabuleiro_RespostaPossiveisJogadas(List<Coordenada> coordenadas)
        {
            //Pintar coordenadas enviadas

            foreach  (Coordenada coor in coordenadas)
            {
                foreach (var box in PictureBoxDoPanel)
                {
                    if (box.Name == "pB" + coor.x.ToString() + coor.y.ToString())
                    {
                        box.BackColor = Color.FromArgb(100,20,0,0);
                    }
                }
            }
        }

        private void PictureBox_DragDrop(object sender, DragEventArgs e)
        {

            var target = (PictureBox)sender;
            var source = (PictureBox)e.Data.GetData(typeof(PictureBox));
            
            if (target.Image == null /* && está nas possiveis jogadas*/)
            {
                if (e.Data.GetDataPresent(typeof(PictureBox)))
                {                    
                    if (source != target)
                    {
                        Console.WriteLine("Do DragDrop from " + source.Name + " to " + target.Name);
                        // You can swap the images out, replace the target image, etc.

                        SwapImages(source, target);
                        


                        selected = null;
                        SelectBox(target);
                        return;
                    }
                }
            }

            tLPTabuleiro.CellPaint += tLPTabuleiro_CellPaint;//Depois de fazer o drag and drop, limpa as sugestões de possiveis jogadas
            
            Console.WriteLine("Don't do DragDrop");
        }


        private void PictureBox_DragEnter(object sender, DragEventArgs e)
        {

            e.Effect = DragDropEffects.Move;

            string nome = ((PictureBox)sender).Name;
            int x, y;
            x = Convert.ToInt32((nome.Remove(0, 2)).Remove(1, 1)); // pB02 -> 0
            y = Convert.ToInt32(nome.Remove(0, 3));// pB02 -> 2


            if (PedidoMostarPossiveisJogadas != null)
            {
                PedidoMostarPossiveisJogadas(x, y);
            }
        }
        
        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            SelectBox((PictureBox)sender);
        }
        
        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left )
            {
                var pb = (PictureBox)sender;
                if (pb.Image != null) //<---
                {
                    pb.DoDragDrop(pb, DragDropEffects.Move);                    

                }
            }
            
        }
        
        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            var pb = (PictureBox)sender;
            pb.BackColor = Color.Transparent;
            if (selected == pb)
            {
                ControlPaint.DrawBorder(e.Graphics, pb.ClientRectangle,
                   Color.Blue, 5, ButtonBorderStyle.Solid,  // Left
                   Color.Blue, 5, ButtonBorderStyle.Solid,  // Top
                   Color.Blue, 5, ButtonBorderStyle.Solid,  // Right
                   Color.Blue, 5, ButtonBorderStyle.Solid); // Bottom
            }
        }
        
        private void SelectBox(PictureBox pb)
        {
            if (selected != pb)
            {
                selected = pb;
            }
            else
            {
                selected = null;
            }

            // Cause each box to repaint
            foreach (var box in PictureBoxDoPanel) box.Invalidate();
        }

        private void SwapImages(PictureBox source, PictureBox target)
        {
            if (source.Image == null && target.Image == null) //<---
            {
                return;
            }

            var temp = target.Image; //<---
            target.Image = source.Image;//<----
            source.Image = temp;//<---
        }
        
        private void tLPTabuleiro_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if ((e.Column + e.Row) % 2 == 1)
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
            else
                e.Graphics.FillRectangle(Brushes.Black, e.CellBounds);

            ControlPaint.DrawBorder(e.Graphics, e.CellBounds,
                   Color.SaddleBrown, 2, ButtonBorderStyle.Solid,  // Left
                   Color.SaddleBrown, 2, ButtonBorderStyle.Solid,  // Top
                   Color.SaddleBrown, 2, ButtonBorderStyle.Solid,  // Right
                   Color.SaddleBrown, 2, ButtonBorderStyle.Solid); // Bottom

        }


        //private void GerarPecasNoTabuleiro(bool corCima)
        //{
        //    for (int x = 0; x < 8; x++)
        //    {
        //        for (int y = 0; y < 4; y++)
        //        {
        //            if (corCima) //0 branco, 1 preto
        //            {
        //                if (x < 3)
        //                {
        //                    PictureBoxDoPanel[x,y].Image = Properties.Resources.PecaPreta;
        //                    PictureBoxDoPanel[x,y].BringToFront();
        //                }
        //                else if (x >= 5)
        //                {
        //                    //meter a outra côr
        //                    PictureBoxDoPanel[x, y].Image = Properties.Resources.PecaBranca;// Image.FromFile("PecaBranca.png");
        //                    PictureBoxDoPanel[x,y].BringToFront();
        //                }
        //                else
        //                {
        //                    PictureBoxDoPanel[x, y].Image = null;
        //                    PictureBoxDoPanel[x, y].BringToFront();
        //                }
        //            }
        //            else
        //            {

        //                if (x < 3)
        //                {
        //                    PictureBoxDoPanel[x, y].Image = Properties.Resources.PecaBranca;
        //                    PictureBoxDoPanel[x, y].BringToFront();
        //                }
        //                else if (x >= 5)
        //                {
        //                    //meter a outra côr
        //                    PictureBoxDoPanel[x, y].Image = Properties.Resources.PecaPreta;                            
        //                    PictureBoxDoPanel[x, y].BringToFront();
        //                }
        //                else
        //                {
        //                    PictureBoxDoPanel[x, y].Image = null;
        //                    PictureBoxDoPanel[x, y].BringToFront();
        //                }
        //            }

        //        }
        //    }
        //}


        //private bool MoveLengthVality(PictureBox[,] matrix, PictureBox source, PictureBox target)
        //{

        //    Point indexSource = new Point();
        //    Point indexTarget = new Point(); ;

        //    for (int y = 0; y < 8; y++)
        //    {
        //        for (int x = 0; x < 4; x++)
        //        {
        //            if (matrix[y, x] == source)
        //            {
        //                indexSource.X = x;
        //                indexSource.Y = y;
        //            }
        //            else if(matrix[y, x] == target)
        //            {
        //                indexTarget.X = x;
        //                indexTarget.Y = y;
        //            }
        //        }
        //    }


        //    if (!(Math.Abs(indexSource.X - indexTarget.X) <=1 && Math.Abs(indexSource.Y - indexTarget.Y) == 1))
        //    {
        //        return false;
        //    }

        //    return true;

        //}



        private void regrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.V_Rules.jogo = true;
            Program.V_Rules.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want to leave?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MessageBox.Show("Do you want to save the game to play later?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Hide();
                    Program.V_Menu.Show();
                    //Guardar o jogo estado do jogo -----------------------------------------------------------------------------------------------------------------------------------
                }

                this.Hide();
                Program.V_Menu.Show();
            }
        }

        private void ViewJogo_Load(object sender, EventArgs e)
        {

            ///
            ///Cor do painel
            ///

            pJogadorUm.BackColor = Color.FromArgb(150, 0, 0, 0);
            pJogadorDois.BackColor = Color.FromArgb(150, 0, 0, 0);

            ///
            /// Cores do MenuStrip
            ///
            mSJogo.BackColor = Color.FromArgb(150, 0, 0, 0);
            mSJogo.ForeColor = Color.White;
        }

        private void pBJogadoUm_MouseHover(object sender, EventArgs e)
        {
            pJogadorUm.Visible = true;
        }

        private void pBJogadoUm_MouseLeave(object sender, EventArgs e)
        {
            pJogadorUm.Visible = false;
        }

        private void pBJogadorDois_MouseHover(object sender, EventArgs e)
        {
            pJogadorDois.Visible = true;
        }

        private void pBJogadorDois_MouseLeave(object sender, EventArgs e)
        {
            pJogadorDois.Visible = false;
        }

        private void bSurrenderJogadorUm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want to quit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Program.V_Result.ShowDialog();
                //Enviar os dados do jogador 1 -----------------------------------------------------------------------------------------------------------------------------

            }
        }

        private void bSurrenderJogadorDois_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want to quit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Program.V_Result.ShowDialog();
                //Enviar os dados do jogador 2 -----------------------------------------------------------------------------------------------------------------------------

            }

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Guardar o jogo estado do jogo -----------------------------------------------------------------------------------------------------------------------------------

            MessageBox.Show("Game saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }



        private void definicoesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Abrir uma nova View
            Program.V_Settings.jogo = true;
            //Program.V_Settings.ShowDialog();
            
        }

        private void ViewJogo_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                

            ///
            /// Inicializar componente
            ///

            //Evento para a view iniciar as picture box com os valores que estão no model

            //GerarPecasNoTabuleiro(false);
            //PictureBoxDoPanel = ArraySavePBP;
            //GerarPecasNoTabuleiro(false);

            }
        }

    }
}
