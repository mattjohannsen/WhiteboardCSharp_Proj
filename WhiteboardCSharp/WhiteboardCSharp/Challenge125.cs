using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge125
    {
        public static bool IsPalindrome(string str)
        {
            str = Regex.Replace(str.ToLower(), @"[^\w]", "");
            return str.SequenceEqual(str.Reverse());
        }
    }
}
//Check if the String is a Palindrome
//A palindrome is a word, phrase, number or other sequence of characters which reads the same backward or forward, such as madam or kayak.

//Write a function that takes a string and determines whether it's a palindrome or not. The function should return a boolean (true or false value).

//Examples
//IsPalindrome("Neuquen") ➞ true

//IsPalindrome("Not a palindrome") ➞ false

//IsPalindrome("A man, a plan, a cat, a ham, a yak, a yam, a hat, a canal-Panama!") ➞ true
//Notes
//Should be case insensitive.
//Special characters(punctuation or spaces) should be ignored.