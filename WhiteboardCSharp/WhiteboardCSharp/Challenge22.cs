using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge22
    {
        public void RunChallenge()
        {
            Console.WriteLine("       Challenge22");
            string stringOne = "hAPPY bIRTHDAY";
            Console.WriteLine(stringOne);
            Console.WriteLine(ReverseCase(stringOne));
            string stringTwo = "MANY THANKS";
            Console.WriteLine(stringTwo);
            Console.WriteLine(ReverseCase(stringTwo));
            string stringThree = "sPoNtAnEoUs";
            Console.WriteLine(stringThree);
            Console.WriteLine(ReverseCase(stringThree));

        }
        public string ReverseCase(string inputString)
        {
            List<char> stringAsList = inputString.ToList();
            List<char> solutionList = new List<char>();
            for (int i = 0; i < stringAsList.Count; i++)
            {
                if (Char.IsUpper(stringAsList[i]))
                {
                    solutionList.Add(char.ToLower(stringAsList[i]));
                }
                else
                {
                    solutionList.Add(char.ToUpper(stringAsList[i]));
                }
            }
            return string.Join("", solutionList); ;
        }


    }
}
//Reverse the Case https://edabit.com/challenge/99oN5igrbXddAjHEL
//Given a string, create a function to reverse the case. All lower-cased letters should be upper-cased, and vice versa.
//Examples
//ReverseCase('Happy Birthday') --> 'hAPPY bIRTHDAY'
//ReverseCase('MANY THANKS') --> 'many thanks'
//ReverseCase('sPoNtAnEoUs') --> 'SpOnTaNeOuS'
// Steps
// create string originalString variable
// create ReverseCase method which takes an inputString
// turn the string into a List<char> stringAsList 
// Create a List<char> solutionList
// Loop through the string and check to see if ToUpper method of the stringAsList[i] is equal to stringAsList[i] THEN...
// ToLower the stringAsList[i] add the char to solutionList
// ELSE you would want to save the stringAsList[i] as ToUpper
// return the list as a string with  return string.Join("", solutionList);
