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
            Console.WriteLine("       Challenge65");
            Console.WriteLine(EncodeMorse("EDABBIT CHALLENGE"));
            //Console.WriteLine();
        }
        public static string EncodeMorse(string str)
        {
            str = str.ToLower();
            char[] arr = str.ToCharArray();
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
                {'!', "-.-.--"}
            };
            string morseCode = "";
            for (int i = 0; i < arr.Length; i++)
            {
                string result;
                if (i == arr.Length -1)
                {
                    if (codeValues.TryGetValue(arr[i], out result))
                    {
                        morseCode += result;
                    }
                    else if (Char.IsWhiteSpace(arr[i]))
                    {
                        morseCode += arr[i];
                    }
                }
                else
                {
                    if (codeValues.TryGetValue(arr[i], out result))
                    {
                        morseCode += result + " ";
                    }
                    else if (Char.IsWhiteSpace(arr[i]))
                    {
                        morseCode += arr[i] + " ";
                    }
                }

            }
            return morseCode.ToString();
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