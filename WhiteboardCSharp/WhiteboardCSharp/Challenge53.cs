using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge53
    {
        public void RunChallenge()
        {
            Console.WriteLine("       Challenge 53");
            Console.WriteLine(Trouble(451999277, 41177722899)); // true
            Console.WriteLine(Trouble(1222345, 12345)); // false
            Console.WriteLine(Trouble(666789, 12345667)); // true
            Console.WriteLine(Trouble(33789, 12345337)); // false
            Console.WriteLine(Trouble(10560002, 100)); // true
            Console.WriteLine(Trouble(888, 888)); // true
        }

        public static bool Trouble(long num1, long num2)
        {
            string searchString = $"{num1},{num2}";
            return Regex.IsMatch(searchString, @"\d*(\d)\1{2}\d*,\d*\1{2}\d*");
            //char[] arrayOne = num1.ToString().ToCharArray(); // Matt's Original Solution
            //char[] arrayTwo = num2.ToString().ToCharArray();
            //var dictOne = new Dictionary<char, int>();
            //var dictTwo = new Dictionary<char, int>();
            //foreach (var item in arrayOne)
            //{
            //    if (dictOne.ContainsKey(item))
            //    {
            //        dictOne[item]++;
            //    }
            //    else
            //    {
            //        dictOne[item] = 1;
            //    }
            //}
            //foreach (var item in arrayTwo)
            //{
            //    if (dictTwo.ContainsKey(item))
            //    {
            //        dictTwo[item]++;
            //    }
            //    else
            //    {
            //        dictTwo[item] = 1;
            //    }
            //}
            //var triplesArray = dictOne.Where(pair => pair.Value >= 3).Select(pair => pair.Key).ToArray();
            //var doublesArray = dictTwo.Where(pair => pair.Value >= 2).Select(pair => pair.Key).ToArray();
            //return triplesArray.Intersect(doublesArray).Any();
        }
    }
}
//Triple + Double = So Much Trouble https://edabit.com/challenge/Pf2mK8M6Av6RFcmtY
//Create a function that takes two integers and returns true if a number repeats three times
//in a row at any place in num1 AND that same number repeats two times in a row in num2.
//Examples
//Trouble(451999277, 41177722899) --> true
//Trouble(1222345, 12345) --> false
//Trouble(666789, 12345667) --> true
//Trouble(33789, 12345337) --> false
//Notes
//You can expect every test case to contain exactly two integers.
