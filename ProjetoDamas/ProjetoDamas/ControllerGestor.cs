using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Usar SQL
using System.Drawing; // Usar a classe Image
using System.Windows.Forms; //Usar MessageBox

namespace ProjetoDamas
{
    public class ControllerGestor
    {

        public ControllerGestor()
        {
            Program.V_Profile.PedidoTerminarSessao += V_Profile_PedidoTerminarSessao;
            Program.V_Settings.PedidoGuardarDados += V_Settings_PedidoGuardarDados;

            Program.V_Login.PedidoLoginJogador += V_Login_PedidoLoginJogador;

        }

        private void V_Login_PedidoLoginJogador(string username, string password)
        {

            var folder = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\Base de dados");

            //construir a ligação ao servidor SQL Server local com o caminho do ficheiro
            //string sqlConnection = "Server=(localdb)\\MSSQLLocalDB;AttachDbFilename=" + folder + "Utilizadores.mdf" +
            //                         ";Trusted_Connection=True;";

            string sqlConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + folder + "DamasDataBase.mdf"
                + ";Integrated Security=True"; //Ir à string connection nas propriedades da Base de dados no ServerExplorer


            //inicializar a ligação ao servidor
            SqlConnection server = new SqlConnection(sqlConnection);

            //abrir a ligação
            server.Open();

            string cmdText = string.Format("SELECT * FROM Jogador WHERE " +
                                            "jogador_username = '{0}' and jogador_password = '{1}'",
                                            username, password);

            //construir o comando SQL com a ligação ao servidor
            SqlCommand command = new SqlCommand(cmdText, server);

            //executar o comando e receber os dados resultantes dessa query 
            SqlDataReader dados = command.ExecuteReader();


            if (dados.HasRows) //vereficar se tem resultados, o que significa que há algum registo com aquele username e password
            {//o login é valido

                dados.Read(); //lê uma linha dos resultados, este metodo retorna um bool para informar se conseguiu ler ou não

                User user = new User();

                //ler os dados, com o nome das colunas como identificador
                user.Nome = dados["jogador_nome"].ToString();
                user.Password = dados["jogador_password"].ToString();
                user.Email = dados["jogador_email"].ToString();
                user.Pais = dados["jogador_pais"].ToString();
                user.Imagem = Image.FromFile(folder + "Fotos\\" + dados["jogador_imagem"].ToString());
                user.Username = dados["jogador_username"].ToString();
                user.DataNascimento = Convert.ToDateTime(dados["jogador_idade"]);

                //fechar sempre a ligação ao servidor quando não é mais necessária
                server.Close();

                Program.M_Gestor.AdicionaJogador(user); // assume que o jogador entrou e adiciona-o ao jogo
                Program.V_Login.Hide();
                Program.V_Menu.Show();
            }
            else // o login é invalido
            {
                server.Close();

                MessageBox.
                     Show("Credenciais erradas!",
                     "Login",
                     System.Windows.Forms.MessageBoxButtons.OK,
                     System.Windows.Forms.MessageBoxIcon.Error);

            }

        }
                     
        private void V_Settings_PedidoGuardarDados(int volume, string tamanho)
        {
            Program.M_Gestor.GuardarDados(volume, tamanho);
        }

        private void V_Profile_PedidoTerminarSessao()
        {
            Program.M_Gestor.TermninarSessao();
        }


    }
}
