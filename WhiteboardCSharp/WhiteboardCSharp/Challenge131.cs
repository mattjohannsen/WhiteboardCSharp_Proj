using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge131
    {
        public static string Reverse(string str)
        {
            string[] arr = str.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length >= 5)
                {
                    char[] temp = arr[i].ToCharArray();
                    Array.Reverse(temp);
                    arr[i] = new string(temp);
                }
            }
            return string.Join(" ", arr);
        }
    }
}
//Reverse the Order of Words with Five Letters or More
//Write a function that takes a string of one or more words as an argument and returns the same string, but with all five or more letter words reversed.Strings passed in will consist of only letters and spaces.Spaces will be included only when more than one word is present.

//Examples
//Reverse("Reverse") ➞ "esreveR"

//Reverse("This is a typical sentence.") ➞ "This is a lacipyt .ecnetnes"

//Reverse("The dog is big.") ➞ "The dog is big."
//Notes
//You can expect a valid string to be provided for each test case.