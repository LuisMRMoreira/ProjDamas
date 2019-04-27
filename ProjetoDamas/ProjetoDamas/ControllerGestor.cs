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
            Program.V_Login.PedidoAlterarLableVmenu += V_Login_PedidoAlterarLableVmenu;
            Program.V_Menu.PedidoLogin += V_Menu_PedidoLogin;
            Program.V_Profile.PedidoTerminarSessao += V_Profile_PedidoTerminarSessao;
            Program.V_Settings.PedidoGuardarDados += V_Settings_PedidoGuardarDados;

        }


        private void V_Settings_PedidoGuardarDados(int volume, string tamanho)
        {
            Program.M_Gestor.GuardarDados(volume, tamanho);
        }

        private void V_Profile_PedidoTerminarSessao()
        {
            Program.M_Gestor.AlterarLogin();
        }

        private void V_Menu_PedidoLogin()
        {
            Program.M_Gestor.AbrePerfilOuLogin();
        }

        private void V_Login_PedidoAlterarLableVmenu()
        {
            Program.M_Gestor.AlterarLogin();
        }
    }
}
