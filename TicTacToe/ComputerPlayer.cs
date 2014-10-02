using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class ComputerPlayer : Player
    {
        public ComputerPlayer()
        {
            this.name = "COM";
            this.value = -1;
        }

        public override short mark()
        {
            throw new NotImplementedException();
        }

        public override int mark(short[,] arr)
        {
            int x = -1;
            for(int i =0;i<3;i++)
            {
                for (int j = 0; j < 3;j++ )
                {
                    if (arr[i, j] == 0)
                    {
                        return 3 * i + j + 1;
                        /*හසන්ගී. මේක තමා ඔයාට වෙනස් කරන්න තියෙන්නේ. මම මේ කෝඩ් එක හරිද කියල බලන්න තමයි මේක ගැහුවේ
                         *ඔයා මේක හොදම විදියට හදන්න
                         *2d array එකේ 1 කියන්නේ  humanPlayer mark කළා කියන එක.
                         *0 කියන්නේ කවුරැවත් මාක් කරල නෑ කියන එක
                         *-1 කියන්නේ computer player mark කළා කියන එක
                         */
                    }
                    
                }
            }
            return x;
        }
    }
}
