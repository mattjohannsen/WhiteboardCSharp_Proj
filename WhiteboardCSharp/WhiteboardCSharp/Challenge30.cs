using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    class Challenge30
    {
        public void RunChallenge()
        {
            Console.WriteLine("       Challenge 30");
            Console.WriteLine(ReverseAndNot(123));
            Console.WriteLine(ReverseAndNot(152));
            Console.WriteLine(ReverseAndNot(123456789));
        }
        public string ReverseAndNot(int i)
        {
            string originalString = i.ToString();
            string reverseString = new string(originalString.Reverse().ToArray());
            string returnString = reverseString + originalString;
            return returnString;
        }
    }
}
//ReverseAndNot https://edabit.com/challenge/YGhgctqPsKQxQQCFS
//Write a function that takes an integer i and returns a string with the integer backwards followed by the original integer.
//To illustrate:
//123
//We reverse 123 to get 321 and then add 123 to the end, resulting in 321123.
//Examples
//ReverseAndNot(123) --> "321123"
//ReverseAndNot(152) -->"251152"
//ReverseAndNot(123456789) --> "987654321123456789"
//Notes
//i is a non-negative integer.
//Bonus: By using System.Linq this should be completed in one line of code.
// Steps
// Take initial int and turn into a string
// originalString =  Take initial int and turn into a string
// reverseString = OriginalString To Array Reverse To String
// newString = originalString + reverseString;
// return newString;