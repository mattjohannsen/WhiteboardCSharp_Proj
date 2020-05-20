using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge1
    {

        public int[] RunChallenge(int[] inputArray, int inputTarget)
        {
            int[] returnArray = new int[2];
            int firstNumber;
            int secondNumber;
            //Loop through the inputArray for first value
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.WriteLine(inputArray[i]);
                //Loop through secondArray for the second value
                for (int j = 0; j < (inputArray.Length); j++)
                {
                    if (i==j)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(inputArray[i] + inputArray[j]);
                        if(inputArray[i] + inputArray[j] == inputTarget)
                        {
                            returnArray[0] = inputArray[i];
                            returnArray[1] = inputArray[j];
                            Console.WriteLine(i + " " + j);
                        }
                    }
                }
            }

            return returnArray;
        }
    }
}
