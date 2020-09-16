using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge84
    {
        public static int CountOnes(int i)
        {
            return Convert.ToString(i, 2).Count(c => c == '1');
        }
    }
}
//Count Ones in Binary Representation of Integer
//Count the amount of ones in the binary representation of an integer.So for example, since 12 is '1100' in binary, the return value should be 2.
//Examples
//CountOnes(0) --> 0
//CountOnes(100) --> 3
//CountOnes(999) --> 8
//Notes
//The input will always be a valid integer(number).
// Steps
// Turn i into binary representation string
// 