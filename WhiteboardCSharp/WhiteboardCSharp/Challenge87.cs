using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge87
    {
        public static int BlockPlayer(int a, int b)
        {
            return 1;
        }
    }
}
//Block the square in Tic Tac Toe
//Create a function that returns a number which can block the player from reaching 3 in a row in a game of Tic Tac Toe.The number given as an argument will correspond to a grid of Tic Tac Toe: topleft is 0, topright is 2, bottomleft is 6, and bottomright is 8.
//Create a function that takes two numbers a, b and returns another number.
//This number should be the final one in a line to block the player from winning.
//Examples
//BlockPlayer(0, 3) --> 6
//BlockPlayer(0, 4) --> 8
//BlockPlayer(3, 5) --> 4
//Notes
//The values given will always have two filled squares in a line.
