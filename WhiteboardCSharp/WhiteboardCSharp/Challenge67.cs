using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge67
    {
        public void RunChallenge()
        {
            ChallengeDescription();
            Rational r1 = new Rational(1, 2);
            Console.WriteLine(r1.Numerator);
            Console.WriteLine(r1.Denominator);
            Console.WriteLine(r1.ToString());
            Rational r2 = new Rational(10, 8);
            Console.WriteLine(r2.Numerator);
            Console.WriteLine(r2.Denominator);
            Console.WriteLine(r2.ToString());
            Rational r3 = new Rational(2, -1);
            Console.WriteLine(r3.Numerator);
            Console.WriteLine(r3.Denominator);
            Console.WriteLine(r3.ToString());
            Rational r4 = new Rational(-16, -64);
            Console.WriteLine(r4.Numerator);
            Console.WriteLine(r4.Denominator);
            Console.WriteLine(r4.ToString());
        }
        public void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 67: Rational Number Class (Part 1)");
            Console.WriteLine("       Create a C# struct with a constructor that takes two integer parameters, either or both of ");
            Console.WriteLine("       which may be positive or negative. Include two read-only properties, Numerator and ");
            Console.WriteLine("       Denominator, that return the numerator and denominator of the fraction respectively of");
            Console.WriteLine("       type int. Also, override the ToString() method to give a string representation of the");
            Console.WriteLine("       rational number as described in the preceding paragraph.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       var r1 = new Rational(1, 2);");
            Console.WriteLine("       r1.Numerator --> 1");
            Console.WriteLine("       r1.Denominator -->  2");
            Console.WriteLine("       r1.ToString() -->  1 / 2");
            Console.WriteLine("       var r2 = new Rational(10, 8);");
            Console.WriteLine("       r2.Numerator -->  5");
            Console.WriteLine("       r2.Denominator -->  4");
            Console.WriteLine("       r2.ToString() -->  5 / 4");
            Console.WriteLine("       var r3 = new Rational(2, -1);");
            Console.WriteLine("       r3.Numerator -->  -2");
            Console.WriteLine("       r3.Denominator -->  1");
            Console.WriteLine("       r3.ToString() --> - 2");
            Console.WriteLine("       var r4 = new Rational(-16, -64);");
            Console.WriteLine("       r4.Denominator -->  4");
            Console.WriteLine("       r4.ToString() -->  1 / 4\n");
        }
    }
}
//Create a C# struct with a constructor that takes two integer parameters, either or both of 
//which may be positive or negative. Include two read-only properties, Numerator and 
//Denominator, that return the numerator and denominator of the fraction respectively of 
//type int. Also, override the ToString() method to give a string representation of the 
//rational number as described in the preceding paragraph.
