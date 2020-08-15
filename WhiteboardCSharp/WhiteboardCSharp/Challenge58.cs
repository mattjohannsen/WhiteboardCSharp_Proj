using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge58
    {
        public void RunChallenge()
        {
            Console.WriteLine("       Challenge 58");
            //Console.WriteLine($"|{ Mangle("Fun times!")}|");
            Console.WriteLine($"|{ Mangle("abcz")}|");        }
        public static string Mangle(string str)
        {
            char[] arr = str.ToCharArray();
            string vowels = "aeiou";
            for (int i = 0; i < arr.Length; i++)
            {
                if (!Char.IsLetter(arr[i]))
                {
                    arr[i] = arr[i];
                }
                else if (arr[i] == 'z' || arr[i] == 'Z')
                {
                    arr[i] = 'A';
                }
                else if (arr[i] == ' ')
                {
                    arr[i] = ' ';
                }
                else
                {
                    arr[i] = (char)(arr[i] + 1);
                    if (vowels.Contains(arr[i]))
                    {
                        arr[i] = Char.ToUpper((char)(arr[i]));
                    }
                }
            }
            return new string(arr);
        }
    }
}
//Mangle the String
//Create a function that takes a string and replaces every letter with the letter following it in the alphabet("c" becomes "d", "z" becomes "a", "b" becomes "c", etc). Then capitalize every vowel(a, e, i, o, u) and return the new modified string.
//Examples
//Mangle("Fun times!") --> "GvO Ujnft!"
//Mangle("The quick brown fox.") --> "UIf rvjdl cspxO gpy."
//Mangle("Omega") --> "Pnfhb"
//Notes
//If a letter is already uppercase, return it as uppercase(regardless of being a vowel).
//"y" is not considered a vowel.
