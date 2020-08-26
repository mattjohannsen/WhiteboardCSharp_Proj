using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge68
    {
        public void RunChallenge()
        {
            Console.WriteLine("       Challenge 68");
            string[] inputArr = { "John Locke", "Thomas Aquinas", "David Hume", "Rene Descartes" };
            string[] sortedArray = SortContacts(inputArr, "ASC");
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.WriteLine($"       {sortedArray[i]}");
            }
            string[] inputArr2 = { "Paul Erdos", "Leonhard Euler", "Carl Gauss" };
            string[] sortedArray2 = SortContacts(inputArr2, "DESC");
            for (int i = 0; i < sortedArray2.Length; i++)
            {
                Console.WriteLine($"       {sortedArray2[i]}");
            }
        }
        public static string[] SortContacts(string[] names, string sort)
        {
            for (int i = 0; i < names.Length - 1; i++)
            {
                for (int j = 0; j < names.Length -1; j++)
                {
                    string lastNameA = names[j].Split(' ')[1];
                    string lastNameB = names[j + 1].Split(' ')[1];
                    int sortValue = string.Compare(lastNameA, lastNameB);
                    string temp;
                    if (sort == "ASC")
                    {
                        if (sortValue == 1)
                        {
                            temp = names[j + 1];
                            names[j + 1] = names[j];
                            names[j] = temp;
                        }
                    }
                    else if (sort == "DESC")
                    {
                        if (sortValue == -1)
                        {
                            temp = names[j];
                            names[j] = names[j + 1];
                            names[j + 1] = temp;
                        }
                    }
                }
            }
            return names;
        }
    }
}
//Contact List
//Write a sorting function that takes in an array of names and sorts them by last name either alphabetically(ASC) or reverse-alphabetically(DESC).
//SortContacts(new string[] {
//  "John Locke",
//  "Thomas Aquinas",
//  "David Hume",
//  "Rene Descartes"
//}, "ASC") --> {
//  "Thomas Aquinas",
//  "Rene Descartes",
//  "David Hume",
//  "John Locke"
//}
//// Aquinas (A) < Descartes (D) < Hume (H) < Locke (L)
//SortContacts(new string[] {
//  "Paul Erdos",
//  "Leonhard Euler",
//  "Carl Gauss"
//}, "DESC") --> {
//  "Carl Gauss",
//  "Leonhard Euler",
//  "Paul Erdos"
//}
//// Gauss (G) > Erdos (ER) > Euler (EU)
//SortContacts([], "DESC") --> {}
//SortContacts(null, "DESC") --> {}