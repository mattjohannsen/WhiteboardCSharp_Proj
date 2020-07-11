using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge34
    {
        public void RunChallenge()
        {
            ChallengeDescription();
            Console.WriteLine($"       Carlos swam masterfully. --> {IsSmooth("Carlos swam masterfully.")}");
            Console.WriteLine($"       Marta appreciated deep perpendicular right trapezoids --> {IsSmooth("Marta appreciated deep perpendicular right trapezoids")}");
            Console.WriteLine($"       Someone is outside the doorway --> {IsSmooth("Someone is outside the doorway")}");
            Console.WriteLine($"       She eats super righteously --> {IsSmooth("She eats super righteously")}");
        }
        bool IsSmooth(string inputString)
        {
            bool sentenceIsSmooth = true;
            char[][] sentenceArray = MakeJaggedArray(inputString);
            for (int i = 0; i < sentenceArray.Length-1; i++)
            {
                if (GetLastCharacter(sentenceArray[i]) != GetFirstCharacter(sentenceArray[i + 1]))
                {
                    return false;
                }
            }
            return sentenceIsSmooth;
        }
        char[][] MakeJaggedArray(string inputString)
        {
            return inputString.Split(' ').Select(word => word.ToArray()).ToArray();
        }
        char GetLastCharacter(char[] inputArray)
        {
            return inputArray[inputArray.Length - 1];
        }
        char GetFirstCharacter(char[] inputArray)
        {
            return inputArray[0];
        }
        private void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 34: Smooth Sentences");
            Console.WriteLine("       Carlos is a huge fan of something he calls smooth sentences.A smooth sentence is one");
            Console.WriteLine("       where the last letter of each word is identical to the first letter the following word.");
            Console.WriteLine("       To illustrate, the following would be a smooth sentence: 'Carlos swam masterfully.'");
            Console.WriteLine("       Since 'Carlos' ends with an 's' and swam begins with an 's' and swam ends with an 'm'");
            Console.WriteLine("       and masterfully begins with an 'm'.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       IsSmooth('Marta appreciated deep perpendicular right trapezoids') --> true");
            Console.WriteLine("       IsSmooth('Someone is outside the doorway') --> false");
            Console.WriteLine("       IsSmooth('She eats super righteously') --> true\n");
        }
    }
}
//Smooth Sentences
//Carlos is a huge fan of something he calls smooth sentences.A smooth sentence is one where the last letter of each word is identical to the first letter the following word.
//To illustrate, the following would be a smooth sentence: "Carlos swam masterfully."
//Since "Carlos" ends with an "s" and swam begins with an "s" and swam ends with an "m" and masterfully begins with an "m".
//Examples
//IsSmooth("Marta appreciated deep perpendicular right trapezoids") --> true
//IsSmooth("Someone is outside the doorway") --> false
//IsSmooth("She eats super righteously") --> true
// Steps
// turn inputString into an Array --> stringAsArray
// turn array into a jagged array --> arrayWithWordsAsArrays with as many members as stringAsArray.length
// sentenceIsSmooth = true;
// Start loop to go through sentence and create arrayWithWordsAsArrays using ToCharArray--> i
// Now compare arrayWithWordsAsArrays to see if smooth
// Loop through arrayWithWordsAsArrays to go through words--> i
//    Loop through arrayWithWordsAsArrays[i] to go through letters
//    
// If arrayWithWordsAsArrays[i]