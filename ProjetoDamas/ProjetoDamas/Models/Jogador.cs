using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDamas
{
    public class Jogador : User
    {//Classe representativa de cada jogador que intervem no jogo

        public event MetodosSemParametros ErroPassDiferente;
        public event MetodosSemParametros ContaCriada;

        private int id;
        private bool corPecas; //0-> branca ou 1 -> preta. Informa qual das peças é que o jogador está a controlar
        private List<Peca> pecasEmJogo;
        private bool prioridade; //informa se o jogador continua com prioridade para jogar após uma jogada
        private int numDamas;//Numero de damas em jogo
        private int numPecas;//Numero de pecas simples em jogo
        private int numeroPecasEmJogo;
        private int numeroDePecasComidas = 0;//começa a zero

        

        //public void RegistarJogador(string nome, string pass, string confirmPass, string nick, string email, string pais, string imagem, string dataDeNascimento)
        //{
        //    //Criar Jogador
        //    //Inserir na base de dados


        //    //Verificar se as passwords são iguais
        //    if (pass != confirmPass)
        //    {
        //        if (ErroPassDiferente != null)
        //        {
        //            ErroPassDiferente();
        //        }
        //    }
        //    else
        //    {
        //        if (ContaCriada != null)
        //        {
        //            ContaCriada();
        //        }
        //        //Program.V_Register.Hide();
        //        //Program.V_Login.Show();
        //    }

        //    //eviar evento a imformar que já foi inserido
        //}


    }
}
