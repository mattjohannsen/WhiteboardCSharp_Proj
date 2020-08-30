﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge70
    {
        public void RunChallenge()
        {
            Console.WriteLine("       Challenge 70");
            Console.WriteLine($"       {CanComplete("butl", "beautiful")}");
        }
        public static bool CanComplete(string str1, string str2)
        {
            return true;
        }

    }
}
//Complete the Word
//An input string can be completed if additional letters can be added and no letters need to be taken away to match the word.Furthermore, the order of the letters in the input string must be the same as the order of letters in the final word.

//Create a function that, given an input string, determines if the word can be completed.

//Examples
//CanComplete("butl", "beautiful") --> true
//// We can add "ea" between "b" and "u", and "ifu" between "t" and "l".

//CanComplete("butlz", "beautiful") --> false
//// "z" does not exist in the word beautiful.

//CanComplete("tulb", "beautiful") --> false
//// Although "t", "u", "l" and "b" all exist in "beautiful", they are incorrectly ordered.

//CanComplete("bbutl", "beautiful") --> false
//// Too many "b"s, beautiful has only 1.
//Notes
//Both string input and word will be lowercased.