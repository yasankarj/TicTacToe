using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Player
    {
        public String name = "";
        public short value;

        public Player(String name, short value) 
        {
            this.name = name;
            this.value = value;
        }

        public short mark()
        {
            return value;
        }
    }
}
