using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge23
    {
        public void RunChallenge()
        {
            Console.WriteLine("       Challenge 23");
            int num = 7;
            int length = 5;
            int[] theAnswer = ArrayOfMultiples(num, length);
            for (int i = 0; i < theAnswer.Length; i++)
            {
                Console.WriteLine(theAnswer[i]);
            }
        }

        public int[] ArrayOfMultiples(int num, int length)
        {
            List<int> solutionList = new List<int>();
            for (int i = 0; i < length; i++)
            {
                solutionList.Add(num*(i+1));
            }
            return solutionList.ToArray();
        }
    }
}
//Array of Multiples
//Create a function that takes two numbers as arguments(num, length) and returns an array of multiples of num up to length.
//Examples
//ArrayOfMultiples(7, 5) ➞ [7, 14, 21, 28, 35]
//ArrayOfMultiples(12, 10) ➞ [12, 24, 36, 48, 60, 72, 84, 96, 108, 120]
//ArrayOfMultiples(17, 6) ➞ [17, 34, 51, 68, 85, 102]
//Notes
//Notice that num is also included in the returned array.
// Steps
// create int num
// create int length
// create ArrayOfMultiples function that returns an int array and pass it num and length
// create solutionList which has length times the amount of indeces
// loop through length amount of times <-- this is i loop
// Add solutionList.Add(num * (i+1))
// Return solutionList.ToArray();