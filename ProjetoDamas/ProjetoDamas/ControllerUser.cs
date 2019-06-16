using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Usar SQL
using System.Drawing; // Usar a classe Image
//using System.IO;
//using System.Windows.Forms;

namespace ProjetoDamas
{
    public class ControllerUser
    {
        public ControllerUser()
        {
            Program.V_Login.PedidoLoginJogador += V_Login_PedidoLoginJogador;
        }

        private void V_Login_PedidoLoginJogador(string username, string password)
        {
            


        }
    }
}
