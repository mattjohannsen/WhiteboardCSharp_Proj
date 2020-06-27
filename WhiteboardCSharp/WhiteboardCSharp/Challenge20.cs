using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge20
    {
        public void RunChallenge()
        {
            Console.WriteLine("       Challenge 20");
            //int[] originalArray = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int[] originalArray = { 43, 65, 23, 89, 53, 9, 6 };
            int[] originalArray = { 718, 991, 449, 644, 380, 440 };
            int[] answerArray = EliminateOddNumbers(originalArray);
            for (int i = 0; i < answerArray.Length; i++)
            {
                Console.WriteLine(answerArray[i]);
            }
        }

        int[] EliminateOddNumbers(int[] inputArray)
        {
            List<int> solutionList = new List<int>();
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i]%2==0)
                {
                    solutionList.Add(inputArray[i]);
                }
            }

            return solutionList.ToArray();
        }
    }
}
//Eliminate Odd Numbers within an Array
//Create a function that takes an array of numbers and returns only the even values.
//Examples
//NoOdds([1, 2, 3, 4, 5, 6, 7, 8]) --> [2, 4, 6, 8]
//NoOdds([43, 65, 23, 89, 53, 9, 6]) --> [6]
//NoOdds([718, 991, 449, 644, 380, 440]) --> [718, 644, 380, 440]
//Notes
//Return all even numbers in the order they were given.
//All test cases contain valid numbers ranging from 1 to 3000.
// Steps
// Create originalArray int array and pass it to EliminateOddNumbers
// Create EliminateOddNumbers method that takes in inputArray
// create solutionList List<int>
// Loop through inputArray and see if the element[i] % 2 == 0
// if so, add it to solutionList
// turn the solutionList to an array solutionArray
// return the solutionArray