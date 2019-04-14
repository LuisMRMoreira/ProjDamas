using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Damas
{
    public partial class ViewJogo : Form
    {

        public ViewJogo()
        {
            InitializeComponent();
        }

        private void tLPTabuleiro_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if ((e.Column + e.Row) % 2 == 1)
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
            else
                e.Graphics.FillRectangle(Brushes.Black, e.CellBounds);

            
        }

        private void ViewJogo_Load(object sender, EventArgs e)
        {
            //1
            //tLPTabuleiro.
        }

        private void GenerateTable(int columnCount, int rowCount)
        {
            ////Clear out the existing controls, we are generating a new table layout
            //tLPTabuleiro.Controls.Clear();

            ////Clear out the existing row and column styles
            //tLPTabuleiro.ColumnStyles.Clear();
            //tLPTabuleiro.RowStyles.Clear();

            //Now we will generate the table, setting up the row and column counts first
            tLPTabuleiro.ColumnCount = columnCount;
            tLPTabuleiro.RowCount = rowCount;

            for (int x = 0; x < columnCount; x++)
            {
                //First add a column
                //tLPTabuleiro.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

                for (int y = 0; y < rowCount; y++)
                {
                    //Next, add a row.  Only do this when once, when creating the first column
                    //if (x == 0)
                    //{
                    //    tLPTabuleiro.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    //}

                    //Create the control, in this case we will add a button


                    //2
                    //Button cmd = new Button();
                    //Imagens
                    //cmd.Text = string.Format("({0}, {1})", x, y);         //Finally, add the control to the correct location in the table
                    //tableLayoutPanel1.Controls.Add(cmd, x, y);
                }
            }
        }

    }
}
