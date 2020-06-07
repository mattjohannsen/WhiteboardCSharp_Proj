using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    class Challenge8
    {

        public void RunChallenge()
        {
            ChallengeDescription();
            string currentLock = "3893";
            string targetLock = "5296";
            int theSolution = GetTotalTurns(currentLock, targetLock);
            Console.WriteLine($"       The solution: {theSolution}");
        }
        public void ChallengeDescription()
        {
            Console.WriteLine("\n\n       Challenge 8");
            Console.WriteLine("       A briefcase has a four-digit rolling-lock. Each digit is a number from 0-9 that can be rolled");
            Console.WriteLine("       either forwards or backwards. Write a method that returns the smallest number of turns it ");
            Console.WriteLine("       takes to transform the lock from current combination to the target combination. One turn is ");
            Console.WriteLine("       equivalent to rolling a number forwards or backwards by one.");
            Console.WriteLine("               a.	Use case:");
            Console.WriteLine("                    i.	Current lock: 3893");
            Console.WriteLine("                    ii.	Target lock: 5296");
        }
        public int GetTotalTurns(string currentLock, string targetLock)
        {
            int totalTurns = 0;
            int[] currentLockArray = new int [4];
            int[] targetLockArray = new int[4];
            int turnUpSolution;
            int turnDownSolution;
            for (int i = 0; i < currentLock.Length; i++)
            {
                currentLockArray[i] = (int)Char.GetNumericValue(currentLock[i]);
                targetLockArray[i] = (int)Char.GetNumericValue(targetLock[i]);
            }
            for (int i = 0; i < currentLockArray.Length; i++)
            {
                if (currentLockArray[i]< targetLockArray[i])
                {
                    turnUpSolution = targetLock[i] - currentLock[i];
                    if (turnUpSolution<0)
                    {
                        turnUpSolution *= -1;
                    }
                    turnDownSolution = currentLock[i] + (10 - targetLock[i]);
                }
                else
                {
                    turnUpSolution = (10 - currentLock[i]) + targetLock[i];
                    turnDownSolution = targetLock[i] - currentLock[i];
                    if (turnDownSolution<0)
                    {
                        turnDownSolution *= -1;
                    }
                }
                if (turnUpSolution < turnDownSolution)
                {
                    totalTurns += turnUpSolution;
                }
                else
                {
                    totalTurns += turnDownSolution;
                }
            }
            return totalTurns;
        }
    }
}
//8.	A briefcase has a four-digit rolling-lock. Each digit is a number from 0-9 that can be rolled either forwards or backwards.
//  Write a method that returns the smallest number of turns it takes to transform the lock from current combination to the target 
//  combination. One turn is equivalent to rolling a number forwards or backwards by one. 21
//a.Use case:  
//i.Current lock: 3893
//ii.Target lock: 5296
// Steps
// Create currentLock variable
// Create targetLock variable
// Create turnUpSolution variable 
// Create turnDownSolution variable 
// Create totalTurns variablex 
// Loop through current lock and compare currentLock[i] to targetLock[i]
// turnUpSolution
// if currentLock is less that targetLock
// turnUpSolution = targetLock[i]-currentLock[i]
// else 
// 10 - currentLock + targetLock[i]
// turnDownSolution 
// If current lock is less than taget lock
// Add currentLock[i] + (10-targetLock[i]) this equals
// if turnUpSolution < turnDownSolution
// add turnUpSolution to totalTurns
// else
// add turnDownSolution to totalTurns
