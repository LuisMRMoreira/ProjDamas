using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDamas
{
    public class Tabuleiro
    {//Tabuleiro de jogo que tem toda a informação necessaria, desde coordenadas (iguais à da matriz). Posicao valida, invalida, ou com peça. Peça a que jogador pertence
        public Posicao[,] tabuleiro { get; private set; }

        public List<Coordenada> PossiveisJogadasL { get; private set; }

        public event MetodosComListaDeCoordenadas RespostaPossiveisJogadas; // Vai para a ViewJogo
        public event MetodosSemParametros RespostaTabuleiroInicializado; // Vai para a ViewJogo
        public event MetodosComDuasCoordenadasEUmTipoDePEca RespostaVerificarJogadaValida; // Vai para a ViewJogo
        public event MetodosSemParametros RespostaVerificarJogadaInvalida;
        public event MetodosComUmaPosicao RespostaComerPeca;


        public Tabuleiro()
        {
            //inicializar este tabuleiro
            //INa View jogo, ir buscar as informaçõe necessarias inicializar as posições na View, de acordo com o tabuleiro;
            tabuleiro = new Posicao[8, 8];
            PossiveisJogadasL = new List<Coordenada>();
            this.InicializarTabuleiro();

        }


        public void PossiveisJogadas(int x, int y)//coordenadas da matriz
        {
            //PossiveisJogadasL.Clear();//limpar as possiveis jogadas para uma proxima jogada
            PossiveisJogadasL.Clear();

            int incrementoX, rowDir = x, collumn = y, rowEsq = x; // Usa-se o incremeto de Y para que não se repita o codigo, assim, de acordo com o sentido de jogo (cima para baixo -> y = +1 /**/ baixo cima -> y = -1)
            int xVal,  yVal;

            if (tabuleiro[x, y] is Peca)
            {                
                if (((Peca)tabuleiro[x, y]).SentidoJogada) //Verificar o sentido de jogada da Peca True -> baixo para cima  
                    incrementoX = -1;
                else
                    incrementoX = 1;

                
                if (tabuleiro[x,y] is Simples) //Caso a posicao passada como parametro seja do tipo simples (não dama)
                {
                    //min x-1 && x+1 && y+1
                    //Como o sentido de jogada é de baixo para cima e não pode jogar para trás, logo, as posicoes possiveis já são mais limitadas
                    //Direção da jogada da peca, lado esquerdo do tabuleiro
                    if ((x + incrementoX >= 0 && x + incrementoX <= 7) && y -1 >= 0)
                    {
                        if (tabuleiro[x + incrementoX, y - 1] is Peca)//Se a posicao possivel estiver ocupada, verificamos a seguinte no mesmo sentido
                        {
                            if (((Peca)tabuleiro[x + incrementoX, y - 1]).CorPeca != ((Peca)tabuleiro[x, y]).CorPeca)// Se a posicao seguinte for ocupada por uma da mesma cor, já nao é necessario procurar a seguinte casa valida
                                if ((x + 2 * incrementoX >= 0 && x + 2 * incrementoX <= 7) && (y - 2 >= 0 && y - 2 <= 7))
                                    if (tabuleiro[x + 2 * incrementoX, y - 2] is Vazia)
                                    {
                                        PossiveisJogadasL.Add(new Coordenada(x + 2 * incrementoX, y - 2)); //Posicao Possivel                     
                                    }
                            
                        } else if (tabuleiro[x + incrementoX, y - 1] is Vazia)
                            PossiveisJogadasL.Add(new Coordenada(x + incrementoX, y - 1));//Posicao Possivel
                    }


                    //Direção da jogada da peca, lado direito do tabuleiro
                    if ((x + incrementoX >= 0 && x + incrementoX <= 7) &&  y + 1 <= 7)
                    {
                        if (tabuleiro[x + incrementoX, y + 1] is Peca)
                        {
                            if (((Peca)tabuleiro[x + incrementoX, y + 1]).CorPeca != ((Peca)tabuleiro[x, y]).CorPeca)// Se a posicao seguinte for ocupada por uma da mesma cor, já nao é necessario procurar a seguinte casa valida                            
                                if ((x + 2 * incrementoX <= 7 && x + 2 * incrementoX >= 0) && (y + 2 >= 0 && y + 2 <= 7))
                                    if (tabuleiro[x + 2 * incrementoX, y + 2] is Vazia)
                                    {
                                        PossiveisJogadasL.Add(new Coordenada(x + 2 * incrementoX, y + 2));//Posicao Possivel
                                    }
                        }
                        else if (tabuleiro[x + incrementoX, y + 1] is Vazia)
                            PossiveisJogadasL.Add(new Coordenada(x + incrementoX, y + 1));//Posicao Possivel
                    }


                    //Direção contrária á jogada da peca, lado esquerdo do tabuleiro (Só verifica se tem uma peca para comer)
                    if ((x - incrementoX >= 0 && x - incrementoX <= 7) && (y - 1 >= 0 && y - 1 <= 7))
                    {
                        if (tabuleiro[x - incrementoX, y - 1] is Peca)
                        {
                            if (((Peca)tabuleiro[x - incrementoX, y - 1]).CorPeca != ((Peca)tabuleiro[x, y]).CorPeca)// Se a posicao seguinte for ocupada por uma da mesma cor, já nao é necessario procurar a seguinte casa valida                            
                                if ((x - 2 * incrementoX <= 7 && x - 2 * incrementoX >= 0) && (y - 2 >= 0 && y - 2 <= 7))
                                    if (tabuleiro[x - 2 * incrementoX, y - 2] is Vazia)
                                    {
                                        PossiveisJogadasL.Add(new Coordenada(x - 2 * incrementoX, y - 2));//Posicao Possivel
                                    }
                        }
                    }

                    //Direção contrária á jogada da peca, lado direito do tabuleiro (Só verifica se tem uma peca para comer)
                    if ((x - incrementoX >= 0 && x - incrementoX <= 7) && (y + 1 >= 0 && y + 1 <= 7))
                    {
                        if (tabuleiro[x - incrementoX, y + 1] is Peca)
                        {
                            if (((Peca)tabuleiro[x - incrementoX, y + 1]).CorPeca != ((Peca)tabuleiro[x, y]).CorPeca)// Se a posicao seguinte for ocupada por uma da mesma cor, já nao é necessario procurar a seguinte casa valida                            
                                if ((x - 2 * incrementoX <= 7 && x - 2 * incrementoX >= 0) && (y + 2 >= 0 && y + 2 <= 7))
                                    if (tabuleiro[x - 2 * incrementoX, y + 2] is Vazia)
                                    {
                                        PossiveisJogadasL.Add(new Coordenada(x - 2 * incrementoX, y + 2));//Posicao Possivel
                                    }
                        }
                    }


                    // verificar o (x-1 e y-1), o (x+1 e y+1), o (x+1 e y-1), o (x-1, y+1)
                    // Para cada uma delas, caso esteja ocupado, tem que se verificar a posicao seguinte ((x-2 e y-2), (x+2 e y+2), (x+2 e y-2), o (x-2, y+2))
                }
                else if (tabuleiro[x, y] is Dama) //Verificar se funcona bem para o caso das Damas ?????????????????!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                {
                    ////collumn são as linhas e as row são as colunas que antam em cada iteração para os lados
                    //linhaDir += incrementoX;
                    //LinhaEsq -= incrementoX; // Caso o sentido de jogada seja de cima para baixo, o incrementoX é positivo, caso contrario, é negativo
                    //colunaDir += 1; // anda uma unidade para trás no x
                    //colunaEsq -= 1; // anda uma unidade para a frente no x
                    int count = 0;

                    //diagonal canto superior esquerdo
                    xVal = x - 1;
                    yVal = y - 1;

                    while (xVal >= 0 && yVal >=0)
                    {

                        if (tabuleiro[xVal, yVal] is Peca)
                        {
                            if (count != 0)
                            {
                                //Se o count for diferente de 0, significa que já encontrou uma peça na ultima posição verificada e por isso não vai verificar mais porque uma dama não consegue passar por cima de 2 pecas
                                break;
                            }else if (((Peca)tabuleiro[x, y]).CorPeca == ((Peca)tabuleiro[xVal, yVal]).CorPeca)
                            {
                                //Se na diagonal encontrar uma peça da mesma côr que da peça que se quer mover, acaba-se a procura
                                break;
                            }
                            else
                            {
                                //Dama come peca
                                count++;
                            } //Caso contrário, não adiciona, mas continua a contar. Se na posição seguinte estiver outra peça, para de verificar 
                        }
                        else
                        {
                            PossiveisJogadasL.Add(new Coordenada(xVal, yVal));
                        }
                            


                        xVal -= 1;
                        yVal -= 1;
                    }


                    //diagonal canto superior direito;
                    xVal = x - 1;
                    yVal = y + 1;
                    count = 0;

                    while (xVal >= 0 && yVal <= 7)
                    {
                        if (tabuleiro[xVal, yVal] is Peca)
                        {
                            if (count != 0)
                            {
                                //Se o count for diferente de 0, significa que já encontrou uma peça na ultima posição verificada e por isso não vai verificar mais porque uma dama não consegue passar por cima de 2 pecas
                                break;
                            }
                            else if (((Peca)tabuleiro[x, y]).CorPeca == ((Peca)tabuleiro[xVal, yVal]).CorPeca)
                            {
                                //Se na diagonal encontrar uma peça da mesma côr que da peça que se quer mover, acaba-se a procura
                                break;
                            }
                            else
                            {
                                //Dama come peca
                                count++;
                            } //Caso contrário, não adiciona, mas continua a contar. Se na posição seguinte estiver outra peça, para de verificar 
                        }
                        else
                        {
                            PossiveisJogadasL.Add(new Coordenada(xVal, yVal));
                        }


                        xVal -= 1;
                        yVal += 1;
                    }



                    //diagonal canto inferior esquerdo
                    xVal = x + 1;
                    yVal = y - 1;
                    count = 0;

                    while (xVal <= 7 && yVal >= 0)
                    {

                        if (tabuleiro[xVal, yVal] is Peca)
                        {
                            if (count != 0)
                            {
                                //Se o count for diferente de 0, significa que já encontrou uma peça na ultima posição verificada e por isso não vai verificar mais porque uma dama não consegue passar por cima de 2 pecas
                                break;
                            }
                            else if (((Peca)tabuleiro[x, y]).CorPeca == ((Peca)tabuleiro[xVal, yVal]).CorPeca)
                            {
                                //Se na diagonal encontrar uma peça da mesma côr que da peça que se quer mover, acaba-se a procura
                                break;
                            }
                            else
                            {
                                //Dama come peca
                                count++;
                            } //Caso contrário, não adiciona, mas continua a contar. Se na posição seguinte estiver outra peça, para de verificar 

                        }
                        else
                        {
                            PossiveisJogadasL.Add(new Coordenada(xVal, yVal));
                        }

                        xVal += 1;
                        yVal -= 1;
                    }


                    //diagonal canto inferior direito
                    xVal = x + 1;
                    yVal = y + 1;
                    count = 0;

                    while (xVal <= 7 && yVal <= 7)
                    {
                        if (tabuleiro[xVal, yVal] is Peca)
                        {
                            if (count != 0)
                            {
                                //Se o count for diferente de 0, significa que já encontrou uma peça na ultima posição verificada e por isso não vai verificar mais porque uma dama não consegue passar por cima de 2 pecas
                                break;
                            }
                            else if (((Peca)tabuleiro[x, y]).CorPeca == ((Peca)tabuleiro[xVal, yVal]).CorPeca)
                            {
                                //Se na diagonal encontrar uma peça da mesma côr que da peça que se quer mover, acaba-se a procura
                                break;
                            }
                            else
                            {
                                //Dama come peca
                                count++;
                            } //Caso contrário, não adiciona, mas continua a contar. Se na posição seguinte estiver outra peça, para de verificar 
                        }
                        else
                        {
                            PossiveisJogadasL.Add(new Coordenada(xVal, yVal));
                        }

                        xVal += 1;
                        yVal += 1;
                    }

                }

            }

            if (RespostaPossiveisJogadas != null)
            {
                RespostaPossiveisJogadas(PossiveisJogadasL);
            }
        }


        public void VerificarJogada(Coordenada origem, Coordenada destino)
        {
            //Quando o destino for válido e tiver no fundo contrário, traca-se para dama

            int contador = 0;

            foreach (Coordenada coor in PossiveisJogadasL)
            {
                if (coor.x == destino.x && coor.y == destino.y)
                {
                                                                                                                                                                                                                  
                    if (VerificaPassagemParaDama(origem, destino))//Se der para trocar para dama, troca
                    {
                        //verifica se passa para dama     >
                        //fazer alterações na matriz tabuleiro >
                        //enviar um novo tabulerio para alterar de simples para Dama >
                    }
                    else//senão, só troca entre as simples
                    {
                        Posicao pos = tabuleiro[origem.x, origem.y];
                        tabuleiro[origem.x, origem.y] = tabuleiro[destino.x, destino.y];
                        tabuleiro[destino.x, destino.y] = pos;
                    }

                    if (ComerPeca(origem, destino) == true)//envia evento
                    {
                        //Se a jogada for valida de acordo com os parâmetros anteriores, apaga todas as Pecas entre a coordenada de origem e destino
                    }

                    if (RespostaVerificarJogadaValida != null)
                    {
                        RespostaVerificarJogadaValida(origem, destino, (Peca)tabuleiro[destino.x,destino.y]);

                        break;

                    }





                }
                else
                {
                    contador++;
                }
            }

            if (contador == PossiveisJogadasL.Count)
            {
                if (RespostaVerificarJogadaInvalida != null)
                {
                    RespostaVerificarJogadaInvalida();
                    
                }
            }

        }

        public bool VerificaPassagemParaDama(Coordenada origem, Coordenada destino)
        {
            //verifica se dá para trocar para dama e se der troca
            if (!((Peca)tabuleiro[origem.x, origem.y]).SentidoJogada) //== false => vai a descer (cima para baixo no tabuleiro (aumenta o x))
            { 
                if (destino.x == 7)
                {
                    tabuleiro[destino.x, destino.y] = new Dama(((Peca)tabuleiro[origem.x, origem.y]).CorPeca, ((Peca)tabuleiro[origem.x, origem.y]).SentidoJogada);
                    tabuleiro[origem.x, origem.y] = new Vazia();
                    return true;

                }
            }
            else
            {
                if (destino.x == 0)
                {
                    tabuleiro[destino.x, destino.y] = new Dama(((Peca)tabuleiro[origem.x, origem.y]).CorPeca, ((Peca)tabuleiro[origem.x, origem.y]).SentidoJogada);
                    tabuleiro[origem.x, origem.y] = new Vazia();
                    return true;
                }
            }

            return false;
        }


        //Caso a peca destino esteja na lista "PosicoesComerL", remove-se da matriz a peca "PosicaoPecaComida". Depois no método onde esta é chama, enviamos dois eventos, um para trocar a peca destino pela origem e a outro evento para removar a peca comida da pictureBox
        public bool ComerPeca(Coordenada origem, Coordenada destino)
        {
            //calcular a diagonal entre o ponto de onrigem e destino
            List<Coordenada> CoordDiagonais = null;
            CoordDiagonais = CalculaDiagonal(origem, destino);

            foreach (Coordenada coord in CoordDiagonais)
            {
                if (tabuleiro[coord.x, coord.y] is Peca)
                {
                    tabuleiro[coord.x, coord.y] = new Vazia();

                    if (RespostaComerPeca != null)
                    {
                        RespostaComerPeca(coord.x, coord.y);
                    }

                    return true;
                }
            }

            return false;



        }


        //Calcula as peças que estão numa diagonal entre dois pontos
        public List<Coordenada> CalculaDiagonal(Coordenada origem, Coordenada destino)
        {            
            int xIncremento, yIncremento, x = origem.x, y = origem.y;
            List<Coordenada> CoordDiagonais = new List<Coordenada>();
            if (destino.y - origem.y > 0)
                yIncremento = 1;
            else
                yIncremento = -1;

            if (destino.x - origem.x > 0)
                xIncremento = 1;
            else
                xIncremento = -1;

            x += xIncremento;
            y += yIncremento;

            while (x != destino.x && y != destino.y)
            {
                CoordDiagonais.Add(new Coordenada(x, y));
                x += xIncremento;
                y += yIncremento;                
            }

            return CoordDiagonais;
        }


        public void InicializarTabuleiro() 
        {   
            //Esta função é usada quando a visibilidade da ViewJogo muda
            // 0 -> Branco em cima, 1 -> preto em baixo

            Random randNum = new Random();            
            bool valor = Convert.ToBoolean(randNum.Next(2));
            //bool sentidoJogada = Convert.ToBoolean(randNum.Next(2));

            //false  = 0 -> Branco  ; true  = 1 -> Preto;
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    if (x < 3 && (x + y) % 2 == 0)
                        tabuleiro[x, y] = new Simples(valor, false);
                    else if (x >= 5 && (x + y) % 2 == 0)
                        tabuleiro[x, y] = new Simples(!valor, true);
                    else if ((x + y) % 2 == 0)
                        tabuleiro[x, y] = new Vazia();
                    else
                        tabuleiro[x, y] = new Invalida();
                }
            }

            if (RespostaTabuleiroInicializado != null)
            {
                RespostaTabuleiroInicializado();
            }

        }

    }
}
