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
            string strStr = str.ToString();
            if (!(str is string) || strStr.Length < 2)
            {
                return "Incompatible.";
            }
            string switched = (new StringBuilder(strStr).Remove(strStr.Length - 1, 1).Remove(0, 1).Insert(0, strStr[strStr.Length - 1]).Insert(strStr.Length - 1, strStr[0])).ToString();
            return (strStr[0] == strStr[strStr.Length - 1]) ? "Two's a pair." : switched;
        }
    }
}
