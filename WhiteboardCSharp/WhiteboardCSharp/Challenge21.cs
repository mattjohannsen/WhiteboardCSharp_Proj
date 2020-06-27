﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge21
    {
        public void RunChallenge()
        {
            Console.WriteLine("       Challenge 21");
            int[][] originalArray = { new int[]{ 4, 2, 7, 1 }, new int[] { 20, 70, 40, 90 }, new int[] { 1, 2, 0 } };
            string theSolution = String.Join(",", FindLargest(originalArray));
            Console.WriteLine(theSolution);
        }

        public int[] FindLargest(int[][] inputArray)
        {
            List<int> solutionList = new List<int>();
            for (int i = 0; i < inputArray.Length; i++)
            {
                int largestValue = inputArray[i].Max();
                solutionList.Add(largestValue);
            }

            return solutionList.ToArray();
        }
    }
}
//Find the Largest Numbers in a Group of Arrays
//Create a function that takes an array of arrays with numbers.Return a new(single) array with the largest numbers of each.
//Examples
//FindLargest([[4, 2, 7, 1], [20, 70, 40, 90], [1, 2, 0]]) --> [7, 90, 2]
//FindLargest([[-34, -54, -74], [-32, -2, -65], [-54, 7, -43]]) --> [-34, -2, 7]
//FindLargest([[0.4321, 0.7634, 0.652], [1.324, 9.32, 2.5423, 6.4314], [9, 3, 6, 3]]) --> [0.7634, 9.32, 9]
//Notes
//Watch out for negative numbers.
// Steps
// Create variable originalArray which is an int[][] jagged array
// Pass originalArray into the FindLargest method which returns an array
// Create a List<int> solutionList
// Loop through originalArray --> This is loop i
// create variable largestValue which is an integer
// The largestValue is going to be equal to originalArray.Max();
// Add this value to the solutionList.
// After loop is complete, turn the solutionList into an array and return this value.
// string joined = String.Join(", ", vegetables);