using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    class Challenge32
    {
        public void RunChallenge()
        {
            Console.WriteLine("       Challenge 32");
            Console.WriteLine(PowerRanger(2, 49, 65));
            Console.WriteLine(PowerRanger(3, 1, 27));
            Console.WriteLine(PowerRanger(10, 1, 5));
            Console.WriteLine(PowerRanger(5, 31, 33));
            Console.WriteLine(PowerRanger(4, 250, 1300));
        }
        public int PowerRanger(int n, int a, int b)
        {
            int powerRangerCount = 0;
            int smallestPossible = Convert.ToInt32(NthRoot(a, n));
            int largestPossible = Convert.ToInt32(NthRoot(b, n));
            int loopLength = largestPossible - smallestPossible;

            for (int i = 0; i <= loopLength; i++)
            {
                powerRangerCount++;
            }
            return powerRangerCount;
        }
        static double NthRoot(double A, int N)
        {
            return Math.Pow(A, 1.0 / N);
        }
    }
}
//Power Ranger https://edabit.com/challenge/McGCFZYn8ikn3GSqz
//Create a function that takes in n, a, b and returns the number of values raised to the nth power that lie in the range[a, b], inclusive.
//Examples
//PowerRanger(2, 49, 65) --> 2
//// 2 squares (n^2) lie between 48 and 65, 49 (7^2) and 64 (8^2)
//PowerRanger(3, 1, 27) --> 3
//// 3 cubes (n^3) lie between 1 and 27, 1 (1^3), 8 (2^3) and 27 (3^3)
//PowerRanger(10, 1, 5) --> 1
//// 1 value raised to the 10th power lies between 1 and 5, 1 (1^10)
//PowerRanger(5, 31, 33) --> 1
//PowerRanger(4, 250, 1300) --> 3
//Notes
//Remember that the range is inclusive.
//a<b will always be true.
// Steps
// Create PowerRanger method
// create a powerRangerCount int
// How many time should loop run?
// Take the square root of b and round up
// 
// Start a loop with 1 and mulitply it by itself n number of times
// If this number is >a and < b then add one to powerRangerCount
// Else continue
// 
