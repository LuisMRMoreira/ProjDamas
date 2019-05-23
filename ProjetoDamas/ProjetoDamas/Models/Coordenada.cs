using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDamas
{
    public class Coordenada
    {//Coordenadas do jogo. A coordenada (0,0) é a 32 segundo o documento das regras da federação. e a coordenada (7,7) é a 1.
        public int x { get; private set; }
        public  int y { get; private set; }

        public Coordenada(int xVal, int yVal)
        {
            x = xVal; 
            y = yVal;
        }

    }
}
