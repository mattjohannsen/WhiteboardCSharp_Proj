using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge63
    {
        public void RunChallenge()
        {
            ChallengeDescription();
            Console.WriteLine($"       BreakPoint(159780) ==> {BreakPoint(159780)}");
            Console.WriteLine($"       BreakPoint(112) ==> {BreakPoint(112)}");
            Console.WriteLine($"       BreakPoint(1034) ==> {BreakPoint(1034)}");
            Console.WriteLine($"       BreakPoint(10) ==> {BreakPoint(10)}");
            Console.WriteLine($"       BreakPoint(343) ==> {BreakPoint(343)}");
        }
        public static bool BreakPoint(int num)
        {
            int[] arr = num.ToString().Select(t => int.Parse(t.ToString())).ToArray();
            int leftSum = 0;
            int rightSum = arr.Sum();
            for (int i = 0; i < arr.Length; i++)
            {
                leftSum += arr[i];
                rightSum -= arr[i];
                if (leftSum == rightSum)
                {
                    return true;
                }
            }
            return false;
        }
        public void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 63: Break Point");
            Console.WriteLine("       A number has a breakpoint if it can be split in a way where the digits on the left side and ");
            Console.WriteLine("       the digits on the right side sum to the same number."); 
            Console.WriteLine("       For instance, the number 35190 can be sliced between the digits 351 and 90, since 3 + 5 + 1 = 9");
            Console.WriteLine("       and 9 + 0 = 9.");
            Console.WriteLine("       On the other hand, the number 555 does not have a breakpoint(you must split between digits).");
            Console.WriteLine("       Create a function that returns true if a number has a breakpoint, and false otherwise.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       BreakPoint(159780) --> true");
            Console.WriteLine("       BreakPoint(112) --> true");
            Console.WriteLine("       BreakPoint(1034) --> true");
            Console.WriteLine("       BreakPoint(10) --> false");
            Console.WriteLine("       BreakPoint(343)  --> false");
            Console.WriteLine("       Notes");
            Console.WriteLine("       Read each digit as only one number.\n");
        }
    }
}
//Break Point
//A number has a breakpoint if it can be split in a way where the digits on the left side and the digits on the right side sum to the same number.
//For instance, the number 35190 can be sliced between the digits 351 and 90, since 3 + 5 + 1 = 9 and 9 + 0 = 9. On the other hand, the number 555 does not have a breakpoint(you must split between digits).
//Create a function that returns true if a number has a breakpoint, and false otherwise.
//Examples
//BreakPoint(159780) --> true
//BreakPoint(112) --> true
//BreakPoint(1034) --> true
//BreakPoint(10) --> false
//BreakPoint(343)  --> false
//Notes
//Read each digit as only one number.
// Steps
// int leftsum;
// int rightsum;
// turn num into an int[] arr;
// start loop i to arr.length -1
// rightsum == 0 to i sum,
// leftsum == i+1 to arr.length -1;
// if leftsum = right sum
// return true;
// if the loop goes to the end
// return false;
