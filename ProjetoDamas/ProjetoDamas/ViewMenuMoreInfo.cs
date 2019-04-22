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
    public partial class ViewMenuMoreInfo : Form
    {
        public ViewMenuMoreInfo()
        {
            InitializeComponent();
        }

        private void bRegras_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewRegras option_regras = new ViewRegras();
            option_regras.Closed += (s, args) => this.Close();
            option_regras.Show();
        }

        private void bRanks_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewRank rank = new ViewRank();
            rank.Closed += (s, args) => this.Close();
            rank.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("You sure you wanna leave the regist?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            this.Hide();
            ViewMenu menu = new ViewMenu();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
           //}
        }

        private void bHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewHistory hist = new ViewHistory();
            hist.Closed += (s, args) => this.Close();
            hist.Show();
        }

        private void bSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewSettings set = new ViewSettings();
            set.Closed += (s, args) => this.Close();
            set.Show();
        }
    }
}
