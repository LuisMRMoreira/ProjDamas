using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDamas
{
    public class Pessoa : Jogador
    {//A classe Pessoa é derivada de jogar e serve como distinção entre robot, uma vez que caso não seja robot, necessita de introduzir toda esta informação

        public int Id { get; set; }
        public string Username { get; set; }
        public string Nome { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Imagem { get; set; } //diretoria da foto
        public string Pais { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCriacaoConta { get; set; }
        public int Vitorias { get; set; }
        public int Empates { get; set; }
        public int Derrotas { get; set; }



        public Pessoa(User u, bool cor, bool prior) : base (cor, prior)
        {
            Id = u.Id;
            Nome = u.Nome;
            Password = u.Password;
            Email = u.Email;
            Pais = u.Pais;
            Imagem = u.Imagem;
            Username = u.Username;
            DataNascimento = u.DataNascimento;
            Pais = u.Pais;
            DataCriacaoConta = u.DataCriacaoConta;
            Vitorias = u.Vitorias;
            Empates = u.Empates;
            Derrotas = u.Derrotas;
        }

        public Pessoa(Pessoa u, bool cor, bool prior) : base(cor, prior)
        {
            Id = u.Id;
            Nome = u.Nome;
            Password = u.Password;
            Email = u.Email;
            Pais = u.Pais;
            Imagem = u.Imagem;
            Username = u.Username;
            DataNascimento = u.DataNascimento;
            Pais = u.Pais;
            DataCriacaoConta = u.DataCriacaoConta;
            Vitorias = u.Vitorias;
            Empates = u.Empates;
            Derrotas = u.Derrotas;
        }

        public Pessoa(Pessoa u): base(false, false) //Está mal
        {
            Id = u.Id;
            Nome = u.Nome;
            Password = u.Password;
            Email = u.Email;
            Pais = u.Pais;
            Imagem = u.Imagem;
            Username = u.Username;
            DataNascimento = u.DataNascimento;
            Pais = u.Pais;
            DataCriacaoConta = u.DataCriacaoConta;
            Vitorias = u.Vitorias;
            Empates = u.Empates;
            Derrotas = u.Derrotas;
        }
    }
}
