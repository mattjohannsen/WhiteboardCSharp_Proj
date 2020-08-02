using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge42
    {
        public void RunChallenge()
        {
            ChallengeDescription();
            Console.WriteLine($"       AlmostPalindrome(abcdcbg) --> {AlmostPalindrome("abcdcbg")}");
            Console.WriteLine($"       AlmostPalindrome(abccia) --> {AlmostPalindrome("abccia")}");
            Console.WriteLine($"       AlmostPalindrome(abcdaaa) --> {AlmostPalindrome("abcdaaa")}");
            Console.WriteLine($"       AlmostPalindrome(1234312) --> {AlmostPalindrome("1234312")}");
        }
        public static bool AlmostPalindrome(string str)
        {
            char[] stringAsArray = str.ToCharArray();
            char[] forwardArray = str.ToCharArray();
            Array.Reverse(stringAsArray);
            int differences = 0;
            for (int i = 0; i < forwardArray.Length; i++)
            {
                if (forwardArray[i] != stringAsArray[i])
                {
                    differences++;
                }
            }
            return (differences == 2);
        }
        public void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 42: Almost Palindrome");
            Console.WriteLine("       A string is an almost-palindrome if, by changing only one character,");
            Console.WriteLine("       you can make it a palindrome.Create a function that returns true");
            Console.WriteLine("       if a string is an almost-palindrome and false otherwise.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       AlmostPalindrome('abcdcbg') --> true");
            Console.WriteLine("       Transformed to 'abcdcba' by changing 'g' to 'a'.");
            Console.WriteLine("       AlmostPalindrome('abccia') --> true");
            Console.WriteLine("       Transformed to 'abccba' by changing 'i' to 'b'.");
            Console.WriteLine("       AlmostPalindrome('abcdaaa') --> false");
            Console.WriteLine("       Can't be transformed to a palindrome in exactly 1 turn.");
            Console.WriteLine("       AlmostPalindrome('1234312') --> false");
            Console.WriteLine("       Notes");
            Console.WriteLine("       Return false if the string is already a palindrome.\n");
        }
    }
}
//Almost Palindrome https://edabit.com/challenge/t6R99zCQ7nesR7Rdk
//A string is an almost-palindrome if, by changing only one character, you can make it a palindrome.Create a function that returns true if a string is an almost-palindrome and false otherwise.
//Examples
//AlmostPalindrome('abcdcbg') --> true
// Transformed to 'abcdcba' by changing 'g' to 'a'.
//AlmostPalindrome('abccia') --> true
// Transformed to 'abccba' by changing 'i' to 'b'.
//AlmostPalindrome('abcdaaa') --> false
// Can't be transformed to a palindrome in exactly 1 turn.
//AlmostPalindrome('1234312') --> false
//Notes
//Return false if the string is already a palindrome.
// Steps
// Create stringAsArray 
// Reverse stringAsArray --> reverseArray
// create int differences = equal to 0
// start i  loop
// if stringAsrray[1] == is equal to reverseArray[i] then add 1 to differences
// if differences equals 2 then return true 
// there will be 2 differences since the difference will be noted on the front half and the back half