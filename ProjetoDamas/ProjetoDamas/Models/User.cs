using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProjetoDamas
{
    public class User
    {
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



        public User( int id, string nome, string password, string email, string pais, string imagem, string username, string idade, DateTime dataNascimento, DateTime dataCriacaoConta, int vitorias, int empates, int derrotas)
        {
            Id = id;
            Nome = nome;
            Password = password;
            Email = email;
            Pais = pais;
            Imagem = imagem;
            Username = username;
            DataNascimento = dataNascimento;
            Pais = pais;
            DataCriacaoConta = dataCriacaoConta;
            Vitorias = vitorias;
            Empates = empates;
            Derrotas = derrotas;
        }

        public User() { }

        public User(User u)
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

        public User(Pessoa u)
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
