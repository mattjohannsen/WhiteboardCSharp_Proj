using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge52
    {
        public void RunChallenge()
        {
            Console.WriteLine("       Challenge 52");
            Console.WriteLine($"|{TextToNumberBinary("zero one zero one zero one zero one")}|");
            Console.WriteLine($"|{TextToNumberBinary("Zero one zero ONE zero one zero one")}|");
            Console.WriteLine($"|{TextToNumberBinary("zero one zero one zero one zero one one two")}|");
            Console.WriteLine($"|{TextToNumberBinary("zero one zero one zero one zero three")}|");
            Console.WriteLine($"|{TextToNumberBinary("one one")}|");
        }
        public static string TextToNumberBinary(string str)
        {
            string[] arr = str.ToLower().Split(' ');
            List<char> solutionList = new List<char>();
            if (arr.Length < 8)
            {
                return "";
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == "zero")
                {
                    solutionList.Add('0');
                }
                else if (arr[i] == "one")
                {
                    solutionList.Add('1');
                }
            }
            int loopLength = solutionList.Count / 8;
            List<char> returnList = new List<char>();
            for (int i = 0; i < loopLength*8; i++)
            {
                returnList.Add(solutionList[i]);
            }
            return string.Join("", returnList.ToArray());
        }
    }
}
//Convert "Zero" and "One" to "1" and "0"
//Create a function that takes a string as an argument.The function must return a string containing 1s and 0s based on the string argument's words. If any word in the argument is not equal to "zero" or "one" (case insensitive), you should ignore it. The returned string's length should be a multiple of 8, if the string is not a multiple of 8 you should remove the numbers in excess.
//Examples
//TextToNumberBinary("zero one zero one zero one zero one") --> "01010101"
//TextToNumberBinary("Zero one zero ONE zero one zero one") --> "01010101"
//TextToNumberBinary("zero one zero one zero one zero one one two") --> "01010101"
//TextToNumberBinary("zero one zero one zero one zero three") --> ""
//TextToNumberBinary("one one") --> ""
//Notes
//You must return the result as a string.
// Steps
// take str and turn into an array
// create string solutionString
// loop through array and turn all letters lowercase
// loop through array 8 times
// if arr[i] == "zero"
// solutionString = solutionString + "0"
// else if 
// arr[i] == "one"
// solutionString = solutionString + "1"
// else
// return "";
// return solutionString;