﻿using System;
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
            Console.WriteLine("       Challenge 24");
            int originalNumber = 0;
            Console.WriteLine(CountOnes(originalNumber));
        }
        public int CountOnes(int inputNumber)
        {
            string binaryNumber = Convert.ToString(inputNumber, 2);
            List<char> binaryList = binaryNumber.ToList();
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