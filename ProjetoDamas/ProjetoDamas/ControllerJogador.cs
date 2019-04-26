using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDamas
{
    public class ControllerJogador
    {
        public ControllerJogador()
        {
            Program.V_Register.PedidoCriarJogador += V_Register_PedidoCriarJogador;
        }

        private void V_Register_PedidoCriarJogador(string nome, string pass, string confirmPass, string nick, string email, string pais, string imageLocation)
        {
            Program.M_Jogador.RegistarJogador(nome, pass, confirmPass, nick, email, pais, imageLocation);
        }
    }
}
