using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge54
    {
        public void RunChallenge()
        {
            Console.WriteLine("       Challenge 54");
            Console.WriteLine($"       AverageWordLength(A B C.) --> {AverageWordLength("A B C.")}");
            Console.WriteLine($"       AverageWordLength(A B C.) --> {AverageWordLength("What a gorgeous day.")}");
            Console.WriteLine($"       AverageWordLength(A B C.) --> {AverageWordLength("Dude, this is so awesome!")}");

            
        }
        public static double AverageWordLength(string str)
        {
            string[] arr = str.Split(' ');
            double totalCharacterLength = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                string temp = Regex.Replace(arr[i], "[^a-zA-Z0-9]", String.Empty);
                arr[i] = temp;
                totalCharacterLength += arr[i].Length;
            }
            return Math.Round(totalCharacterLength / arr.Length, 2);
        }
    }
}
// Steps
// Take string and turn into an array
// Create an int List solutionList
// Create int totalCharacterLength
// loop through array and remove punctuation
// totalCharacterLength += arr[i].Length
// return totalCharacterLength/arr.Length


//Average Word Length https://edabit.com/challenge/z84RP4x6TqLdW4iva
//Create a function that takes in a sentence and returns the average length of each word in that sentence.Round your result to two decimal places.
//Examples
//AverageWordLength("A B C.") --> 1.00
//AverageWordLength("What a gorgeous day.") --> 4.00
//AverageWordLength("Dude, this is so awesome!") --> 3.80