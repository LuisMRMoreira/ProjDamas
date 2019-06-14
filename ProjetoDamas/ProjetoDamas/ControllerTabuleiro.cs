using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDamas
{
    public class ControllerTabuleiro
    {

        public ControllerTabuleiro()
        {
            Program.V_JogoMultiplayer.PedidoMostarPossiveisJogadas += V_JogoMultiplayer_PedidoMostarPossiveisJogadas;
            Program.V_JogoMultiplayer.PedidoInicializarTabuleiro += V_JogoMultiplayer_PedidoInicializarTabuleiro;
            Program.V_JogoMultiplayer.PedidoVerificarJogada += V_JogoMultiplayer_PedidoVerificarJogada;
        }

        private void V_JogoMultiplayer_PedidoVerificarJogada(Coordenada c1, Coordenada c2)
        {
            Program.M_Tabuleiro.VerificarJogada(c1, c2);
        }

        private void V_JogoMultiplayer_PedidoInicializarTabuleiro()
        {
            Program.M_Tabuleiro.InicializarTabuleiro();
        }

        private void V_JogoMultiplayer_PedidoMostarPossiveisJogadas(int x, int y)
        {
            Program.M_Tabuleiro.PossiveisJogadas( x, y);
        }
    }
}
