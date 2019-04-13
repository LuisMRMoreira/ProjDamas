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

        public Image Preta { get; private set; }
        public Image Branca { get; private set; }
        public Image DamaPreta { get; private set; }
        public Image DamaBranca { get; private set; }
        


        Image preta = Image.FromFile(@"C: \Users\lmr_m\Desktop\Temporario\Laboratorio\ProjDamas\Damas\Damas\bin\Debug\"+"PecaPreta.png");
        Image branca = Image.FromFile(@"C: \Users\lmr_m\Desktop\Temporario\Laboratorio\ProjDamas\Damas\Damas\bin\Debug\" + "PecaBranca.png");
        Image damaPreta = Image.FromFile(@"C: \Users\lmr_m\Desktop\Temporario\Laboratorio\ProjDamas\Damas\Damas\bin\Debug\" + "DamaPreta.png");
        Image damaBranca = Image.FromFile(@"C: \Users\lmr_m\Desktop\Temporario\Laboratorio\ProjDamas\Damas\Damas\bin\Debug\" + "DamaBranca.png");

    }
}
