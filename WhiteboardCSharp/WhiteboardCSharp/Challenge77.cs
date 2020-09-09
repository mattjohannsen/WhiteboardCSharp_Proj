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
            //Console.WriteLine(ValidatePassword("P1zz@")); //false;
            //Console.WriteLine(ValidatePassword("iLoveYou")); //false;
            Console.WriteLine(ValidatePassword("Fhg93@")); //true;
            //Console.WriteLine(ValidatePassword("Pè7$areLove")); //false;
            //Console.WriteLine(ValidatePassword("azAZ09è")); //false;
        }
        public static bool ValidatePassword(string password)
        {
            foreach (var character in password)
            {                                                                                 //!@#$%^&*()+=_-{}[]:;\"'?<>,.
                if (!Regex.IsMatch(character.ToString(), @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()+=_-{}[]:;""'?<>,.])[A-Za-z\d!@#$%^&*()+=_-{}[]:;""'?<>,.]{6,24}$"))
                if (!Regex.IsMatch(character.ToString(), @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()+=_-{}[]:;""'?<>,.])[A-Za-z\d!@#$%^&*()+=_-{}[]:;""'?<>,.]{6,24}$"))
                    //if (!Regex.IsMatch(character.ToString(), @"^(?=[^A - Z] *[A - Z])(?=[^a - z] *[a - z])(?=[^0 - 9] *[0 - 9])(?:([\w\d *? !:;])\1 ? (? !\1))+$(?=.*[!@#$%^&*()+=_-{}[]:;""'?<>,.])[A-Za-z\d!@#$%^&*()+=_-{}[]:;""'?<>,.]{6,24}$")) "

                    {
                    return false;
                }
            }
            return true;
            //^(?=.*?[A - Z])(?=.*?[a - z])(?=.*?[0 - 9])(([a - z0 - 9])\2 ? (? !\2))+$(?=.{ 6,24}$)
            
            //return Regex.IsMatch(password, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,24}$");
        }
        //public static bool ValidatePassword(string password)
        //{
        //    //"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,10}$"
        //    if (!CheckPasswordLength(password))
        //    {
        //        return false;
        //    }
        //    if(!CheckForUpper(password))
        //    {
        //        return false;
        //    }
        //    if (!CheckForLower(password))
        //    {
        //        return false;
        //    }
        //    if (!CheckForNumber(password))
        //    {
        //        return false;
        //    }
        //    if (!CheckForTriples(password))
        //    {
        //        return false;
        //    }
        //    if (!AlphaNumericOrAllowed(password))
        //    {
        //        return false;
        //    }
        //    return true;
        //}
        //public static bool CheckPasswordLength(string password)
        //{
        //    return (password.Length >= 6 && password.Length <= 24);
        //}
        //public static bool CheckForUpper(string password)
        //{
        //    for (int i = 0; i < password.Length; i++)
        //    {
        //        if (Char.IsUpper(password[i]))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        //public static bool CheckForLower(string password)
        //{
        //    for (int i = 0; i < password.Length; i++)
        //    {
        //        if (Char.IsLower(password[i]))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        //public static bool CheckForNumber(string password)
        //{
        //    for (int i = 0; i < password.Length; i++)
        //    {
        //        if (Char.IsDigit(password[i]))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        //public static bool CheckForTriples(string password)
        //{
        //    for (int i = 0; i < password.Length - 2; i++)
        //    {
        //        if (password[i] == password[i + 1] && password[i] == password[i + 2])
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}
        //public static bool AlphaNumericOrAllowed(string password)
        //{
        //    for (int i = 0; i < password.Length; i++)
        //    {
        //        char currentChar = password[i];
        //        string allowed = "!@#$%^&*()+=_-{}[]:;\"'?<>,.";
        //        if (Regex.IsMatch(currentChar.ToString(), "^[a-zA-Z0-9]*$")) 
        //        {
        //            continue;
        //        }
        //        else
        //        {
        //            if (allowed.Contains(password[i]))
        //            {
        //                continue;
        //            }
        //            else
        //            {
        //                return false;
        //            }
        //        }
        //    }
        //    return true;
        //}
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