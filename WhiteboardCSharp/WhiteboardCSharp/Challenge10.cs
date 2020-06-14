using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge10
    {
        public int initialNumber = 17;
        public void RunChallenge()
        {
            Console.WriteLine("       This is Challenge 10");
            int numberReversed = GetReverse(initialNumber);
            Console.WriteLine(numberReversed);
            double reciprocal = GetReciprocal(numberReversed);
            Console.WriteLine(reciprocal);
        }

        public double GetReciprocal(int inputNumber)
        {
            double inputDouble = Convert.ToDouble(inputNumber);
            double theReciprocal = (1 / inputDouble);
            return theReciprocal;
        }
        public int GetReverse(int inputNumber)
        {
            string[] initialArray = inputNumber.ToString().Select(n => n.ToString()).ToArray();
            string[] reverseArray = new string[initialArray.Length];
            for (int i = 0; i < initialArray.Length; i++)
            {
                reverseArray[(initialArray.Length - 1)-i] = initialArray[i];
            }
            int numberReversed = Int32.Parse(string.Join("", reverseArray));
            return numberReversed;
        }
    }
}
//10.	Given a number, return the reciprocal of the reverse of the original number, as a double. 
//a.Use case: If given 17, return 0.01408 (1/71)

// Steps
// Create an int variable initialNumber = 17
// Create an int variable numberReversed
// Pass this variable to the GetReverse method and set this equal to numberReversed
// GetReverse method takes in an int, converts it to String, turns it to an array, creates a new array with values opposite of the initialArray, 
// Create a double variable callled reverseReciprocal equal to passing the numberReversed variable to the GetReciprocal method.