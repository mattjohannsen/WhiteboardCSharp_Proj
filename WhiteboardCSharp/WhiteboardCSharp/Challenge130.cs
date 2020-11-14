using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge130
    {
        public static int MajorSum(int[] arr)
        {
            var positiveSum = arr.Where(x => x > 0).Sum();
            var negativeSum = arr.Where(x => x < 0).Sum();
            var zeroCount = arr.Where(x => x == 0).Count();
            return (Math.Abs(negativeSum) > Math.Max(zeroCount, positiveSum)) ? negativeSum : Math.Max(positiveSum, zeroCount);
        }
    }
}
