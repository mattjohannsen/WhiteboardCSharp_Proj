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
            char[] arr = str.ToCharArray();
            string returnString = "";
            if (arr.Length == 1)
            {
                return str;
            }
            else if (arr.Length % 2 == 0)
            {
                returnString += arr[arr.Length / 2 - 1].ToString() + arr[arr.Length / 2].ToString();
            }
            else
            {
                returnString += arr[arr.Length / 2];
            }
            return returnString;
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