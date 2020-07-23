using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge44
    {
        public void RunChallenge()
        {
            Console.WriteLine("       Challenge 44");
            Console.WriteLine(ReverseSubstrationDifference(832));
            Console.WriteLine(ReverseSubstrationDifference(51));
            Console.WriteLine(ReverseSubstrationDifference(7977));
            Console.WriteLine(ReverseSubstrationDifference(1));
            Console.WriteLine(ReverseSubstrationDifference(665));
            Console.WriteLine(ReverseSubstrationDifference(149));
        }
        public int ReverseSubstrationDifference(int inputNumber)
        {
            int minuend = inputNumber;
            int subrahend = ReverseInteger(inputNumber);
            int difference = minuend - subrahend;
            if (difference<=0)
            {
                return 0;
            }
            else
            {
                return difference;
            }
        }
        public int ReverseInteger(int inputNumber)
        {
            char[] charArray = inputNumber.ToString().ToCharArray();
            Array.Reverse(charArray);
            string arrayAsString = new string(charArray);
            int stringAsInt = Int32.Parse(arrayAsString);
            return stringAsInt;

        }
    }
}
//Reverse Coding Challenge #5 https://edabit.com/challenge/RW9MHzMTLMstzjrWG
//This is a reverse coding challenge.Normally you're given explicit directions 
//with how to create a function. Here, you must generate your own function to 
//satisfy the relationship between the inputs and outputs.
//Your task is to create a function that, when fed the inputs below, produce the sample outputs shown.
//Examples
//832 --> 594
//51 --> 36
//7977 --> 180
//1 --> 0
//665 --> 99
//149 --> 0
// Steps
// ReverseSubstrationDifference(int inputNumber)
// reverse inputNumber by passing it into the ReverseInteger method
// declare variables
// minuend = inputNumber
// subtrahend = ReverseInteger(inputNumber);
// ReverseInteger
// Turn the int into a list. Reverse the list. Return the list turned into a string, turned into an Int
// return minuend - subtrahend;

