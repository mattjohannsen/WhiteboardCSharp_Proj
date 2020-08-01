using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge49
    {
        public void RunChallenge()
        {
            Console.WriteLine("       Challenge 49");
            Console.WriteLine(ToCamelCase("hello_edabit"));
            Console.WriteLine(ToSnakeCase("helloEdabit"));
            Console.WriteLine(ToCamelCase("is_modal_open"));
            Console.WriteLine(ToSnakeCase("getColor"));
        }
        public static string ToCamelCase(string inputString)
        {
            string[] stringAsArray = inputString.Split('_');
            char[][] wordsAsArray = stringAsArray.Select(w => w.ToCharArray()).ToArray();
            for (int i = 0; i < wordsAsArray.Length; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    if (i == 0)
                    {
                        continue;
                    }
                    else
                    {
                        wordsAsArray[i][j] = char.ToUpper(wordsAsArray[i][j]);
                    }
                }
            }

            string[] wordsBackAsStrings = wordsAsArray.Select(w => new string(w)).ToArray();
            string returnString = string.Join("", wordsBackAsStrings);
            return returnString;
        }
        public static string ToSnakeCase(string inputString)
        {
            string[] stringAsArray = Regex.Split(inputString, @"(?<!^)(?=[A-Z])");
            for (int i = 0; i < stringAsArray.Length; i++)
            {
                if (stringAsArray[i] != string.Empty && char.IsUpper(stringAsArray[i][0]))
                {
                    stringAsArray[i] = char.ToLower(stringAsArray[i][0]) + stringAsArray[i].Substring(1);
                }
            }
            return string.Join("_", stringAsArray);
        }

    }
}
//camelCase <==> snake_case https://edabit.com/challenge/RBqvKrYLxtM57G5FQ
//Create two functions ToCamelCase() and ToSnakeCase() that each take a single string and convert it into either camelCase or snake_case.If you're not sure what these terms mean, check the Resources tab above.
//Examples
//ToCamelCase("hello_edabit") --> "helloEdabit"
//ToSnakeCase("helloEdabit") --> "hello_edabit"
//ToCamelCase("is_modal_open") --> "isModalOpen"
//ToSnakeCase("getColor") --> "get_color"

// Step ToCamelCase
// Turn into Array = split string split("_"); --> stringAsArray
// turn into Jagged Array of char[] --> wordsAsArray
// start loop through jagged Array of words --> i
// start loop through char in words --> j
// if j = 0 then
// continue
// else
// take wordsAsArray[i][0] toUpperCase
// Take array and turn into a string --> returnString
// return returnString;