using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge43
    {
        public void RunChallenge()
        {
            ChallengeDescription();
            Console.WriteLine($"       LongestCommonEnding(multiplication, ration) --> '{LongestCommonEnding("multiplication", "ration")}'");
            Console.WriteLine($"       LongestCommonEnding(potent, tent) --> '{LongestCommonEnding("potent", "tent")}'");
            Console.WriteLine($"       LongestCommonEnding(skyscraper, carnivore) --> '{LongestCommonEnding("skyscraper", "carnivore")}'");
        }
        public static string LongestCommonEnding(string str1, string str2)
        {
            int shortestLength = Math.Min(str1.Length, str2.Length);
            string stringToCheck = "";
            for (int i = 0; i <= shortestLength -1; i++)
            {
                string oldstringToCheck = stringToCheck;
                stringToCheck = str1[str1.Length - 1 - i].ToString() + stringToCheck;
                bool stringDoesEndWith = str2.EndsWith(stringToCheck, StringComparison.CurrentCulture);
                if (!stringDoesEndWith)
                {
                    return oldstringToCheck;
                }
            }
            return stringToCheck;
        }
        //private string LongestCommonEnding(string stringOne, string stringTwo) // Matt's original solution
        //{
        //    char[] arrayOne = stringOne.ToCharArray();
        //    char[] arrayTwo = stringTwo.ToCharArray();
        //    Array.Reverse(arrayOne);
        //    Array.Reverse(arrayTwo);
        //    int indexWhereSamenessStops=0;
        //    int shortestArrayLength = Math.Min(arrayOne.Length, arrayTwo.Length);
        //    for (int i = 0; i < shortestArrayLength; i++)
        //    {

        //        if (arrayOne[i]==arrayTwo[i])
        //        {
        //            if (shortestArrayLength== i+1)
        //            {
        //                indexWhereSamenessStops = i + 1;
        //            }
        //            else
        //            {
        //                continue;
        //            }
        //        }
        //        else
        //        {
        //            indexWhereSamenessStops = i;
        //            break;
        //        }
        //    }
        //    List<char> solutionList = new List<char>();
        //    if (indexWhereSamenessStops == 0)
        //    {
        //        return "";
        //    }
        //    else
        //    {
        //        for (int j = 0; j < indexWhereSamenessStops; j++)
        //        {
        //            solutionList.Add(arrayOne[j]);
        //        }
        //    }
        //    solutionList.Reverse();
        //    return string.Join("", solutionList);
        //}
        public void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 43: Longest Common Ending");
            Console.WriteLine("       Write a function that returns the longest common ending between two strings.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       LongestCommonEnding(multiplication, ration) --> ation)");
            Console.WriteLine("       LongestCommonEnding(potent, tent) --> tent");
            Console.WriteLine("       LongestCommonEnding(skyscraper, carnivore) --> ");
            Console.WriteLine("       Notes");
            Console.WriteLine("       Return an empty string if there exists no common ending.\n");
        }
    }
}
//Longest Common Ending https://edabit.com/challenge/zRNkYPzy8oviqkrWc
//Write a function that returns the longest common ending between two strings.
//Examples
//LongestCommonEnding("multiplication", "ration") --> "ation"
//LongestCommonEnding("potent", "tent") --> "tent"
//LongestCommonEnding("skyscraper", "carnivore") --> ""
//Notes
//Return an empty string if there exists no common ending.