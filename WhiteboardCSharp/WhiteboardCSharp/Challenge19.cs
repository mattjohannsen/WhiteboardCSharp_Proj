using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge19
    {
        public void RunChallenge()
        {
            Console.WriteLine("       Challenge 19");
            string [] originalArray = { "Tomato", "Potato", "Pair" };
            string [] theAnswer = IsFourLetters(originalArray);
            for (int i = 0; i < theAnswer.Length; i++)
            {
                Console.WriteLine(theAnswer[i]);
            }
        }

        public string [] IsFourLetters(string [] inputArray)
        {
            List<string> returnList = new List<string>();
            for (int i = 0; i < inputArray.Length; i++)
            {
                string tempString = inputArray[i];
                List<char> tempList = tempString.ToList();
                int listCount = tempList.Count;
                if (listCount == 4)
                {
                    returnList.Add(tempString);
                }
            }
            string [] returnArray = returnList.ToArray();
            return returnArray;
        }
    }
}
//Return the Four Letter Strings
//Create a function that takes an array of strings and returns the words that are exactly four letters.
//Examples
//IsFourLetters(["Tomato", "Potato", "Pair"]) --> ["Pair"]
//IsFourLetters(["Kangaroo", "Bear", "Fox"]) -->["Bear"]
//IsFourLetters(["Ryan", "Kieran", "Jason", "Matt"]) --> ["Ryan", "Matt"]
//Notes
//You can expect valid strings for all test cases.
// Steps
// Create originalArray which is an array of strings
// Create  IsFourLetters method which takes in an inputArray of strings
// Create a returnList which is a List of strings
// Loop through the input array and look for strings that are 4 letters long
// I will need to check the strings for their lengths by turning each string into an Array.
// If the string is four letters long, then add it onto the return List
// Turn the returnList into returnArray with ToArray()
// return the returnArray