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
            Console.WriteLine(SpecialReverseString("UPPER lower"));
            Console.WriteLine(SpecialReverseString("1 23 456")); // 6 54 321
            Console.WriteLine(SpecialReverseString("Hello World!"));
            Console.WriteLine(SpecialReverseString("Where's your dog Daisy?"));
            //Console.WriteLine(SpecialReverseString("addition(3, 2) = 5"));
        }
        public static string SpecialReverseString(string txt)
        {
            char[] arr = txt.ToCharArray();
            string noSpaceString = txt.Replace(" ", String.Empty);
            char[] noSpaceArray = noSpaceString.ToCharArray();
            char[] reverseNoSpaceArray = noSpaceArray.Reverse().ToArray();
            string reversedString = new string(reverseNoSpaceArray);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == ' ')
                {
                    reversedString = reversedString.Insert(i, " ");
                }
            }
            char[] solution = reversedString.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (Char.IsUpper(arr[i]) && Regex.IsMatch(arr[i].ToString(), "^[a-zA-Z]*$"))
                {
                    solution[i] = Char.ToUpper(solution[i]);
                }
                else
                {
                    solution[i] = Char.ToLower(solution[i]);
                }
            }
            return reversedString;
            //for (int i = arr.Length - 1; i > 0; i--)
            //{
            //    // reversed[i] is of type space
            //    if (reversed[i] == ' ' && arr[i] != ' ')
            //    {
            //        char temp = (arr[i - 1] == Char.ToUpper(arr[i - 1])) ? Char.ToUpper(reversed[i - 1]) : Char.ToLower(reversed[i - 1]);
            //        char behindChar = (arr[i - 1] == Char.ToUpper(arr[i - 1])) ? Char.ToUpper(reversed[i]) : Char.ToLower(reversed[i]);
            //        reversed[i - 1] = behindChar;
            //        reversed[i] = temp;
            //    }
            //    else if (Regex.IsMatch(arr[i].ToString(), "^[a-zA-Z0-9]*$"))
            //    {
            //        if (arr[i] == Char.ToUpper(arr[i]))
            //        {
            //            reversed[i] = Char.ToUpper(reversed[i]);
            //        }
            //        else
            //        {
            //            reversed[i] = Char.ToLower(reversed[i]);
            //        }
            //        if (i == 1)
            //        {
            //            reversed[i - 1] = (arr[i - 1] == Char.ToUpper(arr[i - 1])) ? Char.ToUpper(reversed[i -1]) : Char.ToLower(reversed[i - 1]);
            //        }
            //    }
            //    else if (Regex.IsMatch(arr[i].ToString(), @"\W|_"))
            //    {
            //        reversed[i] = Char.ToLower(reversed[i]);
            //    }
            //    else
            //    {
            //        reversed[i] = Char.ToLower(reversed[i]);
            //        if (i == 1)
            //        {
            //            if (Regex.IsMatch(reversed[i - 1].ToString(), "^[a-zA-Z0-9]*$"))
            //            {
            //                reversed[i - 1] = (arr[i - 1] == Char.ToUpper(arr[i - 1])) ? Char.ToUpper(reversed[i - 1]) : Char.ToLower(reversed[i - 1]);
            //            }
            //            else
            //            {
            //                reversed[i - 1] = Char.ToLower(reversed[i - 1]);
            //            }

            //        }
            //    }
            //}
            //return new string(reversed);

            //char[] arr = txt.ToCharArray();
            //char[] reversed = txt.Trim().ToCharArray().Reverse().ToArray();
            //for (int i = arr.Length -1; i > 0; i--)
            //{
            //if (reversed[i] == ' ' && arr[i] == ' ')
            //{
            //    continue;
            //}
            //else if (reversed[i] == ' ' && arr[i] != ' ')
            //    {
            //        char temp = reversed[i];
            //        //(Regex.IsMatch(arr[i].ToString(), "^[a-zA-Z]*$")
            //        reversed[i] = (arr[i - 1] == Char.ToUpper(arr[i - 1])) ? Char.ToUpper(reversed[i - 1]) : Char.ToLower(reversed[i - 1]);
            //        reversed[i - 1] = (arr[i] == Char.ToUpper(arr[i])) ? reversed[i - 1] = Char.ToUpper(temp) : reversed[i - 1] = Char.ToLower(temp);
            //        //if (arr[i - 1] == Char.ToUpper(arr[i - 1]))
            //        //{
            //        //    reversed[i] = Char.ToUpper(reversed[i - 1]);
            //        //}
            //        //else
            //        //{
            //        //    reversed[i] = Char.ToLower(reversed[i - 1]);
            //        //}
            //        if (arr[i] == Char.ToUpper(arr[i]))
            //        {
            //            reversed[i - 1] = Char.ToUpper(temp);
            //        }
            //        else
            //        {
            //            reversed[i - 1] = Char.ToLower(temp);
            //        }
            //    }
            //    else if (Regex.IsMatch(arr[i].ToString(), "^[a-zA-Z]*$"))
            //    {
            //        if (arr[i] == Char.ToUpper(arr[i]))
            //        {
            //            reversed[i] = Char.ToUpper(reversed[i]);
            //        }
            //        else
            //        {
            //            reversed[i] = Char.ToLower(reversed[i]);
            //        }
            //    }
            //}
            //return new string(reversed);
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