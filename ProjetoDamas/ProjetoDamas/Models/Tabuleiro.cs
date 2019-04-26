using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDamas
{
    public class Tabuleiro
    {//Tabuleiro de jogo que tem toda a informação necessaria, desde coordenadas (iguais à da matriz). Posicao valida, invalida, ou com peça. Peça a que jogador pertence
        private Posicao[,] tabuleiro = new Posicao[8,8];

        public Posicao Posicao
        {
            get => default(Posicao);
            set
            {
            }
        }
    }
}
