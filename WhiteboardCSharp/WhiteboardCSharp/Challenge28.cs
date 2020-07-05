using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge28
    {
        public void RunChallenge()
        {
            ChallengeDescription();
            int numberToTest = 31;
            bool theAnswer = IsPrime(numberToTest);
            Console.WriteLine($"       Is {numberToTest} a prime number? --> {theAnswer}");
            numberToTest = 18;
            theAnswer = IsPrime(numberToTest);
            Console.WriteLine($"       Is {numberToTest} a prime number? --> {theAnswer}");
            numberToTest = 11;
            theAnswer = IsPrime(numberToTest);
            Console.WriteLine($"       Is {numberToTest} a prime number? --> {theAnswer}");
        }

        public bool IsPrime(int inputNumber)
        {
            bool isNumberPrime = true;
            for (int i = 2; i < inputNumber / 2; i++)
            {
                if (inputNumber % i == 0)
                {
                    return false;
                }
                else
                {
                    continue;
                }
            }
            return isNumberPrime;
        }

        public void ChallengeDescription()
        {
            Console.WriteLine("       Check if a Number is Prime");
            Console.WriteLine("       Create a function that outputs true if a number is prime, and false otherwise.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       isPrime(31) --> true");
            Console.WriteLine("       isPrime(18) --> false");
            Console.WriteLine("       isPrime(11) --> true");
            Console.WriteLine("       Notes");
            Console.WriteLine("       A prime number has no other factors except 1 and itself.");
            Console.WriteLine("       1 is not considered a prime number.\n");
        }
    }
}
//Check if a Number is Prime https://edabit.com/challenge/aoR4PFS6FfpJs6v79
//Create a function that outputs true if a number is prime, and false otherwise.
//Examples
//isPrime(31) --> true
//isPrime(18) --> false
//isPrime(11) --> true
//Notes
//A prime number has no other factors except 1 and itself.
//1 is not considered a prime number.
// int numberToTest = 31
// Create isPrime method and pass in numberToTest
// int stoppingPoint = inputNumber/2
// Start loop and check if i % inputNumber does not equal 0
// If it equals zero than isNumberPrime = false;
// Else return true