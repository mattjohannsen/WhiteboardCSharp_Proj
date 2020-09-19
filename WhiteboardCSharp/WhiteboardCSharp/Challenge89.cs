using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge89
    {
        public static bool IsSymmetrical(int num)
        {
            string str = num.ToString();
            return str.SequenceEqual(str.Reverse());
        }
    }
}
