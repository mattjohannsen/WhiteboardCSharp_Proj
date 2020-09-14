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
            return new string(str.Select(c => char.IsLetter(c) ? (char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)) : c).ToArray());
        }
    }
}
//Reverse the Case https://edabit.com/challenge/99oN5igrbXddAjHEL
//Given a string, create a function to reverse the case. All lower-cased letters should be upper-cased, and vice versa.
//Examples
//ReverseCase("Happy Birthday") --> "hAPPY bIRTHDAY"
//ReverseCase("MANY THANKS") --> "many thanks"
//ReverseCase("sPoNtAnEoUs") --> "SpOnTaNeOuS"