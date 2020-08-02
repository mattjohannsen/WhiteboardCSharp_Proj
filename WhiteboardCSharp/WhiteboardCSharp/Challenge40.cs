using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge40
    {
        public void RunChallenge()
        {
            ChallengeDescription();
            //Console.WriteLine($"       AlphabetIndex(Wow, does that work?) --> {AlphabetIndex("Wow, does that work?")}");
            //Console.WriteLine($"       AlphabetIndex(The river stole the gods.) --> {AlphabetIndex("The river stole the gods.")}");
            //Console.WriteLine($"       AlphabetIndex(We have a lot of rain in June.) --> {AlphabetIndex("We have a lot of rain in June.")}");
            Console.WriteLine($"       AlphabetIndex(The#b00k$is*in^fr0nt#0f!the_taBle.) --> {AlphabetIndex("The#b00k$is*in^fr0nt#0f!the_taBle.")}");
        }
    public static string AlphabetIndex(string str)
    {
        List<char> stringAsList = Regex.Replace(str, "[^A-Za-z]", "").ToList();
        List<int> solutionList = new List<int>();
        for (int i = 0; i < stringAsList.Count; i++)
        {
            solutionList.Add(char.ToUpper(stringAsList[i]) - 64);
        }
        return string.Join(" ", solutionList);
    }
        public void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 40: Replace Letters With Position In Alphabet");
            Console.WriteLine("       Create a function that takes a string and replaces each letter with its");
            Console.WriteLine("       appropriate position in the alphabet. 'a' is 1, 'b' is 2, 'c' is 3, etc, etc.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       AlphabetIndex(Wow, does that work?) --> 23 15 23 4 15 5 19 20 8 1 20 23 15 18 11");
            Console.WriteLine("       AlphabetIndex(The river stole the gods.) --> 20 8 5 18 9 22 5 18 19 20 15 12 5 20 8 5 7 15 4 19");
            Console.WriteLine("       AlphabetIndex(We have a lot of rain in June.) --> 23 5 8 1 22 5 1 12 15 20 15 6 18 1 9 14 9 14 10 21 14 5");
            Console.WriteLine("       Notes");
            Console.WriteLine("       If any character in the string isn't a letter, ignore it.\n");
        }
    }
}
//Replace Letters With Position In Alphabet
//Create a function that takes a string and replaces each letter with its appropriate position in the alphabet. 'a' is 1, 'b' is 2, 'c' is 3, etc, etc.
//Examples
//AlphabetIndex('Wow, does that work?') --> '23 15 23 4 15 5 19 20 8 1 20 23 15 18 11'
//AlphabetIndex('The river stole the gods.') --> '20 8 5 18 9 22 5 18 19 20 15 12 5 20 8 5 7 15 4 19'
//AlphabetIndex('We have a lot of rain in June.') --> '23 5 8 1 22 5 1 12 15 20 15 6 18 1 9 14 9 14 10 21 14 5'
//Notes
//If any character in the string isn't a letter, ignore it.
// Steps
// Turn the string into a char List --> stringAsList
// Go through char List and remove any items that are not letters in alphabet
// create solutionList List<int>
// Begin loop for turning the characters into their respective alphabet index
// solutionList[i] = char.ToUpper(stringAsList[i]) - 64;
// string solutionString = string.Join(" ", solutionList);