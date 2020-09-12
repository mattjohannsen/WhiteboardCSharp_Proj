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
            ChallengeDescription();
            Console.WriteLine($"       SpecialReverseString(\"Edabit\") --> {SpecialReverseString("Edabit")}");
            Console.WriteLine($"       SpecialReverseString(\"UPPER lower\") --> {SpecialReverseString("UPPER lower")}");
            Console.WriteLine($"       SpecialReverseString(\"1 23 456\") --> {SpecialReverseString("1 23 456")}");
        }
        public static string SpecialReverseString(string txt)
        {
            char[] arr = txt.ToCharArray();
            string reverseTxt = new string(txt.Replace(" ", String.Empty).ToCharArray().Reverse().ToArray());
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == ' ') reverseTxt = reverseTxt.Insert(i, " ");
            }
            char[] solution = reverseTxt.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                solution[i] = (Char.IsUpper(arr[i])) ? Char.ToUpper(solution[i]) : Char.ToLower(solution[i]);
            }
            return new string(solution);
        }
        public void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 79: Reverse the String(with a catch)");
            Console.WriteLine("       Create a function that takes a string and returns the reversed string.");
            Console.WriteLine("       However there's a few rules to follow in order to make the challenge interesting:");
            Console.WriteLine("       The UPPERCASE/lowercase positions must be kept in the same order as the original string (see example #1 and #2).");
            Console.WriteLine("       Spaces must be kept in the same order as the original string (see example #3).");
            Console.WriteLine("       Examples");
            Console.WriteLine("       SpecialReverseString(\"Edabit\") --> \"Tibade\"");
            Console.WriteLine("       SpecialReverseString(\"UPPER lower\") --> \"REWOL reppu\"");
            Console.WriteLine("       SpecialReverseString(\"1 23 456\") --> \"6 54 321\"\n");
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