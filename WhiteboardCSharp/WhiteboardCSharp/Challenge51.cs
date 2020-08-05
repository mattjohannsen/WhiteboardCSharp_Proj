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
            ChallengeDescription();
            Console.WriteLine($"       CommentsCorrect(//////) ==> {CommentsCorrect("//////")}");
            Console.WriteLine($"       CommentsCorrect(/**//**////**/) ==> {CommentsCorrect("/**//**////**/")}");
            Console.WriteLine($"       CommentsCorrect(///*/**/) ==> {CommentsCorrect("///*/**/")}");
            Console.WriteLine($"       CommentsCorrect(/////) ==> {CommentsCorrect("/////")}");
        }
        public static bool CommentsCorrect(string str)
        {
            return str.Replace("/**/", "").Replace("//", "") == "";
            //char[] arr = str.ToCharArray();
            //if (arr.Length % 2 != 0)
            ////{
            //    return false;
            //}
            //for (int i = 0; i < arr.Length-2; i++)
            //{
            //    if (arr[i] == '/' && arr[i+1] == '/')
            //    {
            //        i ++;
            //        continue;
            //    }
            //    else if (arr[i] == '/' && arr[i + 1] == '*')
            //    {
            //        if (i+2> arr.Length)
            //        {
            //            return false;
            //        }
            //        else
            //        {
            //            if (arr[i+2] !='*' && arr[i + 3] != '/')
            //            {
            //                return false;
            //            }
            //            i++;
            //            continue;
            //        }
            //    }
            //}
            //return true;
        }
        public void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 51: Valid JavaScript Comments");
            Console.WriteLine("       In JavaScript, there are two types of comments:");
            Console.WriteLine("       Single-line comments start with //");
            Console.WriteLine("       Multi-line or inline comments start with /* and end with */");
            Console.WriteLine("       The input will be a sequence of //, /* and */.");
            Console.WriteLine("       Every /* must have a */ that immediately follows it.");
            Console.WriteLine("       To add, there can be no single-line comments in between multi-line");
            Console.WriteLine("       comments in between the /* and */.");
            Console.WriteLine("       Create a function that returns true if comments are properly formatted, and false otherwise.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       CommentsCorrect(//////) --> true");
            Console.WriteLine("       3 single-line comments: ['//', '//', '//']");
            Console.WriteLine("       CommentsCorrect(/**//**////**/) --> true");
            Console.WriteLine("       3 multi-line comments + 1 single-line comment:");
            Console.WriteLine("       ['/*', '*/', '/*', '*/', '//', '/*', '*/']");
            Console.WriteLine("       CommentsCorrect(///*/**/) --> false");
            Console.WriteLine("       The first /* is missing a */");
            Console.WriteLine("       CommentsCorrect(/////) --> false");
            Console.WriteLine("       The 5th / is single, not a double //\n");
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