﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge74
    {
        public void RunChallenge()
        {
            ChallengeDescription();
            Console.WriteLine($"       UniqueFract() --> {UniqueFract()}");
        }
        public static double UniqueFract()
        {
            List<int[]> arrayList = new List<int[]>();
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (i < j)
                    {
                        int gcd = GetGCF(i, j);
                        int[] arrayToAdd = { i / gcd, j / gcd };
                        arrayList.Add(arrayToAdd);
                    }
                }
            }
            var distinctList = arrayList.GroupBy(c => String.Join(",", c)).Select(c => c.First().ToList()).ToList();
            double returnSum = 0;
            for (int i = 0; i < distinctList.Count; i++)
            {
                returnSum += (double)distinctList[i][0] / distinctList[i][1];
            }
            return returnSum;
        }
        public static int GetGCF(int num1, int num2)
        {
            return (Convert.ToBoolean(num1)) ? GetGCF(num2 % num1, num1) : num2;
        }
        public void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 74: Amount of Unique Fractions");
            Console.WriteLine("       Create a function double UniqueFract(), which should sum all irreducible regular fractions");
            Console.WriteLine("       between 0 and 1, in the numerator and denominator of which there are only single-digit numbers:");
            Console.WriteLine("       1/2, 1/3, 1/4, ... 2/3, 2/4, ... 8/9.");
            Console.WriteLine("       Task");
            Console.WriteLine("       UniqueFract() --> 13.5");
            Console.WriteLine("       Notes");
            Console.WriteLine("       Of the fractions 1/2 2/4 3/6 4/8, only 1/2 is included in the sum.");
            Console.WriteLine("       Don't include any values >= 1.\n");
        }
    }
}
//Amount of Unique Fractions
//Create a function double UniqueFract(), which should sum all irreducible regular fractions between 0 and 1, in the numerator and denominator of which there are only single-digit numbers: 1/2, 1/3, 1/4, ... 2/3, 2/4, ... 8/9.

//Task
//UniqueFract() --> sum
//Notes
//Of the fractions 1/2 2/4 3/6 4/8, only 1/2 is included in the sum.
//Don't include any values >= 1.
// Steps
// Create list which will hold arrays
// Start loop 1 through 9 for numerator
// Start Loop 1 through 9 for denomenator
// reduce numerator and denomenator
// Add numerator/denomenator array to List
// Use list.Distinct() to eliminate duplicates
// Loop through list
// Add each distinct numerator/denomenator double to double theAnswer
// return theAnswer