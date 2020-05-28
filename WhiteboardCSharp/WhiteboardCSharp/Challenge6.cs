using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge6
    {
        public void RunChallenge()
        {
            Console.WriteLine("       Challenge 6");
            string emailToTest = "t@t.tt";
            Console.WriteLine($"       Testing to see if {emailToTest} is a valid email address.");
            Console.WriteLine(ValidateEmail(emailToTest));
        }

        public bool ValidateEmail(string inputEmail)
        {
            bool emailIsValid = false;
            int atIndex;
            int dotIndex;
            if (inputEmail.Contains("@") && inputEmail.Contains("."))
            {
                atIndex = inputEmail.IndexOf("@");
                dotIndex = inputEmail.IndexOf(".");
                if (atIndex > 0)
                {
                    if(dotIndex - atIndex > 1)
                    {
                        if (inputEmail.Length - (dotIndex + 1) > 1)
                        {
                            emailIsValid = true;
                        }
                    }
                    else
                    {
                        return emailIsValid;
                    }
                }
                else
                {
                    return emailIsValid;
                }
            }
            else
            {
                return emailIsValid;
            }

            return emailIsValid;
        }
    }
}
//6.	Create a method that accepts a string, check if it’s a valid email address and returns either true or false depending on the valuation.
// Think about what is necessary to have a valid email address.
//a.Use case:
//i.  “mike1 @gmail.com”  true
//ii. “gmail.com”  false
// Create a string variable
// Create a method to check EmailValidation
// Create boolean variable set to false
// xxxx @ xxxxx . xxx
// Check if email Contains @, ., and com, net, and if so, record the index position of @ and .
