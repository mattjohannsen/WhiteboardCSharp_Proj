using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge4
    {
        ////int[] challenge4Array;
        //public Challenge4()
        //{
        //    int[] challenge4Array = { 7, 9, -3, -32, 107, -1, 36, 95, -14, -99, 21 };
        //}
        public int[] RunChallenge(int[] inputArray)
        {
            int[] returnArray = new int[2];
            int countOfPositive = 0;
            int sumOfNegative = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] > 0)
                {
                    countOfPositive = countOfPositive + 1;
                    Console.WriteLine(inputArray[i] + "/" + countOfPositive);
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
    }
}
//4.	Create a method that takes an array of positive and negative numbers.
//    Return an array where the first element is the count of the positive numbers 
//    and the second element is the sum of negative numbers.
//a.Use case: [7, 9, -3, -32, 107, -1, 36, 95, -14, -99, 21]
//Steps
    
//    1) Create variable for countOfpositive numbers
//    2) Create an int[2] array returnArray for containing the solutions.
//    2) Create variable for the sumOfNegative numbers
//    3) Loop through array and IF the number is > 0 then +1 to the CountOfpositiveNumbers variable
//        ELSE If the number is < 0 then add that number to the Neg
//        Add countOfpositive and sumOfNegative to the returnArray.
