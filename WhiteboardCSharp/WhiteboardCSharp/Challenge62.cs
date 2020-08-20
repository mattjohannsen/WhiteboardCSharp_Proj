using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge62
    {
        public void RunChallenge()
        {
            ChallengeDescription();
            Console.WriteLine($"       Simplify(4 / 6)-- > 2 / 3 ==> {Simplify("4 / 6")}");
            Console.WriteLine($"       Simplify(10 / 11)-- > 10 / 11 ==> {Simplify("10 /11")}");
            Console.WriteLine($"       Simplify(100 / 400)-- > 1 / 4 ==> {Simplify("100 / 400")}");
            Console.WriteLine($"       Simplify(8 / 4)-- > 2 ==> {Simplify("8 / 4")}");
        }
        public static string Simplify(string str)
        {
            string[] arr = str.Split('/');
            int[] intArray = new int[2];
            for (int i = 0; i < arr.Length; i++)
            {
                intArray[i] = Int32.Parse(arr[i]);
            }
            bool fractionIsNotSimplified = true;
            do
            {
                for (int j = 2; j <= intArray[0]; j++)
                {
                    if (intArray[0] % j == 0 && intArray[1] % j == 0)
                    {
                        intArray[0] = intArray[0] / j;
                        intArray[1] = intArray[1] / j;
                    }
                }
                fractionIsNotSimplified = false;
            } while (fractionIsNotSimplified);
            if (intArray[0] % intArray[1] == 0)
            {
                return (intArray[0] / intArray[1]).ToString();
            }
            else
            {
                return String.Join("/", new List<int>(intArray).ConvertAll(i => i.ToString()).ToArray());
            }
        }
        public void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 62: Simplified Fractions");
            Console.WriteLine("       Create a function that returns the simplified version of a fraction.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       Simplify(4 / 6) --> 2 / 3");
            Console.WriteLine("       Simplify(10 / 11) --> 10 / 11");
            Console.WriteLine("       Simplify(100 / 400) --> 1 / 4");
            Console.WriteLine("       Simplify(8 / 4) --> 2");
            Console.WriteLine("       Notes");
            Console.WriteLine("       A fraction is simplified if there are no common factors(except 1) between the numerator and ");
            Console.WriteLine("       the denominator.For example, 4/6 is not simplified, since 4 and 6 both share 2 as a factor.");
            Console.WriteLine("       If improper fractions can be transformed into integers, do so in your code (see example #4).\n");
        }
    }
}
//Simplified Fractions
//Create a function that returns the simplified version of a fraction.

//Examples
//Simplify("4/6") --> "2/3"
//Simplify("10/11") --> "10/11"
//Simplify("100/400") --> "1/4"
//Simplify("8/4") --> "2"
//Notes
//A fraction is simplified if there are no common factors(except 1) between the numerator and 
//the denominator.For example, 4/6 is not simplified, since 4 and 6 both share 2 as a factor.
//If improper fractions can be transformed into integers, do so in your code (see example #4).