using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge59
    {
        public void RunChallenge()
        {
            Console.WriteLine("Challege 59");
            Console.WriteLine(RollingCipher("abcd", 1));
            Console.WriteLine(RollingCipher("abcd", -1));
            Console.WriteLine(RollingCipher("abcd", 3));
            Console.WriteLine(RollingCipher("abcd", 26));
        }
        public static string RollingCipher(string str, int n)
        {
            char[] arr = str.ToCharArray();
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < arr.Length; i++)
            {
                int startingPoint = alphabet.IndexOf(arr[i]) + n;
                if (startingPoint > 25)
                {
                    startingPoint -= 26;
                }
                else if (startingPoint < 0)
                {
                    startingPoint += 26;
                }
                arr[i] = alphabet[startingPoint];
            }
            return new string(arr);
        }
    }
}
//Rolling Cipher
//Write a function that accepts a string and an n and returns a cipher by rolling each character forward(n > 0) or backward(n< 0) n times.
//Note: Think of the letters as a connected loop, so rolling a backwards once will yield z, and rolling z forward once will yield a. If you roll 26 times in either direction, you should end up back where you started.
//Examples
//RollingCipher("abcd", 1) --> "bcde"
//RollingCipher("abcd", -1) --> "zabc"
//RollingCipher("abcd", 3) --> "defg"
//RollingCipher("abcd", 26) --> "abcd"
//Notes
//All letters are lower cased.
//No spacing.
//Each character is rotated the same number of times.