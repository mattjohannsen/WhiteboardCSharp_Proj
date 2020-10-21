using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge121
    {
        public static string RemoveSpecialCharacters(string str)
        {
            return Regex.Replace(str, @"[^\w _-]", "");
        }
    }
}
