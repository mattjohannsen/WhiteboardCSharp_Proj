using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge88
    {
        public static string GetWord(string left, string right)
        {
            return string.Concat(char.ToUpper(left[0]) + left.Substring(1), right);
        }
    }
}
//Re-Form the Word https://edabit.com/challenge/ypLHBBJtdME9pvTuN
//A word has been split into a left part and a right part.Re-form the word by adding both halves together, changing the first character to an uppercase letter.
//Examples
//GetWord("seas", "onal") --> "Seasonal"
//GetWord("comp", "lete") --> "Complete"
//GetWord("lang", "uage") --> "Language"