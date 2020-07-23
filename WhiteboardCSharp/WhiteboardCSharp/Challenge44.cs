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
            ChallengeDescription();
            Console.WriteLine($"       ReverseSubstrationDifference(832) --> {ReverseSubstrationDifference(832)}");
            Console.WriteLine($"       ReverseSubstrationDifference(51) --> {ReverseSubstrationDifference(51)}");
            Console.WriteLine($"       ReverseSubstrationDifference(7977) --> {ReverseSubstrationDifference(7977)}");
            Console.WriteLine($"       ReverseSubstrationDifference(1) --> {ReverseSubstrationDifference(1)}");
            Console.WriteLine($"       ReverseSubstrationDifference(665) --> {ReverseSubstrationDifference(665)}");
            Console.WriteLine($"       ReverseSubstrationDifference(149) --> {ReverseSubstrationDifference(149)}");
        }
        public int ReverseSubstrationDifference(int inputNumber)
        {
            return (inputNumber - ReverseInteger(inputNumber) >= 0) ? inputNumber - ReverseInteger(inputNumber) : 0;
        }
        public int ReverseInteger(int inputNumber)
        {
            return Int32.Parse(new string(inputNumber.ToString().Reverse().ToArray()));

        }
        public void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 44: Longest Common Ending");
            Console.WriteLine("       This is a reverse coding challenge.Normally you're given explicit directions ");
            Console.WriteLine("       with how to create a function. Here, you must generate your own function to ");
            Console.WriteLine("       satisfy the relationship between the inputs and outputs.");
            Console.WriteLine("       Your task is to create a function that, when fed the inputs below, produce the sample outputs shown.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       832 --> 594");
            Console.WriteLine("       51 --> 36");
            Console.WriteLine("       7977 --> 180");
            Console.WriteLine("       1 --> 0");
            Console.WriteLine("       665 --> 99");
            Console.WriteLine("       149 --> 0\n");
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

