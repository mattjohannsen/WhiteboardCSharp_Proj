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
            ChallengeDescription();
            Console.WriteLine($"       AverageWordLength(A B C.) --> {AverageWordLength("A B C.")}");
            Console.WriteLine($"       AverageWordLength(What a gorgeous day.) --> {AverageWordLength("What a gorgeous day.")}");
            Console.WriteLine($"       AverageWordLength(Dude, this is so awesome!) --> {AverageWordLength("Dude, this is so awesome!")}");
        }
        public static double AverageWordLength(string str)
        {
            return Math.Round(Regex.Replace(str, "[^A-Za-z ]", "").Split(' ').Select(x => x.Length).Average(), 2);
        }
        public void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 54: Average Word Length");
            Console.WriteLine("       Create a function that takes in a sentence and returns the average length of each word in that sentence.");
            Console.WriteLine("       Round your result to two decimal places.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       AverageWordLength(A B C.) --> 1.00");
            Console.WriteLine("       AverageWordLength(What a gorgeous day.) --> 4.00");
            Console.WriteLine("       AverageWordLength(Dude, this is so awesome!) --> 3.80\n");
        }
    }
}

//Average Word Length https://edabit.com/challenge/z84RP4x6TqLdW4iva
//Create a function that takes in a sentence and returns the average length of each word in that sentence.Round your result to two decimal places.
//Examples
//AverageWordLength("A B C.") --> 1.00
//AverageWordLength("What a gorgeous day.") --> 4.00
//AverageWordLength("Dude, this is so awesome!") --> 3.80
// Steps
// Take string and turn into an array
// Create an int List solutionList
// Create int totalCharacterLength
// loop through array and remove punctuation
// totalCharacterLength += arr[i].Length
// return totalCharacterLength/arr.Length