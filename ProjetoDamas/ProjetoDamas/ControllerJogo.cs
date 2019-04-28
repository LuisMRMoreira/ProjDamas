using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDamas
{
    public class ControllerJogo
    {

        public ControllerJogo()
        {
            Program.V_JogadoresNoServidor.PedidoAlterarOponenteOnline += V_JogadoresNoServidor_PedidoAlterarOponenteOnline;

        }

        private void V_JogadoresNoServidor_PedidoAlterarOponenteOnline(string nickname, string servidorIP)
        {
            Program.M_Jogo.MostarDadosConectividade(nickname, servidorIP);


        }
    }
}
