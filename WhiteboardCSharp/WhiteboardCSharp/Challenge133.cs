using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge133
    {
        public static string FlipEndChars(object str)
        {
            return "";
        }
    }
}
//Switcharoo
//Create a function that takes a string and returns a new string with its first and last characters swapped, except under three conditions:

//If the length of the string is less than two, return "Incompatible.".
//If the argument is not a string, return "Incompatible.".
//If the first and last characters are the same, return "Two's a pair.".
//Examples
//FlipEndChars("Cat, dog, and mouse.") ➞ ".at, dog, and mouseC"

//FlipEndChars("ada") ➞ "Two's a pair."

//FlipEndChars("Ada") ➞ "adA"

//FlipEndChars("z") ➞ "Incompatible."

//FlipEndChars([1, 2, 3]) ➞ "Incompatible."
//Notes
//Tests are case sensitive(e.g. "A" and "a" are not the same character).