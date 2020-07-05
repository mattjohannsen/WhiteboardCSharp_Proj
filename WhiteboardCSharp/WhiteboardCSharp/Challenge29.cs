using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge29
    {
        public void RunChallenge()
        {
            Console.WriteLine("       Challenge 29");
            long[] arrayOne = { 9, 5, 42, 2, 77 };
            Console.WriteLine(SumSmallest(arrayOne));
            long[] arrayTwo = { 10, 343445353, 3453445, 3453545353453 };
            Console.WriteLine(SumSmallest(arrayTwo));
            long[] arrayThree = { 2, 9, 6, -1 };
            Console.WriteLine(SumSmallest(arrayThree));
            long[] arrayFour = { 879, 953, 694, -847, 342, 221, -91, -723, 791, -587 };
            Console.WriteLine(SumSmallest(arrayFour));
            long[] arrayFive = { 3683, 2902, 3951, -475, 1617, -2385 };
            Console.WriteLine(SumSmallest(arrayFive));
        }
        public long SumSmallest(long[] inputArray)
        {
            long valueOne;
            long valueTwo;
            Array.Sort(inputArray);
            long startingIndex = GetStartingIndex(inputArray);
            valueOne = inputArray[startingIndex];
            valueTwo = inputArray[startingIndex + 1];
            return (valueOne + valueTwo);
        }
        public long GetStartingIndex(long[] inputArray)
        {
            long startingIndex = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] > 0)
                {
                    startingIndex = i;
                    return startingIndex;
                }
            }
            return startingIndex;
        }
    }
}
//Return the Sum of the Two Smallest Numbers
//Create a function that takes an array of numbers and returns the sum of the two lowest positive numbers.
//Examples
//SumSmallest([19, 5, 42, 2, 77]) --> 7
//SumSmallest([10, 343445353, 3453445, 3453545353453]) --> 3453455
//SumSmallest([2, 9, 6, -1]) --> 8
//SumSmallest([879, 953, 694, -847, 342, 221, -91, -723, 791, -587]) --> 563
//SumSmallest([3683, 2902, 3951, -475, 1617, -2385]) --> 4519
//Notes
//Don't count negative numbers.
//Floats and empty arrays will not be used in any of the test cases.
// Create int valueOne;
// Create int valueTwo;
// Create int[2] solutionArray = new int[2];
// Take inputArray and sort
// Find startingIndex create a method that returns value of index where inputArray[i]>0
// valueOne = inputArray[startingIndex]
// valueTwo = inputArray[startingIndex + 1]
// return (valueOne +  valueTwo)

