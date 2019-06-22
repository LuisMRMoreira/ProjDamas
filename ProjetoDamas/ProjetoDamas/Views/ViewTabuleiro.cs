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
    public partial class ViewTabuleiro : Form
    {
        public event MetodosComDuasCoordenadas PedidoJogadaPessoa;
        public event MetodosComUmaCoordenada PedidoMostarPossiveisJogadas;
        public event MetodosComDoisJogadresEUmInteiro PedidoFimDoJogo;

        PictureBox selected;

        public ViewTabuleiro()//attache image to cursor
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
                    cont.MouseClick += PictureBox_MouseClick;
                    cont.MouseDown += Cont_MouseDown;
                    cont.Enabled = false;
                }

            }
            tLPTabuleiro.BringToFront();

            Program.M_Jogo.RespostaComecarJogo += M_Jogo_RespostaComecarJogo;
            Program.M_Jogo.RespostaEnabledPB += M_Jogo_RespostaEnabledPB;
            Program.M_Jogo.RespostaJogadaValida += M_Jogo_RespostaJogadaValida;
            Program.M_Jogo.RespostaJogadaValidaEPecaComida += M_Jogo_RespostaJogadaValidaEPecaComida;
            Program.M_Jogo.RespostaLimparTabuleiro += M_Jogo_RespostaLimparTabuleiro;
            Program.M_Jogo.RespostaJogadas += M_Jogo_RespostaJogadas;
            Program.M_Jogo.RespostaFimDoJogo += M_Jogo_RespostaFimDoJogo;

        }



        /// <summary>
        /// Respostas vindas como evento do model Jogo
        /// </summary>

        private void M_Jogo_RespostaFimDoJogo(Jogador j1, Jogador j2, int i)
        {
            if (PedidoFimDoJogo != null)
                PedidoFimDoJogo(j1, j2, i);
        }

        //Inicializa as PB de um jogo
        private void M_Jogo_RespostaComecarJogo(Posicao[,] t1, Jogador j1, Jogador j2)
        {
            pBJogadoUm.ImageLocation = ((Pessoa)j1).Imagem;
            lNome1N.Text = ((Pessoa)j1).Username;
            lCountry1N.Text = ((Pessoa)j1).Pais;
            lVitorias1N.Text = ((Pessoa)j1).Vitorias.ToString();
            lTotalJogos1N.Text = (((Pessoa)j1).Empates + ((Pessoa)j1).Vitorias + ((Pessoa)j1).Derrotas).ToString();

            if (j2 is Robot)
            {
                pBJogadorDois.ImageLocation = ((Robot)j2).Imagem;
                lNomeN2.Text = "Robot";
                lCountryN2.Text = "--";
                lVitoriasN2.Text = "--";
                lTotalJogos2N.Text = "--";
                bSurrenderJogadorDois.Visible = false;
            }
            else if (j1 is Guest)
            {
                pBJogadorDois.ImageLocation = ((Guest)j2).Imagem;
                lNomeN2.Text = "Guest";
                lCountryN2.Text = "--";
                lVitoriasN2.Text = "--";
                lTotalJogos2N.Text = "--";
                bSurrenderJogadorDois.Visible = true;
            }
            else
            {
                pBJogadorDois.ImageLocation = ((Pessoa)j2).Imagem;
                lNomeN2.Text = ((Pessoa)j2).Username;
                lCountryN2.Text = ((Pessoa)j2).Pais;
                lVitoriasN2.Text = ((Pessoa)j2).Vitorias.ToString();
                lTotalJogos2N.Text = (((Pessoa)j2).Empates + ((Pessoa)j2).Vitorias + ((Pessoa)j2).Derrotas).ToString();
                bSurrenderJogadorDois.Visible = true;
            }

            if (j2.CorPecas)
            {
                lColor1N.Text = "Black";
                lColor2N.Text = "White";
            }
            else
            {
                lColor1N.Text = "White";
                lColor2N.Text = "Black";
            }


            this.InicializarTabuleiro(t1);
            this.Show();
        }

        // Responsavel por inicializar as posições da View
        private void InicializarTabuleiro(Posicao[,] t1)
        {
            for (int i = 0; i < t1.GetLength(0); i++)
            {
                for (int j = 0; j < t1.GetLength(1); j++)// Executa linha a linha
                {
                    if ((i + j) % 2 == 0) // Para cada posição do tabuleiro onde o fundo é branco (Parte jogavel)
                    {
                        // Obter o controlo da PictureBox que está na posição que queremos atualizar
                        string nomeControlo = "pB" + j.ToString() + i.ToString();
                        Control cont = this.Controls.Find(nomeControlo, true)[0];
                        PictureBox pB = (PictureBox)cont;


                        if (t1[i, j] is Simples)// Caso se queira alterar a PictureBox para uma peça simples
                        {
                            if (((Peca)t1[i, j]).CorPeca) //preta
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
                        else if (t1[i, j] is Dama)//Se a peca não for simples, tem de ser Dama
                        {
                            if (((Peca)t1[i, j]).CorPeca) //preta
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
                        else //Se for inválida
                        {
                            pB.Image = null;
                            pB.BringToFront(); //Verificar se funciona sem isto
                        }
                    }
                }
            }

        }

        
        private void M_Jogo_RespostaEnabledPB(int cor, Posicao[,] t1)
        {
            //0->enable das peças brancas(branco-> 0); 1->enable das peças pretas(preto-> 1); 2->disable de tudo(robot)

            if (cor == 2)
            {
                foreach (Control cont in tLPTabuleiro.Controls)
                    if (cont is PictureBox)
                        cont.Enabled = false;
            }
            else
            {
                // false -> branca // true -> preta
                //Verifica de quem é a prioridade de jogo e faz o enable das PictureBox com pecas da cor cintrária.
                for (int i = 0; i < t1.GetLength(0); i++)
                    for (int j = 0; j < t1.GetLength(1); j++)
                        if ((i + j) % 2 == 0) // Para cada posição do tabuleiro onde o fundo é branco (Parte jogavel)
                        {
                            string nomeControlo = "pB" + j.ToString() + i.ToString();
                            Control cont = this.Controls.Find(nomeControlo, true)[0];
                            PictureBox pB = (PictureBox)cont;

                            if ((t1[i, j] is Peca))
                                if (((Peca)t1[i, j]).CorPeca != Convert.ToBoolean(cor))
                                    pB.Enabled = false;
                                else
                                    pB.Enabled = true;
                            else
                                pB.Enabled = true;

                        }


            }
        }


        private void M_Jogo_RespostaLimparTabuleiro(List<Coordenada> lc)
        {
            foreach (Coordenada coor in lc)
            {
                Control c = tLPTabuleiro.GetControlFromPosition(coor.y, coor.x);
                c.BackColor = Color.FromArgb(100, 0, 0, 0);
            }
        }

        private void M_Jogo_RespostaJogadaValidaEPecaComida(Coordenada origem, Coordenada destino, Coordenada pecaComida, Posicao[,] t1)
        {
            this.Jogada_AlterarPB(origem, destino, t1);

            string nomeControlo = "pB" + pecaComida.y.ToString() + pecaComida.x.ToString();
            Control cont = this.Controls.Find(nomeControlo, true)[0];
            PictureBox pBOrigem = (PictureBox)cont;
            pBOrigem.Image = null;

        }

        private void M_Jogo_RespostaJogadaValida(Coordenada origem, Coordenada destino, Posicao[,] t1)
        {
            this.Jogada_AlterarPB(origem, destino, t1);
        }

        public void Jogada_AlterarPB(Coordenada origem, Coordenada destino, Posicao[,] t1)
        {
            string nomeControlo = "pB" + origem.y.ToString() + origem.x.ToString();
            Control cont = this.Controls.Find(nomeControlo, true)[0];
            PictureBox pBOrigem = (PictureBox)cont;

            nomeControlo = "pB" + destino.y.ToString() + destino.x.ToString();
            cont = this.Controls.Find(nomeControlo, true)[0];
            PictureBox pBDestino = (PictureBox)cont;

            if (((Peca)t1[destino.x, destino.y]) is Dama)//0 -> Branca 1-> Preta
                if (((Peca)t1[destino.x, destino.y]).CorPeca)//Preta
                    pBOrigem.Image = Properties.Resources.DamaPreta;
                else
                    pBOrigem.Image = Properties.Resources.DamaBranca;

            SwapImages(pBOrigem, pBDestino);

            //selected = null;

        }

        private void M_Jogo_RespostaJogadas(List<Coordenada> coordenadas)
        {
            foreach (Coordenada coor in coordenadas)
            {
                Control c = tLPTabuleiro.GetControlFromPosition(coor.y, coor.x);
                c.BackColor = Color.FromArgb(200, 100, 0, 0);
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

            if (PedidoJogadaPessoa != null)
            {
                PedidoJogadaPessoa(new Coordenada(y2, x2), new Coordenada(y1, x1));
            }

        }

        private void Cont_MouseDown(object sender, MouseEventArgs e)
        {
            string nome = ((PictureBox)sender).Name;
            int x, y;
            x = Convert.ToInt32((nome.Remove(0, 2)).Remove(1, 1)); // pB02 -> 0
            y = Convert.ToInt32(nome.Remove(0, 3));// pB02 -> 2


            if (PedidoMostarPossiveisJogadas != null)
            {
                PedidoMostarPossiveisJogadas(new Coordenada(y, x));
            }
        }

        private void PictureBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
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
        /// 

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

        //FAZER:::::: Ver este metodo
        private void regrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Program.V_Rules.jogo = true;
            //Program.V_Rules.Show();
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

        //FAZER:::::: Ver este metodo
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Guardar o jogo estado do jogo -----------------------------------------------------------------------------------------------------------------------------------

            MessageBox.Show("Game saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //FAZER:::::: Ver este metodo
        private void definicoesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Abrir uma nova View
            //Program.V_Settings.jogo = true;
            //Program.V_Settings.ShowDialog();

        }


        private void bSurrenderJogadorUm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                if (PedidoFimDoJogo != null)
                    PedidoFimDoJogo(Program.M_Jogo.Jogo.JogadorUm, Program.M_Jogo.Jogo.JogadorDois, 1);
            }
        }

        private void bSurrenderJogadorDois_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                if (PedidoFimDoJogo != null)
                    PedidoFimDoJogo(Program.M_Jogo.Jogo.JogadorUm, Program.M_Jogo.Jogo.JogadorDois, 0);
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


            ///
            /// Sempre que esta view é mostrada, é necessario que as ViewsComecem enable = false
            ///
            foreach (Control cont in tLPTabuleiro.Controls)
                if (cont is PictureBox)
                    cont.Enabled = false;


        }


        //MouseLeave e MouseHover das pictureBox dos jogadores
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
        
    }
}
