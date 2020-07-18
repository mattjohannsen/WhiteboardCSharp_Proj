using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge41
    {
        public void RunChallenge()
        {
            Console.WriteLine("       Challenge 41");
            Console.WriteLine($"       DuplicateCount(abcde) --> {DuplicateCount("abcde")}");
            Console.WriteLine($"       DuplicateCount(aabbcde) --> {DuplicateCount("aabbcde")}");
            Console.WriteLine($"       DuplicateCount(Indivisibilities) --> {DuplicateCount("Indivisibilities")}");
            Console.WriteLine($"       DuplicateCount(Aa) --> {DuplicateCount("Aa")}");
        }
        public int DuplicateCount(string inputString)
        {
            int duplicateCount = 0;
            char[] stringAsArray = inputString.ToCharArray();
            List<char> alreadyCounted = new List<char>();
            for (int i = 0; i < stringAsArray.Length; i++)
            {
                if (!alreadyCounted.Contains(stringAsArray[i]))
                {
                    int numberToAdd = HowManyOccurances(stringAsArray[i], stringAsArray);
                    duplicateCount += numberToAdd;
                    alreadyCounted.Add(stringAsArray[i]);
                }
                else
                {
                    continue;
                }

            }
            return duplicateCount;
        }
        public int HowManyOccurances(char inputChar, char[] inputArray)
        {
            int duplicateCount = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == inputChar)
                {
                    duplicateCount++;
                }
            }
            if (duplicateCount>1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
//Count the Number of Duplicate Characters
//Create a function that takes a string and returns the number of alphanumeric characters that occur more than once.
//Examples
//DuplicateCount(abcde) --> 0
//DuplicateCount(aabbcde) --> 2
//DuplicateCount(Indivisibilities) --> 2
//DuplicateCount(Aa) --> 0
//// Case sensitive
//Notes
//Duplicate characters are case sensitive.
//The input string will contain only alphanumeric characters.
// Steps
// Create int DuplicateCount(inputString) method
// create char[] stringAsArray = inputString.ToCharArray
// create int[] duplicateArray
// create int duplicateCount = 0;
// start i loop going through each index one at a time
// pass duplicateArray[i] to HowManyOccurances to check for occurances
// duplicateCount += HowManyOccurances(char, stringAsArray);
// return duplicateCount;
// HowManyOccurances(char inputChar char inputArray)
// create int duplicateCount
// start loop i
// if inputArray[i]== inputChar then add 1 to duplicateCount