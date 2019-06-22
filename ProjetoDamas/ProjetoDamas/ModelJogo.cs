using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDamas
{
    public class ModelJogo
    {
        public event MetodosComUmaMatrizDePosicoesEJogadores RespostaComecarJogo;
        public event MetodosComUmInteiroEMatrizDePosicoes RespostaEnabledPB; // Provoca o enable das PB das peças do jogador com prioridade e o disable das contrárias 0 -> enable das peças brancas (branco -> 0) ; 1 -> enable das peças pretas (preto -> 1) ; 2 -> disable de tudo (robot)
        public event MetodosComDuasCoordenadasEUmaMatrizDePosicoes RespostaJogadaValida;
        public event MetodosComTresCoordenadasEUmaMatrizDePosicoes RespostaJogadaValidaEPecaComida;
        public event MetodosComListaDeCoordenadas RespostaLimparTabuleiro; // Limpa as possiveis jogaas na View
        public event MetodosComListaDeCoordenadas RespostaJogadas; // Resposta com a lista de jogadas possiveis ou obrigatorias
        public event MetodosComDoisJogadresEUmInteiro RespostaFimDoJogo;


        public Jogo Jogo { get; private set; }

        public void ComecarJogo(User u1, Jogador j2)
        {
            Jogo = new Jogo(u1, j2);
            if (RespostaComecarJogo != null)
            {
                RespostaComecarJogo(Jogo.Tabuleiro.tabuleiro, Jogo.JogadorUm, Jogo.JogadorDois);
            }
            this.Jogada();
        }


        public void Jogada()
        {
            // 0 -> Pecas Brancam ganharam, 1 -> Pecas pretas ganharm, 2 -> Empate, 3 -> Não acabou  
            int estadoJogo = Jogo.Tabuleiro.FimDoJogo();

            if (estadoJogo == 3)
            {
                if (Jogo.JogadorDois.Prioridade) //Se tiver a prioridade de jogo
                {
                    if (Jogo.JogadorDois is Robot) //Verifica-se se é Robot
                    {
                        // Enviar um evento para para fazer o disable das picturBox SEM prioridade na View (as pictureBox do panel começam todas disable (enable = false))
                        if (RespostaEnabledPB != null)
                        {
                            RespostaEnabledPB(2, Jogo.Tabuleiro.tabuleiro); 
                        }                        
                        this.JogadaRobot();
                    }
                    else
                    {
                        // Enviar um evento para para fazer o enable das picturBox com prioridade na View (as pictureBox do panel começam todas disable (enable = false))
                        if (RespostaEnabledPB != null)
                        {
                            RespostaEnabledPB(Convert.ToInt16(Jogo.JogadorDois.CorPecas), Jogo.Tabuleiro.tabuleiro);
                        }
                    }
                }
                else //É o jogadorUm que tem a prioridade
                {
                    // Enviar um evento para para fazer o enable das picturBox com prioridade na View (as pictureBox do panel começam todas disable (enable = false))
                    if (RespostaEnabledPB != null)
                    {
                        RespostaEnabledPB(Convert.ToInt16(Jogo.JogadorUm.CorPecas), Jogo.Tabuleiro.tabuleiro);
                    }
                }
            }
            else
            {                
                //FAZER ::::::::Acabou. verificar os varios outputs do método Jogo.Tabuleiro.FimDoJogo() e enviar eventos de acordo com cada um deles
                int i = -1;
                if (estadoJogo == 0)//Jogador que controla as peças brancas ganhou
                    if (!Jogo.JogadorUm.CorPecas)//Branco
                        i = 0;
                    else
                        i = 1;
                else if (estadoJogo == 1)//Jogador que controla as peças pretas ganhou
                    if (Jogo.JogadorUm.CorPecas)//Pretas
                        i = 0;
                    else
                        i = 1;
                else if (estadoJogo == 2)
                    i = 2;

                if (RespostaFimDoJogo != null)
                {
                    RespostaFimDoJogo(Jogo.JogadorUm, Jogo.JogadorDois, i);
                }

            }
        }


        public void JogadaRobot()
        {
            Coordenada origem = new Coordenada(), destino = new Coordenada();

            bool obrigatoria = false;
            Jogo.Tabuleiro.JogadasObrigatoriasL.Clear();

            for (int i = 0; i < Jogo.Tabuleiro.tabuleiro.GetLength(0); i++)
                for (int j = 0; j < Jogo.Tabuleiro.tabuleiro.GetLength(1); j++)
                {
                    if (Jogo.Tabuleiro.tabuleiro[i,j] is Peca)
                        if (((Peca)Jogo.Tabuleiro.tabuleiro[i, j]).CorPeca == Jogo.JogadorDois.CorPecas)//O jogadorDois é que varia. O jogadorUm é o user logado
                        {
                            Jogo.Tabuleiro.PossiveisJogadas(i, j);
                            if (Jogo.Tabuleiro.JogadasObrigatoriasL.Count != 0) //Se tiver Jogadas Obrigatorias
                            {
                                origem = new Coordenada(i, j);
                                destino = Jogo.Tabuleiro.JogadasObrigatoriasL.Last();//TESTE::::::: Ver se o last funciona
                                obrigatoria = true;
                                goto Sai;
                            }
                            else if (Jogo.Tabuleiro.PossiveisJogadasL.Count != 0) //Se não tiver Jogadas Obrigatorias e tiver jogadas Possiveis
                            {
                                
                                Random randNum = new Random();
                                int possivelIndex = randNum.Next(Jogo.Tabuleiro.JogadasObrigatoriasL.Count);

                                origem = new Coordenada(i, j);
                                destino = Jogo.Tabuleiro.PossiveisJogadasL[possivelIndex];
                                obrigatoria = false;
                            }
                        }
                }

            Jogo.Tabuleiro.PossiveisJogadas(origem.x, origem.y);//Volta a calcular as listadas de jogadas possiveis ou obrigatorias para que assim não se percam (Se esta função não existisse, embora antem fosse encontrada deslocaçºao váliada, não seria validada pelos metodos uma vez que as listas no fim de todas as iterações estava vazia (A ultima pB não tem nem jogadas possiveis nem obrigatorias))

            Sai:

            this.ValidarJogada(origem, destino);

            if (obrigatoria) // Caso a ultima jogada tenha sido obrigatoria
            {
                origem = destino;
                Jogo.Tabuleiro.PossiveisJogadas(destino.x, destino.y);//Possiveis jogadas a partir do destino
                while (Jogo.Tabuleiro.JogadasObrigatoriasL.Count != 0)
                {
                    destino = Jogo.Tabuleiro.JogadasObrigatoriasL.Last();//TESTE::::::: Ver se o last funciona
                    this.ValidarJogada(origem, destino);
                    Jogo.Tabuleiro.PossiveisJogadas(destino.x, destino.y);
                    origem = destino;
                }
            }

            Jogo.JogadorUm.Prioridade = !Jogo.JogadorUm.Prioridade;
            Jogo.JogadorDois.Prioridade = !Jogo.JogadorDois.Prioridade;

            this.Jogada();
        }



        public bool ValidarJogada(Coordenada origem, Coordenada destino)
        {
            var todasPosicoes = new List<Coordenada>(Jogo.Tabuleiro.PossiveisJogadasL.Count + Jogo.Tabuleiro.JogadasObrigatoriasL.Count);
            todasPosicoes.AddRange(Jogo.Tabuleiro.PossiveisJogadasL);
            todasPosicoes.AddRange(Jogo.Tabuleiro.JogadasObrigatoriasL);

            if (Jogo.Tabuleiro.VerificarJogada(origem, destino)) //Se a jogada for válida,  
            {            
                if (Jogo.Tabuleiro.Comida) //Se a jogada comer uma peca
                {
                    // Enviar evento com 3 coordenadas. A de origem, destino e a comida
                    if (RespostaJogadaValidaEPecaComida != null)
                    {
                        RespostaJogadaValidaEPecaComida(origem, destino, Jogo.Tabuleiro.PecaComida, Jogo.Tabuleiro.tabuleiro);
                    }
                    //Enviar evento para limpar as possiveis jogadas
                    if (RespostaLimparTabuleiro != null)
                    {
                        RespostaLimparTabuleiro(todasPosicoes);
                    }
                    return true;
                }
                else
                {
                    // Enviar evento com 2 coordenadas. A de origem e destino
                    if (RespostaJogadaValida != null)
                    {
                        RespostaJogadaValida(origem, destino, Jogo.Tabuleiro.tabuleiro);
                    }
                    //Enviar evento para limpar as possiveis jogadas
                    if (RespostaLimparTabuleiro != null)
                    {
                        RespostaLimparTabuleiro(todasPosicoes);
                    }
                    return true;
                }
            }

            //Enviar evento para limpar as possiveis jogadas
            if (RespostaLimparTabuleiro != null)
            {
                RespostaLimparTabuleiro(todasPosicoes);
            }
            return false;

        }



        public void PossiveisJogadas(Coordenada origem)
        {
            List<Coordenada> jogadas = new List<Coordenada>();

            Jogo.Tabuleiro.PossiveisJogadas(origem.x, origem.y);

            if (Jogo.Tabuleiro.JogadasObrigatoriasL.Count != 0)
                jogadas = Jogo.Tabuleiro.JogadasObrigatoriasL;
            else
                jogadas = Jogo.Tabuleiro.PossiveisJogadasL;


            //Enviar evento com as jogagas (tanto podem ser as possiveis como as obrigatorias)
            if (RespostaJogadas != null)
            {
                RespostaJogadas(jogadas);
            }

        }


        
        public void JogadaPessoa(Coordenada origem, Coordenada destino)
        {
            var todasPosicoes = new List<Coordenada>(Jogo.Tabuleiro.PossiveisJogadasL.Count + Jogo.Tabuleiro.JogadasObrigatoriasL.Count);
            todasPosicoes.AddRange(Jogo.Tabuleiro.PossiveisJogadasL);
            todasPosicoes.AddRange(Jogo.Tabuleiro.JogadasObrigatoriasL);

            if (this.ValidarJogada(origem, destino))
            { //Se a jogada for válida, 
                if (Jogo.Tabuleiro.Comida)
                {//Se a jogada for válida e tiver comido uma peça               
                    Jogo.Tabuleiro.PossiveisJogadas(destino.x, destino.y);//Calcula-se
                    if (Jogo.Tabuleiro.JogadasObrigatoriasL.Count != 0)
                    {//Se a jogada for válida, na ultima jogada comeu uma peça e ainda tem jogadas obrigatorias
                        //A prioridade mantem-se deste jogador
                        this.Jogada();
                    }
                    else
                    {//Se a jogada for válida, na ultima jogada comeu uma peça mas já não tem jogadas obrigatorias
                        Jogo.JogadorDois.Prioridade = !Jogo.JogadorDois.Prioridade;
                        Jogo.JogadorUm.Prioridade = !Jogo.JogadorUm.Prioridade;
                        this.Jogada();
                    }
                }
                else
                {//Se a jogada for válida mas não comeu nenhuma peça perde a vez
                    Jogo.JogadorDois.Prioridade = !Jogo.JogadorDois.Prioridade;
                    Jogo.JogadorUm.Prioridade = !Jogo.JogadorUm.Prioridade;
                    this.Jogada();
                }
            }
            else //Se a jogada não for válida, limpa as posiveis jogadas
                if (RespostaLimparTabuleiro != null)
                    RespostaLimparTabuleiro(todasPosicoes);
          

        }


    }
}
