using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge105
    {
        public static bool IsFactorial(int n)
        {
            int current = 1;
            for (int i = 1; i < n; i++)
            {
                current *= i;
                if (n == current) return true;
                else if (current > n) break;
            }
            return false;
        }
    }
}
//Steps
// 