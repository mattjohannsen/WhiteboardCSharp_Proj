using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge5
    {
        public void RunChallenge()
        {
            string startingString = "3 9 0 1 4 8 10 2";

            Console.WriteLine("       This is challenge 5");
            Console.WriteLine(GetSolution(startingString));

        }

        public string GetSolution(string inputString)
        {
            string solutionString = "";
            int solutionInt;
            List<string> startingStringList = inputString.Split(' ').ToList();
            List<int> startingIntList = startingStringList.Select(int.Parse).ToList();
            List<int> solutionList = new List<int>();
            List<string> solutionStringList = new List<string>();

            startingIntList.Sort();
            solutionList.Add(startingIntList[0]);
            solutionList.Add(startingIntList[startingIntList.Count - 1]);
            for (int i = 0; i < solutionList.Count; i++)
            {
                solutionStringList.Add(solutionList[i].ToString());
            }
            for (int i = 0; i < solutionStringList.Count; i++)
            {
                Console.WriteLine(solutionStringList[i]);
            }
            solutionString = solutionStringList.ToString();
            solutionString = string.Join(" ", solutionStringList.ToArray());
            //solutionString = string.Join(";", myList.ToArray());
            return solutionString;
            //List<int> startingIntList = 
        }
    }
}
//5.	Create a method that accepts a string of space separated numbers and returns the highest and lowest number as a string
//a.Use case: “3 9 0 1 4 8 10 2”  “0 10”

//    Steps
//    Create a string variable equal to “3 9 0 1 4 8 10 2”.
//    Create a list variable
//    Create a solution list variable
//    Create a solution string variable
//    Split that string into pieces and convert it ToList and make it equal the list variable
//    Sort the list
//    The lowest number will be at the 0 index of the list variable
//        Add this to the Solution List at index 0
//    The highest number will be at the Count -1 Index of the list variable.
//        Add this to the Solution List at index 1
//    Convert the Solution List ToString and make this value equal the Solution String
//    Return the Solution String.

