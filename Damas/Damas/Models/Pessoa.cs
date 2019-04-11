using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damas
{
    public class Pessoa : Jogador
    {//A classe Pessoa é derivada de jogar e serve como distinção entre robot, uma vez que caso não seja robot, necessita de introduzir toda esta informação
        private string username;
        private string nomeAbreviado;
        private string password;
        private string email;
        private string fotografia; //diretoria da foto
        private string país;
    }
}
