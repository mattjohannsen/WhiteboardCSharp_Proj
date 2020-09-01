using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge71
    {
        public void RunChallenge()
        {
            Console.WriteLine($"       Challenge 71");
            Console.WriteLine($"       {SmallestTransform(399)}");
        }
        public static int SmallestTransform(int num)
        {
            int[]arr = num.ToString().Select(n => int.Parse(n.ToString())).ToArray();
            IEnumerable<int> uniqueList = arr.Distinct<int>();
            List<int> solutionList = new List<int>();
            foreach (var uniqueNum in uniqueList)
            {
                int totalCount = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    totalCount += Math.Max(uniqueNum, arr[i]) - Math.Min(uniqueNum, arr[i]);
                }
                solutionList.Add(totalCount);
            }
            return solutionList.Min(s => s);
        }
    }
}
//Smallest Transform
//Create a function that returns the smallest number of changes it takes to transform one number into one with identical digits.A step is incrementing or decrementing a digit by one.
//Examples
//SmallestTransform(399) --> 6
//// 399 transformed to 999 in 6 steps.
//SmallestTransform(1234) --> 4
//// 1234 can be transformed to either 2222 or 3333 using 4 steps.
//SmallestTransform(153) --> 4
//SmallestTransform(33338) --> 5
//SmallestTransform(7777) --> 0
//Notes
//If a number already has identical digits, return 0.