using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class timeStamp
    {
        
        private String hr = "";
        private String min = "";
        private String sec = "";
        private String timeString = "";
        private long t;


        public timeStamp(long t)
        {
            // TODO: Complete member initialization
            this.t = t;
            hr = "" + (t / 3600);
            t %= 3600;
            min = "" + (t / 60);
            t %= 60;
            sec = "" + t;
            timeString = hr + " : " + min + " : " + sec;
        }

        public String show()
        {
            return timeString;
        }
    }
}
