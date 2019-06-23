using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjetoDamas
{
    static class DataBaseAccess
    {

        public static User GetUserById(int id)
        {
            var folder = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\Base de dados");

            string sqlConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + folder + "DamasDataBase.mdf"
                + ";Integrated Security=True";

            SqlConnection server = new SqlConnection(sqlConnection);

            server.Open();

            string cmdText = string.Format("SELECT * FROM Jogador WHERE " +
                                "jogador_id = '{0}'", id);

            SqlCommand command = new SqlCommand(cmdText, server);

            SqlDataReader dados = command.ExecuteReader();

            User user = new User();
            if (dados.HasRows) //vereficar se tem resultados, o que significa que há algum registo com aquele username e password
            {
                ////lê os dados associados ao utilizador logado que estão na BD
                dados.Read();
                
                user.Id = Convert.ToInt32(dados["jogador_id"]);
                user.Nome = dados["jogador_nome"].ToString();
                user.Password = dados["jogador_password"].ToString();
                user.Email = dados["jogador_email"].ToString();
                user.Pais = dados["jogador_pais"].ToString();
                user.Imagem = folder + "Fotos\\" + dados["jogador_imagem"].ToString();
                user.Username = dados["jogador_username"].ToString();
                user.DataNascimento = Convert.ToDateTime(dados["jogador_idade"]);
                user.DataCriacaoConta = Convert.ToDateTime(dados["jogador_dataCriacaoConta"]);
                user.Vitorias = Convert.ToInt32(dados["jogador_vitorias"]);
                user.Empates = Convert.ToInt32(dados["jogador_empates"]);
                user.Derrotas = Convert.ToInt32(dados["jogador_derrotas"]);                

            }

            server.Close();
            //Enviar exception no else porque foi apagado algum jogador da BD entretanto
            return user;

        }
    }
}
