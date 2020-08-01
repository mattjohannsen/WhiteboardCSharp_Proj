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
            ChallengeDescription();
            Console.WriteLine($"       3 --> {Challenge48.MysteryFunc(3)}");
            Console.WriteLine($"       9 --> {Challenge48.MysteryFunc(9)}");
            Console.WriteLine($"       17 --> {Challenge48.MysteryFunc(17)}");
            Console.WriteLine($"       24 --> {Challenge48.MysteryFunc(24)}");
        }
        public static int MysteryFunc(int inputNumber)
        {
            string returnString = "";
            int nCount = 0;
            for (int i = 1; i <= inputNumber / 2; i++)
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
            for (int j = 1; j < 10; j++)
            {
                if (Math.Pow(2, nCount) + j == inputNumber)
                {
                    returnString += j;
                    break;
                }
            }
            return Convert.ToInt32(returnString);
        }
        public void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 48: Reverse Coding Challenge #2");
            Console.WriteLine("       This is a reverse coding challenge.");
            Console.WriteLine("       Your task is to create a function that, when fed the inputs below, produce the sample outputs shown.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       3 --> 21");
            Console.WriteLine("       9 --> 2221");
            Console.WriteLine("       17 --> 22221");
            Console.WriteLine("       24 --> 22228\n");
        }
    }
}

//Reverse Coding Challenge #2 https://edabit.com/challenge/PGLjsEXWB5AWdoFGY
//This is a reverse coding challenge.
//Your task is to create a function that, when fed the inputs below, produce the sample outputs shown.
//Examples
//3 --> 21
//9 --> 2221
//17 --> 22221
//24 --> 22228
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