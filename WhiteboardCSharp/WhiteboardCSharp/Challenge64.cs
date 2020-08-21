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
            char[] arr1 = str1.Reverse().ToArray();
            char[] arr2 = str2.Reverse().ToArray();
            int loopLength = Math.Min(str1.Length, str2.Length);
            for (int i = 0; i < loopLength; i++)
            {
                if (arr1[i] == '*' || arr2[i] == '*')
                {
                    continue;
                }
                else
                {
                    if (char.ToUpper(arr1[i]) != char.ToUpper(arr2[i]))
                    {
                        return false;
                    }
                }
            }
            return true;
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