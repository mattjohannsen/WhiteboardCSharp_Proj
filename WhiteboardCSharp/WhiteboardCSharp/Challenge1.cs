using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge1
    {
        int[] challengeArray = { 5, 17, 77, 50 };
        int target;
        int[] indecesArray;

        public Challenge1()
        {
            target = 55;
        }
        public void RunChallenge()
        {
            ChallengeDescription();
            indecesArray = GetIndeces(challengeArray, target);
            DisplayAnswer(indecesArray);

        }

        public void ChallengeDescription()
        {
            Console.WriteLine("\n       Problem #1");
            Console.WriteLine("       Given the following array of values: { 5, 17, 77, 50 }");
        }

        public int[] GetIndeces(int[] inputArray, int inputTarget)
        {
            int[] returnArray = new int[2];
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < (inputArray.Length); j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    else
                    {
                        if (inputArray[i] + inputArray[j] == inputTarget)
                        {
                            returnArray[0] = i;
                            returnArray[1] = j;
                        }
                    }
                }
            }
            return returnArray;
        }
        public void DisplayAnswer(int[] inputArray)
        {
            Console.Write($"       The indeces of the two numbers that add up to {target} are: ");
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write(inputArray[i] + " ");
            }
        }
    }
}
