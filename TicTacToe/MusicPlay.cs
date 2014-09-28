using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace TicTacToe
{
    class MusicPlay
    {

        public void playIntroSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"c:\prog\Angry-Birds-Main-Theme-Song.wav");
           
                    simpleSound.PlayLooping();
        }
    }
}
