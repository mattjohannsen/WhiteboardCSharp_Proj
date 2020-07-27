using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge13
    {
        public void RunChallenge()
        {
            Console.WriteLine("       This is Challenge 13");
            ChallengeDescription();
            string initialString = "javascript is cool";
            Console.WriteLine("\n       Initial String: " + initialString);
            Console.WriteLine("        Hacker Speak: " + HackerSpeak(initialString));
            initialString = "programming is fun";
            Console.WriteLine("\n       Initial String: " + initialString);
            Console.WriteLine("        Hacker Speak: " + HackerSpeak(initialString));
            initialString = "become a coder";
            Console.WriteLine("\n       Initial String: " + initialString);
            Console.WriteLine("        Hacker Speak: " + HackerSpeak(initialString));
            //Console.WriteLine(HackerSpeak(initialString));
        }

        //public string GetHackerSpeak(string inputString)
        //{
        //    return new string((ReplaceChar(ReplaceChar(ReplaceChar(ReplaceChar(ReplaceChar(TurnStringIntoList(inputString), 'a', '4'), 'e', '3'), 'i', '1'), 'o', '0'), 's', '5')).ToArray());
        //}
        //public List<char> TurnStringIntoList(string inputString)
        //{
        //    return inputString.ToCharArray().ToList();
        //}
        //public List<char> ReplaceChar(List<char> inputList, char unwantedCharacter, char replacmentCharacter)
        //{
        //    for (int i = 0; i < inputList.Count; i++)
        //    {
        //        if (inputList[i] == unwantedCharacter)
        //        {
        //            inputList[i] = replacmentCharacter;
        //        }
        //    }
        //    return inputList;
        //}
        public void ChallengeDescription()
        {
            Console.WriteLine("       This is Challenge 13: H4ck3r Sp34k");
            Console.WriteLine("       Create a function that takes a string as an argument and returns a coded (h4ck3r 5p34k) version of the string.");
            Console.WriteLine("       HackerSpeak('javascript is cool') --> 'j4v45cr1pt 15 c00l'");
            Console.WriteLine("       HackerSpeak('programming is fun') --> 'pr0gr4mm1ng 15 fun'");
            Console.WriteLine("       HackerSpeak('become a coder') --> 'b3c0m3 4 c0d3r'");
        }

        public static string HackerSpeak(string inputString)
        {
            char[][] charactersToReplace = new char[][] { new char[] { 'a', '4' }, new char[] { 'e', '3' }, new char[] { 'i', '1' }, new char[] { 'o', '0' }, new char[] { 's', '5' } };
            return new string(MakeArrayReplacements(inputString.ToCharArray(), charactersToReplace));
        }
        public static char[] MakeArrayReplacements(char[] inputArray, char[][] replacementsArray)
        {
            for (int i = 0; i < replacementsArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length; j++)
                {
                    if (inputArray[j] == replacementsArray[i][0])
                    {
                        inputArray[j] = replacementsArray[i][1];
                    }
                }
            }
            return inputArray;
        }
    }
}
// Steps
// Create method GetHackerSpeak that takes in a string and returns a string
// Create a helper method that turns a string into a List TurnStringIntoList
// Create a variable initialList that is equal to TurnStringIntoList(inputString)
// Create a helper method that takes a list, an unwantedCharacter, and it's replacmentCharacter and returns a list GetListWithNewCharacters
// pass this method the initialList GetListWithNewCharacters(initialList)
// Create a variable listWithNoAs
// create a variable listWithNoAs which is equal to  GetListWithNewCharacters(initialList, a, 4)
// create a variable listWithNoEs which is equal to  GetListWithNewCharacters(listWithNoAs, e, 3)
// create a variable listWithNoIs which is equal to GetListWithNewCharacters(listWithNoAs, i, 1)
// create a variable listWithNoOs which is equal to GetListWithNewCharacters(listWithNoIs, o, 0)
// create a variable listWithNoSs which is equal to GetListWithNewCharacters(listWithNoOs, s, 5)
// create a variable hackerCodeString is equal to listWithNoSs turned into a String
// return string

//H4ck3r Sp34k https://edabit.com/challenge/7nzfry4P3WrrL7t38
//Create a function that takes a string as an argument and returns a coded(h4ck3r 5p34k) version of the string.

//Examples
//HackerSpeak("javascript is cool") ➞ "j4v45cr1pt 15 c00l"

//HackerSpeak("programming is fun") ➞ "pr0gr4mm1ng 15 fun"

//HackerSpeak("become a coder") ➞ "b3c0m3 4 c0d3r"
//Notes
//In order to work properly, the function should replace all "a"s with 4, "e"s with 3, "i"s with 1, "o"s with 0, and "s"s with 5.