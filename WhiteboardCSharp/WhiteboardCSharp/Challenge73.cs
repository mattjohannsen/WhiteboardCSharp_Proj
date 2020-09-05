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
            ChallengeDescription();
            int[] inputArray1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine($"       LCM([ 1, 2, 3, 4, 5, 6, 7, 8, 9 ]) --> {LCM(inputArray1)}");
            int[] inputArray2 = { 5 };
            Console.WriteLine($"       LCM([ 5 ]) --> {LCM(inputArray2)}");
            int[] inputArray3 = { 5, 7, 11 };
            Console.WriteLine($"       LCM([ 5, 7, 11 ]) --> {LCM(inputArray3)}");
            int[] inputArray4 = { 5, 7, 11, 35, 55, 77 };
            Console.WriteLine($"       LCM([ 5, 7, 11, 35, 55, 77 ]) --> {LCM(inputArray4)}\n");
        }
        public static int LCM(int[] nums)
        {
            Array.Sort(nums);
            int multiplicationFactor = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    int gcf = GetGCF(nums[i], nums[j]);
                    if (nums[j] % gcf == 0 && i != j)
                    {
                        multiplicationFactor *= gcf;
                        nums = ReduceWhenPossible(nums, gcf);
                        continue;
                    }
                }
            }
            int lcm = 1;
            for (int k = 0; k < nums.Length; k++)
            {
                lcm *= nums[k];
            }
            return lcm * multiplicationFactor;
        }
        public static int[] ReduceWhenPossible(int[] arr, int divisor)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % divisor == 0)
                {
                    arr[i] /= divisor;
                }
            }
            return arr;
        }
        public static int GetGCF(int num1, int num2)
        {
            if (num2 == 0)
            {
                return num1;
            }
            else
            {
                return GetGCF(num2, num1 % num2);
            }
        }
        public void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 73: Least Common Multiple");
            Console.WriteLine("       Given a array of integers, create a function that will find the smallest positive integer that is evenly");
            Console.WriteLine("       divisible by all the members of the list.In other words, find the least common multiple(LCM).");
            Console.WriteLine("       Examples");
            Console.WriteLine("       LCM({ 1, 2, 3, 4, 5, 6, 7, 8, 9 }) --> 2520");
            Console.WriteLine("       LCM({ 5 }) --> 5");
            Console.WriteLine("       LCM({ 5, 7, 11 }) --> 385");
            Console.WriteLine("       LCM({ 5, 7, 11, 35, 55, 77 }) --> 385\n");
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