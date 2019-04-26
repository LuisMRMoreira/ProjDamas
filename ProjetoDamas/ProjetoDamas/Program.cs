using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDamas
{
    static class Program
    {

        public static ViewMenu V_Menu { get; private set; }
        public static ViewLogin V_Login { get; private set; }
        public static ViewRegister V_Register { get; private set; }
        public static ViewProfileInfo V_Profile { get; private set; }
        public static ViewSettings V_Settings { get; private set; }
        public static ViewRegras V_Rules { get; private set; }

        //Model
        public static Gestor M_Gestor { get; private set; }
        public static Jogador M_Jogador { get; private set; }


        //Controller
        public static ControllerGestor C_Gestor { get; private set; }
        public static ControllerJogador C_Jogador { get; private set; }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            M_Gestor = new Gestor();
            M_Jogador = new Jogador();
            V_Menu = new ViewMenu();
            V_Login = new ViewLogin();
            V_Register = new ViewRegister();
            V_Profile = new ViewProfileInfo();
            V_Settings = new ViewSettings();
            V_Rules = new ViewRegras();
            C_Gestor = new ControllerGestor();
            C_Jogador = new ControllerJogador();

            Application.Run(V_Menu);
        }
    }
}
