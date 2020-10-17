using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge116
    {
        public static bool CheckPerfect(int num)
        {
            return Enumerable.Range(1, num - 1).Where(i => (num % i) == 0).Sum() == num;
            //int sum = 0; //<--- Best solution
            //for (int i = 1; i < num; i++)
            //{
            //    if (num % i == 0)
            //    {
            //        sum += i;
            //    }
            //}
            //return sum == num;
        }
    }
}
//Perfect Number https://edabit.com/challenge/5B4jvew2NvzKhfcQv
//Create a function that tests whether or not an integer is a perfect number.
//A perfect number is a number that can be written as the sum of its factors, (equal to sum of its proper divisors) excluding the number itself.

//For example, 6 is a perfect number, since 1 + 2 + 3 = 6, where 1, 2, and 3 are all factors of 6. Similarly, 28 is a perfect number, since 1 + 2 + 4 + 7 + 14 = 28.