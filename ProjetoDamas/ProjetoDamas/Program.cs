using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ProjetoDamas
{
    static class Program
    {

        public static ViewMenu V_Menu { get; private set; }
        public static ViewLogin V_Login { get; private set; }
        public static ViewRegister V_Register { get; private set; }
        public static ViewProfileInfo V_Profile { get; private set; }
        public static ViewRegras V_Rules { get; private set; }
        public static ViewModoJogo V_ModoJogo { get; private set; }
        public static ViewTabuleiro V_Tabuleiro { get; private set; }
        public static ViewEnd V_Result { get; private set; }
        public static ViewJogosInacabados V_JogosInacabados { get; private set; }
        public static ViewOponenteServidor V_OponenteServidor { get; private set; }
        public static ViewJogadoresNoServidor V_JogadoresNoServidor { get; private set; }
        public static ViewJogadorOponente V_JogadorOponente { get; private set; }

        //Model
        public static ModelJogo M_Jogo { get; private set; }
        public static ModelUser M_User { get; private set; }


        //Controller
        public static ControllerJogo C_Jogo { get; private set; }
        public static ControllerUser C_User { get; private set; }



        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            M_Jogo = new ModelJogo();
            M_User = new ModelUser();
            V_Menu = new ViewMenu();
            V_Login = new ViewLogin();
            V_Register = new ViewRegister();
            V_Profile = new ViewProfileInfo();
            //V_Settings = new ViewSettings();
            V_Rules = new ViewRegras();
            V_ModoJogo = new ViewModoJogo();
            V_Tabuleiro = new ViewTabuleiro();
            //V_GameStatistics = new ViewStatistics();
            V_Result = new ViewEnd();
            V_JogosInacabados = new ViewJogosInacabados();
            V_OponenteServidor = new ViewOponenteServidor();
            V_JogadoresNoServidor = new ViewJogadoresNoServidor();
            //V_Torneio = new ViewTorneio();
            //V_JogosTorneio = new ViewTorneioJogos();
            //V_TorneiosInacabados = new ViewTorneiosInacabados();
            V_JogadorOponente = new ViewJogadorOponente();
            C_Jogo = new ControllerJogo();
            C_User = new ControllerUser();
            Application.Run(V_Login);
        }
    }
}
