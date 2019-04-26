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
    public partial class ViewSettings : Form
    {

        bool valoresAlterados = false;

        public event MetodosComDoisParametros PedidoGuardarDados;


        public ViewSettings()
        {
            InitializeComponent();
            Program.M_Gestor.RespostaDadosGuardados += M_Gestor_RespostaDadosGuardados;
        }

        private void M_Gestor_RespostaDadosGuardados()
        {
            this.Hide();
            Program.V_Menu.Show();
        }




        private void nUDVolumeLevel_ValueChanged(object sender, EventArgs e)
        {
            valoresAlterados = true;
        }

        private void cBWindowSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            valoresAlterados = true;
        }

        private void pBReturn_Click(object sender, EventArgs e)
        {
            if (valoresAlterados)//Se algum valor tiver mudado
            {
                if (MessageBox.Show("Do you want to save the changes?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (PedidoGuardarDados != null)
                    {
                        PedidoGuardarDados(Convert.ToInt32(nUDVolumeLevel.Value), cBWindowSize.SelectedText);
                    }
                }
            }

            this.Hide();
            Program.V_Menu.Show();
            

        }
    }
}
