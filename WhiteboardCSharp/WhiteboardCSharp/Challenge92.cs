using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge92
    {
        public static bool ValidatePIN(string pin)
        {
            return pin.All(char.IsDigit) && pin.Length == 4 || pin.Length == 6;
        }
    }
}
//ATM PIN Code Validation
//ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits.Your task is to create a function that takes a string and returns true if the PIN is valid and false if it's not.
//Examples
//ValidatePIN("1234") --> true
//ValidatePIN("12345") --> false
//ValidatePIN("a234") --> false
//ValidatePIN("") --> false
//Notes
//Some test cases contain special characters.
//Empty strings must return false.