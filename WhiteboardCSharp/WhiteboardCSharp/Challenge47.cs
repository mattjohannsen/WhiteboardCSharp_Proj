using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge47
    {
        public void RunChallenge()
        {
            Console.WriteLine("       Challenge 47");
            Console.WriteLine(Challenge47.IsParselTongue("Sshe ssselects to eat that apple. "));
            Console.WriteLine(Challenge47.IsParselTongue("She ssselects to eat that apple. "));
            Console.WriteLine(Challenge47.IsParselTongue("Beatrice samples lemonade "));
            Console.WriteLine(Challenge47.IsParselTongue("You ssseldom sssspeak sso boldly, ssso messmerizingly."));
        }
        public static bool IsParselTongue(string str)
        {
            string[] arr = str.Split(' ');
            char[][] wordsAsArrays = arr.Select(w => w.ToCharArray()).ToArray();
            for (int i = 0; i < wordsAsArrays.Length; i++)
            {
                bool wordIsParsel = IsWordParsel(wordsAsArrays[i]);
                if (wordIsParsel)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsWordParsel(char[] arr)
        {
            int sCount = 0;
            int ssCount = 0;
            for (int j = 0; j < arr.Length-1; j++)
            {
                char firstChar = char.ToLower(arr[j]);
                char secondChar = char.ToLower(arr[j+1]);
                if (char.ToLower(arr[j]) == 's')
                {
                    sCount++;
                }
                if (firstChar == 's' && secondChar == 's')
                {
                    ssCount ++;
                }
            }
            if (sCount == 0)
            {
                return true;
            }
            else if (sCount == 1)
            {
                return false;
            }
            else if (ssCount >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
//Parseltongue https://edabit.com/challenge/q5GcPcJRibksZBDQX
//Hermione has come up with a precise formula for determining whether or not a phrase was ssspoken by a parssseltongue(a reference from the Harry Potter universe; the language of ssserpents and those who can converse with them).
//Each word in a sssentence must contain either:
//At least 2 instances of the letter "s" (i.e.must be together ss), or...
//Zero instances of the letter "s".
//Examples
//IsParselTongue("Sshe ssselects to eat that apple. ") --> true
//IsParselTongue("She ssselects to eat that apple. ") --> false
//// "She" only contains one "s".
//IsParselTongue("Beatrice samples lemonade") --> false
//// While "samples" has 2 instances of "s", they are not together.
//IsParselTongue("You ssseldom sssspeak sso boldly, ssso messmerizingly.") --> true
//Notes
//There should be no words with only one instance of the letter "s" (see example #2).