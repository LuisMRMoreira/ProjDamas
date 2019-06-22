using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace ProjetoDamas
{
    public class ControllerJogo
    {

        public ControllerJogo()
        {
            Program.V_Tabuleiro.PedidoJogadaPessoa += V_Tabuleiro_PedidoJogadaPessoa;
            Program.V_Tabuleiro.PedidoMostarPossiveisJogadas += V_Tabuleiro_PedidoMostarPossiveisJogadas;
            Program.V_JogadorOponente.PedidoComecarJogo += V_JogadorOponente_PedidoComecarJogo;
            Program.V_ModoJogo.PedidoComecarJogoRobot += V_JogadorOponente_PedidoComecarJogo;
            Program.V_Result.PedidoRecomecarJogo += V_JogadorOponente_PedidoComecarJogo;
        }


        private void V_JogadorOponente_PedidoComecarJogo(User u1, Jogador j)
        {            
            Program.M_Jogo.ComecarJogo(u1,j);
        }

        private void V_Tabuleiro_PedidoMostarPossiveisJogadas(Coordenada c)
        {
            Program.M_Jogo.PossiveisJogadas(c);
        }

        private void V_Tabuleiro_PedidoJogadaPessoa(Coordenada c1, Coordenada c2)
        {
            Program.M_Jogo.JogadaPessoa(c1,c2);
        }
    }
}
