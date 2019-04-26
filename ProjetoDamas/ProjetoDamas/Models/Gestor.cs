using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDamas
{
    public class Gestor
    {
        public event MetodosComDuasStrings PedidoAlterarVMenuLogin;
        public event MetodosSemParametros PedidoMostrarPerfil;
        public event MetodosSemParametros PedidoMostrarLogin;


        public bool Login = false; 

        //classe responsavel pela gestão do jogo
        //Vai fornecer o menu e os modos de jogo


        //INFO: MUITAS CLASSES
        //As classes são uma especie de tipo de dados
        //De forma a termos apenas uma matriz na classe tabuleiro com toda a informação necessaria, criamos uma classe Posição que representa cada uma das casas do tabuleiro. 
        //Cada casa pode ser inválida, vazia ou ter peca, desta forma criamos 3 subclasses dereivadas da classe posicao (Praticamente foi só para distinguirmos cada posicao). 
        //De seguida criamos duas subclasses derivadas da classe peca, que nos informa se a peça é simples ou se é dama. Esta parte é necessaria uma vez que o moviemento (metodo) de uma peça simples é diferente de uma dama 

        //Poderiamos ter utilizado enums ou apenas identificação por inteiros, no entanto optamos por esta opção por parecer a mais intuitiva.


        public void AlterarVMenuEAbir()
        {//altera a lable e a imagem que do login. Aqui vamos ter de ir buscar à base de dados 

            if (PedidoAlterarVMenuLogin != null)
            {
                PedidoAlterarVMenuLogin(@"C:\Users\lmr_m\Desktop\Temporario\Laboratorio\ProjDamas\ProjetoDamas\ProjetoDamas\Resources\" + "DamaBranca", "nomezito");
            }

            Login = true;

        }


        public void AbrePerfilOuLogin()
        {
            if (Login)//Se ja tiver feito login
            {
                if (PedidoMostrarPerfil != null)
                {
                    PedidoMostrarPerfil();
                }
            }
            else
            {
                if (PedidoMostrarLogin != null)
                {
                    PedidoMostrarLogin();
                }
            }

        }


    }
}
