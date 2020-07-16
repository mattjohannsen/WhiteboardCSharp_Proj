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
            Console.WriteLine("       Challenge38");
            Console.WriteLine(ConvertToHex("hello world"));
            Console.WriteLine(ConvertToHex("Big Boi"));
            Console.WriteLine(ConvertToHex("Marty Poppinson"));
        }
        private string ConvertToHex(string inputString)
        {
            char[] stringAsArray = inputString.ToCharArray();
            int arrayLength = stringAsArray.Length;
            string[] hexArray = new string[arrayLength];
            for (int i = 0; i < stringAsArray.Length; i++)
            {
                byte tempByte = Convert.ToByte(stringAsArray[i]);
                hexArray[i] = tempByte.ToString("x");
            }
            return string.Join(" ", hexArray);
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