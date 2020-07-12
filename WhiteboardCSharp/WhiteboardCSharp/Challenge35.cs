using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge35
    {
        public void RunChallenge()
        {
            ChallengeDescription();
            Console.WriteLine($"       NextPrime(12)--> {NextPrime(12)}");
            Console.WriteLine($"       NextPrime(24)--> {NextPrime(24)}");
            Console.WriteLine($"       NextPrime(11)--> {NextPrime(11)}");
        }
        private int NextPrime(int inputNumber)
        {
            bool lookingForNextPrime = true;
            if (IsPrime(inputNumber))
            {
                return inputNumber;
            }
            else
            {
                do
                {
                    inputNumber++;
                    if (IsPrime(inputNumber))
                    {
                        lookingForNextPrime = false;
                    }
                } while (lookingForNextPrime);
                return inputNumber;
            }
        }
        private bool IsPrime(int inputNumber)
        {
            bool isNumberPrime = true;
            for (int i = 2; i < inputNumber/2; i++)
            {
                if (inputNumber % i  == 0)
                {
                    return false;
                }
            }
            return isNumberPrime;
        }
        private void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 35: Next Prime");
            Console.WriteLine("       Given an integer, create a function that returns the next prime.If the number is prime, return the number itself.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       NextPrime(12) --> 13");
            Console.WriteLine("       NextPrime(24) --> 29");
            Console.WriteLine("       NextPrime(11) --> 11");
            Console.WriteLine("       11 is a prime, so we return the number itself.\n");
        }
    }
}
//Next Prime
//Given an integer, create a function that returns the next prime.If the number is prime, return the number itself.
//Examples
//NextPrime(12) --> 13
//NextPrime(24) --> 29
//NextPrime(11) --> 11
//// 11 is a prime, so we return the number itself.
// Steps
// Start a loop from 2 until the inputNumber divided by 2
// if inputNumber % i != 0