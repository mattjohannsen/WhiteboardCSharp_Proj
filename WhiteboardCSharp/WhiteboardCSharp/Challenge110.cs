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
        int[] arr = num.ToString().Select(c => Convert.ToInt32(c.ToString())).ToArray();
        int product = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            product *= arr[i];
        }
        return product;
        }
    }
}
