﻿using System;
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
            Console.WriteLine("       Challenge 78");
            Console.WriteLine($"       (\"Hello, World!\", 2) --> {WrapAround("Hello, World!", 2)}");
            Console.WriteLine($"       (\"From what I gathered\", -4) --> {WrapAround("From what I gathered", -4)}");
            Console.WriteLine($"       (\"S\", -60) --> {WrapAround("S", -60)}");
            Console.WriteLine($"       (\"Nonscience\", -12) --> {WrapAround("Nonscience", -12)}");
            Console.WriteLine($"       (\"Excelsior\", 30) --> {WrapAround("Excelsior", 30)}");
            Console.WriteLine($"       (\"Incomprehensibilities\", 50) --> {WrapAround("Incomprehensibilities", 50)}");
        }
        public static string WrapAround(string input, int offset)
        {
            if (input.Length == 1)
            {
                return input;
            }
            else if(System.Math.Abs(offset) > input.Length)
            {
                offset %= input.Length;
                if (offset < 0)
                {
                    string firstString = input.Substring(input.Length + offset);
                    string secondString = input.Substring(0, input.Length + offset);
                    return firstString + secondString;
                }
                else
                {
                    string firstString = input.Substring(offset);
                    string secondString = input.Substring(0, offset);
                    return firstString + secondString;
                }
            }
            else if (offset < 0)
            {
                string firstString = input.Substring(input.Length + offset);
                string secondString = input.Substring(0, input.Length + offset);
                return firstString + secondString;
            }
            else
            {
                string firstString = input.Substring(offset);
                string secondString = input.Substring(0, offset);
                return firstString + secondString;
            }
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