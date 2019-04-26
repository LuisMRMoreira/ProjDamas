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

        }




        private void V_Menu_PedidoLogin()
        {
            Program.M_Gestor.AbrePerfilOuLogin();
        }

        private void V_Login_PedidoAlterarLableVmenu()
        {
            Program.M_Gestor.AlterarVMenuEAbir();
        }
    }
}
