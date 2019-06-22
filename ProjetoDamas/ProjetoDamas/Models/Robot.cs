using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDamas
{
    public class Robot : Jogador
    {//Classe derivada de JOgador que representa um jogador standalone. 
     //INFO: Era necessario uma diferenciação entre os jogadores destes tipos, uma vez que um robot não necessita de nosse, username,....
        public string Imagem { get; private set; }
        
        public Robot(bool cor, bool prior) : base(cor, prior)
        {
            var folder = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\Resources");
            Imagem = folder+ "Robot Image.png";
        }
        

    }
}
