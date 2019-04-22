﻿using System;
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

        private void bLeave_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewMenu menu = new ViewMenu();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }

        private void pbReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewMenu menu = new ViewMenu();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }
    }
}
