using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class humanPlayer : Player
    {
        public override short mark()
        {
            return value;
        }

        public override int mark(short[,] arr)
        {
            throw new NotImplementedException();
        }

        public humanPlayer(String name, short value)
        {
            this.value = value;
            this.name = name;
        }
    }
}
