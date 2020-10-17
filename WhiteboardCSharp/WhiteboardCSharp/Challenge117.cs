using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge117
    {
    public static string Moran(int n)
    {
        int sum = n.ToString().Select(t => int.Parse(t.ToString())).ToArray().Sum();
        if (n % sum == 0)
            return (IsPrime(n / sum)) ? "M" : "H";
        return "Neither";
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
//A Harshad number is a number which is divisible by the sum of its digits.For example, 132 is divisible by 6 (1+3+2).

//A subset of the Harshad numbers are the Moran numbers.Moran numbers yield a prime when divided by the sum of their digits. For example, 133 divided by 7 (1+3+3) yields 19, a prime.

//Create a function that takes a number and returns "M" if the number is a Moran number, "H" if it is a (non-Moran) Harshad number, or "Neither".

//Examples
//Moran(132) --> "H"
//Moran(133) --> "M"
//Moran(134) --> "Neither"