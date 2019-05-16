using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDamas
{
    public class ControllerGestor
    {

        public ControllerGestor()
        {
            Program.V_Profile.PedidoTerminarSessao += V_Profile_PedidoTerminarSessao;
            Program.V_Settings.PedidoGuardarDados += V_Settings_PedidoGuardarDados;

            Program.V_Login.PedidoLoginJogador += V_Login_PedidoLoginJogador;

        }

        private void V_Login_PedidoLoginJogador(string username, string password)
        {
            Program.M_Gestor.VerificarLogin(username, password);
        }
                     
        private void V_Settings_PedidoGuardarDados(int volume, string tamanho)
        {
            Program.M_Gestor.GuardarDados(volume, tamanho);
        }

        private void V_Profile_PedidoTerminarSessao()
        {
            Program.M_Gestor.TermninarSessao();
        }


    }
}
