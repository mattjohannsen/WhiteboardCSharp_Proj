using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge99
    {
        public static int SumSmallest(int[] values)
        {
            Array.Sort(values);
            int value1 = 0;
            int value2 = 0;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= 0)
                {
                    value1 = values[i];
                    value2 = values[i + 1];
                    break;
                }
            }
            return value1 + value2;
        }
    }
}
//Return the Sum of the Two Smallest Numbers
//Create a function that takes an array of numbers and returns the sum of the two lowest positive numbers.
//Examples
//SumSmallest([19, 5, 42, 2, 77]) --> 7
//SumSmallest([10, 343445353, 3453445, 3453545353453]) --> 3453455
//SumSmallest([2, 9, 6, -1]) --> 8
//SumSmallest([879, 953, 694, -847, 342, 221, -91, -723, 791, -587]) --> 563
//SumSmallest([3683, 2902, 3951, -475, 1617, -2385]) --> 4519
//Notes
//Don't count negative numbers.
//Floats and empty arrays will not be used in any of the test cases.