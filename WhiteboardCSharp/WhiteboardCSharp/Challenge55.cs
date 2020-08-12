using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge55
    {
        public void RunChallenge()
        {
            Console.WriteLine("       Challenge 55");
            Console.WriteLine($"       Encrypt(banana) ==> {Encrypt("banana")}");
            Console.WriteLine($"       Encrypt(karaca) ==> {Encrypt("karaca")}");
            Console.WriteLine($"       Encrypt(burak) ==> {Encrypt("burak")}");
            Console.WriteLine($"       Encrypt(alpaca) ==> {Encrypt("alpaca")}");
        }
        public static string Encrypt(string word)
        {
            char[] arr = word.ToCharArray();
            Array.Reverse(arr);
            return new string(arr).Replace("a", "0").Replace("e", "1").Replace("i", "2").Replace("o", "2").Replace("u", "3") + "aca";
        }
        public void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 55: The Karaca's Encryption Algorithm");
            Console.WriteLine("       Make a function that encrypts a given input with these steps:");
            Console.WriteLine("       Input: 'apple'");
            Console.WriteLine("       Step 1: Reverse the input: 'elppa'");
            Console.WriteLine("       Step 2: Replace all vowels using the following chart:");
            Console.WriteLine("       a => 0");
            Console.WriteLine("       e => 1");
            Console.WriteLine("       i => 2");
            Console.WriteLine("       o => 2");
            Console.WriteLine("       u => 3");
            Console.WriteLine("       '1lpp0'");
            Console.WriteLine("       Step 3: Add 'aca' to the end of the word: '1lpp0aca'");
            Console.WriteLine("       Output: '1lpp0aca'");
            Console.WriteLine("       Examples");
            Console.WriteLine("       Encrypt(banana) => 0n0n0baca");
            Console.WriteLine("       Encrypt(karaca) => 0c0r0kaca");
            Console.WriteLine("       Encrypt(burak) => k0r3baca");
            Console.WriteLine("       Encrypt(alpaca) => 0c0pl0aca");
            Console.WriteLine("       Notes");
            Console.WriteLine("       All inputs are strings, no uppercases and all output must be strings.\n");
        }
    }
}
// Steps
// Turn string into array
// reverse array
// replace characters
// turn array into a string
// add "aca" to end.
// return string

//The Karaca's Encryption Algorithm
//Make a function that encrypts a given input with these steps:
//Input: "apple"
//Step 1: Reverse the input: "elppa"
//Step 2: Replace all vowels using the following chart:
//a => 0
//e => 1
//i => 2
//o => 2
//u => 3
//// "1lpp0"
//Step 3: Add "aca" to the end of the word: "1lpp0aca"
//Output: "1lpp0aca"
//Examples
//Encrypt("banana") => "0n0n0baca"
//Encrypt("karaca") => "0c0r0kaca"
//Encrypt("burak") => "k0r3baca"
//Encrypt("alpaca") => "0c0pl0aca"
//Notes
//All inputs are strings, no uppercases and all output must be strings.