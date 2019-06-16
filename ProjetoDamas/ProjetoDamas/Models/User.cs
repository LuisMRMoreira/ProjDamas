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
        public Image Imagem { get; set; } //diretoria da foto
        public string Pais { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCriacaoConta { get; set; }


        public User( int id, string nome, string password, string email, string pais, Image imagem, string username, string idade, DateTime dataNascimento, DateTime dataCriacaoConta)
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
        }

        public User() { }
    }
}
