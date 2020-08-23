using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge65
    {
        public void RunChallenge()
        {
            ChallengeDescription();
            Console.WriteLine(EncodeMorse("EDABBIT CHALLENGE"));
            //Console.WriteLine();
        }
        public static string EncodeMorse(string str)
        {
            Dictionary<char, string> codeValues = new Dictionary<char, string>()
            {
                {'a', ".-"},
                {'b', "-..."},
                {'c', "-.-."},
                {'d', "-.."},
                {'e', "."},
                {'f', "..-."},
                {'g', "--."},
                {'h', "...."},
                {'i', ".."},
                {'j', ".---"},
                {'k', "-.-"},
                {'l', ".-.."},
                {'m', "--"},
                {'n', "-."},
                {'o', "---"},
                {'p', ".--."},
                {'q', "--.-"},
                {'r', ".-."},
                {'s', "..."},
                {'t', "-"},
                {'u', "..-"},
                {'v', "...-"},
                {'w', ".--"},
                {'x', "-..-"},
                {'y', "-.--"},
                {'z', "--.."},
                {'0', "-----"},
                {'1', ".----"},
                {'2', "..---"},
                {'3', "...--"},
                {'4', "....-"},
                {'5', "....."},
                {'6', "-...."},
                {'7', "--..."},
                {'8', "---.."},
                {'9', "----."},
                {',', "--..--"},
                {':', "---..."},
                {'\'', ".----."},
                {'.', ".-.-.-"},
                {'?', "..--.."},
                {'!', "-.-.--"},
                {' ', " "}
            };
            List<string> morseCode = new List<string>();
            foreach (var item in str.ToLower())
            {
                morseCode.Add(codeValues[item]);
            }
            return string.Join(" ", morseCode);
        }
        public void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 65: Encode Morse");
            Console.WriteLine("       Create a function that takes a string as an argument and return a non-encoded, encrypted string.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       EncodeMorse(EDABBIT CHALLENGE) --> . - .. .- -... -... ..- -.-. .... .- .- .. .-.. . -. --. .");
            Console.WriteLine("       EncodeMorse(HELP ME!) --> .... . .-.. .--.   --.   -.-.--");
            Console.WriteLine("       Notes");
            Console.WriteLine("       Input value can be lower or upper case.");
            Console.WriteLine("       Input string can have digits.");
            Console.WriteLine("       Input string can have some special characters:");
            Console.WriteLine("       (e.g.comma, colon, apostrophe, period, question mark, exclamation mark)\n");
        }
    }
}
//Encode Morse
//Create a function that takes a string as an argument and return a non-encoded, encrypted string.

//Examples
//EncodeMorse("EDABBIT CHALLENGE") --> ". -.. .- -... -... .. -   -.-. .... .- .-.. .-.. . -. --. ."

//EncodeMorse("HELP ME !") --> ".... . .-.. .--.   -- .   -.-.--"
//Notes
//Input value can be lower or upper case.
//Input string can have digits.
//Input string can have some special characters (e.g.comma, colon, apostrophe, period, question mark, exclamation mark).