using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge76
    {
        public void RunChallenge76()
        {
            Console.WriteLine("       Challenge 76");
            //Console.WriteLine($"       AnagramStrStr(\"abc\", \"abcd\") --> {AnagramStrStr("dab", "abcd")}");
            Console.WriteLine($"       AnagramStrStr(\"car\", \"race\") --> {AnagramStrStr("car", "race")}"); //true
            Console.WriteLine($"       AnagramStrStr(\"nod\", \"done\") --> {AnagramStrStr("nod", "done")}"); //true
            Console.WriteLine($"       AnagramStrStr(\"bag\", \"grab\") --> {AnagramStrStr("bag", "grab")}"); //false
        }
        public static bool AnagramStrStr(string needle, string haystack)
        {
            List<string> permutationList = new List<string>();
            Permute(needle, 0, needle.Length - 1, permutationList);
            for (int i = 0; i < permutationList.Count; i++)
            {
                if (haystack.Contains(permutationList[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public static void Permute(string str, int l, int r, List<string> permutations)
        {
            if (l == r)
            {
                Console.WriteLine(str);
                AddToPermutationList(permutations, str);
            }
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = Swap(str, l, i);
                    Permute(str, l + 1, r, permutations);
                    str = Swap(str, l, i);
                }
            }
        }
        public static List<string> AddToPermutationList(List<string> inputList, string str)
        {
            inputList.Add(str);
            return inputList;
        }
        public static string Swap(string a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            return new string(charArray);
        }
    }
}
//Find an Anagram of a String in Another String
//Create a function that takes two strings and determines if an anagram of the first string is in the second string. Anagrams of "bag" are "bag", "bga", "abg", "agb", "gab", "gba". Since none of those anagrams are in "grab", the answer is false. A "g", "a", and "b" are in the string "grab", but they're split up by the "r".
//Examples
//AnagramStrStr("car", "race") --> true
//AnagramStrStr("nod", "done") --> true
//AnagramStrStr("bag", "grab") --> false
//Notes
//Inputs will be valid strings in all lowercase letters.
//There exists a linear time algorithm for this.
// Steps turn string into array
// Enter a string into permutations --> abc
// The string is turned into an array [a,b,c]
// The first char is frozen
// if arr-Length - 1 == 2
// swap arr[1] and arr [2]
// return array;
// else
// create newArray[arr.Length - 1]