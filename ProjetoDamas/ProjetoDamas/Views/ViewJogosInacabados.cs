using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDamas
{
    public partial class ViewJogosInacabados : Form
    {
        public event MetodosComUmInteiro PedidoLoadJogosInacabados;
        public event MetodosComUmJogo PedidoVoltarAJogo;
        public event MetodosComUmUser PedidoAdicionarUser;


        public ViewJogosInacabados()
        {
            InitializeComponent();
            Program.M_Jogo.RespostaLoadJogosInacabados += M_Jogo_RespostaLoadJogosInacabados;
        }

        private void M_Jogo_RespostaLoadJogosInacabados(List<Jogo> lj)
        {

            dGVJogosInacabados.Rows.Clear();
            foreach (Jogo jogo in lj)
            {
                if (jogo.JogadorDois is Robot)
                {
                    dGVJogosInacabados.Rows.Add(((Pessoa)jogo.JogadorUm).Username, "--------", "Robot");
                }
                else
                {
                    dGVJogosInacabados.Rows.Add(((Pessoa)jogo.JogadorUm).Username, ((Pessoa)jogo.JogadorDois).Username , "Local");
                }
            }
        }

        private void pbReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_Menu.Show();
        }

        private void rBNone_CheckedChanged(object sender, EventArgs e)
        {
            cBCountries.Visible = false;
            dTPDataDeJogo.Visible = false;
            cTBNickname.Visible = false;
        }

        private void rBName_CheckedChanged(object sender, EventArgs e)
        {
            cBCountries.Visible = false;
            dTPDataDeJogo.Visible = false;
            cTBNickname.Visible = true;
        }

        private void rBDate_CheckedChanged(object sender, EventArgs e)
        {
            cBCountries.Visible = false;
            dTPDataDeJogo.Visible = true;
            cTBNickname.Visible = false;
        }

        private void rBCountry_CheckedChanged(object sender, EventArgs e)
        {
            cBCountries.Visible = true;
            dTPDataDeJogo.Visible = false;
            cTBNickname.Visible = false;
        }

        private void ViewJogosInacabados_Load(object sender, EventArgs e)
        {
            ///
            ///Cor do painel
            ///

            pDataGridView.BackColor = Color.FromArgb(150, 0, 0, 0);


            ///
            /// Inicializar componente
            ///



            ///
            /// Inicializar DataGridView
            ///




        }

        private void dGVJogosInacabados_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dGVJogosInacabados.SelectedRows != null)
            {
                bContinueGame.Enabled = true;
            }
                
        }

        private void bContinueGame_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to go back to this game?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int selectedRow = -1;
                if (dGVJogosInacabados.CurrentRow != null)
                {
                    selectedRow = dGVJogosInacabados.CurrentRow.Index;

                    if (!(Program.M_Jogo.JogosInacabados[selectedRow].JogadorDois is Robot)) //Se não for robot, adicionamos aos users
                    {
                        User u = new User(((Pessoa)Program.M_Jogo.JogosInacabados[selectedRow].JogadorDois));
                        if (PedidoAdicionarUser != null)
                        {
                            PedidoAdicionarUser(u);
                        }
                    }

                    if (PedidoVoltarAJogo != null)
                    {
                        PedidoVoltarAJogo(Program.M_Jogo.JogosInacabados[selectedRow]);
                    }

                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Please select a game to proceed", "Invalid game", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void ViewJogosInacabados_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                if (PedidoLoadJogosInacabados != null)
                {
                    PedidoLoadJogosInacabados(Program.M_User.Users[0].Id);
                }
            }
        }
    }
}
