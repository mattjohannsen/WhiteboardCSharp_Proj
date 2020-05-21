using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    class Challenge2
    {
        string wordToCheck;

        public void RunChallenge()
        {
            ChallengeDescription();
        }

        public void ChallengeDescription()
        {
            Console.WriteLine("\n\n       Problem #2");
            Console.WriteLine("       Palindrome is a word, phrase, or sequence that reads the same backward as forward i.e.");
            Console.WriteLine("       madam. Write code that takes a user input and checks to see if it is a Palindrome and reports");
            Console.WriteLine("       the result. You must handle spaces.");

        }
    }


    //    Step 1) Capture user input
    //    Step 2) Get word length
    //    Step 3) Divide by 2
    //    Step 4) If odd...
    //            a) Since integer rounds down the result will be the middle index and also the number of times we need to run a check on the characters
    //            b) Check if the characters match on indeces +1 and -1.
    //    Step 5) If even...
    //            a) Compare the characters at the (length divided by 2)index and (the length divided by 2 -1)index
    //            b) Run this check until false or length/2 times.
    //    Step 6) If everthing matches... it is a palindrome
}
