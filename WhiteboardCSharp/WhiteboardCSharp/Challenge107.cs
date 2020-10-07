using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge107
    {
        public static bool IsValidPhoneNumber(string str)
        {
            return Regex.IsMatch(str, @"^\(\d{3}\)+\s+\d{3}-\d{4}$");
        }
    }
}
//Is the Phone Number Formatted Correctly?
//Create a function that accepts a string and returns true if it's in the format of a proper phone number and false if it's not.
//Assume any number between 0-9 (in the appropriate spots) will produce a valid phone number.
//This is what a valid phone number looks like:
//(123) 456-7890
//Examples
//IsValidPhoneNumber("(123) 456-7890") --> true
//IsValidPhoneNumber("1111)555 2345") --> false
//IsValidPhoneNumber("098) 123 4567") --> false
//Notes
//Don't forget the space after the closing parentheses.