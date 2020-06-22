using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge18
    {
        public void RunChallenge()
        {
            ChallengeDesription();
            string orignalString = "mice";
            int nTimes = 5;
            Console.WriteLine($"       Original string: '{orignalString}', n times: ({nTimes}) --> {RepeatNTimes(orignalString, nTimes)}");
            orignalString = "hello";
            nTimes = 3;
            Console.WriteLine($"       Original string: '{orignalString}', n times: ({nTimes}) --> {RepeatNTimes(orignalString, nTimes)}");
            orignalString = "stop";
            nTimes = 1;
            Console.WriteLine($"       Original string: '{orignalString}', n times: ({nTimes}) --> {RepeatNTimes(orignalString, nTimes)}");
        }

        public string RepeatNTimes(string inputString, int inputNumber)
        {
            List<char> stringAsList = inputString.ToList();
            List<char> returnList = new List<char>();
            for (int i = 0; i < stringAsList.Count; i++)
            {
                for (int j = 0; j < inputNumber; j++)
                {
                    returnList.Add(stringAsList[i]);
                }
            }
            return string.Join("", returnList);
        }

        public void ChallengeDesription()
        {
            Console.WriteLine("       Challenge 18: Repeating Letters N Times");
            Console.WriteLine("       Create a function that repeats each character in a string n times.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       Repeat('mice', 5) --> 'mmmmmiiiiiccccceeeee'");
            Console.WriteLine("       Repeat('hello', 3) --> 'hhheeellllllooo'");
            Console.WriteLine("       Repeat('stop', 1) --> 'stop'");
        }
    }
}
//Repeating Letters N Times https://edabit.com/challenge/Lmhmtj3QZw9cF5Zew
//Create a function that repeats each character in a string n times.
//Examples
//Repeat("mice", 5) ➞ "mmmmmiiiiiccccceeeee"
//Repeat("hello", 3) ➞ "hhheeellllllooo"
//Repeat("stop", 1) ➞ "stop"
// Steps
// create variable orignalString;
// create variable nTimes;
// send orignalString and nTimes into the RepeatNTimes method
// create a stringAsList variable using the inputString
// create a new returnList variable
// create a new returnString variable
// create an i loop through the stringAsList variable
// for each character in the stringAsList variable
// create a new j loop that Adds stringAsList[i] to the returnList nTimes
// take the returnList and turn it into a string and return it
