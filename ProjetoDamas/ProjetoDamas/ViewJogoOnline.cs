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
    public partial class ViewJogoOnline : Form
    {

        public PictureBox[,] PictureBoxDoPanel;
        PictureBox selected;

        public ViewJogoOnline()//attache image to cursor
        {
            InitializeComponent();
            PictureBoxDoPanel = new PictureBox[8, 4] { { pB00, pB20, pB40, pB60 },
                                                       { pB11, pB31, pB51, pB71 },
                                                       { pB02, pB22, pB42, pB62 },
                                                       { pB13, pB33, pB53, pB73 },
                                                       { pB04, pB24, pB44, pB64 },
                                                       { pB15, pB35, pB55, pB75 },
                                                       { pB06, pB26, pB46, pB66 },
                                                       { pB17, pB37, pB57, pB77 }};

            foreach (var box in PictureBoxDoPanel)
            {
                box.AllowDrop = true;
                box.DragDrop += PictureBox_DragDrop;
                box.DragEnter += PictureBox_DragEnter;
                box.MouseClick += PictureBox_MouseClick;
                box.MouseMove += PictureBox_MouseMove;
                //box.Paint += PictureBox_Paint;
            }

            GerarPecasNoTabuleiro(false);

        }





        private void PictureBox_DragDrop(object sender, DragEventArgs e)
        {
            var target = (PictureBox)sender;
            var source = (PictureBox)e.Data.GetData(typeof(PictureBox));
            
            if (target.Image == null && MoveLengthVality(PictureBoxDoPanel, source, target))
            {
                if (e.Data.GetDataPresent(typeof(PictureBox)))
                {
                    
                    if (source != target)
                    {
                        Console.WriteLine("Do DragDrop from " + source.Name + " to " + target.Name);
                        // You can swap the images out, replace the target image, etc.

                        SwapImages(source, target);
                        


                        selected = null;
                        SelectBox(target);
                        return;
                    }
                }
            }
            Console.WriteLine("Don't do DragDrop");
        }
        
        private void PictureBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        
        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            SelectBox((PictureBox)sender);
        }
        
        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left )
            {
                var pb = (PictureBox)sender;
                if (pb.Image != null) //<---
                {
                    pb.DoDragDrop(pb, DragDropEffects.Move);                    

                }
            }
            
        }
        
        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            var pb = (PictureBox)sender;
            pb.BackColor = Color.Transparent;
            if (selected == pb)
            {
                ControlPaint.DrawBorder(e.Graphics, pb.ClientRectangle,
                   Color.Blue, 5, ButtonBorderStyle.Solid,  // Left
                   Color.Blue, 5, ButtonBorderStyle.Solid,  // Top
                   Color.Blue, 5, ButtonBorderStyle.Solid,  // Right
                   Color.Blue, 5, ButtonBorderStyle.Solid); // Bottom
            }
        }
        
        private void SelectBox(PictureBox pb)
        {
            if (selected != pb)
            {
                selected = pb;
            }
            else
            {
                selected = null;
            }

            // Cause each box to repaint
            foreach (var box in PictureBoxDoPanel) box.Invalidate();
        }

        private void SwapImages(PictureBox source, PictureBox target)
        {
            if (source.Image == null && target.Image == null) //<---
            {
                return;
            }

            var temp = target.Image; //<---
            target.Image = source.Image;//<----
            source.Image = temp;//<---
        }
        
        private void tLPTabuleiro_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if ((e.Column + e.Row) % 2 == 1)
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
            else
                e.Graphics.FillRectangle(Brushes.Black, e.CellBounds);

            ControlPaint.DrawBorder(e.Graphics, e.CellBounds,
                   Color.SaddleBrown, 2, ButtonBorderStyle.Solid,  // Left
                   Color.SaddleBrown, 2, ButtonBorderStyle.Solid,  // Top
                   Color.SaddleBrown, 2, ButtonBorderStyle.Solid,  // Right
                   Color.SaddleBrown, 2, ButtonBorderStyle.Solid); // Bottom

        }


        private void GerarPecasNoTabuleiro(bool corCima)
        {
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    if (corCima) //0 branco, 1 preto
                    {
                        if (x < 3)
                        {
                            PictureBoxDoPanel[x,y].Image = Properties.Resources.PecaPreta;
                            PictureBoxDoPanel[x,y].BringToFront();
                        }
                        else if (x >= 5)
                        {
                            //meter a outra côr
                            PictureBoxDoPanel[x, y].Image = Properties.Resources.PecaBranca;// Image.FromFile("PecaBranca.png");
                            PictureBoxDoPanel[x,y].BringToFront();
                        }
                    }
                    else
                    {

                        if (x < 3)
                        {
                            PictureBoxDoPanel[x, y].Image = Properties.Resources.PecaBranca;
                            PictureBoxDoPanel[x, y].BringToFront();
                        }
                        else if (x >= 5)
                        {
                            //meter a outra côr
                            PictureBoxDoPanel[x, y].Image = Properties.Resources.PecaPreta;                            
                            PictureBoxDoPanel[x, y].BringToFront();
                        }
                    }

                }
            }
        }


        private bool MoveLengthVality(PictureBox[,] matrix, PictureBox source, PictureBox target)
        {

            Point indexSource = new Point();
            Point indexTarget = new Point(); ;

            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    if (matrix[y, x] == source)
                    {
                        indexSource.X = x;
                        indexSource.Y = y;
                    }
                    else if(matrix[y, x] == target)
                    {
                        indexTarget.X = x;
                        indexTarget.Y = y;
                    }
                }
            }


            if (!(Math.Abs(indexSource.X - indexTarget.X) <=1 && Math.Abs(indexSource.Y - indexTarget.Y) == 1))
            {
                return false;
            }

            return true;

        }

        private void pbJogador1_MouseHover(object sender, EventArgs e)
        {
            lNome.Visible = true;
            lNomeN.Visible = true;

            lCountry.Visible = true;
            lCountryN.Visible = true;

            lVitorias.Visible = true;
            lVitoriasN.Visible = true;
        }

        private void pbJogador1_MouseLeave(object sender, EventArgs e)
        {
            lNome.Visible = false;
            lNomeN.Visible = false;

            lCountry.Visible = false;
            lCountryN.Visible = false;

            lVitorias.Visible = false;
            lVitoriasN.Visible = false;
        }

        private void pbJogador2_MouseHover(object sender, EventArgs e)
        {
            lNome2.Visible = true;
            lNomeN2.Visible = true;

            lCountry2.Visible = true;
            lCountryN2.Visible = true;

            lVitorias2.Visible = true;
            lVitoriasN2.Visible = true;
        }

        private void pbJogador2_MouseLeave(object sender, EventArgs e)
        {
            lNome2.Visible = false;
            lNomeN2.Visible = false;

            lCountry2.Visible = false;
            lCountryN2.Visible = false;

            lVitorias2.Visible = false;
            lVitoriasN2.Visible = false;
        }

        private void definiçõesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewSettings set = new ViewSettings();
            set.Closed += (s, args) => this.Close();
            set.Show();
        }

        private void regrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewRegras reg = new ViewRegras();
            reg.Closed += (s, args) => this.Close();
            reg.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wanna leave without save?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

            }

            this.Close();//?????????
        }








        //private Point firstPoint = new Point();
        //public void MovingPiece(PictureBox im)
        //{
        //    im.MouseDown += (ss, ee) =>
        //    {
        //        if (ee.Button == System.Windows.Forms.MouseButtons.Left) { firstPoint = Control.MousePosition; }

        //    };

        //    im.MouseMove += (ss, ee) =>
        //    {
        //        if (ee.Button == System.Windows.Forms.MouseButtons.Left)
        //        {
        //            Point temp = Control.MousePosition;
        //            Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

        //            im.Location = new Point(im.Location.X - res.X, im.Location.Y - res.Y);

        //            firstPoint = temp;
        //        }

        //    };


        //}

    }
}
