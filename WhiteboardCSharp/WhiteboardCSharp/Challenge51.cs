using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge51
    {
        public void RunChallenge()
        {
            Console.WriteLine("       Challenge 51");
            //Console.WriteLine(CommentsCorrect("//////"));
            
            Console.WriteLine(CommentsCorrect("///*/**/"));
        }
        public static bool CommentsCorrect(string str)
        {
            char[] arr = str.ToCharArray();
            if (arr.Length % 2 != 0)
            {
                return false;
            }
            for (int i = 0; i < arr.Length-2; i++)
            {
                if (arr[i] == '/' && arr[i+1] == '/')
                {
                    i ++;
                    continue;
                }
                else if (arr[i] == '/' && arr[i + 1] == '*')
                {
                    if (i+2> arr.Length)
                    {
                        return false;
                    }
                    else
                    {
                        if (arr[i+2] !='*' && arr[i + 3] != '/')
                        {
                            return false;
                        }
                        i++;
                        continue;
                    }
                }
            }
            return true;
        }
    }
}
//Valid JavaScript Comments
//In JavaScript, there are two types of comments:
//Single-line comments start with //
//Multi-line or inline comments start with /* and end with */
//The input will be a sequence of //, /* and */. Every /* must have a */ that immediately follows it. To add, there can be no single-line comments in between multi-line comments in between the /* and */.
//Create a function that returns true if comments are properly formatted, and false otherwise.
//Examples
//CommentsCorrect("//////") --> true
//// 3 single-line comments: ["//", "//", "//"]
//CommentsCorrect("/**//**////**/") --> true
//// 3 multi-line comments + 1 single-line comment:
//// ["/*", "*/", "/*", "*/", "//", "/*", "*/"]
//CommentsCorrect("///*/**/") --> false
//// The first /* is missing a */
//CommentsCorrect("/////") --> false
//// The 5th / is single, not a double //
/////Steps
// turn str into char[] arr
// if (arr.length % 2 != 0)
// return false;
// loop i arr.length-1
// if (arr[i] == / && arr[i+1] == /)
// continue
// else if (arr[i] == / && arr[i+1] == *)
//// if (i + )