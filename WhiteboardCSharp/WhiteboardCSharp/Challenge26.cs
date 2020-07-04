using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge26
    {
        public void RunChallenge()
        {
            Console.WriteLine("       challenge 26");
            int numberToTest = 838;
            bool theAnswer = IsPalindrome(numberToTest);
            Console.WriteLine(theAnswer);
            numberToTest = 4433;
            theAnswer = IsPalindrome(numberToTest);
            Console.WriteLine(theAnswer);
            numberToTest = 443344;
            theAnswer = IsPalindrome(numberToTest);
            Console.WriteLine(theAnswer);
            numberToTest = 4436344;
            theAnswer = IsPalindrome(numberToTest);
            Console.WriteLine(theAnswer);
            numberToTest = 4456344;
            theAnswer = IsPalindrome(numberToTest);
            Console.WriteLine(theAnswer);

        }
        public bool IsPalindrome(int inputNumber)
        {
            bool isPalindrome = true;
            string numberAsString = inputNumber.ToString();
            List<char> numberAsList = numberAsString.ToList();
            int startingPlace = numberAsList.Count / 2;
            if (numberAsList.Count %2 == 0) // list is even
            {
                for (int i = 0; i < startingPlace; i++)
                {
                    char leftChar = numberAsList[startingPlace - 1 - i];
                    char rightChar = numberAsList[startingPlace + i];
                    if (leftChar == rightChar)
                    {
                        continue;
                    }
                    else
                    {
                        isPalindrome = false;
                        return isPalindrome;
                    }
                }
            }
            else // list is odd
            {
                for (int i = 0; i < startingPlace; i++)
                {
                    if (numberAsList[startingPlace + i + 1] == numberAsList[startingPlace - 1 - i])
                    {
                        continue;
                    }
                    else
                    {
                        isPalindrome = false;
                        return isPalindrome;
                    }
                }
            }

            return isPalindrome;
        }

    }
}
//Check if a Number is a Palindrome
//Create a function that returns true if a number is a palindrome.
//Examples
//IsPalindrome(838) --> true
//IsPalindrome(4433) --> false
//IsPalindrome(443344) --> true
// Steps
// Create int numberToTest
// pass numberToTest into IsPalindrome() method
// create bool IsPalindrome method which returns bool isPalindrome
// set isPalindrome equal to true
// turn the int into a string and turn it into a list numberAsList

// check to see if the length of the list is odd or even
// if it is even then
// int startingPlace = divide the length of the list into two
// loop through the list startingPlace times
// if the numberAsList[startingPlace] == numberAsList[startingPlace-1-i]
// continue
//else return isPalindrome false

// else if it is odd
// int startingPlace = dividing the List.Count/2
// loop through list startingPlace times
// if numberAsList[startingPlace + i] == numberAsList[startingPlace-1-i]
// continue
//else return isPalindrome false
