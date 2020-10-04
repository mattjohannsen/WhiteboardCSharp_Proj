using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge104
    {
        public static int GCD(int n1, int n2)
        {
            if (n1 == n2)
            {
                return n1;
            }
            int smaller = Math.Min(n1, n2);
            int larger = Math.Max(n1, n2);
            for (int i = smaller; i > 1; i--)
            {
                if (smaller % i == 0)
                {
                    if (larger % i == 0)
                    {
                        return i;
                    }
                }
            }
            return 1;
        }
    }
}
