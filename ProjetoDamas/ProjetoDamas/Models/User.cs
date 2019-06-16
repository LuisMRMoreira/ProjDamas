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
        public string Username { get; set; }
        public string Nome { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Image Imagem { get; set; } //diretoria da foto
        public string Pais { get; set; }
        public DateTime DataNascimento { get; set; }

        public User(string nome, string password, string email, string pais, Image imagem, string username, string idade, DateTime dataNascimento )
        {
            Nome = nome;
            Password = password;
            Email = email;
            Pais = pais;
            Imagem = imagem;
            Username = username;
            DataNascimento = dataNascimento;
            Pais = pais;
        }

        public User() { }
    }
}
