using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge93
    {
        public void RunChallenge()
        {
            object[] arr = new object[] { 1, 2, "a", "b" };
            Console.WriteLine("Original Array");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("Return Array");
            int[] returnArray = FilterArray(arr);
            for (int i = 0; i < returnArray.Length; i++)
            {
                Console.WriteLine(returnArray[i]);
            }
        }
        public static int[] FilterArray(object[] arr)
        {
            return arr.OfType<int>().ToArray();
        }
    }
}
//Filter out Strings from an Array
//Create a function that takes an array of non-negative integers and strings and return a new array without the strings.

//Examples
//FilterArray([1, 2, "a", "b"]) --> [1, 2]

//FilterArray([1, "a", "b", 0, 15]) --> [1, 0, 15]

//FilterArray([1, 2, "aasf", "1", "123", 123]) --> [1, 2, 123]
//Notes
//Zero is a non-negative integer.
//The given array only has integers and strings.
// Steps
// Create int intCount = loop through and get int Count
// create a new array with loopCount elements
// Loop through arr and if the object is a string then add it to returnArray;