using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge72
    {
        public void RunChallenge()
        {
            Console.WriteLine("       Challenge 72");
            Console.WriteLine($"        {CannotCapture(new int[,] { { 0, 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 1, 0, 1, 0 }, { 0, 1, 0, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 1, 0, 0, 0 } })}");
            Console.WriteLine($"        {CannotCapture(new int[,] { { 1, 0, 1, 0, 1, 0, 1, 0 }, { 0, 1, 0, 1, 0, 1, 0, 1 }, { 1, 0, 1, 0, 1, 0, 1, 0 }, { 0, 0, 0, 1, 0, 1, 0, 1 }, { 1, 0, 0, 0, 1, 0, 1, 0 }, { 0, 0, 0, 0, 0, 1, 0, 1 }, { 1, 0, 1, 0, 1, 0, 1, 0 }, { 1, 0, 0, 1, 0, 0, 0, 1 } })}");
        }
        public static bool CannotCapture(int[,] board)
        {
            int[] horizontalmoves = new int[8] { 2, 2, -2, -2, 1, 1, - 1, -1 };
            int[] verticalmoves = new int[8] { 1, -1, 1, -1, 2, -2, 2, -2 };
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == 1)
                    {
                        for (int k = 0; k < horizontalmoves.Length; k++)
                        {
                            int row = i + verticalmoves[k];
                            int column = j + horizontalmoves[k];
                            if (row < 0 || row > 7 || column < 0 || column > 7)
                            {
                                continue;
                            }
                            else
                            {
                                int boardValue = board[row, column];
                                if (boardValue == 1)
                                {
                                    return false;
                                }
                            }
                        }
                    }
                }
            }
            return true;
        }
    }
}
//Knights on a Board
//Write a function that returns true if the knights are placed on a chessboard such that no 
//knight can capture another knight.Here, 0s represent empty squares and 1s represent knights.

//Examples
//CannotCapture(new int[,] {
//  { 0, 0, 0, 1, 0, 0, 0, 0 },
//  { 0, 0, 0, 0, 0, 0, 0, 0 },
//  { 0, 1, 0, 0, 0, 1, 0, 0 },
//  { 0, 0, 0, 0, 1, 0, 1, 0 },
//  { 0, 1, 0, 0, 0, 1, 0, 0 },
//  { 0, 0, 0, 0, 0, 0, 0, 0 },
//  { 0, 1, 0, 0, 0, 0, 0, 1 },
//  { 0, 0, 0, 0, 1, 0, 0, 0 }
//}) ➞ True

//CannotCapture(new int[,] {
//  {1, 0, 1, 0, 1, 0, 1, 0},
//  {0, 1, 0, 1, 0, 1, 0, 1},
//  {1, 0, 1, 0, 1, 0, 1, 0},
//  {0, 0, 0, 1, 0, 1, 0, 1},
//  {1, 0, 0, 0, 1, 0, 1, 0},
//  {0, 0, 0, 0, 0, 1, 0, 1},
//  {1, 0, 1, 0, 1, 0, 1, 0},
//  {1, 0, 0, 1, 0, 0, 0, 1} 
//}) ➞ False
//Notes
//Knights can be present in any of the 64 squares.
//No other pieces except knights exist.
// Steps
// There are 8 arrays that are 8 long
// if knight at arr[0][0] then possible moves are[2][1],[2][-1],[-2][1],[-2][-1], [1][2],[1][-2],[-1][2],[-1][-2]