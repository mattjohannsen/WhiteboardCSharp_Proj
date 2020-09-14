using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge82
    {
        public static string ReverseCase(string str)
        {
            char[] arr = str.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == Char.ToUpper(arr[i]))
                {
                    arr[i] = Char.ToLower(arr[i]);
                }
                else if (arr[i] == Char.ToLower(arr[i]))
                {
                    arr[i] = Char.ToUpper(arr[i]);
                }
            }
            return new string(arr);
        }
    }
}
//Reverse the Case https://edabit.com/challenge/99oN5igrbXddAjHEL
//Given a string, create a function to reverse the case. All lower-cased letters should be upper-cased, and vice versa.
//Examples
//ReverseCase("Happy Birthday") --> "hAPPY bIRTHDAY"
//ReverseCase("MANY THANKS") --> "many thanks"
//ReverseCase("sPoNtAnEoUs") --> "SpOnTaNeOuS"