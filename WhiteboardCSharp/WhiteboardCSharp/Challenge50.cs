using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge50
    {
        public void RunChallenge()
        {
            ChallengeDescription();
            Console.WriteLine(DoesRhyme("Sam I am!", "Green eggs and ham."));
            Console.WriteLine(DoesRhyme("Sam I am!", "Green eggs and HAM."));
            Console.WriteLine(DoesRhyme("You are off to the races", "a splendid day."));
            Console.WriteLine(DoesRhyme("and frequently do?", "you gotta move."));
        }
        public static bool DoesRhyme(string str1, string str2)
        {
            char[] arrayOne = Regex.Replace(str1.Split(' ').Last().ToLower(), "[^a-zA-Z]", "").ToCharArray();
            char[] arrayTwo = Regex.Replace(str2.Split(' ').Last().ToLower(), "[^a-zA-Z]", "").ToCharArray();
            Array.Reverse(arrayOne);
            Array.Reverse(arrayTwo);
            string vowels = "aeiou";
            int loopCount = Math.Min(arrayOne.Length, arrayTwo.Length);
            for (int i = 0; i < loopCount; i++)
            {
                if (arrayOne[i] != arrayTwo[i])
                {
                    return false;
                }
                else
                {
                    if (vowels.Contains(arrayOne[i]))
                    {
                        return true;
                    }
                }
            }
            return true;
        }
        public void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 50: Rhyme Time");
            Console.WriteLine("       Create a function that returns true if two lines rhyme and false otherwise.");
            Console.WriteLine("       For the purposes of this exercise, two lines rhyme if the last word from");
            Console.WriteLine("       each sentence contains the same vowels.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       DoesRhyme(Sam I am!, Green eggs and ham.) --> true");
            Console.WriteLine("       DoesRhyme(Sam I am!, Green eggs and HAM.) --> true");
            Console.WriteLine("       Capitalization and punctuation should not matter.");
            Console.WriteLine("       DoesRhyme(You are off to the races, a splendid day.) --> false");
            Console.WriteLine("       DoesRhyme(and frequently do? , you gotta move.) -->false");
            Console.WriteLine("       Notes");
            Console.WriteLine("       Case insensitive.\n");
        }
    }
}
//Rhyme Time
//Create a function that returns true if two lines rhyme and false otherwise.For the purposes of this exercise, two lines rhyme if the last word from each sentence contains the same vowels.
//Examples
//DoesRhyme("Sam I am!", "Green eggs and ham.") --> true
//DoesRhyme("Sam I am!", "Green eggs and HAM.") --> true
//// Capitalization and punctuation should not matter.
//DoesRhyme("You are off to the races", "a splendid day.") --> false
//DoesRhyme("and frequently do?", "you gotta move.") -->false
//Notes
//Case insensitive.
//Here we are disregarding cases like "thyme" and "lime".
//We are also disregarding cases like "away" and "today" (which technically rhyme, even though they contain different vowels).
//Steps
// turn the sentences into an array
// remove the last words of sentences --> lastWordOne, lastWordTwo
// remove punctuation from lastWordOne, lastWordTwo
// turn lastWordOne, lastWordTwo into arrays --> arrayOne, arrayTwo
// Reverse arrayOne, arrayTwo
// string vowels = "aeiou"
// loop through i loop
// if arrayOne[i] != arrayTwo[i]
// return false
// else
// if arrayOne[i] == "a" or "i" or "e" or o or u
// then return true;
// else
// continue
// return true;