using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace TicTacToe
{
    class MusicPlay
    {
        private SoundPlayer sound = null;
        private static MusicPlay _obj;
        private MusicPlay()
        { 
        
        }

        public static MusicPlay getMusicPlayer()
        {
            if (_obj == null)
            {
                _obj = new MusicPlay();
            }
            return _obj;
        }

        public void playIntroSound()
        {
            sound = new SoundPlayer(@"c:\prog\Intro.wav");

            try
            {
                sound.PlayLooping();
            }
            catch (FileNotFoundException ex) { }

        }

        public void stopIntroSound()
        {
            if (sound != null)
            {
                sound.Stop();
            }

        }

        public void playGameSound()
        {
            sound = new SoundPlayer(@"c:\prog\Click.wav");

            try
            {
                sound.PlayLooping();
            }
            catch (FileNotFoundException ex) { }
        }

        public void stopGameSound()
        {
            if (sound != null)
            {
                sound.Stop();
            }

        }

        public void playConSound()
        {
            sound = new SoundPlayer(@"c:\prog\Congrats.wav");

            try
            {
                sound.Play();
            }
            catch (FileNotFoundException ex) { }

        }


    }
}
