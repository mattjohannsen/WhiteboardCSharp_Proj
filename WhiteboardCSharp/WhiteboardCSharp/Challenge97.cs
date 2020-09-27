using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge97
    {
        public static bool IsPrime(int x)
        {
            if (x <= 1) return false;
            int max = x / 2;
            for (int i = 2; i <= max; i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
    }
}
//Create a function that returns true if a number is prime, and false otherwise.A prime number is any positive integer that is evenly divisible by only two divisors: 1 and itself.
//The first ten prime numbers are:
//2, 3, 5, 7, 11, 13, 17, 19, 23, 29
//Examples
//isPrime(31) --> true
//isPrime(18) --> false
//isPrime(11) --> true
//Notes
//A prime number has no other factors except 1 and itself.
//If a number is odd it is not divisible by an even number.
//1 is not considered a prime number.