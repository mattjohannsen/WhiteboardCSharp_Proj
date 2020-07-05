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
            ChallengeDescription();
            long[] arrayOne = { 9, 5, 42, 2, 77 };
            string arrayAsString = string.Join(", ", arrayOne);
            Console.WriteLine($"       [ {arrayAsString} ] smallest sum --> {SumSmallest(arrayOne)}");
            long[] arrayTwo = { 10, 343445353, 3453445, 3453545353453 };
            arrayAsString = string.Join(", ", arrayTwo);
            Console.WriteLine($"       [ {arrayAsString} ] smallest sum --> {SumSmallest(arrayTwo)}");
            long[] arrayThree = { 2, 9, 6, -1 };
            arrayAsString = string.Join(", ", arrayThree);
            Console.WriteLine($"       [ {arrayAsString} ] smallest sum --> {SumSmallest(arrayThree)}");
            long[] arrayFour = { 879, 953, 694, -847, 342, 221, -91, -723, 791, -587 };
            arrayAsString = string.Join(", ", arrayFour);
            Console.WriteLine($"       [ {arrayAsString} ] smallest sum --> {SumSmallest(arrayFour)}");
            long[] arrayFive = { 3683, 2902, 3951, -475, 1617, -2385 };
            arrayAsString = string.Join(", ", arrayFive);
            Console.WriteLine($"       [ {arrayAsString} ] smallest sum --> {SumSmallest(arrayFive)}");
        }
        public long SumSmallest(long[] inputArray)
        {
            long valueOne;
            long valueTwo;
            Array.Sort(inputArray);
            int startingIndex = GetStartingIndex(inputArray);
            valueOne = inputArray[startingIndex];
            valueTwo = inputArray[startingIndex + 1];
            return (valueOne + valueTwo);
        }
        public int GetStartingIndex(long[] inputArray)
        {
            int startingIndex = 0;
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

        public void ChallengeDescription()
        {
            Console.WriteLine("       Return the Sum of the Two Smallest Numbers");
            Console.WriteLine("       Create a function that takes an array of numbers and returns the sum of the two lowest positive numbers.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       SumSmallest([19, 5, 42, 2, 77]) --> 7");
            Console.WriteLine("       SumSmallest([10, 343445353, 3453445, 3453545353453]) --> 3453455");
            Console.WriteLine("       SumSmallest([2, 9, 6, -1]) --> 8");
            Console.WriteLine("       SumSmallest([879, 953, 694, -847, 342, 221, -91, -723, 791, -587]) --> 563");
            Console.WriteLine("       SumSmallest([3683, 2902, 3951, -475, 1617, -2385]) --> 4519");
            Console.WriteLine("       Notes");
            Console.WriteLine("       Don't count negative numbers.");
            Console.WriteLine("       Floats and empty arrays will not be used in any of the test cases.\n");
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

