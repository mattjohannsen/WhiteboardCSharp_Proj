using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge128
    {
        public static string ToScottishScreaming(string str)
        {
            return Regex.Replace(str.ToUpper(), @"[AIOU]", "E");
        }
    }
}
//Scottish Screaming https://edabit.com/challenge/fcGARuJW6tcYyWMQw
//A strong Scottish accent makes every vowel similar to an "e", so you should replace every vowel with an "e". Additionally, it is being screamed, so it should be in block capitals.

//Create a function that takes a string and returns a string.

//Examples
//ToScottishScreaming("hello world") ➞ "HELLE WERLD"

//ToScottishScreaming("Mr. Fox was very naughty") ➞ "MR. FEX WES VERY NEEGHTY"

//ToScottishScreaming("Butterflies are beautiful!") ➞ "BETTERFLEES ERE BEEETEFEL!"
//Notes
//Make sure to include all punctuation that is in the original string.
//You don't need any more namespaces than are already given.