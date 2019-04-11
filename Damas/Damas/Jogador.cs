using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damas
{
    public class Jogador
    {//Classe representativa de cada jogador que intervem no jogo
        private int id;
        private bool corPecas; //0-> branca ou 1 -> preta. Informa qual das peças é que o jogador está a controlar
        private List<Peca> pecasEmJogo;
        private bool prioridade; //informa se o jogador continua com prioridade para jogar após uma jogada
        private int numDamas;//Numero de damas em jogo
        private int numPecas;//Numero de pecas simples em jogo
        private int numeroPecasEmJogo;
        private int numeroDePecasComidas = 0;//começa a zero

        public Peca Peca
        {
            get => default(Peca);
            set
            {
            }
        }
    }
}
