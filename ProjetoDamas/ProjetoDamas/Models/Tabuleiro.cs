using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDamas
{
    public class Tabuleiro
    {//Tabuleiro de jogo que tem toda a informação necessaria, desde coordenadas (iguais à da matriz). Posicao valida, invalida, ou com peça. Peça a que jogador pertence
        private Posicao[,] tabuleiro = new Posicao[8,8];

        public List<Coordenada> possiveisJogadas { get; private set; }

        public event MetodosComListaDeCoordenadas RespostaPossiveisJogadas; //ViewJogo


        public Tabuleiro()
        {
            //inicializar este tabuleiro
            //INa View jogo, ir buscar as informaçõe necessarias inicializar as posições na View, de acordo com o tabuleiro;



        }

        public void PossiveisJogadas(int x, int y)
        {
            possiveisJogadas.Clear();//limpar as possiveis jogadas para uma proxima jogada

            int incrementoY, rowDir = x, collumn = y, rowEsq = x; // Usa-se o incremeto de Y para que não se repita o codigo, assim, de acordo com o sentido de jogo (cima para baixo -> y = +1 /**/ baixo cima -> y = -1)

            if (((Peca)tabuleiro[x, y]).sentidoJogada) //Verificar o sentido de jogada da Peca True -> baixo para cima  
                incrementoY = -1;
            else
                incrementoY = 1;

            if (tabuleiro[x,y] is Simples) //Caso a posicao passada como parametro seja do tipo simples (não dama)
            {
                //min x-1 && x+1 && y+1
                //Como o sentido de jogada é de baixo para cima e não pode jogar para trás, logo, as posicoes possiveis já são mais limitadas
                if (x - 1 >= 0 && y + incrementoY >= 0)
                {
                    if (tabuleiro[x - 1, y +incrementoY] is Peca)//Se a posicao possivel estiver ocupada, verificamos a seguinte no mesmo sentido
                    {
                        if (((Peca)tabuleiro[x - 1, y + incrementoY]).corPeca != ((Peca)tabuleiro[x, y]).corPeca)// Se a posicao seguinte for ocupada por uma da mesma cor, já nao é necessario procurar a seguinte casa valida
                            if (x - 2 >= 0 && y + 2 * incrementoY >= 0)
                                if (tabuleiro[x - 2, y + 2 * incrementoY] is Vazia)
                                    possiveisJogadas.Add(new Coordenada(x - 2, y + 2 * incrementoY)); //Posicao Possivel                                
                            
                    } else if (tabuleiro[x - 1, y + incrementoY] is Vazia)
                        possiveisJogadas.Add(new Coordenada(x - 1, y + incrementoY));//Posicao Possivel
                }



                if (x + 1 <= 7 && y + incrementoY >= 0)
                {
                    if (tabuleiro[x + 1, y + incrementoY] is Peca)
                    {
                        if (((Peca)tabuleiro[x + 1, y + incrementoY]).corPeca != ((Peca)tabuleiro[x, y]).corPeca)// Se a posicao seguinte for ocupada por uma da mesma cor, já nao é necessario procurar a seguinte casa valida                            
                            if (x + 2 <= 7 && y + 2 * incrementoY >= 0)                                
                                if (tabuleiro[x + 2, y + 2 * incrementoY] is Vazia)
                                    possiveisJogadas.Add(new Coordenada(x + 2, y + 2 * incrementoY));//Posicao Possivel                           
                    }
                    else if (tabuleiro[x + 1, y + incrementoY] is Vazia)
                        possiveisJogadas.Add(new Coordenada(x + 1, y + incrementoY));//Posicao Possivel
                }                       
                    
                // verificar o (x-1 e y-1), o (x+1 e y+1), o (x+1 e y-1), o (x-1, y+1)
                // Para cada uma delas, caso esteja ocupado, tem que se verificar a posicao seguinte ((x-2 e y-2), (x+2 e y+2), (x+2 e y-2), o (x-2, y+2))
            }
            else if (tabuleiro[x, y] is Dama)
            {
                collumn += incrementoY; // Caso o sentido de jogada seja de cima para baixo, o incrementoY é positivo, caso contrario, é negativo
                rowDir -= 1; // anda uma unidade para trás no x
                rowEsq += 1; // anda uma unidade para a frente no x

                //Verificar numa diagonal para cima
                while (collumn >= 0 && collumn <=7 && rowDir >= 0 && rowDir <=7 && rowEsq >= 0 && rowEsq <= 7)
                {

                    if (tabuleiro[rowDir,collumn] is Peca) // Como encontra uma peca no caminho, tem de verificar se é sua ou de outro jogador 
                    {
                        if (((Peca)tabuleiro[x, y]).corPeca == ((Peca)tabuleiro[rowDir, collumn]).corPeca)
                            break; //Se uma das pecas que tiver no caminho for do mesmo jogador, a contagem acaba e sai-se do ciclo
                        else
                            possiveisJogadas.Add(new Coordenada(rowDir, collumn));//Posicao Possivel

                    }
                    else if(tabuleiro[rowDir, collumn] is Vazia)
                        possiveisJogadas.Add(new Coordenada(rowDir, collumn)); //Posicao Possivel


                    if (tabuleiro[rowEsq, collumn] is Peca)
                    {
                        if (((Peca)tabuleiro[x, y]).corPeca == ((Peca)tabuleiro[rowEsq, collumn]).corPeca)
                            break; //Se uma das pecas que tiver no caminho for do mesmo jogador, a contagem acaba e sai-se do ciclo
                        else
                            possiveisJogadas.Add(new Coordenada(rowEsq, collumn));//Posicao Possivel
                    }
                    else if (tabuleiro[rowEsq, collumn] is Vazia)
                        possiveisJogadas.Add(new Coordenada(rowEsq, collumn));// Posicao Possivel


                    collumn += incrementoY; 
                    rowDir -= 1;
                    rowEsq += 1; 

                }
            }

            if (RespostaPossiveisJogadas != null)
            {
                RespostaPossiveisJogadas(possiveisJogadas);
            }
        }


        //public void AbrirViewJogo(bool valor) // Caso valor = true, Inicializa-se a View Jogo com os valores iniciais, caso contrário, vai buscar-se os valores guardados anteriorente
        //{
        //    if (valor)
        //    {
        //        this.InicializarPecas();
        //    }
             
        //}



        public void InicializarPecas(bool posPecas) // 0 -> Branco em cima, 1 -> preto em baixo
        {
            //Usar quando a visibilidade da ViewJogo muda

            bool valor = posPecas;

            //false  = 0 -> Branco  ; true  = 1 -> Preto;
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 4; y++)
                {

                    if (x < 3 && (x + y) % 2 == 1)
                    {
                        tabuleiro[x, y] = new Simples(valor); 
                    }
                    else if (x >= 5 && (x + y) % 2 == 1)
                    {
                        tabuleiro[x, y] = new Simples(!valor); 
                    }
                    else if ((x + y) % 2 == 1)
                    {
                        tabuleiro[x, y] = new Vazia();
                    }
                }
            }

        }




        public Posicao Posicao
        {
            get => default(Posicao);
            set
            {
            }
        }
    }
}
