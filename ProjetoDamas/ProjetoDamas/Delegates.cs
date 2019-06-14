using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDamas
{

    public delegate void MetodosSemParametros();
    public delegate void MetodosComDuasStrings(string imagem, string nome);
    public delegate void MetodosComUmInteiro(int escolha);
    public delegate void MetodosComInfoJogador(string nome, string pass, string confirmPass, string nick, string email, string pais, string imageLocation, string dataDeNascimento);
    public delegate void MetodosComDoisParametros(int volume, string tamanho); //pode ser alterado
    public delegate void MetodosComUmaPosicao(int x, int y);
    public delegate void MetodosComListaDeCoordenadas(List<Coordenada> coordenadas);
    public delegate void MetodosComDuasCoordenadas(Coordenada c1, Coordenada c2);
    public delegate void MetodosComDuasCoordenadasEUmTipoDePEca(Coordenada c1, Coordenada c2, Peca p1);
}
