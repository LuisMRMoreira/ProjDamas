using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace ProjetoDamas
{
    public class PlayMusic
    {

        public PlayMusic()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\lmr_m\Desktop\Temporario\Laboratorio\ProjDamas\ProjetoDamas\ProjetoDamas\Resources\Minecraft Background Music.mp3";
            player.Play();
        }
        




    }
}
