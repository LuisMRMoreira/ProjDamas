using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDamas
{
    public class ModelUser
    {
        public event MetodosComDoisUsers RespostaUsers;
        public event MetodosComUmUser RespostaLogin;
        public event MetodosComDoisJogadresEUmInteiro RespostaFimDeJogo;
        public List<User> Users { get; private set; } //O User na primeira posição está logado de inicio e o que está na segunda posição está logado só para jogar

        public ModelUser()
        {
            Users = new List<User>();
        }


        public void AdicionarUser(User u) // Adiciona um user à lista de users. Quando o user faz logout, a lista fica vazia. Quando depois de um jogo, o jogadorDois decide se quer voltar a jogar ou sair, se decidir sair remove-mos o segundo jogador da lista, senão continuamos com a lista como está
        {
            Users.Add(u);
            if (Users.Count == 2)
            {
                if (RespostaUsers != null)
                    RespostaUsers(Users[0], Users[1]);
            }
            else
                if (RespostaLogin != null)
                RespostaLogin(Users[0]);
        }


        public void FimDoJogo(Jogador j1, Jogador j2, int i)
        {
            if (i == 0)
            {
                if (!(j2 is Robot))
                {
                    Users[0].Vitorias++;
                    Users[1].Derrotas++;
                }
                else
                {
                    Users[0].Vitorias++;
                }
            }
            else if (i == 1)
            {
                if (!(j2 is Robot))
                {
                    Users[1].Vitorias++;
                    Users[0].Derrotas++;
                }
                else
                {
                    Users[0].Derrotas++;
                }
            }
            else
            {
                if (!(j2 is Robot))
                {
                    Users[1].Empates++;
                    Users[0].Empates++;
                }
                else
                {
                    Users[0].Empates++;
                }
            }

            if (RespostaFimDeJogo != null)
            {
                RespostaFimDeJogo(j1, j2, i);
            }



        }


        public void VoltarMenu()
        {
            if (Users.Count == 2)
            {
                Users.RemoveAt(1);
            }
        }



    }
}
