using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge126
    {
        public static string Accum(string str)
        {
            StringBuilder sb = new StringBuilder("");
            for (int i = 0; i < str.Length; i++)
            {
                sb.Append(char.ToUpper(str[i]) + new string(char.ToLower(str[i]), i) + '-');
            }
            return sb.ToString().Substring(0, sb.Length - 1);
        }
    }
}
