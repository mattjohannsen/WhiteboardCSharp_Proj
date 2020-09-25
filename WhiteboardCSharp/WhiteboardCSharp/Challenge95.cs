using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge95
    {
        public static bool IsPalindrome(int num)
        {
            if (num < 0)
            {
                return false;
            }
            return (num == ReverseNumber(num));
        }
        public static int ReverseNumber(int num)
        {
            int reversed = 0;
            while (num > 0)
            {
                reversed = (reversed * 10) + (num % 10);
                num /= 10;
            }
            return reversed;
        }
    }
}
//Check if a Number is a Palindrome
//Create a function that returns true if a number is a palindrome.
//Examples
//IsPalindrome(838) --> true
//IsPalindrome(4433) --> false
//IsPalindrome(443344) --> true
//Notes
//A palindrome is a number that remains the same when reversed.
//Bonus: Try solving this without turning the number into a string.
// Steps
// 