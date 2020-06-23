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
            ChallengeDesription();
            string [] ArrayOne = { "Tomato", "Potato", "Pair" };
            string [] theAnswer = IsFourLetters(ArrayOne);
            ShowAnswer(theAnswer);
            string[] ArrayTwo = { "Kangaroo", "Bear", "Fox" };
            ShowAnswer(IsFourLetters(ArrayTwo));
            string[] ArrayThree = { "Ryan", "Kieran", "Jason", "Matt" };
            ShowAnswer(IsFourLetters(ArrayThree));
        }
        public string [] IsFourLetters(string [] inputArray)
        {
            List<string> returnList = new List<string>();
            for (int i = 0; i < inputArray.Length; i++)
            {
                List<char> stringAsList = inputArray[i].ToList();
                if (stringAsList.Count == 4)
                {
                    returnList.Add(inputArray[i]);
                }
            }
            return returnList.ToArray();
        }
        public void ShowAnswer(string [] inputArray)
        {
            Console.Write("\n       ");
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write(inputArray[i] + " ");
            }
            Console.WriteLine();
        }
        public void ChallengeDesription()
        {
            Console.WriteLine("       Challenge 19: Return the Four Letter Strings");
            Console.WriteLine("       Create a function that takes an array of strings and returns the words that are exactly four letters.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       IsFourLetters('Tomato', 'Potato', 'Pair') --> ['Pair']");
            Console.WriteLine("       IsFourLetters('Kangaroo', 'Bear', 'Fox') --> ['Bear']");
            Console.WriteLine("       IsFourLetters('Ryan', 'Kieran', 'Jason', 'Matt') --> ['Ryan', 'Matt']");
        }
    }
}
//Return the Four Letter Strings https://edabit.com/challenge/W4x4o2M7ny6Cqkfhn
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