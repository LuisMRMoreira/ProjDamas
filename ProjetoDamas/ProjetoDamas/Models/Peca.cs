using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damas
{
    public class Peca : Posicao
    {//Classe que representa cada peca que está no tabuleiro. Recebe as coordenadas por herança de Posicao
        private bool corPeca; //0-> branca ou 1 ->preta. 
        private bool estado; //0-> simples ou 1-> dama
        private List<Coordenada> historico;
        private int jogadasSucessivas;

        public Coordenada Coordenada
        {
            get => default(Coordenada);
            set
            {
            }
        }
    }
}
