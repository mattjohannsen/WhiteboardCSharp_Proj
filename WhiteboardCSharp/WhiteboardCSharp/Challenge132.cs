using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge132
    {
        public static string OddishOrEvenish(int num)
        {
            //int[] arr = num.ToString().Select(n => Convert.ToInt32(n)).ToArray();
            //int arrSum = arr.Sum();
            //return (arrSum % 2 == 0) ? "Evenish" : "Oddish";
            return (num.ToString().Select(n => Convert.ToInt32(n)).ToArray().Sum() % 2 == 0) ? "Evenish" : "Oddish";
        }
    }
}
//Oddish vs.Evenish
//Create a function that determines whether a number is Oddish or Evenish.A number is Oddish if the sum of all of its digits is odd, and a number is Evenish if the sum of all of its digits is even.If a number is Oddish, return "Oddish". Otherwise, return "Evenish".

//For example, OddishOrEvenish(121) should return "Evenish", since 1 + 2 + 1 = 4. OddishOrEvenish(41) should return "Oddish", since 4 + 1 = 5.

//Examples
//OddishOrEvenish(43) ➞ "Oddish"
//// 4 + 3 = 7
//// 7 % 2 = 1

//OddishOrEvenish(373) ➞ "Oddish"
//// 3 + 7 + 3 = 13
//// 13 % 2 = 1

//OddishOrEvenish(4433) ➞ "Evenish"
//// 4 + 4 + 3 + 3 = 14
//// 14 % 2 = 0