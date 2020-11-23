using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge134
    {
        public static string FlipEndChars(object str)
        {
            string text = str.ToString();
            if (!(str is string) || text.Length < 2) return "Incompatible.";
            if (text[0] == text[text.Length - 1]) return "Two's a pair.";
            return (new StringBuilder(text).Remove(text.Length - 1, 1).Remove(0, 1).Insert(0, text[text.Length - 1]).Insert(text.Length - 1, text[0])).ToString();
        }
    }
}
