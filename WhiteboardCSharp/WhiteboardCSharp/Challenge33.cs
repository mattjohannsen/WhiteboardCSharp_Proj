using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge33
    {
        public void RunChallenge()
        {
            Console.WriteLine("      Challenge 33");
            Console.WriteLine(ReversedBinaryInteger(10));
            Console.WriteLine(ReversedBinaryInteger(12));
            Console.WriteLine(ReversedBinaryInteger(25));
            Console.WriteLine(ReversedBinaryInteger(45));
        }
        public int ReversedBinaryInteger(int inputNumber)
        {
            string binaryRepresentation = Convert.ToString(inputNumber, 2);
            char[] binaryAsArray = binaryRepresentation.ToCharArray();
            Array.Reverse(binaryAsArray);
            string reverseString = string.Join("", binaryAsArray);
            int integerOfReverse = Convert.ToInt32(reverseString, 2);
            return integerOfReverse;
        }
    }
}
//Reversing a Binary String
//Write a function that takes an integer n, reverses the binary representation of that integer, and returns the new integer from the reversed binary.
//Examples
//ReversedBinaryInteger(10)--> 5
//// 10 = 1010 -> 0101 = 5
//ReversedBinaryInteger(12) --> 3
//// 12 = 1100 -> 0011 = 3
//ReversedBinaryInteger(25) --> 19
//// 25 = 11001 -> 10011 = 19
//ReversedBinaryInteger(45) --> 45
//// 45 = 101101 -> 101101 = 45
//Notes
//All values of n will be positive.
// Steps
// take inputNumber and create binary representation of integer --> binaryRepresentation
// take binaryRepresentation and turn it into an Array --> binaryAsArray
// take binaryAsArray and reverse it --> reverseBinaryArray
// turn reverseBinaryArray into a string -->reverseString
// turn reverseString into an int --> integerOfReverse
// return integerOfReverse
