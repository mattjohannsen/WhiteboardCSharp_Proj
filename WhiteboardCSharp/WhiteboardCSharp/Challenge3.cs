using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge3
    {
        public List <int> listOne;
        public List<int> listTwo;
        public List<int> selectedList;

        public Challenge3()
        {
            listOne = new List<int>() { 5, 7, 3, 8, 6 };
            listTwo = new List<int>() { 17, 15, 20, 19, 21, 16, 18 };
            selectedList = new List<int>();
        }

        public void RunChallenge()
        {
            ChallengeDescription();
            SelectList();
            selectedList.Sort();
            Console.WriteLine("         " + DoesListIncrement(selectedList));
        }
        public bool DoesListIncrement(List<int> inputList)
        {
            bool doesListIncrement = true;
            for (int i = 0; i < inputList.Count; i++)
            {
                if (i < (inputList.Count - 1))
                {
                    if ((inputList[i] + 1) != (inputList[i + 1]))
                    {
                        doesListIncrement = false;
                    }
                }
            }
            return doesListIncrement;
        }
        public void SelectList()
        {
            Console.WriteLine("       Select 1 or 2:");
            Console.WriteLine("         1. {5, 7, 3, 8, 6}");
            Console.WriteLine("         2. {17, 15, 20, 19, 21, 16, 18}");

            bool invalidInput = true;
            while (invalidInput)
            {
                Console.Write("         ");
                string listChoice = Console.ReadLine();
                switch (listChoice)
                {
                    case "1":
                        selectedList = listOne;
                        invalidInput = false;
                        break;
                    case "2":
                        selectedList = listTwo;
                        invalidInput = false;
                        break;
                    default:
                        Console.WriteLine("        Please enter a valid list selection:");
                        break;
                }
            }
        }
        public void ChallengeDescription()
        {
            Console.WriteLine("\n\n       Challenge 3");
            Console.WriteLine("       Given a list of integers, return a bool that represents whether or not all integers in");
            Console.WriteLine("       the list can form a sequence of incrementing integers");
            Console.WriteLine("           a. Use case:");
            Console.WriteLine("               i. {5, 7, 3, 8, 6}  false (no 4 to complete the sequence)");
            Console.WriteLine("              ii. {17, 15, 20, 19, 21, 16, 18} -> true");
        }
    }
}

// 1) Select a list of integers
//     Create variables for both integer lists
//     Create switch case for user to select which list
// 2) Sort the list of integers ascending
// 3) Set a boolean variable to true
// 4) Starting at the beginning, increase by 1, if this value equals the value of the next index, the boolean value remains true. Else it returns false;