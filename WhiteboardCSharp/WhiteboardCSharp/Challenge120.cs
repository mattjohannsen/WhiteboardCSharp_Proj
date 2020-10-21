using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge120
    {
        public static string[] ParseArray(object[] arr)
        {
            return Array.ConvertAll(arr, e => e.ToString());
        }
    }
}
//Convert All Array Objects to String //https://edabit.com/challenge/hqTYj7NbLnCcjxryi
//Create a function that takes an array of integers and strings, converts integers to strings, and returns the array as a string array.

//Examples
//ParseArray([1, 2, "a", "b"]) --> ["1", "2", "a", "b"]