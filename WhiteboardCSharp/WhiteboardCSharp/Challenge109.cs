using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge109
    {
        public static string FormatNum(int num)
        {
            return num.ToString("N0");
        }
    }
}
//Format Number with Comma(s) Separating Thousands
//Create a function that takes a number as an argument and returns a string formatted to separate thousands.
//Examples
//FormatNum(1000) --> "1,000"
//FormatNum(100000) --> "100,000"
//FormatNum(20) --> "20"
//Notes
//You can expect a valid number for all test cases.