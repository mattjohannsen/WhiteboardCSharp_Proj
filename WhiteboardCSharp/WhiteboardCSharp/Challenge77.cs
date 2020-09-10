using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge77
    {
        public void RunChallenge()
        {
            ChallengeDescription();
            Console.WriteLine($"       ValidatePassword(\"P1zz@\") --> {ValidatePassword("P1zz@")}");
            Console.WriteLine($"       ValidatePassword(\"iLoveYou\") --> {ValidatePassword("iLoveYou")}");
            Console.WriteLine($"       ValidatePassword(\"Fhg93@\") --> {ValidatePassword("Fhg93@")}");
        }
        public static bool ValidatePassword(string password)
        {
            if (!CheckPasswordLength(password))
            {
                return false;
            }
            if (!CheckForUpper(password))
            {
                return false;
            }
            if (!CheckForLower(password))
            {
                return false;
            }
            if (!CheckForNumber(password))
            {
                return false;
            }
            if (!AlphaNumericOrAllowed(password))
            {
                return false;
            }
            if (ConsecutiveCharsOkay(password))
            {
                return false;
            }
            return true;
        }
        public static bool CheckPasswordLength(string password)
        {
            return (new Regex("^.{6,24}$").IsMatch(password));
        }
        public static bool CheckForUpper(string password)
        {
            return (new Regex("(?=.*[A-Z])").IsMatch(password));
        }
        public static bool CheckForLower(string password)
        {
            return (new Regex("(?=.*[a-z])").IsMatch(password));
        }
        public static bool CheckForNumber(string password)
        {
            return (new Regex(@"(\d)").IsMatch(password));
        }
        public static bool ConsecutiveCharsOkay(string password)
        {
            return (new Regex(@"([a-zA-Z0-9])\1{2}").IsMatch(password));
        }
        public static bool AlphaNumericOrAllowed(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                char currentChar = password[i];
                string allowed = "!@#$%^&*()+=_-{}[]:;\"'?<>,.";
                if (Regex.IsMatch(currentChar.ToString(), "^[a-zA-Z0-9]*$"))
                {
                    continue;
                }
                else
                {
                    if (allowed.Contains(password[i]))
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 77: Password Validation");
            Console.WriteLine("       Create a function that validates a password to conform to the following rules:");
            Console.WriteLine("       Length between 6 and 24 characters.");
            Console.WriteLine("       At least one uppercase letter(A-Z).");
            Console.WriteLine("       At least one lowercase letter(a-z).");
            Console.WriteLine("       At least one digit(0-9).");
            Console.WriteLine("       Maximum of 2 repeated characters.");
            Console.WriteLine("       \aa\" is OK");
            Console.WriteLine("       \"aaa\" is NOT OK");
            Console.WriteLine("       Supported special characters:");
            Console.WriteLine("       ! @ # $ % ^ & * ( ) + = _ - { } [ ] : ; \" \' ? < > , .");
            Console.WriteLine("       Examples");
            Console.WriteLine("       ValidatePassword(\"P1zz@\") --> false");
            Console.WriteLine("       ValidatePassword(\"iLoveYou\") --> false");
            Console.WriteLine("       ValidatePassword(\"Fhg93@\") --> true\n");
        }
    }
}
//Password Validation
//Create a function that validates a password to conform to the following rules:
//Length between 6 and 24 characters.
//At least one uppercase letter(A-Z).
//At least one lowercase letter(a-z).
//At least one digit(0-9).
//Maximum of 2 repeated characters.
//"aa" is OK 👍
//"aaa" is NOT OK 👎
//Supported special characters:
//! @ # $ % ^ & * ( ) + = _ - { } [ ] : ; " ' ? < > , .
//Examples
//ValidatePassword("P1zz@") --> false
//// Too short.
//ValidatePassword("iLoveYou") --> false
//// Missing a number.
//ValidatePassword("Fhg93@") --> true
//// OK!