using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge98
    {
        public static string HighLow(string str)
        {
            int[] arr = Array.ConvertAll(str.Split(' '), s => int.Parse(s));
            int[] solution = new int[] { arr.Max(), arr.Min() };
            return string.Join(" ", solution);
        }
    }
}
//Return the Highest and Lowest Numbers
//Create a function that accepts a string of space separated numbers and returns the highest and lowest number(as a string).
//Examples
//HighLow("1 2 3 4 5") --> "5 1"
//HighLow("1 2 -3 4 5") --> "5 -3"
//HighLow("1 9 3 4 -5") --> "9 -5"
//HighLow("13") --> "13 13"
//Notes
//All numbers are valid Int32, no need to validate them.
//There will always be at least one number in the input string.
//Output string must be two numbers separated by a single space, and highest number is first.