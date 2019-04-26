using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDamas
{
    public class Jogo
    {//Classe que representa um jogo. Dois jogadores e um tabuleiro

        private int id; //Para quando quiseremos voltar a um jogo seja mais facil procurar através do id
        private Jogador jogadorUm;
        private Jogador jogadorDois;
        private Tabuleiro tabuleiro;
        private int contadorJogadas; //serve para os casos de empate ou para as regras
        private DateTime tempo;//tempo de jogo. Apenas para informação

        public Tabuleiro Tabuleiro
        {
            get => default(Tabuleiro);
            set
            {
            }
        }

        public Jogador Jogador
        {
            get => default(Jogador);
            set
            {
            }
        }
    }
}
