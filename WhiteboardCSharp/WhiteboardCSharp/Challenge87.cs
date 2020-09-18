using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge87
    {
        public void RunChallenge()
        {
            Console.WriteLine("Challenge 87");
            Console.WriteLine(BlockPlayer(0,3));
        }
        public static int BlockPlayer(int a, int b)
        {
            int[][] solutions = { new int[] { 0, 1, 2 }, new int[] { 3, 4, 5 }, new int[] { 6, 7, 8 }, new int[] { 0, 3, 6}, new int[] { 1, 4, 7 }, new int[] { 2, 5, 8 }, new int[] { 0, 4, 8 }, new int[] { 2, 4, 6 } };
            int block = 0;
            for (int i = 0; i < solutions.Length; i++)
            {
                if (solutions[i].Contains(a) && solutions[i].Contains(b))
                {
                    block = Convert.ToInt32(string.Join("", solutions[i]).Replace(a.ToString(), "").Replace(b.ToString(), ""));
                    break;
                }
            }
            return block;
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
//0	1	2
//3	4	5
//6	7	8
//0	3	6
//1	4	7
//2	5	8
//0	4	8
//2	4	6

