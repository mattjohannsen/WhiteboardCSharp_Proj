using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge118
    {
        public static string FindNemo(string sentence)
        {
            int index = Array.IndexOf(sentence.Split(' '), "Nemo");
            return (index < 0) ? "I can't find Nemo :(" : $"I found Nemo at {index + 1}!";
        }
    }
}
