using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge119
    {
        public static string IsPrime(int[] primes, int num)
        {
            int min = 0;
            int max = primes.Length - 1;
            string found = "no";
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (num == primes[mid])
                {
                    found = "yes";
                    break;
                }
                else if (num < primes[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return found;
        }
    }
}
