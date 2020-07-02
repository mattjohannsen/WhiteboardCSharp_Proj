using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge25
    {
        public void RunChallenge()
        {
            ChallengeDescription();
            char originalChar = 'A';
            Console.WriteLine($"       Original Char = {originalChar} --> CounterpartCharCode = {CounterpartCharCode(originalChar)}");
            originalChar = 'a';
            Console.WriteLine($"       Original Char = {originalChar} --> CounterpartCharCode = {CounterpartCharCode(originalChar)}");
        }
        public int CounterpartCharCode(char inputChar)
        {
            int returnValue;
            if (Char.IsUpper(inputChar))
            {
                returnValue = Char.ToLower(inputChar);
           }
            else if (Char.IsLower(inputChar))
            {
                returnValue = Char.ToUpper(inputChar);
            }
            else
            {
                returnValue = (int)inputChar;
            }
            return returnValue;
        }

        public void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 25: Find the Characters Counterpart Char Code");
            Console.WriteLine("       Create a function that takes a single character as an argument and returns");
            Console.WriteLine("       the char code of its lowercased / uppercased counterpart.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       Given that:");
            Console.WriteLine("       - 'A' char code is: 65");
            Console.WriteLine("       - 'a' char code is: 97");
            Console.WriteLine("       CounterpartCharCode('A') -->97");
            Console.WriteLine("       CounterpartCharCode('a') --> 65");
            Console.WriteLine("       Notes");
            Console.WriteLine("       The argument will always be a single character.");
            Console.WriteLine("       Not all inputs will have a counterpart(e.g.numbers), in which case return the inputs char code.\n");
        }
    }
}
//Find the Characters Counterpart Char Code
//Create a function that takes a single character as an argument and returns the char code of its lowercased / uppercased counterpart.
//Examples
//Given that:
//  - 'A' char code is: 65
//  - 'a' char code is: 97
//CounterpartCharCode('A') -->97
//CounterpartCharCode('a') --> 65
//Notes
//The argument will always be a single character.
//Not all inputs will have a counterpart(e.g.numbers), in which case return the inputs char code.
// Steps
// Create originalChar char variable
// Create CounterpartCharCode method which takes in inputChar and checks to see if it is upperCase
// if it is uppercase, turn it into lowercase and get the char code value which is the returnValue
// else if it is lowercase, turn it into uppercase and get the char code value which is the returnValue
// else it is netiher uppercase or lowercase so return the char code value of original inputChar