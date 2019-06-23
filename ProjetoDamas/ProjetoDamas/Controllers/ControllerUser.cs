using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace ProjetoDamas
{
    public class ControllerUser
    {
        public ControllerUser()
        {
            Program.V_Login.PedidoLogin += V_Login_PedidoLogin;
            Program.V_JogadorOponente.PedidoVerificarUser += V_Login_PedidoLogin;
            Program.V_Tabuleiro.PedidoFimDoJogo += V_Tabuleiro_PedidoFimDoJogo;
            Program.V_Result.PedidoVoltarMenu += V_Result_PedidoVoltarMenu;
            Program.V_Register.PedidoRegistarJogador += V_Register_PedidoRegistarJogador;
            Program.V_Profile.PedidoGuardarDados += V_Profile_PedidoGuardarDados;
            Program.V_Profile.PedidoTerminarSessao += V_Profile_PedidoTerminarSessao;
            Program.V_JogosInacabados.PedidoAdicionarUser += V_JogosInacabados_PedidoAdicionarUser;
        }

        private void V_JogosInacabados_PedidoAdicionarUser(User u)
        {
            Program.M_User.AdicionaUserJogoAcabado(u);
        }

        private void V_Profile_PedidoTerminarSessao()
        {
            Program.M_User.Users.Clear();
            Program.V_Login.Show();
        }

        private void V_Profile_PedidoGuardarDados(string username, string pass, string nick, string email, string pais, string imageLocation, DateTime dataDeNascimento)
        {
            var folder = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\Base de dados");

            string sqlConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + folder + "DamasDataBase.mdf"
                + ";Integrated Security=True";

            SqlConnection server = new SqlConnection(sqlConnection);

            server.Open();

            int id = 0;
            if ((id = Program.M_User.Users[0].Id) != -1)
            {
                ///////////////////////
                //Obteve-se o id do usuario logado para assim se poder alterar todos os dados
                string cmdText = string.Format("SELECT * FROM Jogador WHERE " +
                                    "jogador_id = '{0}'", id);

                //construir o comando SQL com a ligação ao servidor
                SqlCommand command = new SqlCommand(cmdText, server);

                //executar o comando e receber os dados resultantes dessa query 
                SqlDataReader dados = command.ExecuteReader();
                /////////////////////

                if (dados.HasRows) //vereficar se tem resultados, o que significa que há algum registo com aquele username e password
                {
                    ////lê os dados associados ao utilizador logado que estão na BD
                    dados.Read();

                    User user = new User();
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

                    dados.Close();


                    //Alterar dados na BD
                    string filename = Path.GetFileName(imageLocation); //nome da foto

                    string comando = String.Format("UPDATE Jogador " +
                                                "SET jogador_nome = '{0}', jogador_password = '{1}', jogador_email = '{2}'," +
                                                "jogador_pais = '{3}', jogador_imagem = '{4}', jogador_username = '{5}', jogador_idade = '{6}'" +
                                                "WHERE jogador_id = '{7}' ",
                                                nick, pass, email, pais, filename, username, dataDeNascimento.ToString("MM/dd/yyyy HH:mm:ss"), id);

                    command = new SqlCommand(comando, server);


                    int resultado = 0;

                    resultado = command.ExecuteNonQuery();



                    if (resultado == 1) 
                    {

                        if (string.Compare(imageLocation, (folder + "Fotos\\" + filename)) == 0)
                        {
                            //Se a diretorias forem iguais a foto não foi alterada e por isso continua a mesma

                        }
                        else
                        {   //Se a diretoria passada pelo evento não estiver na pasta das dotos, então é uma foto novaCopiar imagem para a pasta fotos
                            if (File.Exists(folder + "Fotos\\" + filename))
                            {
                                File.Delete(folder + "Fotos\\" + filename);
                            }
                            System.IO.File.Copy(imageLocation, folder + "Fotos\\" + filename, true); //copiar a foto da sua diretoria para a pasta fotos



                        }


                        server.Close();

                        Program.M_User.Users[0] = new User(user);

                    }
                    else
                    {
                        server.Close();
                        // não inseriu na base de dados, não fazemos nada

                    }

                }

                // Program.M_Gestor.GuardarDados(volume, tamanho);
            }
        }

        private void V_Register_PedidoRegistarJogador(string username, string pass, string nick, string email, string pais, string imageLocation, DateTime dataDeNascimento)
        {
            var folder = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\Base de dados");

            string sqlConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + folder + "DamasDataBase.mdf"
                + ";Integrated Security=True";

            SqlConnection server = new SqlConnection(sqlConnection);

            server.Open();

            //Copiar imagem para a pasta fotos
            string filename = Path.GetFileName(imageLocation); //nome da foto

            string comando = String.Format("INSERT INTO Jogador" +
                                            "(jogador_nome, jogador_password, jogador_email, jogador_pais, jogador_imagem, jogador_username, jogador_idade) values " +
                                            "( '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                                            nick, pass, email, pais, filename, username, dataDeNascimento.ToString("MM/dd/yyyy HH:mm:ss"));

            //construir o comando SQL com a ligação ao servidor
            SqlCommand command = new SqlCommand(comando, server);


            int resultado = 0;

            try
            {   //executar o comando e receber os dados resultantes dessa query 
                resultado = command.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                MessageBox.Show("The values of username, email or image already exist.", "Invalid Registation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            if (resultado == 1)  // se o resultado for 1, significa que adicionou correctamente o utilizador
            {
                //Copiar imagem para a pasta fotos
                System.IO.File.Copy(imageLocation, folder + "\\Fotos\\" + filename, true); //copiar a foto da sua diretoria para a pasta fotos

                //Obtem a ultima linha inserida na base de dados
                string cmdText = string.Format("SELECT * FROM Jogador WHERE " +
                                    "jogador_id = @@IDENTITY");

                command = new SqlCommand(cmdText, server);

                SqlDataReader dados = command.ExecuteReader();

                dados.Read(); //lê uma linha dos resultados, este metodo retorna um bool para informar se conseguiu ler ou não

                User user = new User();
                user.Id = Convert.ToInt32(dados["jogador_id"]);
                user.Nome = dados["jogador_nome"].ToString();
                user.Password = dados["jogador_password"].ToString();
                user.Email = dados["jogador_email"].ToString();
                user.Pais = dados["jogador_pais"].ToString();
                //user.Imagem = Image.FromFile(folder + "Fotos\\" + dados["jogador_imagem"].ToString());
                user.Imagem = folder + "Fotos\\" + dados["jogador_imagem"].ToString();
                user.Username = dados["jogador_username"].ToString();
                user.DataNascimento = Convert.ToDateTime(dados["jogador_idade"]);
                user.DataCriacaoConta = Convert.ToDateTime(dados["jogador_dataCriacaoConta"]);
                user.Vitorias = Convert.ToInt32(dados["jogador_vitorias"]);
                user.Empates = Convert.ToInt32(dados["jogador_empates"]);
                user.Derrotas = Convert.ToInt32(dados["jogador_derrotas"]);

                server.Close();


                Program.V_Register.Hide();
                Program.V_Login.Show();



            }
            else
            {
                server.Close();
                // não inseriu na base de dados, não fazemos nada

            }
        }

        private void V_Result_PedidoVoltarMenu()
        {
            Program.M_User.VoltarMenu();
        }

        private void V_Tabuleiro_PedidoFimDoJogo(Jogador j1, Jogador j2, int i)
        {
            Jogador jV, jP;
            if (i == 0)
            {
                jV = j1;
                jP = j2;
            }
            else if (i == 1)
            {
                jV = j2;
                jP = j1;
            }
            else
            {
                jV = j2;
                jP = j1;
            }


            var folder = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\Base de dados");
            string sqlConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + folder + "DamasDataBase.mdf"
                + ";Integrated Security=True";
            SqlConnection server = new SqlConnection(sqlConnection);
            server.Open();




            if (jV is Robot)
            {
                string cmdText = string.Format("SELECT * FROM Jogador WHERE jogador_id = '{0}'", ((Pessoa)jP).Id);
                SqlCommand command = new SqlCommand(cmdText, server);
                SqlDataReader dados = command.ExecuteReader();
                dados.Read();
                int derrotas = Convert.ToInt32(dados["jogador_derrotas"]);
                int empates = Convert.ToInt32(dados["jogador_empates"]);
                dados.Close();

                string comando;
                int resultado;

                if (i == 2)
                {
                    comando = String.Format("UPDATE Jogador SET jogador_empates = '{0}' WHERE jogador_id = '{1}'", empates++, ((Pessoa)jP).Id);
                    command = new SqlCommand(comando, server);
                    resultado = command.ExecuteNonQuery();
                }
                else
                {
                    comando = String.Format("UPDATE Jogador SET jogador_derrotas = '{0}' WHERE jogador_id = '{1}'", derrotas++, ((Pessoa)jP).Id);
                    command = new SqlCommand(comando, server);
                    resultado = command.ExecuteNonQuery();
                }

                server.Close();


            } else if (jP is Robot)
            {
                string cmdText = string.Format("SELECT * FROM Jogador WHERE jogador_id = '{0}'", ((Pessoa)jV).Id);
                SqlCommand command = new SqlCommand(cmdText, server);
                SqlDataReader dados = command.ExecuteReader();
                dados.Read();
                int vitorias = Convert.ToInt32(dados["jogador_vitorias"]);
                int empates = Convert.ToInt32(dados["jogador_empates"]);
                dados.Close();

                string comando;
                int resultado;

                if (i == 2)
                {
                    comando = String.Format("UPDATE Jogador SET jogador_empates = '{0}' WHERE jogador_id = '{1}'", empates++, ((Pessoa)jV).Id);
                    command = new SqlCommand(comando, server);
                    resultado = command.ExecuteNonQuery();
                }
                else
                {
                    comando = String.Format("UPDATE Jogador SET jogador_vitorias = '{0}' WHERE jogador_id = '{1}'", vitorias++, ((Pessoa)jP).Id);
                    command = new SqlCommand(comando, server);
                    resultado = command.ExecuteNonQuery();
                }

                server.Close();

            }
            else
            {
                string cmdText = string.Format("SELECT * FROM Jogador WHERE jogador_id = '{0}'", ((Pessoa)jP).Id);
                SqlCommand command = new SqlCommand(cmdText, server);
                SqlDataReader dados = command.ExecuteReader();
                dados.Read();
                int derrotas = Convert.ToInt32(dados["jogador_derrotas"]);
                int empates1 = Convert.ToInt32(dados["jogador_empates"]);
                dados.Close();


                cmdText = string.Format("SELECT * FROM Jogador WHERE jogador_id = '{0}'", ((Pessoa)jV).Id);
                command = new SqlCommand(cmdText, server);
                dados = command.ExecuteReader();
                dados.Read();
                int vitorias = Convert.ToInt32(dados["jogador_vitorias"]);
                int empates2 = Convert.ToInt32(dados["jogador_empates"]);
                dados.Close();

                string comando;
                int resultado;

                if (i == 2)//Empate -> Aumentar os empates
                {
                    comando = String.Format("UPDATE Jogador SET jogador_empates = '{0}' WHERE jogador_id = '{1}'", empates1++, ((Pessoa)jP).Id);
                    command = new SqlCommand(comando, server);
                    resultado = command.ExecuteNonQuery();

                    comando = String.Format("UPDATE Jogador SET jogador_empates = '{0}' WHERE jogador_id = '{1}'", empates2++, ((Pessoa)jV).Id);
                    command = new SqlCommand(comando, server);
                    resultado = command.ExecuteNonQuery();
                }
                else
                {
                    comando = String.Format("UPDATE Jogador SET jogador_derrotas = '{0}' WHERE jogador_id = '{1}'", derrotas++, ((Pessoa)jP).Id);
                    command = new SqlCommand(comando, server);
                    resultado = command.ExecuteNonQuery();

                    comando = String.Format("UPDATE Jogador SET jogador_vitorias = '{0}' WHERE jogador_id = '{1}'", vitorias++, ((Pessoa)jV).Id);
                    command = new SqlCommand(comando, server);
                    resultado = command.ExecuteNonQuery();
                }


                server.Close();
            }

            Program.M_User.FimDoJogo(j1, j2, i);
        }
        
        private void V_Login_PedidoLogin(string username, string password)
        {
            var folder = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\Base de dados");

            string sqlConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + folder + "DamasDataBase.mdf"
                + ";Integrated Security=True"; 

            SqlConnection server = new SqlConnection(sqlConnection);

            server.Open();

            string cmdText = string.Format("SELECT * FROM Jogador WHERE " +
                                            "jogador_username = '{0}' and jogador_password = '{1}'",
                                            username, password);

            SqlCommand command = new SqlCommand(cmdText, server);

            SqlDataReader dados = command.ExecuteReader();


            if (dados.HasRows) 
            {
                dados.Read();

                User user = new User();
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

                server.Close();

                if (Program.M_User.Users.Count == 1)
                    if (user.Id == Program.M_User.Users[0].Id)
                        MessageBox.
                             Show("Unavalable player: Player already selected!",
                             "Player selection",
                             System.Windows.Forms.MessageBoxButtons.OK,
                             System.Windows.Forms.MessageBoxIcon.Error);
                    else
                        Program.M_User.AdicionarUser(user);
                else
                    Program.M_User.AdicionarUser(user);


            }
            else
            {
                server.Close();

                MessageBox.
                     Show("Wrong credentials!",
                     "Login",
                     System.Windows.Forms.MessageBoxButtons.OK,
                     System.Windows.Forms.MessageBoxIcon.Error);

            }
        }


    }
}
