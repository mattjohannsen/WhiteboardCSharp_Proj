using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge14
    {
        public void RunChallenge()
        {
            Console.WriteLine("       This is Challenge14");
            ChallengeDescription();
            string theString = "String";
            Console.WriteLine($"       {theString} doubled = {DoubleChar(theString)}");
            theString = "Hello World!";
            Console.WriteLine($"       {theString} doubled = {DoubleChar(theString)}");
            theString = "1234!_ ";
            Console.WriteLine($"       {theString} doubled = {DoubleChar(theString)}");
        }

        public static string DoubleChar(string inputString)
        {
            List<char> stringAsList = inputString.ToList();
            List<char> doubleList = new List<char>();
            for (int i = 0; i < stringAsList.Count; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    doubleList.Add(stringAsList[i]);
                }
            }
            return string.Join("", doubleList);
        }

        public void ChallengeDescription()
        {
            Console.WriteLine("       Repeating Letters");
            Console.WriteLine("       Create a function that takes a string and returns a string in which each character is repeated once.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       DoubleChar('String') --> 'SSttrriinngg'");
            Console.WriteLine("       DoubleChar('Hello World!') --> 'HHeelllloo  WWoorrlldd!!'");
            Console.WriteLine("       DoubleChar('1234!_ ') --> '11223344!!__  '");
        }

    }
}
//Repeating Letters
//Create a function that takes a string and returns a string in which each character is repeated once.
//Examples
//DoubleChar("String") ➞ "SSttrriinngg"
//DoubleChar("Hello World!") ➞ "HHeelllloo  WWoorrlldd!!"
//DoubleChar("1234!_ ") ➞ "11223344!!__  "
//Notes
//All test cases contain valid strings.Don't worry about spaces, special characters or numbers. They're all considered valid characters.
// Steps
// Create function DoubleCharactersInString which takes in a string and returns a string
// Take a string and turn it into a list
// Create a second list duplicateList
//  Concat them together like
//foreach (var n in a.Concat(b))
//{
//    // enumerates 1, 2, 3, 4
//}
// Turn the list into a string
// Return the string
