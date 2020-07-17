using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge39
    {
        public void RunChallenge()
        {
            ChallengeDescription();
            Console.WriteLine($"       IsValidHexCode('#CD5C5C') --> {IsValidHexCode("#CD5C5C")}");
            Console.WriteLine($"       IsValidHexCode('#EAECEE') --> {IsValidHexCode("#EAECEE")}");
            Console.WriteLine($"       IsValidHexCode('#eaecee') --> {IsValidHexCode("#eaecee")}");
            Console.WriteLine($"       IsValidHexCode('#CD5C58C') --> {IsValidHexCode("#CD5C58C")}");
            Console.WriteLine($"       IsValidHexCode('#CD5C5Z') --> {IsValidHexCode("#CD5C5Z")}");
            Console.WriteLine($"       IsValidHexCode('#CD5C&C') --> {IsValidHexCode("#CD5C&C")}");
            Console.WriteLine($"       IsValidHexCode('CD5C5C') --> {IsValidHexCode("CD5C5C")}");
        }
        private bool IsValidHexCode(string inputString)
        {
            bool isValidHexCode = true;
            bool checkingForHex = true;
            char[] stringAsArray = inputString.ToCharArray();
            while (checkingForHex)
            {
                if (!IsNumSignFirst(stringAsArray[0]))
                {
                    return false;
                }
                if (!ArrayHas7Elements(stringAsArray))
                {
                    return false;
                }
                for (int i = 1; i < stringAsArray.Length; i++)
                {
                    if (Char.IsLetter(stringAsArray[i]))
                    {
                        isValidHexCode = CheckAlphsAtoF(stringAsArray[i]);
                    }
                    else if (Char.IsDigit(stringAsArray[i]))
                    {
                        isValidHexCode = CheckNum0to9(stringAsArray[i]);
                    }
                    else
                    {
                        return false;
                    }
                }
                checkingForHex = false;
            }
            return isValidHexCode;
        }
        private bool IsNumSignFirst(char inputChar)
        {
            return (inputChar == '#');
        }
        private bool ArrayHas7Elements(char[] inputArray)
        {
            return (inputArray.Length == 7);
        }
        private bool CheckAlphsAtoF(char inputChar)
        {
            if (Char.ToUpper(inputChar) >= 'A' && Char.ToUpper(inputChar) <= 'F')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool CheckNum0to9(char inputChar)
        {
            int charToInt = (int)Char.GetNumericValue(inputChar);
            if (charToInt >=0 && charToInt <= 9)
            {
                return true;
            }
            return false;
        }
        private void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 39: Valid Hex Code");
            Console.WriteLine("       Create a function that determines whether a string is a valid hex code.");
            Console.WriteLine("       A hex code must begin with a pound key # and is exactly 6 characters in length.");
            Console.WriteLine("       All alphabetic characters may be uppercase or lowercase.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       IsValidHexCode(#CD5C5C) --> true");
            Console.WriteLine("       IsValidHexCode(#EAECEE) --> true");
            Console.WriteLine("       IsValidHexCode(#eaecee) --> true");
            Console.WriteLine("       IsValidHexCode(#CD5C58C) --> false");
            Console.WriteLine("       Length exceeds 6");
            Console.WriteLine("       IsValidHexCode(CABBACCC) --> false");
            Console.WriteLine("       Not all alphabetic characters in A-F");
            Console.WriteLine("       IsValidHexCode(CABBACCC) --> false");
            Console.WriteLine("       Contains unacceptable character");
            Console.WriteLine("       IsValidHexCode(CD5C5C) --> false");
            Console.WriteLine("       Missing #\n");
        }

    }
}
//Valid Hex Code
//Create a function that determines whether a string is a valid hex code.
//A hex code must begin with a pound key # and is exactly 6 characters in length. Each character must be a digit from 0-9 or an alphabetic character from A-F. All alphabetic characters may be uppercase or lowercase.
//Examples
//IsValidHexCode("#CD5C5C") --> true
//IsValidHexCode("#EAECEE") --> true
//IsValidHexCode("#eaecee") --> true
//IsValidHexCode("#CD5C58C") --> false
//// Length exceeds 6
//IsValidHexCode("#CD5C5Z") --> false
//// Not all alphabetic characters in A-F
//IsValidHexCode("#CD5C&C") --> false
//// Contains unacceptable character
//IsValidHexCode("CD5C5C") --> false
//// Missing #
// Steps
// set variable isValidHexCode = true
// Turn input string into char[] --> stringAsArray
// Check if first character is # --> IsNumSignFirst(stringAsArray[0]))
// Check to see if array has 7 characters --> DoesArrayHave7Members(stringAsArray)
// Check to see if char are numeric or alphabetic ELSE return false;
// Check to see if all alphabetic character.ToUpper are between A-F
// Check to see if all numberic characters are between 0-9