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
            //string initialString = "javascript is cool";
            //string initialString = "programming is fun";
            string initialString = "become a coder";
            Console.WriteLine(initialString);
            Console.WriteLine(GetHackerSpeak(initialString));
        }

        public string GetHackerSpeak(string inputString)
        {
            List<char> initialList = TurnStringIntoList(inputString);
            List<char> listWithNoAs = GetListWithNewCharacters(initialList, 'a', '4');
            List<char> listWithNoEs = GetListWithNewCharacters(listWithNoAs, 'e', '3');
            List<char> listWithNoIs = GetListWithNewCharacters(listWithNoEs, 'i', '1');
            List<char> listWithNoOs = GetListWithNewCharacters(listWithNoIs, 'o', '0');
            List<char> listWithNoSs = GetListWithNewCharacters(listWithNoOs, 's', '5');
            string hackerCodeString = new string(listWithNoSs.ToArray());
            return hackerCodeString;
        }

        public List<char> TurnStringIntoList(string inputString)
        {
            List<char> returnList = inputString.ToCharArray().ToList();
            return returnList;
        }

        public List<char> GetListWithNewCharacters(List<char> inputList, char unwantedCharacter, char replacmentCharacter)
        {
            List<char> returnList = inputList;
            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] == unwantedCharacter)
                {
                    inputList[i] = replacmentCharacter;
                }
            }
            return returnList;
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


//H4ck3r Sp34k
//Create a function that takes a string as an argument and returns a coded(h4ck3r 5p34k) version of the string.

//Examples
//HackerSpeak("javascript is cool") ➞ "j4v45cr1pt 15 c00l"

//HackerSpeak("programming is fun") ➞ "pr0gr4mm1ng 15 fun"

//HackerSpeak("become a coder") ➞ "b3c0m3 4 c0d3r"
//Notes
//In order to work properly, the function should replace all "a"s with 4, "e"s with 3, "i"s with 1, "o"s with 0, and "s"s with 5.