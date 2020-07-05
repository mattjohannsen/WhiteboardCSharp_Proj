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
            Console.WriteLine("       Challenge 28");
            int numberToTest = 11;
            bool theAnswer = isPrime(numberToTest);
            Console.WriteLine(theAnswer);
        }

        public bool isPrime(int inputNumber)
        {
            bool isNumberPrime = true;
            int stoppingPoint = inputNumber / 2;
            for (int i = 2; i < stoppingPoint; i++)
            {
                if (inputNumber % i == 0)
                {
                    isNumberPrime = false;
                    return isNumberPrime;
                }
                else
                {
                    continue;
                }
            }
            return isNumberPrime;
        }
    }
}
//Check if a Number is Prime
//Create a function that outputs true if a number is prime, and false otherwise.
//Examples
//isPrime(31) ➞ true
//isPrime(18) ➞ false
//isPrime(11) ➞ true
//Notes
//A prime number has no other factors except 1 and itself.
//1 is not considered a prime number.
// int numberToTest = 31
// Create isPrime method and pass in numberToTest
// int stoppingPoint = inputNumber/2
// Start loop and check if i % inputNumber does not equal 0
// If it equals zero than isNumberPrime = false;
// Else return true