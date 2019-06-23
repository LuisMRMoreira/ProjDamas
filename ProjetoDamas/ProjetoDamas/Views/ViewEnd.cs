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
    public partial class ViewEnd : Form
    {
        public event MetodosSemParametros PedidoVoltarMenu;
        public event MetodosComUmUserEUMJogador PedidoRecomecarJogo;

        public ViewEnd()
        {
            InitializeComponent();
            Program.M_User.RespostaFimDeJogo += M_User_RespostaFimDeJogo;
        }

        private void M_User_RespostaFimDeJogo(Jogador j1, Jogador j2, int i)
        {//0 -> j1 ; 1 -> j2 ; 2 -> Empate
            if (i == 0)//Ganhou o JogadorUm
            {
                lNomeVencedorN.Text = ((Pessoa)j1).Username;
                lCountryVencedorN.Text = ((Pessoa)j1).Pais;
                pbJogadorVencedor.ImageLocation = ((Pessoa)j1).Imagem;

                if (j2 is Robot)
                {
                    lNomePerdedorN.Text = "Robot";
                    lCountryPerdedorN.Text = "--";
                    pBJogadorPerdedor.ImageLocation = ((Robot)j2).Imagem;
                }
                else if (j2 is Guest)
                {
                    lNomePerdedorN.Text = "Guest";
                    lCountryPerdedorN.Text = "--";
                    pBJogadorPerdedor.ImageLocation = ((Guest)j2).Imagem;
                }
                else
                {
                    lNomePerdedorN.Text = ((Pessoa)j2).Username;
                    lCountryPerdedorN.Text = ((Pessoa)j2).Pais;
                    pBJogadorPerdedor.ImageLocation = ((Pessoa)j2).Imagem;
                }


            }
            else if (i == 1) //Ganhoi o jogadorDois
            {
                lNomePerdedorN.Text = ((Pessoa)j1).Username;
                lCountryPerdedorN.Text = ((Pessoa)j1).Pais;
                pBJogadorPerdedor.ImageLocation = ((Pessoa)j1).Imagem;

                if (j2 is Robot)
                {
                    lNomeVencedorN.Text = "Robot";
                    lCountryVencedorN.Text = "--";
                    pbJogadorVencedor.ImageLocation = ((Robot)j2).Imagem;
                } else
                if (j2 is Guest)
                {
                    lNomeVencedorN.Text = "Guest";
                    lCountryVencedorN.Text = "--";
                    pbJogadorVencedor.ImageLocation = ((Guest)j2).Imagem;
                }
                else
                {
                    lNomeVencedorN.Text = ((Pessoa)j2).Username;
                    lCountryVencedorN.Text = ((Pessoa)j2).Pais;
                    pbJogadorVencedor.ImageLocation = ((Pessoa)j2).Imagem;
                }

            }
            else //Empate 
            {
                lWinner.Text = "It's a draw";

                lNomeVencedorN.Text = ((Pessoa)j1).Username;
                lCountryVencedorN.Text = ((Pessoa)j1).Pais;
                pbJogadorVencedor.ImageLocation = ((Pessoa)j1).Imagem;

                if (j2 is Robot)
                {
                    lNomePerdedorN.Text = "Robot";
                    lCountryPerdedorN.Text = "--";
                    pBJogadorPerdedor.ImageLocation = ((Robot)j2).Imagem;
                } else
                if (j2 is Guest)
                {
                    lNomePerdedorN.Text = "Guest";
                    lCountryPerdedorN.Text = "--";
                    pBJogadorPerdedor.ImageLocation = ((Guest)j2).Imagem;
                }
                else 
                {
                    lNomePerdedorN.Text = ((Pessoa)j2).Username;
                    lCountryPerdedorN.Text = ((Pessoa)j2).Pais;
                    pBJogadorPerdedor.ImageLocation = ((Pessoa)j2).Imagem;
                }
            }

            Program.V_Tabuleiro.Hide();
            this.Show();



        }


        private void bBackMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (PedidoVoltarMenu != null)
            {
                PedidoVoltarMenu();
            }
            Program.V_Menu.Show();

        }

        private void ViewEnd_Load(object sender, EventArgs e)
        {
            pCor.BackColor = Color.FromArgb(40, 0, 0, 0);
            pBJogadorPerdedor.BackColor = Color.FromArgb(40, 0, 0, 0);
            pbJogadorVencedor.BackColor = Color.FromArgb(40, 0, 0, 0);
            pInfoVencedor.BackColor = Color.FromArgb(40, 0, 0, 0);
            pPerdedor.BackColor = Color.FromArgb(40, 0, 0, 0);
            bBackMenu.BackColor = Color.FromArgb(40, 0, 0, 0);
            lGameEnded.BackColor = Color.FromArgb(40, 0, 0, 0);
            lWinner.BackColor = Color.FromArgb(40, 0, 0, 0);

        }

        private void bAgain_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (PedidoRecomecarJogo != null)
            {
                PedidoRecomecarJogo(new User(((Pessoa)Program.M_Jogo.Jogo.JogadorUm)), Program.M_Jogo.Jogo.JogadorDois);
            }
        }
    }
}
