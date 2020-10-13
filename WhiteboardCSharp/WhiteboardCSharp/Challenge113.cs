using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge113
    {
        public static string NoYelling(string phrase)
        {
            string[] arr = phrase.Split(' ');
            arr[arr.Length - 1] = Regex.Replace(arr.Last(), "[!?.]*([!?.])", "$1");
            return string.Join(" ", arr);
        }
    }
}
//No Yelling
//Create a function that transforms sentences ending with multiple question marks? or exclamation marks ! into a sentence only ending with one without changing punctuation in the middle of the sentences.
//Examples
//NoYelling("What went wrong?????????") --> "What went wrong?"
//NoYelling("Oh my goodness!!!") --> "Oh my goodness!"
//NoYelling("I just!!! can!!! not!!! believe!!! it!!!") --> "I just!!! can!!! not!!! believe!!! it!"
//// Only change repeating punctuation at the end of the sentence.
//NoYelling("Oh my goodness!") --> "Oh my goodness!"
//// Do not change sentences where there exists only one or zero exclamation marks/question marks.
//NoYelling("I just cannot believe it.") --> "I just cannot believe it."
//Notes
//Only change ending punctuation - keep the exclamation marks or question marks in the middle of the sentence the same(see third example).
//Don't worry about mixed punctuation (no cases that end in something like ?!??!).
//Keep sentences that do not have question/exclamation marks the same.