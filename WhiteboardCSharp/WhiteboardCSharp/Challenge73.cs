using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge73
    {
        public void RunChallenge()
        {
            Console.WriteLine("       Challenge 73");
            int[] inputArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(LCM(inputArray));
            //Console.WriteLine(LCM(xxx));
        }
        public static int LCM(int[] nums)
        {
            Array.Sort(nums);
            int product = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                product *= nums[i];
                for (int j = 0; j < nums.Length; j++)
                {
                    if (product % nums[nums.Length - 1 - j]>1 && product % nums[nums.Length - 1 - j] == 0)
                    {
                        return product;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return product;
        }
    }
}
//Least Common Multiple
//Given a array of integers, create a function that will find the smallest positive integer that is evenly divisible by all the members of the list.In other words, find the least common multiple(LCM).
//Examples
//LCM({ 1, 2, 3, 4, 5, 6, 7, 8, 9 }) --> 2520
//LCM({ 5 }) --> 5
//LCM({ 5, 7, 11 }) --> 385
//LCM({ 5, 7, 11, 35, 55, 77 }) --> 385