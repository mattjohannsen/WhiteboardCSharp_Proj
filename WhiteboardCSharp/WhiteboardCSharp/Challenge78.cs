using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge78
    {
        public void RunChallenge()
        {
            Console.WriteLine("      Challenge 78");
        }
        public static string WrapAround(string input, int offset)
        {
            return input;
        }
    }
}
//Wrap Around https://edabit.com/challenge/KKSrd8yh2GrGDbASn
//Create a function to reproduce the wrap around effect shown:

//Examples
//WrapAround("Hello, World!", 2) --> "llo, World!He"

//WrapAround("From what I gathered", -4) --> "eredFrom what I gath"

//WrapAround("No Changes", 0) --> "No Changes"

//WrapAround("Nonscience", -12) --> "ceNonscien"
//Notes
//The offset can be negative.
//The offset can be greater than input.