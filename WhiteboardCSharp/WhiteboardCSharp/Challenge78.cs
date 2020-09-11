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
            ChallengeDescription();
            Console.WriteLine($"       (\"Hello, World!\", 2) --> {WrapAround("Hello, World!", 2)}");
            Console.WriteLine($"       (\"From what I gathered\", -4) --> {WrapAround("From what I gathered", -4)}");
            Console.WriteLine($"       (\"No Changes\", 0) --> {WrapAround("No Changes", 0)}");
            Console.WriteLine($"       (\"Nonscience\", -12) --> {WrapAround("Nonscience", -12)}");
        }
        public static string WrapAround(string input, int offset)
        {
            if (System.Math.Abs(offset) > input.Length || offset < 0) offset %= input.Length;
            return (offset < 0) ? input.Substring(input.Length + offset) + input.Substring(0, input.Length + offset) : input.Substring(offset) + input.Substring(0, offset);
        }
        public void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 78: Wrap Around");
            Console.WriteLine("       Create a function to reproduce the wrap around effect shown:");
            Console.WriteLine("       Examples");
            Console.WriteLine("       WrapAround(\"Hello, World!\", 2) --> \"llo, World!He\"");
            Console.WriteLine("       WrapAround(\"From what I gathered\", -4) --> \"eredFrom what I gath\"");
            Console.WriteLine("       WrapAround(\"No Changes\", 0) --> \"No Changes\"");
            Console.WriteLine("       WrapAround(\"Nonscience\", -12) --> \"ceNonscien\"");
            Console.WriteLine("       Notes");
            Console.WriteLine("       The offset can be negative.");
            Console.WriteLine("       The offset can be greater than input.\n");
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
// Steps
// Turn input into an array
// create solutionArray
// if i + offset > solutionArray.Length
// solutionArray[i] = arr[i + offset]
// solutionArray[i] = arr[i + offset]