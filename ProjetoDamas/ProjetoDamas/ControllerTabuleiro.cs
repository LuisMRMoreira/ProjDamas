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
        }

        private void V_JogoMultiplayer_PedidoMostarPossiveisJogadas(int x, int y)
        {
            Program.M_Tabuleiro.PossiveisJogadas( x, y);
        }
    }
}
