using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

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
        public static ViewModoJogo V_ModoJogo { get; private set; }
        public static ViewJogo V_JogoMultiplayerLocal { get; private set; }
        public static ViewJogoOnline V_JogoMultiplayerOnline { get; private set; }
        public static ViewJogoRobot V_JogoRobot { get; private set; }
        public static ViewStatistics V_GameStatistics { get; private set; }

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
            V_ModoJogo = new ViewModoJogo();
            V_JogoMultiplayerLocal = new ViewJogo();
            V_JogoMultiplayerOnline = new ViewJogoOnline();
            V_JogoRobot = new ViewJogoRobot();
            V_GameStatistics = new ViewStatistics();
            C_Gestor = new ControllerGestor();
            C_Jogador = new ControllerJogador();
            
            

            Application.Run(V_Menu);
        }
    }
}
