using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge124
    {
        public static string MakeTitle(string str)
        {
            return Regex.Replace(str, @"(^\w)|(\s\w)", w => w.Value.ToUpper());
        }
    }
}
//Capitalize the First Letter of Each Word
//Create a function that takes a string as an argument and converts the first character of each word to uppercase.Return the newly formatted string.

//Examples
//MakeTitle("This is a title") ➞ "This Is A Title"

//MakeTitle("capitalize every word") ➞ "Capitalize Every Word"

//MakeTitle("I Like Pizza") ➞ "I Like Pizza"

//MakeTitle("PIZZA PIZZA PIZZA") ➞ "PIZZA PIZZA PIZZA"
//Notes
//You can expect a valid string for each test case.
//Some words may contain more than one uppercase letter(see example #4).