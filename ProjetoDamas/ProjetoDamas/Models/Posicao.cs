using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDamas
{
    public class Posicao
    {//Classe que representa cada um dos quadrados do tabuleiro.
     //Estes quadrados podem ser inválidos, podem estar vazios, ou podem ter uma peça contida nele
        //private Coordenada coordenada;
        //private bool corFundo; //0-> branca e 1-> preta
        //private int numeroPassagens; //Numero de vezes que cada posição foi ocupada por uma peca. Serve para uma das regras

        public Coordenada Coordenada { get; private set; }

        //INFO: Podiamos ter criado uma classe ocupado queteria com o atributo peca, no entanto a classe peca necessita ser derivada da classe posição para assim herdar o atributo coordenada (Que vai ser necessario na utilização da lista de peças que o jogador tem)


    }
}
