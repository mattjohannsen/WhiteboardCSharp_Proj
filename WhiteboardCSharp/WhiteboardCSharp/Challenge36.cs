using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    class Challenge36
    {
        public void RunChallenge()
        {
            ChallengeDescription();
            Console.WriteLine($"       RepeatCharNoOfTimes('A4B5C2') --> {RepeatCharNoOfTimes("A4B5C2")}");
            Console.WriteLine($"       RepeatCharNoOfTimes('C2F1E5') --> {RepeatCharNoOfTimes("C2F1E5")}");
            Console.WriteLine($"       RepeatCharNoOfTimes('T4S2V2') --> {RepeatCharNoOfTimes("T4S2V2")}");
            Console.WriteLine($"       RepeatCharNoOfTimes('A1B2C3D4') --> {RepeatCharNoOfTimes("A1B2C3D4")}");

        }
        private string RepeatCharNoOfTimes(string inputString)
        {
            List<char> stringToList = inputString.ToList();
            string solutionString = "";
            for (int i = 0; i < stringToList.Count; i+=2)
            {
                for (int j = 0; j < Int32.Parse(stringToList[i + 1].ToString()); j++)
                {
                    solutionString += stringToList[i].ToString();
                }
            }
            return solutionString;
        }
        private void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 35: Reverse Coding Challenge #1");
            Console.WriteLine("       This is a reverse coding challenge.Normally you're given explicit directions with how");
            Console.WriteLine("       to create a function. Here, you must generate your own function to to satisfy the");
            Console.WriteLine("       relationship between the inputs and outputs.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       RepeatCharNoOfTimes(A4B5C2) --> AAAABBBBBCC");
            Console.WriteLine("       RepeatCharNoOfTimes(C2F1E5) --> CCFEEEEE");
            Console.WriteLine("       RepeatCharNoOfTimes(T4S2V2) --> TTTTSSVV");
            Console.WriteLine("       RepeatCharNoOfTimes(A1B2C3D4) --> ABBCCCDDDD\n");
        }
    }
}
//Reverse Coding Challenge #1 https://edabit.com/challenge/bqveyPRgcWZM7XzMQ
//This is a reverse coding challenge.Normally you're given explicit directions with how to create a function. Here, you must generate your own function to satisfy the relationship between the inputs and outputs.
//Your task is to create a function that, when fed the inputs below, produce the sample outputs shown.
//Examples
//A4B5C2 --> AAAABBBBBCC
//C2F1E5 --> CCFEEEEE
//T4S2V2 --> TTTTSSVV
//A1B2C3D4 --> ABBCCCDDDD
// Steps
// Turn input String into a char List stringToList//
// create solutionString;
// Loop through stringToList increase by 2
// string charToAdd = stringToList[i];
// start new loop j loop is stringToList[i+1]
// solutionString = solutionString + charToAdd
// return solutionString
