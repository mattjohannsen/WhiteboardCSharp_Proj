using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge110
    {
        public static int MysteryFunc(int num)
        {
            return num.ToString().Select(c => Convert.ToInt32(c.ToString())).ToArray().Aggregate(1, (x, y) => x * y);
        }
    }
}
