using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge48
    {
        public void RunChallenge()
        {
            Console.WriteLine("       Challenge 47");
            Console.WriteLine(Challenge48.TwoToTheNthPowerPlusModulus(3));
            Console.WriteLine(Challenge48.TwoToTheNthPowerPlusModulus(9));
            Console.WriteLine(Challenge48.TwoToTheNthPowerPlusModulus(17));
            Console.WriteLine(Challenge48.TwoToTheNthPowerPlusModulus(24));

        }
        public static long TwoToTheNthPowerPlusModulus(int inputNumber)
        {
            string returnString = "";
            int loopLength = inputNumber / 2;
            int nCount = 0;
            //int loopLength = Convert.ToInt32(Math.Pow(inputNumber, 1 / 2));
            for (int i = 1; i <= loopLength; i++)
            {
                if (Math.Pow(2, i) < inputNumber)
                {
                    returnString += "2";
                    nCount++;
                }
                else
                {
                    break;
                }
            }
            double nthProductWithoutRemainder = Math.Pow(2, nCount);
            for (int j = 1; j < 10; j++)
            {
                if (nthProductWithoutRemainder + j == inputNumber)
                {
                    returnString += j;
                    break;
                }
            }
            long returnNumber = Convert.ToInt32(returnString);

            return returnNumber;
        }

    }
}
//Reverse Coding Challenge #2
//This is a reverse coding challenge.

//Your task is to create a function that, when fed the inputs below, produce the sample outputs shown.

//Examples
//3 ➞ 21 2+1 = 3

//9 ➞ 2221 2*2*2 =  8 + 1 =9

//17 ➞ 22221 2*2*2*2+1 = 17

//24 ➞ 22228 Four 2's 4*2=8 2*2*2*2 + 8
//inputNumber = 3
//2*1
//Steps
//make string = returnString = "";
//inputNumber%2 = lastNumber
//inputNumber/2 = loopLength
//start loop at 1, loopLength, i++
//if i* 2 < inputNumber
//returnString + "2";
//else
//returnString + lastNumber;
//end loop
//returnInt = Int32.Parse(returnString );
//return returnInt;