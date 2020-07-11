using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    class Challenge31
    {
        public void RunChallenge()
        {
            ChallengeDescription();
            Console.WriteLine($"       PalindromeTimestamps(2, 12, 22, 4, 35, 10) --> {PalindromeTimestamps(2, 12, 22, 4, 35, 10)}");
            Console.WriteLine($"       PalindromeTimestamps(12, 12, 12, 13, 13, 13) --> {PalindromeTimestamps(12, 12, 12, 13, 13, 13)}");
            Console.WriteLine($"       PalindromeTimestamps(6, 33, 15, 9, 55, 10) --> {PalindromeTimestamps(6, 33, 15, 9, 55, 10)}");
        }
        public static int PalindromeTimestamps(int hours1, int minutes1, int seconds1, int hours2, int minutes2, int seconds2)
        {
            TimeSpan timeSpan1 = new TimeSpan(hours1, minutes1, seconds1);
            TimeSpan timeSpan2 = new TimeSpan(hours2, minutes2, seconds2);
            int palidromeCounter = 0;
            while (timeSpan1 < timeSpan2)
            {
                if (CheckForPalidrome(timeSpan1.ToString()))
                {
                    palidromeCounter++;
                    Console.WriteLine(timeSpan1.ToString() + "--> " + CheckForPalidrome(timeSpan1.ToString()));
                }
                timeSpan1 = timeSpan1.Add(TimeSpan.FromSeconds(1));
            }
            return palidromeCounter;
        }
        public static bool CheckForPalidrome(string inputString)
        {
            bool isPalindrome = inputString.SequenceEqual(inputString.Reverse());
            return isPalindrome;
        }
        public void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 31: Palindrome Timestamps");
            Console.WriteLine("       Create a function that takes two times of day(hours, minutes, seconds)");
            Console.WriteLine("       and returns the amount of occurences of palendrome timestamps.");
            Console.WriteLine("       A palindrome timestamp should be read the same hours : minutes : seconds");
            Console.WriteLine("       as seconds : minutes : hours, keeping in mind the second's and hour's digits");
            Console.WriteLine("       will reverse.For example, 02 : 11 : 20 is a palindrome timestamp.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       PalindromeTimestamps(2, 12, 22, 4, 35, 10) --> 14");
            Console.WriteLine("       PalindromeTimestamps(12, 12, 12, 13, 13, 13) --> 6");
            Console.WriteLine("       PalindromeTimestamps(6, 33, 15, 9, 55, 10) --> 0");
            Console.WriteLine("       Notes");
            Console.WriteLine("       Expect military time.");
            Console.WriteLine("       Include the given time parameters if they happen to be palindromes.");
            Console.WriteLine("       The parameter timestamps are chronological.\n");
        }
    }
}
//Palindrome Timestamps https://edabit.com/challenge/asngMFwniLcegJJ7P
//Create a function that takes two times of day(hours, minutes, seconds) and returns the amount of occurences of palendrome timestamps.
//A palindrome timestamp should be read the same hours : minutes : seconds as seconds : minutes : hours, keeping in mind the second's and hour's digits will reverse.For example, 02 : 11 : 20 is a palendrome timestamp.
//Examples
//PalindromeTimestamps(2, 12, 22, 4, 35, 10) --> 14
//PalindromeTimestamps(12, 12, 12, 13, 13, 13) --> 6
//PalindromeTimestamps(6, 33, 15, 9, 55, 10) --> 0
//Notes
//Expect military time.
//Include the given time parameters if they happen to be palindromes.
//The parameter timestamps are chronological.
// Steps
// Create TimeSpan variables for timeSpan1 and timeSpan2 with corresponding hours, minutes, seconds
// Create int palidromeCounter variable = 0;
// Check to see if timeSpan1.ToString() is a palindrome
// if it is, then add 1 to the palidromeCounter
// else add 1 to the seconds of timeSpan1 and repeat