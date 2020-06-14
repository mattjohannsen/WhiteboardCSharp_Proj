using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge11
    {
        //public string inputString = "hello";
        //public string inputString = "HELLO";
        //public string inputString = "Hello";
        public string inputString = "ketcHUp";
        public void RunChallenge()
        {
            Console.WriteLine("       This is Challenge 11");
            bool theAnswer = SameCase(inputString);
            Console.WriteLine($"      Does {inputString} contain the same case?: {theAnswer}");
        }

        public bool SameCase (string inputString)
        {
            bool isCaseTheSame = false;
            List<char> charList = inputString.ToCharArray().ToList();
            bool firstCharIsUpper;
            for (int i = 0; i < charList.Count; i++)
            {
                firstCharIsUpper = Char.IsUpper(charList[0]);
                if (Char.IsUpper(charList[i]) == firstCharIsUpper)
                {
                    isCaseTheSame = true;
                }
                else
                {
                    isCaseTheSame = false;
                    return isCaseTheSame;
                }
            }
            return isCaseTheSame;
        }
    }
}
//Check if the Same Case https://edabit.com/challenge/ivaEWKZbFMcR8emJ8
//Create a function that returns true if an input string contains only uppercase or only lowercase letters.
//Examples
//SameCase("hello") --> true
//SameCase("HELLO") --> true
//SameCase("Hello") --> false
//SameCase("ketcHUp") --> false
// Create variable inputString;
// Create method SameCase which takes in string inputString
// Create variable for stringList
// Turn the string inputString into a list and set it equal to stringList
// Loop through the stringList and check to see what the Case of each letter is
// Set a variable firstCharCase equal to the Case of the first character
// If any case of the characters does not equal firstCharCase return FALSE
// Else return true that this string has the same case
