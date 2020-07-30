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
            ChallengeDescription();
            Console.WriteLine($"       Sshe ssselects to eat that apple. --> {Challenge47.IsParselTongue("Sshe ssselects to eat that apple. ")}");
            Console.WriteLine($"       She ssselects to eat that apple. --> {Challenge47.IsParselTongue("She ssselects to eat that apple. ")}");
            Console.WriteLine($"       Beatrice samples lemonade --> {Challenge47.IsParselTongue("Beatrice samples lemonade ")}");
            Console.WriteLine($"       You ssseldom sssspeak sso boldly, ssso messmerizingly. --> {Challenge47.IsParselTongue("You ssseldom sssspeak sso boldly, ssso messmerizingly.")}");
        }
        public static bool IsParselTongue(string sentence)
        {
            char[][] wordsAsArrays = sentence.Split(' ').Select(w => w.ToCharArray()).ToArray();
            for (int i = 0; i < wordsAsArrays.Length; i++)
            {
                if (!IsWordParsel(wordsAsArrays[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsWordParsel(char[] arr)
        {
            int sCount = 0;
            for (int j = 0; j < arr.Length-1; j++)
            {
                if (char.ToLower(arr[j]) == 's')
                {
                    sCount++;
                    if (char.ToLower(arr[j + 1]) == 's')
                    {
                        return true;
                    }
                }
            }
            return (sCount == 0);
        }
        public void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 47: Parseltongue");
            Console.WriteLine("       Hermione has come up with a precise formula for determining whether or not a phrase");
            Console.WriteLine("       was ssspoken by a parssseltongue(a reference from the Harry Potter universe;");
            Console.WriteLine("       the language of ssserpents and those who can converse with them");
            Console.WriteLine("       Each word in a sssentence must contain either:");
            Console.WriteLine("       At least 2 instances of the letter 's' (i.e.must be together ss), or...");
            Console.WriteLine("       Zero instances of the letter 's'.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       IsParselTongue(Sshe ssselects to eat that apple. ) --> true");
            Console.WriteLine("       IsParselTongue(She ssselects to eat that apple. ) --> false");
            Console.WriteLine("       She only contains one 's'.");
            Console.WriteLine("       IsParselTongue(Beatrice samples lemonade) --> false");
            Console.WriteLine("       While 'samples' has 2 instances of 's', they are not together.");
            Console.WriteLine("       IsParselTongue(You ssseldom sssspeak sso boldly, ssso messmerizingly.) --> true");
            Console.WriteLine("       Notes");
            Console.WriteLine("       There should be no words with only one instance of the letter 's' (see example #2).\n");
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