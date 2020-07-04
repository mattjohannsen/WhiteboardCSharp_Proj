using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge27
    {
        public void RunChallenge()
        {
            Console.WriteLine("       Challenge 27");
            string originalString = "test";
            string theAnswer = GetMiddle(originalString);
            Console.WriteLine(theAnswer);
            originalString = "testing";
            theAnswer = GetMiddle(originalString);
            Console.WriteLine(theAnswer);
            originalString = "middle";
            theAnswer = GetMiddle(originalString);
            Console.WriteLine(theAnswer);
            originalString = "A";
            theAnswer = GetMiddle(originalString);
            Console.WriteLine(theAnswer);
        }
        public string GetMiddle(string inputString)
        {
            List<char> stringAsList = inputString.ToList();
            List<char> solutionList = new List<char>();
            int startingPoint = stringAsList.Count / 2;
            string solutionString;
            if (stringAsList.Count % 2 == 0)
            {
                solutionList.Add(stringAsList[startingPoint - 1]);
                solutionList.Add(stringAsList[startingPoint]);
                solutionString = new string(solutionList.ToArray());
            }
            else
            {
                solutionString = stringAsList[startingPoint].ToString();
            }
            return solutionString;
        }
    }
}
//Return the Middle Character(s) of a String
//Create a function that takes a string and returns the middle character(s). 
//If the word's length is odd, return the middle character. 
//If the word's length is even, return the middle two characters.
//Examples
//GetMiddle('test') --> 'es'
//GetMiddle('testing') --> 't'
//GetMiddle('middle') --> 'dd'
//GetMiddle('A') --> 'A'
//Notes
//All test cases contain a single word(as a string).
// Steps
// Create string originalString variable and pass it into...
// Create GetMiddle method which takes in an inputString and returns a string
// Create solutionList variable
// Turn input string into a list List<char> stringAsList
// if the list has odd amount of characters divide by 2 and at return the char at that index spot as a string
// if the list is even
// Take characters at startingSpot - 1 and startingSpot and add these to solutionList
// Return Turn solutionList into a string ToSTring()