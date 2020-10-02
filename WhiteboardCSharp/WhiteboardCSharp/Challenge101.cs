using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge101
    {
        public static bool IsStrangePair(string str1, string str2)
        {
            if (str1.Length == 0 || str2.Length ==0)
            {
                return (str1.Length == 0 && str2.Length == 0);
            }
            else
            {
                return (str2.EndsWith(str1[0].ToString()) && str1.EndsWith(str2[0].ToString()));
            }
        }
    }
}
//Strange Pair
//A pair of strings form a strange pair if both of the following are true:
//The 1st string's first letter = 2nd string's last letter.
//The 1st string's last letter = 2nd string's first letter.
//Create a function that returns true if a pair of strings constitutes a strange pair, and false otherwise.
//Examples
//IsStrangePair("ratio", "orator") --> true
//// "ratio" ends with "o" and "orator" starts with "o".
//// "ratio" starts with "r" and "orator" ends with "r".
//IsStrangePair("sparkling", "groups") --> true
//IsStrangePair("bush", "hubris") --> false
//IsStrangePair("", "") --> true
//Notes
//It should work on a pair of empty strings(they trivially share nothing).