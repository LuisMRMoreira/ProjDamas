using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDamas
{
    public class Jogador 
    {//Classe representativa de cada jogador que intervem no jogo
        

        public bool CorPecas { get; private set; } //0-> branca ou 1 -> preta. Informa qual das peças é que o jogador está a controlar
        public bool Prioridade { get; set; } //informa se o jogador continua com prioridade para jogar após uma jogada


        public Jogador( bool cor, bool prior)
        {
            CorPecas = cor;
            Prioridade = prior;
        }

    }

}
