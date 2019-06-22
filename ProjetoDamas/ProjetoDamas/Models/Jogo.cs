using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDamas
{
    public class Jogo
    {//Classe que representa um jogo. Dois jogadores e um tabuleiro
        
        //public int id; //Para quando quiseremos voltar a um jogo seja mais facil procurar através do id
        public Jogador JogadorUm { get; private set; }
        public Jogador JogadorDois { get; private set; }
        public Tabuleiro Tabuleiro { get; private set; }


        public Jogo(User u1, Jogador j2)
        {
            Random randNum = new Random();
            bool corDaPeca = Convert.ToBoolean(randNum.Next(2));

            if (j2 is Robot)
            {
                //Se a cor da peca é 0, começa a jogar porque é branco, logo a prioridade é true para esse jogador
                JogadorUm = new Pessoa(u1, corDaPeca, !corDaPeca);
                JogadorDois = new Robot(!corDaPeca, corDaPeca); 
            }
            else //Se não for Robot, é pessoa
            {
                JogadorUm = new Pessoa(u1, corDaPeca, !corDaPeca);
                JogadorDois = new Pessoa((Pessoa)j2, !corDaPeca, corDaPeca);
            }

            Tabuleiro = new Tabuleiro();
            
        }

        public Jogo()
        {
        }






    }
}
