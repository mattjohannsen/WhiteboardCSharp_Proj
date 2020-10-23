using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge123
    {
        public static bool ValidateEmail(string str)
        {
            return (str.Contains("@") && str.Contains(".") && str.IndexOf("@") > 0 && str.LastIndexOf(".") > str.IndexOf("@"));
        }
    }
}
//Basic E-Mail Validation
//Create a function that accepts a string, checks if it's a valid email address and returns either true or false, depending on the evaluation.

//The string must contain an @ character.
//The string must contain a.character.
//The @ must have at least one character in front of it.
//e.g. "e@edabit.com" is valid while "@edabit.com" is invalid.
//The.and the @ must be in the appropriate places.
//e.g. "hello.email@com" is invalid while "john.smith@email.com" is valid.
//If the string passes these tests, it's considered a valid email address.

//Examples
//ValidateEmail("@gmail.com") --> false
//ValidateEmail("hello.gmail@com") --> false
//ValidateEmail("gmail") --> false
//ValidateEmail("hello@gmail") --> false
//ValidateEmail("hello@edabit.com") --> true
//Notes
//Check the Tests tab to see exactly what's being evaluated.
//You can solve this challenge with RegEx, but it's intended to be solved with logic.
//Solutions using RegEx will be accepted but frowned upon :(