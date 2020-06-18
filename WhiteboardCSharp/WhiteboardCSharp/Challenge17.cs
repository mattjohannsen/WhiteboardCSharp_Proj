using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge17
    {
        public void RunChallenge()
        {
            Console.WriteLine("       This is challenge 17");
            int ourInteger = 5;
            Console.WriteLine($"       The input: {ourInteger} The Answer: {GetFactorial(ourInteger)}");
            ourInteger = 3;
            Console.WriteLine($"       The input: {ourInteger} The Answer: {GetFactorial(ourInteger)}");
            ourInteger = 2;
            Console.WriteLine($"       The input: {ourInteger} The Answer: {GetFactorial(ourInteger)}");
        }

        public int GetFactorial(int inputInteger)
        {
            if (inputInteger != 1)
            {
                Console.WriteLine(inputInteger);
                return inputInteger * GetFactorial(inputInteger - 1); 
            }
            else
            {
                Console.WriteLine(inputInteger);
                return inputInteger;
            }

        }
    }
}
// Recursion & Factorials
// Create a function that gives the factorial of an integer
// Create a ourInteger variable
// Create a function that takes in an integer inputInteger and returns an integer theFactorial
// Take the number and check to see if the number is not equal to 1
// If it is not, the multiple it by itself -1 and send it to the GetFactorial function to check to see if itself -1 is equal to one.
// If it is, then return the number