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
            ChallengeDescription();
            Console.WriteLine($"       ToCamelCase(hello_edabit) ==> {ToCamelCase("hello_edabit")}");
            Console.WriteLine($"       ToSnakeCase(helloEdabit) ==> {ToSnakeCase("helloEdabit")}");
            Console.WriteLine($"       ToCamelCase(is_modal_open) ==> {ToCamelCase("is_modal_open")}");
            Console.WriteLine($"       ToSnakeCase(getColor) ==> {ToSnakeCase("getColor")}");
        }
        public static string ToCamelCase(string inputString)
        {
            string[] stringAsArray = inputString.Split('_');
            for (int i = 0; i < stringAsArray.Length; i++)
            {
                if (i != 0 && stringAsArray[i] != string.Empty && char.IsLower(stringAsArray[i][0]))
                {
                    stringAsArray[i] = char.ToUpper(stringAsArray[i][0]) + stringAsArray[i].Substring(1);
                }
            }
            return string.Join("", stringAsArray);
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
        public void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 49: camelCase <==> snake_case");
            Console.WriteLine("       Create two functions ToCamelCase() and ToSnakeCase() that each take a single string and");
            Console.WriteLine("       convert it into either camelCase or snake_case.If you're not sure what these terms mean,");
            Console.WriteLine("       check the Resources tab above.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       ToCamelCase(hello_edabit) --> helloEdabit");
            Console.WriteLine("       ToSnakeCase(helloEdabit) --> hello_edabit");
            Console.WriteLine("       ToCamelCase(is_modal_open) --> isModalOpen");
            Console.WriteLine("       ToSnakeCase(getColor)-- > get_color\n");
        }
    }
}
//camelCase <==> snake_case https://edabit.com/challenge/RBqvKrYLxtM57G5FQ
//Create two functions ToCamelCase() and ToSnakeCase() that each take a single string and convert it into either camelCase or snake_case.If you're not sure what these terms mean, check the Resources tab above.
//Examples
//ToCamelCase(hello_edabit) --> helloEdabit
//ToSnakeCase(helloEdabit) --> hello_edabit
//ToCamelCase(is_modal_open) --> isModalOpen
//ToSnakeCase(getColor") --> get_color

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