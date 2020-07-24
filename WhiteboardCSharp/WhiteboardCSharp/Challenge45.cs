using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge45
    {
        char charToCheck;
        public void RunChallenge()
        {
            Console.WriteLine("       Challenge 45");
            Console.WriteLine(Brackets("(a*(b-c)..... )")); //true
            Console.WriteLine(Brackets(")(a-b-45/7*(a-34))")); //false
            Console.WriteLine(Brackets("sin(90...)+.............cos1)")); //false
        }
        public bool Brackets(string inputString)
        {
            List<char> stringAsList = inputString.ToList();
            int firstleftBracket = stringAsList.IndexOf('(');
            int firstrightBracket = stringAsList.IndexOf(')');
            int lastLeftBracket = stringAsList.LastIndexOf('(');
            int lastRightBracket = stringAsList.LastIndexOf(')');
            if (charToCheck == ')' || charToCheck == null)
            {
                charToCheck = '(';
                if (firstleftBracket < firstrightBracket)
                {
                    return false;
                }
            }
            else
            {
                charToCheck = ')';
                if (firstrightBracket < firstleftBracket)
                {
                    return false;
                }
            }
            if (!StringHasEqualParenthesis(inputString))
            {
                return false;
            }
            while ((stringAsList.Count == 0))
            {
                if (charToCheck == '(')
                {
                    // This is the code for checking for ( correctness
                    if (lastRightBracket < lastLeftBracket)
                    {
                        return false;
                    }
                    else if (firstrightBracket < firstleftBracket)
                    {
                        return false;
                    }
                    else
                    {
                        List<char> smallerList = new List<char>();
                        int loopCount = stringAsList.Count - (stringAsList.Count - lastRightBracket);
                        for (int i = firstleftBracket + 1; i < loopCount; i++)
                        {
                            smallerList.Add(stringAsList[i]);
                        }
                        string smallerstring = new string(smallerList.ToArray());
                        Brackets(smallerstring);
                    }
                    // End of code for checking for ( correctness
                }
                else
                {
                    // Beginning of code for checking for ) right parenthesis correctness
                    if (lastLeftBracket < lastRightBracket)
                    {
                        return false;
                    }
                    else if (firstleftBracket < firstrightBracket)
                    {
                        return false;
                    }
                    else
                    {
                        List<char> smallerList = new List<char>();
                        int loopCount = stringAsList.Count - (stringAsList.Count - lastLeftBracket);
                        for (int i = firstrightBracket + 1; i < loopCount; i++)
                        {
                            smallerList.Add(stringAsList[i]);
                        }
                        string smallerstring = new string(smallerList.ToArray());
                        Brackets(smallerstring);
                    }
                    // End of code for checking for ( right parenthesis correctness
                }
            }
            return true;
        }
        public bool StringHasEqualParenthesis(string inputString)
        {
            var leftCount = inputString.Count(x => x == '(');
            var rightCount = inputString.Count(x => x == ')');
            return (leftCount==rightCount);
        }
    }
}
//Clear Brackets
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
