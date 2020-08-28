using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge69
    {
        public void RunChallenge()
        {
            Console.WriteLine("       Challenge 69");
            Console.WriteLine($"       IsValidIP(1.2.3.4) --> true --> {IsValidIP("1.2.3.4")}");
            Console.WriteLine($"       IsValidIP(1.2.3) --> false --> {IsValidIP("1.2.3")}");
            Console.WriteLine($"       IsValidIP(1.2.3.4.5) --> false --> {IsValidIP("1.2.3.4.5")}");
            Console.WriteLine($"       IsValidIP(123.45.67.89) --> true --> {IsValidIP("123.45.67.89")}");
            Console.WriteLine($"       IsValidIP(123.456.78.90) --> false --> {IsValidIP("123.456.78.90")}");
            Console.WriteLine($"       IsValidIP(123.045.067.089) --> false --> {IsValidIP("123.045.067.089")}");
            Console.WriteLine($"       IsValidIP(0.232.47.227) --> true --> {IsValidIP("0.232.47.227")}");
        }
        public static bool IsValidIP(string IP)
        {
            string[] arr = IP.Split('.').ToArray();
            if (arr.Length != 4)
            {
                return false;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i][0]=='0' && arr[i].Length > 1)
                {
                    return false;
                }
                else if (!arr[i].All(char.IsDigit))
                {
                    return false;
                }
                else if (Convert.ToInt32(arr[i]) < 0 || Convert.ToInt32(arr[i]) > 255)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
//IPv4 Validation
//Create a function that takes a string (IPv4 address in standard dot-decimal format) and returns true if the IP is valid or false if it's not. For information on IPv4 formatting, please refer to the resources in the Resources tab.
//Examples
//IsValidIP("1.2.3.4") --> true
//IsValidIP("1.2.3") --> false
//IsValidIP("1.2.3.4.5") --> false
//IsValidIP("123.45.67.89") --> true
//IsValidIP("123.456.78.90") --> false
//IsValidIP("123.045.067.089") --> false
//Notes
//IPv6 addresses are not valid.
//Leading zeros are not valid ("123.045.067.089" should return false).
//You can expect a single string for every test case.
//Numbers may only be between 1 and 255.
//The last digit may not be zero, but any other might.