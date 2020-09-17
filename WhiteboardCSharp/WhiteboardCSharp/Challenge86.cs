using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge86
    {
        public static string GetMiddle(string str)
        {
            return str.Length % 2 == 0 ? str[str.Length / 2 - 1].ToString() + str[str.Length / 2].ToString() : str[str.Length / 2].ToString();
        }
    }
}
//Return the Middle Character(s) of a String
//Create a function that takes a string and returns the middle character(s). If the word's length is odd, return the middle character. If the word's length is even, return the middle two characters.
//Examples
//GetMiddle("test") --> "es"
//GetMiddle("testing") --> "t"
//GetMiddle("middle") --> "dd"
//GetMiddle("A") --> "A"
//Notes
//All test cases contain a single word(as a string).