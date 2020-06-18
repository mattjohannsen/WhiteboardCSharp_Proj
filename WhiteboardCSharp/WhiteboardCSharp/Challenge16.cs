using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge16
    {
        public void RunChallenge()
        {
            ChallengeDescription();
            string originalString = "loop";
            Console.WriteLine($"       Original String: {originalString} --> {AreThereDoubles(originalString)}");
             originalString = "yummy";
            Console.WriteLine($"       Original String: {originalString} --> {AreThereDoubles(originalString)}");
            originalString = "orange";
            Console.WriteLine($"       Original String: {originalString} --> {AreThereDoubles(originalString)}");
            originalString = "munchkin";
            Console.WriteLine($"       Original String: {originalString} --> {AreThereDoubles(originalString)}");

        }

        public bool AreThereDoubles(string inputString)
        {
            List<char> stringAsList = inputString.ToList();
            char previousChar = stringAsList[0];
            for (int i = 0; i < stringAsList.Count; i++)
            {
                if (i != 0)
                {
                    if (stringAsList[i] == previousChar)
                    {
                        return true;
                    }
                    else
                    {
                        previousChar = stringAsList[i];
                    }
                }
            }
            return false;
        }

        public void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 16: Double Letters");
            Console.WriteLine("       Create a function that takes a word and returns true if the word has two consecutive identical letters.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       DoubleLetters('loop') --> True");
            Console.WriteLine("       DoubleLetters('yummy') --> True");
            Console.WriteLine("       DoubleLetters('orange') --> False");
            Console.WriteLine("       DoubleLetters('munchkin') --> False");
        }
    }
}
//Double Letters https://edabit.com/challenge/ugg9ZK7xY5vk5qJXr
//Create a function that takes a word and returns true if the word has two consecutive identical letters.
//Examples
//DoubleLetters('loop') ➞ true
//DoubleLetters('yummy') ➞ true
//DoubleLetters('orange') ➞ false
//DoubleLetters('munchkin') ➞ false
// Steps
// Create a variable originalString which is equal to "loop"
// Create a method AreThereDoubles which takes in an inputString and returns a bool value containsDouble which is set to false at the beginning of method
// Turn the string into a list stringAsList
// Loop through stringAsList
// set a variable previousChar on the first loop where i = 0 previousChar
// if stringAsList[i] is equal to previousChar then return containsDouble as true
// otherwise after the loop is complete return containsDouble which will still be false.