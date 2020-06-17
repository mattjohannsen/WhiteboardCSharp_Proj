using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    class Challenge15
    {
        public void RunChallenge()
        {
            ChallengeDescription();
            string originalString = "hello";
            Console.WriteLine($"       Original String: {originalString} Modified String: {RemoveFirstLastChar(originalString)}");
            originalString = "maybe";
            Console.WriteLine($"       Original String: {originalString} Modified String: {RemoveFirstLastChar(originalString)}");
            originalString = "benefit";
            Console.WriteLine($"       Original String: {originalString} Modified String: {RemoveFirstLastChar(originalString)}");
            originalString = "a";
            Console.WriteLine($"       Original String: {originalString} Modified String: {RemoveFirstLastChar(originalString)}");
        }
        public string RemoveFirstLastChar(string inputString)
        {
            List<char> stringAsList = inputString.ToList();
            List<char> modifiedList = new List<char>();
            if (stringAsList.Count <= 2)
            {
                return inputString;
            }
            else
            {
                for (int i = 1; i < stringAsList.Count - 1; i++)
                {
                    modifiedList.Add(stringAsList[i]);
                }
            }
            return string.Join("", modifiedList);
        }

        public void ChallengeDescription()
        {
            Console.WriteLine("       Remove the First and Last Characters");
            Console.WriteLine("       Create a function that removes the first and last characters from a string.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       RemoveFirstLast('hello') ➞ 'ell'");
            Console.WriteLine("       RemoveFirstLast('maybe') ➞ 'ayb'");
            Console.WriteLine("       RemoveFirstLast('benefit') ➞ 'enefi'");
            Console.WriteLine("       RemoveFirstLast('a') ➞ 'a'");
            Console.WriteLine("       Notes");
            Console.WriteLine("       If the string is 2 or fewer characters long, return the string itself(See example #4).");
        }
    }
}
//Steps
// Create variable originalString
// Create method RemoveFirstLastChar which takes in a string and returns a string, returnString
// Create a variable stringAsList which is turning the string into a List
// If the list Count is less than or equal to 2, then turn the list back into a string and returnString
// Create a variable that is equal to a new char List called modifiedList
// Loop through the first list 1 to stringAsList.Count -1
// the modifiedList.Add = stringAsList[i]
// Turn the modifiedList back into a String which is equal to returnString
// return returnString

//Remove the First and Last Characters
//Create a function that removes the first and last characters from a string.
//Examples
//RemoveFirstLast("hello") ➞ "ell"
//RemoveFirstLast("maybe") ➞ "ayb"
//RemoveFirstLast("benefit") ➞ "enefi"
//RemoveFirstLast("a") ➞ "a"
//Notes
//If the string is 2 or fewer characters long, return the string itself(See example #4).