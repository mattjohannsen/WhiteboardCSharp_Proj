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
            return (n1 == 0) ? n2 : GCD(n2 % n1, n1);
        }
    }
}
