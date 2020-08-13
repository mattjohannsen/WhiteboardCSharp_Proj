using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge56
    {
        public void RunChallenge()
        {
            Console.WriteLine("       Challenge 56");
            Console.WriteLine(CorrectSigns("3 < 7 < 11"));
            Console.WriteLine(CorrectSigns("13 > 44 > 33 > 1"));
            Console.WriteLine(CorrectSigns("1 < 2 < 6 < 9 > 3"));
            Console.WriteLine(CorrectSigns("9 < 9"));
        }
        public static bool CorrectSigns(string str)
        {
            string[] arr = str.Split(' ');
            for (int i = 0; i <= arr.Length-3; i+=2)
            {
                if (arr[i + 1] == "<" && Int32.Parse(arr[i]) >= Int32.Parse(arr[i + 2]))
                {
                    return false;
                }
                else if (arr[i + 1] == ">" && Int32.Parse(arr[i]) <= Int32.Parse(arr[i + 2]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
//Correct Inequality Signs https://edabit.com/challenge/oh2F7YH25bKe2rwmZ 18 minutes
//Create a function that returns true if a given inequality expression is correct and false otherwise.
//Examples
//CorrectSigns("3 < 7 < 11") --> true
//CorrectSigns("13 > 44 > 33 > 1") --> false
//CorrectSigns("1 < 2 < 6 < 9 > 3") --> true
// Steps
// split str into an array => arr
// loop through arr.Length - 3 times
// if i % 2
// int leftNumber = arr[i]
// int rightNumber = arr[i+2]
// if arr[i+1] == "<" && arr[i] >= arr[i+2]
// return false;
// else if (arr[i+1] == ">" && arr[i] <= arr[i+2])
// return false;

