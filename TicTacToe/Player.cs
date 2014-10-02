using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    abstract class Player
    {
        public String name = "";
        public short value;

        abstract public short mark();
        abstract public int mark(short [,] arr);
        /*public Player(String name, short value) 
        {
            this.name = name;
            this.value = value;
        }*/

        /*public short mark()
        {
            return value;
        }*/
    }
}
