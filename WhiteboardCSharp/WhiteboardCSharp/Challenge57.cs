using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge57
    {
        public void RunChallenge()
        {
            ChallengeDescription();
            Console.WriteLine($"       PossiblePalindrome(acabbaa) --> {PossiblePalindrome("acabbaa")}");
            Console.WriteLine($"       PossiblePalindrome(aacbdbc) --> {PossiblePalindrome("aacbdbc")}");
            Console.WriteLine($"       PossiblePalindrome(aacbdb) --> {PossiblePalindrome("aacbdb")}");
            Console.WriteLine($"       PossiblePalindrome(abacbb) --> {PossiblePalindrome("abacbb")}");
        }
        public static bool PossiblePalindrome(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Sort(arr);
            Dictionary<char, int> charFrequency = new Dictionary<char, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (charFrequency.ContainsKey(arr[i]))
                {
                    charFrequency[arr[i]] ++;
                }
                else
                {
                    charFrequency.Add(arr[i], 1);
                }
            }
            int oddCount = 0;
            foreach (KeyValuePair<char, int> character in charFrequency)
            {
                if (character.Value % 2 != 0)
                {
                    oddCount++;
                }
            }
            return oddCount < 2;
        }
        public void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 57: Possible Palindrome");
            Console.WriteLine("       Create a function that determines whether it is possible to build a palindrome from the characters in a string.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       PossiblePalindrome(acabbaa) --> true");
            Console.WriteLine("       Can make the following palindrome: aabcbaa");
            Console.WriteLine("       PossiblePalindrome(aacbdbc) --> true");
            Console.WriteLine("       Can make the following palindrome: abcdcba");
            Console.WriteLine("       PossiblePalindrome(aacbdb) --> false");
            Console.WriteLine("       PossiblePalindrome(abacbb) --> false\n");
        }
    }
}
//Possible Palindrome
//Create a function that determines whether it is possible to build a palindrome from the characters in a string.
//Examples
//PossiblePalindrome("acabbaa") --> true
//// Can make the following palindrome: "aabcbaa"
//PossiblePalindrome("aacbdbc") --> true
//// Can make the following palindrome: "abcdcba"
//PossiblePalindrome("aacbdb") --> false
//PossiblePalindrome("abacbb") --> false