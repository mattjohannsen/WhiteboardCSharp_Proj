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
            ChallengeDescription();
            Console.WriteLine($"       IsValidIP(1.2.3.4) --> {IsValidIP("1.2.3.4")}");
            Console.WriteLine($"       IsValidIP(1.2.3) --> {IsValidIP("1.2.3")}");
            Console.WriteLine($"       IsValidIP(1.2.3.4.5) --> {IsValidIP("1.2.3.4.5")}");
            Console.WriteLine($"       IsValidIP(123.45.67.89) --> {IsValidIP("123.45.67.89")}");
            Console.WriteLine($"       IsValidIP(123.456.78.90) --> {IsValidIP("123.456.78.90")}");
            Console.WriteLine($"       IsValidIP(123.045.067.089) --> {IsValidIP("123.045.067.089")}");
            Console.WriteLine($"       IsValidIP(0.232.47.227) --> {IsValidIP("0.232.47.227")}");
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
        public void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 69: IPv4 Validation");
            Console.WriteLine("       Create a function that takes a string (IPv4 address in standard dot-decimal format)");
            Console.WriteLine("       and returns true if the IP is valid or false if it's not.");
            Console.WriteLine("       For information on IPv4 formatting, please refer to the resources in the Resources tab.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       IsValidIP(\"1.2.3.4\") --> true");
            Console.WriteLine("       IsValidIP(\"1.2.3\") --> false");
            Console.WriteLine("       IsValidIP(\"1.2.3.4.5\") --> false");
            Console.WriteLine("       IsValidIP(\"123.45.67.89\") --> true");
            Console.WriteLine("       IsValidIP(\"123.456.78.90\") --> false");
            Console.WriteLine("       IsValidIP(\"123.045.067.089\") --> false");
            Console.WriteLine("       IsValidIP(\"0.232.47.227\") --> true");
            Console.WriteLine("       Notes");
            Console.WriteLine("       IPv6 addresses are not valid.");
            Console.WriteLine("       Leading zeros are not valid (\"123.045.067.089\" should return false).");
            Console.WriteLine("       You can expect a single string for every test case.");
            Console.WriteLine("       Numbers may only be between 1 and 255.");
            Console.WriteLine("       The last digit may not be zero, but any other might.\n");
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