using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge38
    {
        public void RunChallenge()
        {
            ChallengeDescription();
            Console.WriteLine($"       ConvertToHex('hello world') --> {ConvertToHex("hello world")}");
            Console.WriteLine($"       ConvertToHex('Big Boi') --> {ConvertToHex("Big Boi")}");
            Console.WriteLine($"       ConvertToHex('Marty Poppinson') --> {ConvertToHex("Marty Poppinson")}");
        }
        private string ConvertToHex(string inputString)
        {
            char[] stringAsArray = inputString.ToCharArray();
            string[] hexArray = new string[stringAsArray.Length];
            for (int i = 0; i < stringAsArray.Length; i++)
            {
                hexArray[i] = Convert.ToByte(stringAsArray[i]).ToString("x");
            }
            return string.Join(" ", hexArray);
        }
        private void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 38: Convert to Hex");
            Console.WriteLine("       Create a function that takes a strings characters as ASCII");
            Console.WriteLine("       and returns each characters hexadecimal value as a string.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       ConvertToHex(hello world) --> 68 65 6c 6c 6f 20 77 6f 72 6c 64");
            Console.WriteLine("       ConvertToHex(Big Boi) --> 42 69 67 20 42 6f 69");
            Console.WriteLine("       ConvertToHex(Marty Poppinson) --> 4d 61 72 74 79 20 50 6f 70 70 69 6e 73 6f 6e");
            Console.WriteLine("       Notes");
            Console.WriteLine("       Each byte must be seperated by a space.");
            Console.WriteLine("       All alpha hex characters must be lowercase.\n");
        }
    }
}
//Convert to Hex
//Create a function that takes a strings characters as ASCII and returns each characters hexadecimal value as a string.
//Examples
//ConvertToHex("hello world") --> "68 65 6c 6c 6f 20 77 6f 72 6c 64"
//ConvertToHex("Big Boi") --> "42 69 67 20 42 6f 69"
//ConvertToHex("Marty Poppinson") --> "4d 61 72 74 79 20 50 6f 70 70 69 6e 73 6f 6e"
//Notes
//Each byte must be seperated by a space.
//All alpha hex characters must be lowercase.
// Steps
// Turn inputString into char[] Array --> stringAsArray
// Create hexArray