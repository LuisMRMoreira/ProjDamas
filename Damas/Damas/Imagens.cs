using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Damas
{



    public class Imagens
    {

        //public Image Preta { get; private set; }
        //public Image Branca { get; private set; }
        //public Image DamaPreta { get; private set; }
        //public Image DamaBranca { get; private set; }

        ////Preta = Image.FromFile(@"C: \Users\lmr_m\Desktop\Temporario\Laboratorio\ProjDamas\Damas\Damas\bin\Debug\"+"PecaPreta.png");
        //Image branca = Image.FromFile(@"C: \Users\lmr_m\Desktop\Temporario\Laboratorio\ProjDamas\Damas\Damas\bin\Debug\" + "PecaBranca.png");
        //Image damaPreta = Image.FromFile(@"C: \Users\lmr_m\Desktop\Temporario\Laboratorio\ProjDamas\Damas\Damas\bin\Debug\" + "DamaPreta.png");
        //Image damaBranca = Image.FromFile(@"C: \Users\lmr_m\Desktop\Temporario\Laboratorio\ProjDamas\Damas\Damas\bin\Debug\" + "DamaBranca.png");



        public Bitmap Preta { get; private set; }
        public Bitmap Branca { get; private set; }
        public Bitmap DamaPreta { get; private set; }
        public Bitmap DamaBranca { get; private set; }

        public Imagens()
        {
            Preta = new Bitmap(@"C: \Users\lmr_m\Desktop\Temporario\Laboratorio\ProjDamas\Damas\Damas\bin\Debug\" + "PecaPreta.png");
            Branca = new Bitmap(@"C: \Users\lmr_m\Desktop\Temporario\Laboratorio\ProjDamas\Damas\Damas\bin\Debug\" + "PecaBranca.png");
            DamaPreta = new Bitmap(@"C: \Users\lmr_m\Desktop\Temporario\Laboratorio\ProjDamas\Damas\Damas\bin\Debug\" + "DamaPreta.png");
            DamaBranca = new Bitmap(@"C: \Users\lmr_m\Desktop\Temporario\Laboratorio\ProjDamas\Damas\Damas\bin\Debug\" + "DamaBranca.png");
        }



    }
}
