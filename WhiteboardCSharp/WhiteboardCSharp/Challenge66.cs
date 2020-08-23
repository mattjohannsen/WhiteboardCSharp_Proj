using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge66
    {
        public void RunChallenge()
        {
            ChallengeDescription();
            Console.WriteLine($"       FirstIndex(68 65 6c 6c 6f 20 77 6f 72 6c 64, world) --> 6 --> {FirstIndex("68 65 6c 6c 6f 20 77 6f 72 6c 64", "world")}");
            Console.WriteLine($"       FirstIndex(47 6f 6f 64 62 79 65 20 77 6f 72 6c 64, world) --> 8 --> {FirstIndex("47 6f 6f 64 62 79 65 20 77 6f 72 6c 64", "world")}");
            Console.WriteLine($"       FirstIndex(42 6f 72 65 64 20 77 6f 72 6c 64, Bored) --> 0 --> {FirstIndex("42 6f 72 65 64 20 77 6f 72 6c 64", "Bored")}");
        }
        public static int FirstIndex(string hexString, string needle)
        {
            return Array.IndexOf(hexString.Split(' '), Convert.ToByte(needle[0]).ToString("x"));
        }
        public void ChallengeDescription()
        {
            Console.WriteLine("       Needle in a Hex String");
            Console.WriteLine("       Find the index of a string within a hex encoded string.");
            Console.WriteLine("       You will be given a string which needs to be found in another string which has previously");
            Console.WriteLine("       been translated into hex.");
            Console.WriteLine("       You will need to return the first index of the needle within the hex encoded string.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       FirstIndex(68 65 6c 6c 6f 20 77 6f 72 6c 64, world) --> 6");
            Console.WriteLine("       FirstIndex(47 6f 6f 64 62 79 65 20 77 6f 72 6c 64, world) --> 8");
            Console.WriteLine("       FirstIndex(42 6f 72 65 64 20 77 6f 72 6c 64, Bored) --> 0\n");
        }
    }
}
//Needle in a Hex String
//Find the index of a string within a hex encoded string.
//You will be given a string which needs to be found in another string which has previously been translated into hex.You will need to return the first index of the needle within the hex encoded string.
//Examples
//FirstIndex("68 65 6c 6c 6f 20 77 6f 72 6c 64", "world") --> 6
//FirstIndex("47 6f 6f 64 62 79 65 20 77 6f 72 6c 64", "world") --> 8
//FirstIndex("42 6f 72 65 64 20 77 6f 72 6c 64", "Bored") --> 0