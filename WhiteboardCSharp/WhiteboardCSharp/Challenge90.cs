using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge90
    {
        public static int StackBoxes(int n)
        {
            return Convert.ToInt32(Math.Pow(n, 2));
        }
    }
}
//Stack the Boxes https://edabit.com/challenge/h2BGWkeBcoiW2tSXX
//Here's an image of four models. Some of the cubes are hidden behind other cubes. Model one consists of one cube. Model two consists of four cubes, and so on...
//Stack the Boxes
//Write a function that takes a number n and returns the number of stacked boxes in a model n levels high, visible and invisible.
//Examples
//StackBoxes(1) --> 1
//StackBoxes(2) --> 4
//StackBoxes(0) --> 0
//Notes
//Step n is a positive integer.