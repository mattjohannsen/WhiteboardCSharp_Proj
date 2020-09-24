using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge94
    {
        public static int Potatoes(string potato)
        {
            return Regex.Matches(potato, "potato").Count;
        }
    }
}
