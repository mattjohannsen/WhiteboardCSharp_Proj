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
            Console.WriteLine("       Challenge 66");
            Console.WriteLine(FirstIndex("68 65 6c 6c 6f 20 77 6f 72 6c 64", "world"));
            Console.WriteLine(FirstIndex("47 6f 6f 64 62 79 65 20 77 6f 72 6c 64", "world"));
            Console.WriteLine(FirstIndex("42 6f 72 65 64 20 77 6f 72 6c 64", "Bored"));
        }
        public static int FirstIndex(string hexString, string needle)
        {
            char[] arrNeedle = needle.ToCharArray();
            string[] hexArray = new string[arrNeedle.Length];
            for (int i = 0; i < arrNeedle.Length; i++)
            {
                hexArray[i] = Convert.ToByte(arrNeedle[i]).ToString("x");
            }
            string needleString = string.Join(" ", hexArray);
            string theNeedle = hexArray[0];
         
            string[] hexStringArray = hexString.Split(' ');
            return Array.IndexOf(hexStringArray, theNeedle);
            //string testHexString = string.Join(" ", hexArray);
            return 1;
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