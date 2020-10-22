using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge122
    {
        public static int SumPrimes(int[] arr)
        {
            List<int> primes = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPrime(arr[i]))
                {
                    primes.Add(arr[i]);
                }
            }
            return primes.Sum();
        }
        public static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;
            var limit = (int)Math.Floor(Math.Sqrt(num));
            for (int i = 3; i <= limit; i += 2)
                if (num % i == 0)
                    return false;
            return true;
        }
    }
}
//Sum of Prime Numbers
//Create a function that takes a list of numbers and returns the sum of all prime numbers in the list.
//Examples
//SumPrimes(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }) --> 17
//SumPrimes(new int[] { 2, 3, 4, 11, 20, 50, 71 }) --> 87
//SumPrimes(new int[] { }) --> 0
//Notes
//Given numbers won't exceed 101.
//A prime number is a number which has exactly two divisors(1 and itself).