using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge45
    {
        public void RunChallenge()
        {
            ChallengeDescription();
            Console.WriteLine(Brackets("(a*(b-c)..... )")); //true
            Console.WriteLine(Brackets(")((a-b-45/7*(a-34))")); //false
            Console.WriteLine(Brackets("sin(90...)+.............cos1)")); //false
        }
        public static bool Brackets(string inputString)
        {
            char[] stringAsArray = inputString.ToCharArray();
            int count = 0;
            for (int i = 0; i < stringAsArray.Length; i++)
            {
                if (stringAsArray[i] == '(')
                {
                    int lookForRightsFromThisIndex = i + 1;
                    int nextRightBracket = Array.IndexOf(stringAsArray, ')', lookForRightsFromThisIndex);
                    if (nextRightBracket == -1) return false;
                    count++;
                }
                if (stringAsArray[i] == ')')
                {
                    if (count == 0) return false;
                    count--;
                }
            }
            return (count == 0);
        }
        public bool StringHasEqualParenthesis(string inputString)
        {
            var leftCount = inputString.Count(x => x == '(');
            var rightCount = inputString.Count(x => x == ')');
            return (leftCount==rightCount);
        }
        public void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 45: Clear Brackets");
            Console.WriteLine("       Create a function Brackets() that takes a string and checks that the brackets");
            Console.WriteLine("       in the math expression are correct.The function should return true or false.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       Brackets('(a * (b - c)..... )') --> true");
            Console.WriteLine("       Brackets(')(a - b - 45 / 7 * (a - 34))') --> false");
            Console.WriteLine("       Brackets('sin(90...) + .............cos1)') --> false");
            Console.WriteLine("       Notes");
            Console.WriteLine("       The string may not contain brackets, then return true.");
            Console.WriteLine("       String may contain spaces.");
            Console.WriteLine("       The string may be empty.\n");
        }
    }
}
//Clear Brackets https://edabit.com/challenge/9y3dJ4kWQ7GxdGNN5
//Create a function Brackets() that takes a string and checks that the brackets in the math expression are correct.The function should return true or false.
//Examples
//Brackets("(a*(b-c)..... )") --> true
//Brackets(")(a-b-45/7*(a-34))") --> false
//Brackets("sin(90...)+.............cos1)") --> false
//Notes
//The string may not contain brackets, then return true.
//String may contain spaces.
//The string may be empty.
// Steps
// isExpressionCorrect = false
// turn inputString into an char[] Array --> stringAsArray
// start i loop which is equal to stringAsArray.Length/2
// if stringAsArray[i] contains ( or "
// then start counting backwards in string <-- and find if the first ) or " is
// if all of the corresponding ( and " line up with " or )
// then return true
