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
        public ViewJogosInacabados()
        {
            InitializeComponent();
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
            dGVJogosInacabados.Rows.Add("Luis", "Diogo", "Local", "15/04/2019");
            dGVJogosInacabados.Rows.Add("Luis", "Carlos", "Online", "23/04/2019");
            dGVJogosInacabados.Rows.Add("Carlos", "--------", "Robot", "22/04/2019");


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
                if (dGVJogosInacabados.CurrentRow != null)
                {
                    if (dGVJogosInacabados.CurrentRow.Cells[2].Value.ToString() == "Robot")
                    {
                        this.Hide();
                        Program.V_JogoRobot.ShowDialog();
                        // Mudar o conteudo da view ---------------------------------------------------------------------------------------------------------
                    }
                    else 
                    {
                        //Local or online
                        this.Hide();
                        Program.V_JogoMultiplayer.ShowDialog();
                        // Mudar o conteudo da view ---------------------------------------------------------------------------------------------------------
                    }

                }
            }
            
        }


    }
}
