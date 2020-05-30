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
            string initialString = "abc";
            Console.WriteLine("       Challenge 7");
            string displayString = GetAlphabetPositionString(initialString);
            Console.WriteLine(displayString);
        }

        public string GetAlphabetPositionString(string inputString)
        {
            string returnString;
            List<char> stringToCharList = inputString.ToList();
            List<int> stringAsAlphabetPosition = new List<int>();
            for (int i = 0; i < inputString.Length; i++)
            {
                int alphabetPosition = (int)inputString[i] % 32;
                stringAsAlphabetPosition.Add(alphabetPosition);
            }
            for (int i = 0; i < stringAsAlphabetPosition.Count; i++)
            {
                Console.WriteLine(stringAsAlphabetPosition[i]);
            }
            //for (int i = 0; i < stringAsAlphabetPosition.Count; i++)
            //{
            //    stringToCharList[i] = stringAsAlphabetPosition[i].ToString();
            //}
            returnString = string.Join("", stringAsAlphabetPosition.ToArray());
            return returnString;
        }

    }
}
// Create a string variable initialString xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
// Create a GetAlphabetPosition Method xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
// Send initialString into GetAlphabetPosition Method xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
// Create a variable to hold the string as a list of Char xxxxxxxxxxxxxxxxxxxxxxxxxxxxx
// Turn the string into a list .ToList xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
// Create a stringAsAlphabetPosition string List variable xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
// Create a string returnString variable xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
// Loop through initialString whichi is now inputString and get the alphabet position xxxxxx
// Using (int)inputString[i] % 32 to get position 
// Add this variable to the stringAsAlphabetPosition list as a String ToString()
// Turn this int List into a one String -->string combindedString = string.Join( ",", myList.ToArray() );
// return string returnString