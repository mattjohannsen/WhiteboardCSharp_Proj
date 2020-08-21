using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge64
    {
        public void RunChallenge()
        {
            Console.WriteLine("       Challenge 64");
            Console.WriteLine($"       Overlap(ABC, Ican'tsingmyABC) ==> {Overlap("ABC", "Ican'tsingmyABC")}");
            Console.WriteLine($"       Overlap(abc, Ican'tsingmyABC) ==> {Overlap("abc", "Ican'tsingmyABC")}");
            Console.WriteLine($"       Overlap(Ican'tsingmyABC, abc) ==> {Overlap("Ican'tsingmyABC", "abc")}");
            Console.WriteLine($"       Overlap(hello world, hello) ==> {Overlap("hello world", "hello")}");
            Console.WriteLine($"       Overlap(+=, this should work too +=) ==> {Overlap("+=", "this should work too +=")}");
            Console.WriteLine($"       Overlap(hey, *********) ==> {Overlap("hey", "*********")}");
            Console.WriteLine($"       Overlap(a*c, *b* ==> {Overlap("a*c", "*b*")}"); //true
        }
        public static bool Overlap(string str1, string str2)
        {
            int lengthCheck = Math.Min(str1.Length, str2.Length);
            string str1End = GetStringEnd(lengthCheck, str1);
            string str2End = GetStringEnd(lengthCheck, str2);
            if (str1End.Contains("*") || (str2End.Contains("*")))
            {
                char[] arr1 = str1End.ToCharArray();
                char[] arr2 = str2End.ToCharArray();
                char[] string1Array = str1.ToCharArray();
                char[] string2Array = str2.ToCharArray();
                for (int i = 0; i < arr2.Length; i++)
                {
                    if (arr1[i] == '*')
                    {
                        string2Array[string2Array.Length - arr1.Length + i] = '*';
                            arr2[i] = '*';
                        }
                    else if (arr2[i] == '*')
                    {
                        string1Array[string1Array.Length - arr2.Length + i] = '*';
                            arr1[i] = '*';
                    }
                }
                str1End = new string(arr1);
                str2End = new string(arr2);
                str1 = new string(string1Array);
                str2 = new string(string2Array);
            }
            return (str1.ToUpper().EndsWith(str2End.ToUpper()) || str2.ToUpper().EndsWith(str1End.ToUpper()));
        }
        public static string GetStringEnd(int strLength, string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            string returnString = "";
            for (int j = 0; j < strLength; j++)
            {
                returnString += arr[j];
            }
            return new string(returnString.Reverse().ToArray());
        }
    }
}
//Is One String in the Other?
//Create a function that takes two strings and returns true if either of the strings appears at the very end of the other string. Return false otherwise.The character * is a wildcard, so it can take the place of any character.
//Examples
//Overlap("ABC", "Ican'tsingmyABC") --> true
//Overlap("abc", "Ican'tsingmyABC") --> true
//Overlap("Ican'tsingmyABC", "abc") --> true
//Overlap("hello world", "hello") --> false
//Overlap("+=", "this should work too +=") --> true
//Overlap("hey", "*********") --> true
//Notes
//Your function should NOT be case sensitive(see example #2).