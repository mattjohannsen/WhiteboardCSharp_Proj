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
            int positiveSum = 0;
            int negativeSum = 0;
            int zeroCount = 0;
            List<int> solution = new List<int>();
            bool hasPositives = false;
            bool hasNegatives = false;
            bool hasZeros = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    positiveSum += arr[i];
                    hasPositives = true;
                }
                else if (arr[i] < 0)
                {
                    negativeSum += arr[i];
                    hasNegatives = true;
                }
                else
                {
                    zeroCount++;
                    hasZeros = true;
                }
            }
            if (hasPositives) solution.Add(positiveSum);
            if (hasNegatives) solution.Add(negativeSum);
            if (hasZeros) solution.Add(zeroCount);
            int largest = solution.Max();
            if (Math.Abs(negativeSum) > largest)
            {
                return negativeSum;
            }
            else
            {
                return solution.Max();
            }
        }
    }
}
