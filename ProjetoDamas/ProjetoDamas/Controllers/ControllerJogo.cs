using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Linq;

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
            Program.V_Tabuleiro.PedidoGuardarJogo += V_Tabuleiro_PedidoGuardarJogo;
            Program.V_JogosInacabados.PedidoLoadJogosInacabados += V_JogosInacabados_PedidoLoadJogosInacabados;
            Program.V_JogosInacabados.PedidoVoltarAJogo += V_JogosInacabados_PedidoVoltarAJogo;
            Program.V_Tabuleiro.PedidoRemoverJogoInacabado += V_Tabuleiro_PedidoRemoverJogoInacabado;
        }

        private void V_Tabuleiro_PedidoRemoverJogoInacabado(int i)
        {
            bool inacabados = false;
            int index = 0;
            foreach (Jogo jogo in Program.M_Jogo.JogosInacabados)
            {
                if (jogo.Id == i)
                {
                    inacabados = true;
                    //remover indice atual
                    Program.M_Jogo.JogosInacabados.RemoveAt(index);
                    break;
                }
                index++;
            }

            //Se estiver no inacabados, removemos do ficheiro xml
            if (inacabados)
            {
              //  if (Program.M_Jogo.JogosInacabados.Count == 0)
               // {
                    var folder = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\XML");
                    if (File.Exists(folder + "JogosInacabados.xml"))
                    {
                        XDocument doc = XDocument.Load(folder + "JogosInacabados.xml");
                        if (doc.Descendants("Jogo").Count() != 0)
                        {
                        ////Obter conjunto de jogosInacabados
                        //var jogos = from jogo in doc.Descendants("Jogo")
                        //            select jogo;

                        ////Para cada jogoInacabado, verificamos se Algum dos jogadores têm o id do jogador logado
                        //foreach (var jogoIn in jogos)
                        //{
                        //    if (Convert.ToInt16(jogoIn.Attribute("Id").Value) == i)
                        //    {

                        //        doc.Remove(jogoIn);//.Remove();
                        //        break;
                        //    }
                        //}

                        var q = from node in doc.Descendants("Jogo")
                                let attr = node.Attribute("Id")
                                where attr != null && attr.Value == i.ToString()
                                select node;
                        q.ToList().ForEach(x => x.Remove());
                        doc.Save(folder + "JogosInacabados.xml");
                        }
                    }
                //}                
            }


        }


        private void V_JogosInacabados_PedidoVoltarAJogo(Jogo j)
        {
            Program.M_Jogo.ComecarJogo(j);
        }

        private void V_JogosInacabados_PedidoLoadJogosInacabados(int i)
        {
            List<Jogo> jogosInacabados = new List<Jogo>();
            if (Program.M_Jogo.JogosInacabados.Count == 0)
            {                
                var folder = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\XML");
                if (File.Exists(folder + "JogosInacabados.xml"))
                {
                    XDocument doc = XDocument.Load(folder + "JogosInacabados.xml");
                    if (doc.Descendants("Jogo").Count() != 0)
                    {
                        int numJogador = 0;
                        Jogador j1 = new Jogador(), j2 = new Jogador();
                        bool jogadorEncontrado = false;

                        //Obter conjunto de jogosInacabados
                        var jogos = from jogo in doc.Descendants("Jogo")
                                        select jogo;

                        //Para cada jogoInacabado, verificamos se Algum dos jogadores têm o id do jogador logado
                        foreach (var jogoIn in jogos)
                        {
                            foreach (var jogador in jogoIn.Element("Jogadores").Elements())
                            {
                                numJogador++;
                                if (jogador.Name == "Pessoa") //Se o jogador for uma pesso e for o primeiro jogador
                                {
                                    if (numJogador == 1)
                                    {
                                        User u = new User();
                                        u = DataBaseAccess.GetUserById(Convert.ToInt16(jogador.Attribute("Id").Value));
                                        j1 = new Pessoa(u, Convert.ToBoolean(jogador.Element("Cor").Value), Convert.ToBoolean(jogador.Element("Prioridade").Value));
                                    }
                                    else
                                    {
                                        User u2 = new User();
                                        u2 = DataBaseAccess.GetUserById(Convert.ToInt16(jogador.Attribute("Id").Value));
                                        j2 = new Pessoa(u2, Convert.ToBoolean(jogador.Element("Cor").Value), Convert.ToBoolean(jogador.Element("Prioridade").Value));
                                    }

                                    if (jogador.Attribute("Id").Value == i.ToString())
                                        jogadorEncontrado = true;

                                } else if (jogador.Name == "Robot")
                                    j2 = new Robot(Convert.ToBoolean(jogador.Element("Cor").Value), Convert.ToBoolean(jogador.Element("Prioridade").Value));
                            }


                            if (jogadorEncontrado)
                            {
                                Posicao[,] t = new Posicao[8, 8];
                                foreach (var posicao in jogoIn.Descendants("Tabuleiro").Elements())
                                {
                                    int x, y;
                                    string coordenadas = posicao.Attribute("Coordenada").Value;

                                    x = Convert.ToInt32(coordenadas.Remove(1, 2)); // 0;1 -> 0
                                    y = Convert.ToInt32(coordenadas.Remove(0, 2));// 1;0 -> 0

                                    if (posicao.Name == "Vazia")
                                        t[x, y] = new Vazia();
                                    else if (posicao.Name == "Invalida")
                                        t[x, y] = new Invalida();
                                    else if (posicao.Attribute("Tipo").Value == "Simples")
                                        t[x, y] = new Simples(Convert.ToBoolean(posicao.Attribute("Cor").Value), Convert.ToBoolean(posicao.Attribute("Sentido").Value));
                                    else
                                        t[x, y] = new Dama(Convert.ToBoolean(posicao.Attribute("Cor").Value), Convert.ToBoolean(posicao.Attribute("Sentido").Value));
                                }

                                Tabuleiro tab = new Tabuleiro(t);
                            
                                Jogo j = new Jogo(j1, j2, tab);
                                j.Id = Convert.ToInt16(jogoIn.Attribute("Id").Value);

                                jogosInacabados.Add(j);
                            }


                            numJogador = 0;
                            jogadorEncontrado = false;
                        }

                    

                    }

                }
            }

            Program.M_Jogo.LoadJogosInacabados(jogosInacabados);
        }





        private void V_Tabuleiro_PedidoGuardarJogo()
        {
            //Se quiser guardar um jogo pela segunda vez
            this.V_Tabuleiro_PedidoRemoverJogoInacabado(Program.M_Jogo.Jogo.Id);

            int id = -1;
            var folder = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\XML");
            XDocument doc;

            if (!File.Exists(folder + "JogosInacabados.xml"))
            {
                id = 1;

                doc = new XDocument(new XDeclaration("1.0", Encoding.UTF8.ToString(), "yes"),
                                new XComment("Lista de jogos inacabados"),
                                new XElement("Jogos"));

                doc.Save(folder + "JogosInacabados.xml");

            }
            else
            {
                doc = XDocument.Load(folder + "JogosInacabados.xml");

                if (doc.Descendants("Jogo").Count() == 0)
                {//Se não tiver nenhum Jogo guardado
                    id = 1;
                }
                else
                {
                    //Obtem o id Maximo do jogo guardado em XML
                    id = doc.Root.Elements("Jogo").Max(x => (int)x.Attribute("Id"));
                    id++;
                }

            }

            //Criar um jogo
            XElement Jogo = new XElement("Jogo",
                            new XAttribute("Id", id),
                            new XElement("Jogadores"),
                            new XElement("Tabuleiro")
                            );


            //Criar dois Jogadores
            XElement jogadorDois, jogadorUm;
            jogadorUm = new XElement("Pessoa",
                                 new XAttribute("Id", ((Pessoa)Program.M_Jogo.Jogo.JogadorUm).Id),
                                 new XElement("Prioridade", Program.M_Jogo.Jogo.JogadorUm.Prioridade),
                                 new XElement("Cor", Program.M_Jogo.Jogo.JogadorUm.CorPecas));
            
            if (Program.M_Jogo.Jogo.JogadorDois is Robot)
            {
                jogadorDois = new XElement("Robot",
                     new XElement("Prioridade", Program.M_Jogo.Jogo.JogadorDois.Prioridade),
                     new XElement("Cor", Program.M_Jogo.Jogo.JogadorDois.CorPecas));
            }
            else
            {
                jogadorDois = new XElement("Pessoa",
                     new XAttribute("Id", ((Pessoa)Program.M_Jogo.Jogo.JogadorDois).Id),
                     new XElement("Prioridade", Program.M_Jogo.Jogo.JogadorDois.Prioridade),
                     new XElement("Cor", Program.M_Jogo.Jogo.JogadorDois.CorPecas));
            }
            //Adicionar os jogadores criados dentro do elemento jogadores que por sua vez está dentro do elemento Jogo
            var a = Jogo.Descendants("Jogadores").FirstOrDefault();
            a.Add(jogadorUm);
            a.Add(jogadorDois);

            //Adicionar as posições do tabuleiro ao elemento Jogo
            var b = Jogo.Descendants("Tabuleiro").LastOrDefault();
            for (int i = 0; i < Program.M_Jogo.Jogo.Tabuleiro.tabuleiro.GetLength(0); i++)
                for (int j = 0; j < Program.M_Jogo.Jogo.Tabuleiro.tabuleiro.GetLength(1); j++)
                {
                    XElement posicao;
                    if (Program.M_Jogo.Jogo.Tabuleiro.tabuleiro[i,j] is Peca)
                    {
                        if (Program.M_Jogo.Jogo.Tabuleiro.tabuleiro[i, j] is Simples)
                        {
                            posicao = new XElement("Peca", new XAttribute("Coordenada", i.ToString() + ";" + j.ToString()), new XAttribute("Cor", ((Peca)Program.M_Jogo.Jogo.Tabuleiro.tabuleiro[i, j]).CorPeca), new XAttribute("Sentido", ((Peca)Program.M_Jogo.Jogo.Tabuleiro.tabuleiro[i, j]).SentidoJogada), new XAttribute("Tipo", "Simples"));
                        }
                        else
                        {
                            posicao = new XElement("Peca", new XAttribute("Coordenada", i.ToString() + ";" + j.ToString()), new XAttribute("Cor", ((Peca)Program.M_Jogo.Jogo.Tabuleiro.tabuleiro[i, j]).CorPeca), new XAttribute("Sentido", ((Peca)Program.M_Jogo.Jogo.Tabuleiro.tabuleiro[i, j]).SentidoJogada), new XAttribute("Tipo", "Dama"));
                        }
                        
                        b.Add(posicao);
                    }
                    else if (Program.M_Jogo.Jogo.Tabuleiro.tabuleiro[i, j] is Vazia)
                    {
                        posicao = new XElement("Vazia", new XAttribute("Coordenada", i.ToString() + ";" + j.ToString()));
                        b.Add(posicao);
                    }
                    else if (Program.M_Jogo.Jogo.Tabuleiro.tabuleiro[i, j] is Invalida)
                    {
                        posicao = new XElement("Invalida", new XAttribute("Coordenada", i.ToString() + ";" + j.ToString()));
                        b.Add(posicao);
                    }

                    
                }

            var c = doc.Descendants("Jogos").LastOrDefault();
            c.Add(Jogo);

            Program.M_Jogo.JogosInacabados.Add(Program.M_Jogo.Jogo);

            doc.Save(folder + "JogosInacabados.xml");

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
