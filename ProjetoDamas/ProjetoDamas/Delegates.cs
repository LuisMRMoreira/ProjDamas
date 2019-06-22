using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDamas
{    
    
   
    public delegate void MetodosComDoisParametros(int volume, string tamanho); //pode ser alterado
    public delegate void MetodosComUmaPosicao(int x, int y);
    public delegate void MetodosSemParametros();
    public delegate void MetodosComDuasCoordenadasEUmTipoDePEca(Coordenada c1, Coordenada c2, Peca p1);

    public delegate void MetodosComDoisUser(Jogador u1, Jogador u2);


    //Novos
    public delegate void MetodosComUmaMatrizDePosicoesEJogadores(Posicao[,] t1, Jogador j1, Jogador J2);
    public delegate void MetodosComUmInteiroEMatrizDePosicoes(int i, Posicao[,] t1);
    public delegate void MetodosComDuasCoordenadasEUmaMatrizDePosicoes(Coordenada c1, Coordenada c2, Posicao[,] t1);
    public delegate void MetodosComTresCoordenadasEUmaMatrizDePosicoes(Coordenada c1, Coordenada c2, Coordenada c3, Posicao[,] t1);    
    public delegate void MetodosComListaDeCoordenadas(List<Coordenada> coordenadas);
    public delegate void MetodosComDuasCoordenadas(Coordenada c1, Coordenada c2);
    public delegate void MetodosComUmaCoordenada(Coordenada c);
    public delegate void MetodosComDuasStrings(string s1, string s2);
    public delegate void MetodosComDoisUsers(User u1, User u2);
    public delegate void MetodosComUmUser(User u);
    public delegate void MetodosComUmUserEUMJogador(User u, Jogador j);
    public delegate void MetodosComDoisJogadresEUmInteiro(Jogador j1, Jogador j2, int i);
    public delegate void MetodosComUmInteiro(int i);
    public delegate void MetodosComInfoJogador(string nome, string pass, string nick, string email, string pais, string imageLocation, DateTime dataDeNascimento);
}
