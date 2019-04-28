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
    public partial class ViewEnd : Form
    {
        public ViewEnd()
        {
            InitializeComponent();
        }

        private void bBackMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_Menu.Show();
        }

        private void ViewEnd_Load(object sender, EventArgs e)
        {
            pCor.BackColor = Color.FromArgb(40, 0, 0, 0);
            pBJogadorPerdedor.BackColor = Color.FromArgb(40, 0, 0, 0);
            pbJogadorVencedor.BackColor = Color.FromArgb(40, 0, 0, 0);
            pInfoVencedor.BackColor = Color.FromArgb(40, 0, 0, 0);
            pPerdedor.BackColor = Color.FromArgb(40, 0, 0, 0);
            bBackMenu.BackColor = Color.FromArgb(40, 0, 0, 0);
            lGameEnded.BackColor = Color.FromArgb(40, 0, 0, 0);
            lWinner.BackColor = Color.FromArgb(40, 0, 0, 0);

        }

    }
}
