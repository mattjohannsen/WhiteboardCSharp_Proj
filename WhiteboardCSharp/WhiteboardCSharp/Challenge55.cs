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
            string returnString = new string(arr);
            string newString = returnString.Replace("a", "0").Replace("e", "1").Replace("i", "2").Replace("o", "2").Replace("i", "3");
            newString += "aca";
            return newString;

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