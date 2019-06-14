using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDamas
{
    public class Peca : Posicao
    {//Classe que representa cada peca que está no tabuleiro. Recebe as coordenadas por herança de Posicao
        public bool CorPeca { get; private set; } //0-> branca ou 1 ->preta. 
        public int JogadasSucessivas { get; private set; }
        public bool SentidoJogada { get; private set; } //0-> cima para baixo ou 1 -> baixo para cima.


        public Peca(bool corP, bool sentidoJogada)
        {
            CorPeca = corP;
            SentidoJogada = sentidoJogada;

        }


        //public Coordenada Coordenada
        //{
        //    get => default(Coordenada);
        //    set
        //    {
        //    }
        //}
    }
}
