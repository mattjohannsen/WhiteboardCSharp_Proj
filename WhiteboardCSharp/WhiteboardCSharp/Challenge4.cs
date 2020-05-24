using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge4
    {
        int[] ourArray = { 7, 9, -3, -32, 107, -1, 36, 95, -14, -99, 21 };

        public void RunChallenge()
        {
            ChallengeDescription();
            int[] solutionArray = GetSolution(ourArray);
            DisplaySolution(solutionArray);

        }

        public int[] GetSolution(int[] inputArray)
        {
            int[] returnArray = new int[2];
            int countOfPositive = 0;
            int sumOfNegative = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] > 0)
                {
                    countOfPositive = countOfPositive + 1;
                }
                else if (inputArray[i] < 0)
                {
                    sumOfNegative = sumOfNegative + inputArray[i];
                }
            }
            returnArray[0] = countOfPositive;
            returnArray[1] = sumOfNegative;
            return returnArray;
        }

        public void DisplaySolution(int[] inputArray)
        {
            Console.WriteLine("\n       The Solution");
            Console.WriteLine($"       The count of this array's positive integers: {inputArray[0]}");
            Console.WriteLine($"       The sum of this array's negative integers: {inputArray[1]}");
        }

        public void ChallengeDescription()
        {
            Console.WriteLine("\n\n       Challenge 4");
            Console.WriteLine("       Create a method that takes an array of positive and negative numbers. Return an array where");
            Console.WriteLine("       the first element is the count of the positive numbers and the second element is the sum of");
            Console.WriteLine("       negative numbers.");
            Console.WriteLine("               a.	Use case: [7, 9, -3, -32, 107, -1, 36, 95, -14, -99, 21]");
        }
    }
}

//Steps
    
//    1) Create variable for countOfpositive numbers
//    2) Create an int[2] array returnArray for containing the solutions.
//    2) Create variable for the sumOfNegative numbers
//    3) Loop through array and IF the number is > 0 then +1 to the CountOfpositiveNumbers variable
//        ELSE If the number is < 0 then add that number to the Neg
//        Add countOfpositive and sumOfNegative to the returnArray.
