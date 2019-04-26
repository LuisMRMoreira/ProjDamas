﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDamas
{

    public delegate void MetodosSemParametros();
    public delegate void MetodosComDuasStrings(string imagem, string nome);
    public delegate void MetodosComUmInteiro(int escolha);
    public delegate void MetodosComInfoJogador(string nome, string pass, string confirmPass, string nick, string email, string pais, string imageLocation);
    public delegate void MetodosComDoisParametros(int volume, string tamanho); //pode ser alterado

}
