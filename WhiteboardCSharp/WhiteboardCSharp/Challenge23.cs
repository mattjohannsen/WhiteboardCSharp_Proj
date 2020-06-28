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
            ChallengeDescription();
            int num = 7;
            int length = 5;
            ShowAnswer(ArrayOfMultiples(num, length));
            num = 12;
            length = 10;
            ShowAnswer(ArrayOfMultiples(num, length));
            num = 17;
            length = 6;
            ShowAnswer(ArrayOfMultiples(num, length));
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

        public void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 23: Array of Multiples");
            Console.WriteLine("       Create a function that takes two numbers as arguments(num, length) and");
            Console.WriteLine("       returns an array of multiples of num up to length.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       ArrayOfMultiples(7, 5) --> [7, 14, 21, 28, 35]");
            Console.WriteLine("       ArrayOfMultiples(12, 10) --> [12, 24, 36, 48, 60, 72, 84, 96, 108, 120]");
            Console.WriteLine("       ArrayOfMultiples(17, 6) --> [17, 34, 51, 68, 85, 102]");
            Console.WriteLine("       Notes");
            Console.WriteLine("       Notice that num is also included in the returned array.\n");
        }

        public void ShowAnswer(int[] inputArray)
        {
           Console.WriteLine($"       [{String.Join(", ", inputArray)}]");
        }
    }
}
//Array of Multiples https://edabit.com/challenge/2QvnWexKoLfcJkSsc
//Create a function that takes two numbers as arguments(num, length) and returns an array of multiples of num up to length.
//Examples
//ArrayOfMultiples(7, 5) --> [7, 14, 21, 28, 35]
//ArrayOfMultiples(12, 10) --> [12, 24, 36, 48, 60, 72, 84, 96, 108, 120]
//ArrayOfMultiples(17, 6) --> [17, 34, 51, 68, 85, 102]
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