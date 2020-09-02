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
        }
        public static bool CannotCapture(int[,] board)
        {
            return true || false;
        }
    }
}
//Knights on a Board
//Write a function that returns true if the knights are placed on a chessboard such that no knight can capture another knight.Here, 0s represent empty squares and 1s represent knights.

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