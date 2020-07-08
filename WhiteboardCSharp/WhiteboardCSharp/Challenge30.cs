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
            ChallengeDescription();
            Console.WriteLine($"       ReverseAndNot(123) --> {ReverseAndNot(123)}");
            Console.WriteLine($"       ReverseAndNot(152) --> {ReverseAndNot(152)}");
            Console.WriteLine($"       ReverseAndNot(123456789) --> {ReverseAndNot(123456789)}");
        }
        public string ReverseAndNot(int i)
        {
            // Original Solution
            //string originalString = i.ToString();
            //string reverseString = new string(i.ToString().Reverse().ToArray());
            //string returnString = reverseString + originalString;
            // Bonus One Line Linq solution
            return i.ToString() + new string(i.ToString().Reverse().ToArray());
        }
        public void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 30: ReverseAndNot");
            Console.WriteLine("       Write a function that takes an integer i and returns a string with");
            Console.WriteLine("       the integer backwards followed by the original integer.");
            Console.WriteLine("       To illustrate:");
            Console.WriteLine("       123");
            Console.WriteLine("       We reverse 123 to get 321 and then add 123 to the end, resulting in 321123.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       ReverseAndNot(123) --> 321123");
            Console.WriteLine("       ReverseAndNot(152) --> 251152");
            Console.WriteLine("       ReverseAndNot(123456789) --> 987654321123456789");
            Console.WriteLine("       Notes");
            Console.WriteLine("       i is a non-negative integer.");
            Console.WriteLine("       Bonus: By using System.Linq this should be completed in one line of code.\n");
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