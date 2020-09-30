using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge100
    {
        public static bool IsIsogram(string str)
        {
            return str.Length == str.ToLower().Distinct().Count();
        }
    }
}
//Is the Word an Isogram? https://edabit.com/challenge/aQWAAz6SiApZBA8A8
//An isogram is a word that has no duplicate letters.Create a function that takes a string and returns either true or false depending on whether or not it's an "isogram".
//Examples
//IsIsogram("Algorism") --> true
//IsIsogram("PasSword") --> false
//// Not case sensitive.
//IsIsogram("Consecutive") --> false
//Notes
//Ignore letter case (should not be case sensitive).
//All test cases contain valid one word strings.