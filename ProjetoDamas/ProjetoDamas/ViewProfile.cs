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
    public partial class ViewProfile : Form
    {
        public ViewProfile()
        {
            InitializeComponent();
        }

        private void buttonChangeProfile_Click(object sender, EventArgs e)
        {
            ViewProfileValidation pfc = new ViewProfileValidation();
            pfc.Show();
        }

        private void buttonCheckProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewProfileInfo profile = new ViewProfileInfo();  
            profile.Show();
            profile.Closed += (s, args) => this.Close();

            //ViewShowProfileInfo pfi = new ViewShowProfileInfo();
            //pfi.Show();
        }
    }
}
