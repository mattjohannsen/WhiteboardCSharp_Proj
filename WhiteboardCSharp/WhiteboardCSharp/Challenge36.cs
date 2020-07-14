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
            Console.WriteLine("       Challenge36");
            Console.WriteLine(CharRepeatString("A4B5C2"));
            Console.WriteLine(CharRepeatString("C2F1E5"));
            Console.WriteLine(CharRepeatString("T4S2V2"));
            Console.WriteLine(CharRepeatString("A1B2C3D4"));

        }
        private string CharRepeatString(string inputString)
        {
            List<char> stringToList = inputString.ToList();
            string solutionString = "";
            for (int i = 0; i < stringToList.Count; i+=2)
            {
                string charToAdd = stringToList[i].ToString();
                int loopCount = Int32.Parse(stringToList[i + 1].ToString());
                for (int j = 0; j < loopCount; j++)
                {
                    solutionString = solutionString + charToAdd;
                }
            }
            return solutionString;
        }
    }
}
//Reverse Coding Challenge #1
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
