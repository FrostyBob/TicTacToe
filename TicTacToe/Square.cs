using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Square
    {
        private int locX;
        private int locY;
        private char State;

        Square(int aLocX, int aLocY, char aState = 'N')
        {
            locX = aLocX;
            locY = aLocY;
            State = aState;
        }
       
    }
}
