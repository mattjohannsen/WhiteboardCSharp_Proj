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
            ChallengeDescription();
            Console.WriteLine($"       AnagramStrStr(\"car\", \"race\") --> {AnagramStrStr("car", "race")}"); //true
            Console.WriteLine($"       AnagramStrStr(\"nod\", \"done\") --> {AnagramStrStr("nod", "done")}"); //true
            Console.WriteLine($"       AnagramStrStr(\"bag\", \"grab\") --> {AnagramStrStr("bag", "grab")}"); //false
        }
        public static bool AnagramStrStr(string needle, string haystack)
        {
            string[] permutations = Permutations(needle.ToCharArray()).Select(x => new string(x.ToArray())).ToArray();
            for (int i = 0; i < permutations.Length; i++)
            {
                if (haystack.Contains(permutations[i]))
                {
                    return true;
                }
            }
            return false;
        }
        private static IEnumerable<IEnumerable<T>> Permutations<T>(IEnumerable<T> str)
        {
            var counter = str.Count();
            if (counter == 1)
            {
                yield return str;
            }
            else
            {
                for (int i = 0; i < counter; i++)
                {
                    foreach (var permutation in Permutations(str.Take(i).Concat(str.Skip(i + 1))))
                    {
                        yield return str.Skip(i).Take(1).Concat(permutation);
                    }
                }
            }
        }
        public void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 76: Find an Anagram of a String in Another String");
            Console.WriteLine("       Create a function that takes two strings and determines if an anagram of the first string");
            Console.WriteLine("       is in the second string. Anagrams of \"bag\" are \"bag\", \"bga\", \"abg\", \"agb\", \"gab\", \"gba\".");
            Console.WriteLine("       Since none of those anagrams are in \"grab\", the answer is false.");
            Console.WriteLine("       A \"g\", \"a\", and \"b\" are in the string \"grab\", but they're split up by the \"r\".");
            Console.WriteLine("       Examples");
            Console.WriteLine("       AnagramStrStr(\"car\", \"race\") --> true");
            Console.WriteLine("       AnagramStrStr(\"nod\", \"done\") --> true");
            Console.WriteLine("       AnagramStrStr(\"bag\", \"grab\") --> false");
            Console.WriteLine("       Notes");
            Console.WriteLine("       Inputs will be valid strings in all lowercase letters.");
            Console.WriteLine("       There exists a linear time algorithm for this.\n");
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