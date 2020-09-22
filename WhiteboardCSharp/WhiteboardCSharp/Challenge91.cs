using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge91
    {
        public static string Maskify(string str)
        {
            if (str.Length <= 4) return str;
            char[] arr = str.ToCharArray();
            for (int i = 0; i < arr.Length - 4; i++)
            {
                arr[i] = '#';
            }
            return new string(arr);
        }
    }
}
//Maskify the String https://edabit.com/challenge/RFeBL2TzSf7mRMNJi
//Usually when you sign up for an account to buy something, your credit card number, phone number or answer to a secret question is partially obscured in some way.Since someone could look over your shoulder, you don't want that shown on your screen. Hence, the website masks these strings.
//Your task is to create a function that takes a string, transforms all but the last four characters into "#" and returns the new masked string.
//Examples
//Maskify("4556364607935616") --> "############5616"
//Maskify("64607935616") --> "#######5616"
//Maskify("1") --> "1"
//Maskify("") --> ""
//Notes
//The maskify function must accept a string of any length.
//An empty string should return an empty string (fourth example above).
// Steps
// if string.length is less than or equal to 4 characters then return str
// else
// turn str into arr
// loop through length - 4 times
// replace arr[i] with '#'
// return arr to String()