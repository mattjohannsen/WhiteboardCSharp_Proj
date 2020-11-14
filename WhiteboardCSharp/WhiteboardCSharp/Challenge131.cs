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
            return string.Join(" ", str.Split(' ').Select(x => x.Length >= 5 ? new String(x.Reverse().ToArray()) : x));
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