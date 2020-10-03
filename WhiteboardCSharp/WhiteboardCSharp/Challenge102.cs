using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge102
    {
        public void RunChallenge()
        {
            int num = 123;
            Console.WriteLine(num);
            Console.WriteLine(SortDescending(num));
        }
        public static int SortDescending(int num)
        {
            int[] arr = num.ToString().Select(n => int.Parse(n.ToString())).OrderByDescending(c => c).ToArray();
            return int.Parse(string.Join("", arr));
        }
    }
}
