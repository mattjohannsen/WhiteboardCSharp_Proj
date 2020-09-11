using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge79
    {
        public void RunChallenge()
        {
            Console.WriteLine("       Challenge 79");
            Console.WriteLine(SpecialReverseString("Edabit"));
        }
        public static string SpecialReverseString(string txt)
        {
            char[] arr = txt.ToCharArray();
            char[] reversed = txt.Trim().ToCharArray().Reverse().ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == ' ')
                {
                    char temp = arr[i];
                    reversed[i] = reversed[i + 1];
                    reversed[i + 1] = temp;
                }
                else if (Regex.IsMatch(arr[i].ToString(), "^[a-zA-Z0-9]*$"))
                {
                    if (arr[i] == Char.ToUpper(arr[i]))
                    {
                        reversed[i] = Char.ToUpper(reversed[i]);
                    }
                    else
                    {
                        reversed[i] = Char.ToLower(reversed[i]);
                    }
                }
            }
            return new string(reversed);
            //char[] arr = txt.ToCharArray();
            //bool[] spaces = new bool[arr.Length];
            //for (int i = 0; i < spaces.Length; i++)
            //{
            //    bool value = (arr[i] == ' ');
            //    spaces[i] = value;
            //}
            //bool[] upperCase = new bool[arr.Length];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    bool value = (arr[i] == Char.ToUpper(arr[i]));
            //    upperCase[i] = value;
            //}
            //char[] onlyChars = txt.Trim().ToCharArray().Reverse().ToArray();
            ////string onlyChars = new string(txt.Trim().ToCharArray().Reverse().ToArray());
            //string solution = "";
            //for (int i = 0; i < spaces.Length; i++)
            //{
            //    if (spaces[i])
            //    {
            //        solution += ' ';
            //    }
            //    else
            //    {
            //        if (upperCase[i])
            //        {
            //            solution += ' ';
            //        }
            //    }
            //}
            //return new string(solution.ToArray());
        }
    }
}
//Reverse the String(with a catch)
//Create a function that takes a string and returns the reversed string. However there's a few rules to follow in order to make the challenge interesting:
//The UPPERCASE/lowercase positions must be kept in the same order as the original string (see example #1 and #2).
//Spaces must be kept in the same order as the original string (see example #3).
//Examples
//SpecialReverseString("Edabit") --> "Tibade"
//SpecialReverseString("UPPER lower") --> "REWOL reppu"
//SpecialReverseString("1 23 456") --> "6 54 321"
// Steps
// make array upperCase;
// make array spaces;
// make array onlyChars;
// removespaces