using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge7
    {
        public void RunChallenge()
        {
            //string initialString = "abc";
            string initialString = "CODING is fun";
            Console.WriteLine("       Challenge 7");
            string displayString = GetAlphabetPositionString(initialString);
            Console.WriteLine("       " + displayString);
        }

        public string GetAlphabetPositionString(string inputString)
        {
            string returnString;
            List<int> stringAsAlphabetPosition = new List<int>();
            for (int i = 0; i < inputString.Length; i++)
            {
                int alphabetPosition = (int)inputString[i] % 32;
                if (alphabetPosition != 0)
                {
                    stringAsAlphabetPosition.Add(alphabetPosition);
                }
            }
            returnString = string.Join("", stringAsAlphabetPosition.ToArray());
            return returnString;
        }

    }
}
// Create a string variable initialString 
// Create a GetAlphabetPosition Method 
// Send initialString into GetAlphabetPosition Method 
// Create a stringAsAlphabetPosition string List variable 
// Create a string returnString variable 
// Loop through initialString whichi is now inputString and get the alphabet position xxxxxx
// Using (int)inputString[i] % 32 to get position 
// Add this variable to the stringAsAlphabetPosition list as a String ToString()
// Turn this int List into a one String -->string combindedString = string.Join( ",", myList.ToArray() );
// return string returnString