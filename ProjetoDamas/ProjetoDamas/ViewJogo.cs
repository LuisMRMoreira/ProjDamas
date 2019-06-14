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
    public partial class ViewJogo : Form
    {
        public event MetodosComUmaPosicao PedidoMostarPossiveisJogadas;
        public event MetodosSemParametros PedidoInicializarTabuleiro; //Vai para o model tabuleiro
        public event MetodosComDuasCoordenadas PedidoVerificarJogada; //Vai para o model tabuleiro verificar se a peca pode ir da coordenada anterior para a atual

        public PictureBox[,] PictureBoxDoPanel;
        PictureBox selected;

        public ViewJogo()//attache image to cursor
        {
            InitializeComponent();


            foreach (Control cont in tLPTabuleiro.Controls)
            {
                if (cont is PictureBox)
                {
                    cont.AllowDrop = true;
                    cont.BringToFront();
                    cont.DragDrop += PictureBox_DragDrop;
                    cont.DragEnter += PictureBox_DragEnter;
                    cont.MouseMove += PictureBox_MouseMove;
                    //cont.Paint += PictureBox_Paint;
                    cont.MouseClick += PictureBox_MouseClick;
                    cont.MouseDown += Cont_MouseDown;
                    //cont.MouseUp += Cont_MouseUp;
                }

            }
            tLPTabuleiro.BringToFront();



            Program.M_Tabuleiro.RespostaPossiveisJogadas += M_Tabuleiro_RespostaPossiveisJogadas;
            Program.M_Tabuleiro.RespostaTabuleiroInicializado += M_Tabuleiro_RespostaTabuleiroInicializado;
            Program.M_Tabuleiro.RespostaVerificarJogadaValida += M_Tabuleiro_RespostaVerificarJogadaValida;
            Program.M_Tabuleiro.RespostaVerificarJogadaInvalida += M_Tabuleiro_RespostaVerificarJogadaInvalida;
            Program.M_Tabuleiro.RespostaComerPeca += M_Tabuleiro_RespostaComerPeca;
        }

        private void M_Tabuleiro_RespostaComerPeca(int x, int y)
        {
            string nomeControlo = "pB" + y.ToString() + x.ToString();
            Control cont = this.Controls.Find(nomeControlo, true)[0];
            PictureBox pBOrigem = (PictureBox)cont;
            pBOrigem.Image = null;
        }

        private void M_Tabuleiro_RespostaVerificarJogadaInvalida()
        {
            selected = null;

            foreach (Coordenada coor in Program.M_Tabuleiro.PossiveisJogadasL)
            {
                Control c = tLPTabuleiro.GetControlFromPosition(coor.y, coor.x);
                c.BackColor = Color.FromArgb(100, 0, 0, 0);
            }

            
            //Program.M_Tabuleiro.PossiveisJogadasL.Clear();

        }

        private void M_Tabuleiro_RespostaVerificarJogadaValida(Coordenada c1, Coordenada c2, Peca tipoPecaDestino)
        {
            string nomeControlo = "pB" + c1.y.ToString() + c1.x.ToString();
            Control cont = this.Controls.Find(nomeControlo, true)[0];
            PictureBox pBOrigem = (PictureBox)cont;

            nomeControlo = "pB" + c2.y.ToString() + c2.x.ToString();
            cont = this.Controls.Find(nomeControlo, true)[0];
            PictureBox pBDestino = (PictureBox)cont;

            if (tipoPecaDestino is Dama)
            {//0 -> Branca 1-> Preta
                if (tipoPecaDestino.CorPeca)//Preta
                {
                    pBOrigem.Image = Properties.Resources.DamaPreta;
                }
                else
                {
                    pBOrigem.Image = Properties.Resources.DamaBranca;
                }
                
            }

            SwapImages(pBOrigem, pBDestino);
                       
            selected = null;
            //SelectBox(pBDestino);
            //return;

            foreach (Coordenada coor in Program.M_Tabuleiro.PossiveisJogadasL)
            {
                Control c = tLPTabuleiro.GetControlFromPosition(coor.y, coor.x);
                c.BackColor = Color.FromArgb(100, 0, 0, 0);
            }
            
            //tLPTabuleiro.CellPaint += tLPTabuleiro_CellPaint;//Depois de fazer o drag and drop, limpa as sugestões de possiveis jogadas

            //Program.M_Tabuleiro.PossiveisJogadasL.Clear();

        }



        // Responsavel por inicializar as posições da View
        private void M_Tabuleiro_RespostaTabuleiroInicializado()
        {
            for (int i = 0; i < Program.M_Tabuleiro.tabuleiro.GetLength(0); i++)
            {
                for (int j = 0; j < Program.M_Tabuleiro.tabuleiro.GetLength(1); j++)// Executa linha a linha
                {
                    if ((i + j) % 2 == 0) // Para cada posição do tabuleiro onde o fundo é branco (Parte jogavel)
                    {
                        // Obter o controlo da PictureBox que está na posição que queremos atualizar
                        string nomeControlo = "pB" + j.ToString() + i.ToString();
                        Control cont = this.Controls.Find(nomeControlo,true)[0];
                        PictureBox pB = (PictureBox)cont;


                        if (Program.M_Tabuleiro.tabuleiro[i, j] is Simples)// Caso se queira alterar a PictureBox para uma peça simples
                        {
                            if (((Peca)Program.M_Tabuleiro.tabuleiro[i, j]).CorPeca) //preta
                            {
                                pB.Image = Properties.Resources.PecaPreta;
                                pB.BringToFront(); //Verificar se funciona sem isto
                            }
                            else //Branca
                            {
                                pB.Image = Properties.Resources.PecaBranca;
                                pB.BringToFront(); //Verificar se funciona sem isto
                            }

                        }
                        else if (Program.M_Tabuleiro.tabuleiro[i, j] is Dama)//Se a peca não for simples, tem de ser Dama
                        {
                            if (((Peca)Program.M_Tabuleiro.tabuleiro[i, j]).CorPeca) //preta
                            {
                                pB.Image = Properties.Resources.DamaPreta;
                                pB.BringToFront(); //Verificar se funciona sem isto
                            }
                            else //Branca
                            {
                                pB.Image = Properties.Resources.DamaBranca;
                                pB.BringToFront(); //Verificar se funciona sem isto
                            }
                        }
                    }
                }
            }

        }



        private void M_Tabuleiro_RespostaPossiveisJogadas(List<Coordenada> coordenadas)
        {
            //Pintar coordenadas enviadas

            foreach  (Coordenada coor in coordenadas)
            {
                Control c = tLPTabuleiro.GetControlFromPosition(coor.y, coor.x);
                c.BackColor = Color.FromArgb(200, 100, 0, 0);

                // Obter o controlo da PictureBox que está na posição que queremos atualizar
                //Control cont = Controls.Find("pB" + coor.y.ToString() + coor.x.ToString(), true)[0];
                //PictureBox pB = (PictureBox)cont;

                //pB.BackColor = Color.FromArgb(100,100,0,0);                

            }
        }



        /// <summary>
        /// Codigo relativo ao Drag and Drop
        /// </summary>

        private void PictureBox_DragDrop(object sender, DragEventArgs e)
        {
            var target = (PictureBox)sender;
            var source = (PictureBox)e.Data.GetData(typeof(PictureBox));
            string cSource = target.Name;
            string cTarget = source.Name;
            int x1, y1, x2, y2;
            x1 = Convert.ToInt32((cSource.Remove(0, 2)).Remove(1, 1)); // pB02 -> 0
            y1 = Convert.ToInt32(cSource.Remove(0, 3));// pB02 -> 2
            x2 = Convert.ToInt32((cTarget.Remove(0, 2)).Remove(1, 1));
            y2 = Convert.ToInt32(cTarget.Remove(0, 3));

            if (PedidoVerificarJogada != null)
            {
                PedidoVerificarJogada(new Coordenada(y2, x2), new Coordenada(y1, x1));//Origem, destino
            }






            //if (target.Image == null /* && está nas possiveis jogadas*/)
            //{
            //    if (e.Data.GetDataPresent(typeof(PictureBox)))
            //    {                    
            //        if (source != target)
            //        {
            //            Console.WriteLine("Do DragDrop from " + source.Name + " to " + target.Name);
            //            // You can swap the images out, replace the target image, etc.

            //            SwapImages(source, target);



            //            selected = null;
            //            SelectBox(target);
            //            return;
            //        }
            //    }
            //}

            //tLPTabuleiro.CellPaint += tLPTabuleiro_CellPaint;//Depois de fazer o drag and drop, limpa as sugestões de possiveis jogadas

            //Console.WriteLine("Don't do DragDrop");
        }


        private void PictureBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        
        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            SelectBox((PictureBox)sender);
        }
        

        private void Cont_MouseDown(object sender, MouseEventArgs e)
        {
            string nome = ((PictureBox)sender).Name;
            int x, y;
            x = Convert.ToInt32((nome.Remove(0, 2)).Remove(1, 1)); // pB02 -> 0
            y = Convert.ToInt32(nome.Remove(0, 3));// pB02 -> 2


            if (PedidoMostarPossiveisJogadas != null)
            {
                PedidoMostarPossiveisJogadas(y, x);
            }
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

            foreach (Control cont in tLPTabuleiro.Controls) cont.Invalidate();
                //foreach (var box in PictureBoxDoPanel) box.Invalidate();
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
        

        /// <summary>
        /// Pintura das posições do tabuleiro de jogo
        /// </summary>

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

        /// <summary>
        /// Click dos butões, Load da View e Mouse Hover das imagens dos jogadores
        /// </summary>

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

        // Mouse Hover E mouse leave
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


        private void ViewJogo_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                if (PedidoInicializarTabuleiro != null)
                {
                    tLPTabuleiro.SendToBack();
                    PedidoInicializarTabuleiro();
                }









            ///
            /// Inicializar componente
            ///

            //Evento para a view iniciar as picture box com os valores que estão no model

            //GerarPecasNoTabuleiro(false);
            //PictureBoxDoPanel = ArraySavePBP;
            //GerarPecasNoTabuleiro(false);

            }
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


    }
}
