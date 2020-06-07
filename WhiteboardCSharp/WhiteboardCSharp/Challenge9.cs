using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge9
    {
        int numberToTest = 331;
        public void RunChallenge()
        {
            Console.WriteLine("         Challenge 9");
            Console.WriteLine($"         Is {numberToTest} a happy number?");
            bool testMessage = IsNumberHappy(numberToTest);
            if (testMessage)
            {
                Console.WriteLine($"       {numberToTest} is a happy number.");
            }
            else
            {
                Console.WriteLine($"       {numberToTest} is not a happy number.");
            }        
        }

        public bool IsNumberHappy(int inputNumber)
        {
            bool isNumberHappy = false;
            int numberToCheck = GetSumOfSquare(inputNumber);
                if (numberToCheck == 1)
                {
                    isNumberHappy = true;
                }
                else
                {
                  return IsNumberHappy(numberToCheck);
                }
                //GetSumOfSquare(inputNumber);


            return isNumberHappy;
        }

        //public int[] GetArrayOfNumbers(int inputNumber)
        //{
        //    //int[] returnArray = inputNumber.ToString().Select(n => Convert.ToInt32(n)).ToArray();
        //    int[] returnArray = inputNumber.ToString().Select(n => Convert.ToInt32(n.ToString())).ToArray();
        //    return returnArray;
        //}
        public int GetSumOfSquare(int inputNumber)
        {
            int sumOfSquares = 0;
            int[] intArray = inputNumber.ToString().Select(n => Convert.ToInt32(n.ToString())).ToArray();
            Console.Write("       ");
            for (int i = 0; i < intArray.Length; i++)
            {
                
                int squareOfNumber;
                squareOfNumber = intArray[i] * intArray[i];
                sumOfSquares += squareOfNumber;
                Console.Write(" " + squareOfNumber);
            }
            Console.Write(" " + sumOfSquares + "\n");
            return sumOfSquares;
         }
    }
}

//9.	Happy Numbers // 33 = 25 = 8 
//a.A happy number is a number defined by the following process: starting with any positive integer, 
//    replace the number by the sum of the squares of its digits, and repeat the process until the 
//    number equals 1. An example of a happy number is 19
// Steps
// Create an integer numberToTest variable xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
// Create a IsNumberHappy method xxxxxxxxxxxxxxxx xxxxxxxxxxxxxxxxxxxxx
// Create sumOfSquares variable xxxxxxxxxxxxxxxxxxxx
// Keep checking the sum of the numbers, and if the sum of the squares equals 1 then return true.
// Turn the number into a string, and turn it into an array
// Create a loop that sums each iteration and adds it to sumOfSquares variable
// Create method that takes a number and returns the sum of it's squares.
// If the number equals 1, then return true;
//19
//1*1 + 9*9 = 82
//8*8 + 2*2 = 68
//6*6 + 8*8 = 100
//1*1 + 0*0 + 0*0 = 1
