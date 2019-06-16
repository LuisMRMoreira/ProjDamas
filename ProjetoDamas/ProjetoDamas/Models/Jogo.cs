using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDamas
{
    public class Jogo
    {//Classe que representa um jogo. Dois jogadores e um tabuleiro

        public event MetodosComDuasStrings RespostaAlterarOponenteOnline;

        public int id; //Para quando quiseremos voltar a um jogo seja mais facil procurar através do id
        public Jogador jogadorUm { get; private set; }
        public Jogador jogadorDois { get; private set; }
        public Tabuleiro tabuleiro { get; private set; }
        public int contadorJogadas { get; private set; } //serve para os casos de empate ou para as regras
        public DateTime tempo { get; private set; }//tempo de jogo. Apenas para informação


        public Jogo()
        {
            //id =
            //jogadorUm

        }


        public void MostarDadosConectividade(string nickname, string servidorIP)
        {


            if (RespostaAlterarOponenteOnline != null)
            {
                RespostaAlterarOponenteOnline(nickname, servidorIP);
            }

        }

        public void ComecarJogo()
        {
            
        }





    }
}
