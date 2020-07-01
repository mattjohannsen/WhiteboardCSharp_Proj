using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge24
    {
        public void RunChallenge()
        {
            ChallengeDescription();
            int originalNumber = 0;
            Console.WriteLine($"       Original number: {originalNumber} #1's: {CountOnes(originalNumber)}");
            originalNumber = 100;
            Console.WriteLine($"       Original number: {originalNumber} #1's: {CountOnes(originalNumber)}");
            originalNumber = 999;
            Console.WriteLine($"       Original number: {originalNumber} #1's: {CountOnes(originalNumber)}");
        }
        public int CountOnes(int inputNumber)
        {
            List<char> binaryList = Convert.ToString(inputNumber, 2).ToList();
            int binaryCount = 0;
            for (int i = 0; i < binaryList.Count; i++)
            {
                if (binaryList[i]=='1')
                {
                    binaryCount++;
                }
            }
            return binaryCount;
        }

        public void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 24: Count Ones in Binary Representation of Integer");
            Console.WriteLine("       Count the amount of ones in the binary representation of an integer.");
            Console.WriteLine("       So for example, since 12 is '1100' in binary, the return value should be 2.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       CountOnes(0) --> 0");
            Console.WriteLine("       CountOnes(100) --> 3");
            Console.WriteLine("       CountOnes(999) --> 8");
            Console.WriteLine("       Notes");
            Console.WriteLine("       The input will always be a valid integer(number).\n");
        }
    }
}
//Count Ones in Binary Representation of Integer https://edabit.com/challenge/zn3A3AAzoE7vezw7Q
//Count the amount of ones in the binary representation of an integer.So for example, since 12 is '1100' in binary, the return value should be 2.
//Examples
//CountOnes(0) --> 0
//CountOnes(100) --> 3
//CountOnes(999) --> 8
//Notes
//The input will always be a valid integer(number).
// Steps
// create int originalNumber
// Turn originalNumber into binary representation of itself binaryNumber
// Turn the binaryNumber into a string and then into a list List<char> binaryList
// create int binaryCount
// Loop through binaryList and if binaryList[i] is equal to 1 the add one to binaryCount
// return binaryCount