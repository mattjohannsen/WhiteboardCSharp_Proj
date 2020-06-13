﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    class Challenge12
    {
        //public int numberOne = 25; //Returns true
        //public int numberTwo = 21;
        //public int numberThree = 125;
        //int numberOne = 55; //Returns true
        //int numberTwo = 226;
        //int numberThree = 5190;
        int numberOne = 12; //Returns false
        int numberTwo = 215;
        int numberThree = 2142;
        public void RunChallenge()
        {
            ChallengeDescription();
            bool theAnswer = DoesTwoIntProductEqualThird(numberOne, numberTwo, numberThree);
            Console.WriteLine($"\n       Does ({numberOne}, {numberTwo}, {numberThree}) pass Last Digit Ultimate Challenge?: " + theAnswer);
        }

        public bool DoesTwoIntProductEqualThird(int firstNum, int secondNum, int thirdNum)
        {
            bool doesSolutionWork = ((GetLastDigit(thirdNum)) == (GetLastDigit(GetLastDigit(firstNum) * GetLastDigit(secondNum)))) ? true : false;

            return doesSolutionWork;
        }

        public int GetLastDigit(int inputNumber)
        {
            List<int> numberList = inputNumber.ToString().Select(c => Convert.ToInt32(c.ToString())).ToList();
            return numberList[numberList.Count - 1];

        }
        public void ChallengeDescription()
        {
            Console.WriteLine("       This is Challenge 12: Last Digit Ultimate");
            Console.WriteLine("       Your job is to create a function that takes 3 numbers: a, b, c and returns true if the last digit");
            Console.WriteLine("       of(the last digit of a* the last digit of b) = the last digit of c.");
        }
    }
}
// Steps
// Create three variables for three numbers - numberOne, numberTwo, numberThree
// Create bool method which takes in three numbers DoesTwoIntProductEqualThird and returns true or false
// Create variables for last digits - firstNumLast and lastNumLast
// Create two Lists for each int,
//  Turn the int into a string, and then to an array --> num.ToString().Select(c => Convert.ToInt32(c.ToString())).ToArray();
// Find the last digits of each List by using a for loop
// If the product of firstNumLast multiplied by secondNumLast is equal to the thirdNumLast number THEN
// return true
// Else return false.

//Last Digit Ultimate https://edabit.com/challenge/gFiX2TwoCKi6NZz5H
//Your job is to create a function that takes 3 numbers: a, b, c and returns true if the last digit
//    of(the last digit of a* the last digit of b) = the last digit of c.Check examples for explanation.
//last_dig(25, 21, 125) ➞ true
//// The last digit of 25 is 5, the last digit of 21 is 1, and the last
//// digit of 125 is 5, and the last digit of 5*1 = 5, which is equal
//// to the last digit of 125 (5).

//last_dig(55, 226, 5190) ➞ true
//// The last digit of 55 is 5, the last digit of 226 is 6, and the last
//// digit of 5190 is 0, and the last digit of 5*6 = 30 is 0, which is
//// equal to the last digit of 5190 (0).

//last_dig(12, 215, 2142) ➞ false
//// The last digit of 12 is 2, the last digit of 215 is 5, and the last
//// digit of 2142 is 2, and the last digit of 2*5 = 10 is 0, which is
//// not equal to the last digit of 2142 (2).