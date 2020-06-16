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
            string theString = "String";
            Console.WriteLine(DoubleCharactersInString(theString));
        }

        public string DoubleCharactersInString(string inputString)
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
            //List<char> doubleList = stringAsList.Zip(duplicateList, (x,y) => x + y);
            //List<char> doubleList = stringAsList.Zip(duplicateList, (l, n) => l + n).ToList();
            //foreach (var n in stringAsList.Concat(duplicateList))
            //{
            //    // enumerates 1, 2, 3, 4
            //}
            string doubleString = string.Join("", doubleList);
            return doubleString;
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
