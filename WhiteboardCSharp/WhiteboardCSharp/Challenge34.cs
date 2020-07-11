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
            Console.WriteLine("       Challenge 34");
            //Console.WriteLine(IsSmooth("Carlos swam masterfully."));
            Console.WriteLine(IsSmooth("She eats super righteously"));
        }
        bool IsSmooth(string inputString)
        {
            bool sentenceIsSmooth = true;
            string[] stringAsArray = inputString.Split(' ');
            char[][] arrayWithWordsAsArrays = new char[stringAsArray.Length][];
            for (int i = 0; i < stringAsArray.Length; i++)
            {
                arrayWithWordsAsArrays[i] = stringAsArray[i].ToCharArray();
            }
            for (int i = 0; i < arrayWithWordsAsArrays.Length-1; i++)
            {
                char currentWordLastChar = GetLastCharacter(arrayWithWordsAsArrays[i]);
                char nextWordFirstChar = GetFirstCharacter(arrayWithWordsAsArrays[i+1]);
                if (currentWordLastChar != nextWordFirstChar)
                {
                    return false;
                }
            }
            return sentenceIsSmooth;
        }
        char GetLastCharacter(char[] inputArray)
        {
            return inputArray[inputArray.Length - 1];
        }
        char GetFirstCharacter(char[] inputArray)
        {
            return inputArray[0];
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