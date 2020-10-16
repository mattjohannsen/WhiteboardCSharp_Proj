using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge115
    {
        public static int Tetra(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += GetTriangular(i);
            }
            return sum;
        }
        public static int GetTriangular(int num)
        {
            if (num != 1)
            {
                return num + GetTriangular(num - 1);
            }
            else
            {
                return num;
            }
        }
    }
}
