using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDamas
{
    public class Gestor
    {
        public event MetodosSemParametros RespostaDadosGuardados; //View...
        public event MetodosComDuasStrings RespostaLoginBemSucedido; //ViewMenu
        public event MetodosSemParametros RespostaLoginInvalido; //ViewLogin
        public event MetodosSemParametros RespostaTerminarSessao; //ViewLogin


        public bool Login = false;

        //classe responsavel pela gestão do jogo
        //Vai fornecer o menu e os modos de jogo


        //INFO: MUITAS CLASSES
        //As classes são uma especie de tipo de dados
        //De forma a termos apenas uma matriz na classe tabuleiro com toda a informação necessaria, criamos uma classe Posição que representa cada uma das casas do tabuleiro. 
        //Cada casa pode ser inválida, vazia ou ter peca, desta forma criamos 3 subclasses dereivadas da classe posicao (Praticamente foi só para distinguirmos cada posicao). 
        //De seguida criamos duas subclasses derivadas da classe peca, que nos informa se a peça é simples ou se é dama. Esta parte é necessaria uma vez que o moviemento (metodo) de uma peça simples é diferente de uma dama 

        //Poderiamos ter utilizado enums ou apenas identificação por inteiros, no entanto optamos por esta opção por parecer a mais intuitiva.





        public void GuardarDados(int volume, string tamanho)
        {
            //BASE DE DADOS: Guardar dados ---------------------------------------------------------------------------------------------------------------

            if (RespostaDadosGuardados != null)
            {
                RespostaDadosGuardados();
            }
            

        }





        public void TermninarSessao()
        {
            //Destruir instancia de jogador caso tenha sido criada no metodo VerificarLogin????? 

            //Voltar à ViewLogin
            if (RespostaTerminarSessao != null)
            {
                RespostaTerminarSessao();
            }

        }



        public void VerificarLogin(string username, string password)
        {//BASE DE DADOS: Verificar se os valores coincidem (LEMBRAR: A password na base de dados está encriprada)

            if (/*forem válidos*/true)
            {
                //BASE DE DADOS: Obter a imagem e nickname do jogador na Base de dados
                string localizacaoImagem_jogador = null;
                string nikname_jogador = null;

                //abrir View Menu com a lable com o nome e imahem do jogador
                if (RespostaLoginBemSucedido != null)
                {
                    RespostaLoginBemSucedido(nikname_jogador,localizacaoImagem_jogador);
                }

                //instanciar um jogador???

                
            }
            else /*Caso sejam invalidos*/
            {
                //Mostrar mensagem de erro

                if (RespostaLoginInvalido != null)
                {
                    RespostaLoginInvalido();
                }                
            }



        }


    }
}
