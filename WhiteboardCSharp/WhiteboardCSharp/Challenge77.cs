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
            Console.WriteLine("       Challenge 77");
            Console.WriteLine(ValidatePassword("P1zz@")); //false;
            Console.WriteLine(ValidatePassword("P1zz@P1zz@P1zz@P1zz@P1zz@")); //false;
            Console.WriteLine(ValidatePassword("mypassword11")); //false;
            Console.WriteLine(ValidatePassword("MYPASSWORD11")); //false;
            Console.WriteLine(ValidatePassword("iLoveYou")); //false;
            Console.WriteLine(ValidatePassword("Pè7$areLove")); //false;
            Console.WriteLine(ValidatePassword("Repeeea7!") + "<--Should be false"); //false;
            Console.WriteLine(ValidatePassword("H4(k+x0")); //true;
            Console.WriteLine(ValidatePassword("Fhg93@")); //true;
            Console.WriteLine(ValidatePassword("aA0!@#$%^&*()+=_-{}[]:;\"")); //true;
            Console.WriteLine(ValidatePassword("zZ9'?<>,.")); //true;
            //Console.WriteLine((new Regex(@"(?!.*([.])\1{2})").IsMatch("Repeeea7!")));
            //Console.WriteLine((new Regex(@"(?!.*?(.)\1{2,})").IsMatch("Repeeea7!")));
            //Console.WriteLine(new Regex(@"/ (.)\1{ 2, } /").IsMatch("ad"));
            //Console.WriteLine(new Regex(@"([a-zA-Z0-9!])\1{2}").IsMatch("aa")); // this works aaaa true aa false
            //Console.WriteLine(new Regex(@"([a-zA-Z0-9])\1{2}").IsMatch("Repeeea7!")); // this works Repeea7! true Repeea7! false

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
            //for (int i = 0; i < password.Length - 2; i++)
            //{
            //    if (password[i] == password[i + 1] && password[i] == password[i + 2])
            //    {
            //        return false;
            //    }
            //}
            //return true;
            //return (new Regex(@"(?!.*?(.)\1{2,})").IsMatch(password)); //only 5th last test fails
            //return (new Regex(@"(?!.*?(.)\1{2,})").IsMatch(password));
            //return (new Regex(@"^(.)(?!\1\1){3,}$").IsMatch(password)); last four tests fail
            //return (new Regex(@"(([.])\2 ? (? !\2))+$").IsMatch(password)); 
            //return (new Regex(@"(?: ([\w\d *? !:;])\1 ? (? !\1))+$").IsMatch(password)); 
            //return (new Regex(@"(?!.*([A-Za-z0-9])\1{2})").IsMatch(password)); //only 5th last test fails
            //eturn (new Regex(@"(?!.*([.])\1{2})").IsMatch(password));
            //return (new Regex(@"(?!.*([.])\1{2})").IsMatch(password));
            //return (new Regex(@"(^?!.*([A-Za-z0-9!])\1{2})+$").IsMatch(password));
            //return (new Regex(@"/(\b(?:([A-Za-z0-9])(?!\2{2}))+\b)/").IsMatch(password));
            //return(new Regex(@"^/([a-zA-Z0-9!])\1{2,}$/i").IsMatch(password));
            //return (new Regex(@"(?!.*([.])\1{2})").IsMatch(password)); // only 5th test fails
            //return (new Regex(@"(?!.*?(.)\1{2,})").IsMatch(password)); //only 5th last test fails
            //return (new Regex(@"/ (.)\1{ 2,}/").IsMatch(password));
            //return (new Regex(@"([a-zA-Z0-9])\1{2}").IsMatch("password"));
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