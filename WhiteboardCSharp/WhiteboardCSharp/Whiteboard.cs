using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Whiteboard
    {
        public void ShowWhiteboard()
        {
            Console.WriteLine("\n\n       Welcome to Matt's C# Whiteboard!");
            Console.WriteLine("\n       Problem #1");
            Console.WriteLine("       Given the following array of values: { 5, 17, 77, 50 }");
            int[] challengeArray = { 5, 17, 77, 50 };
            int target = 55;
            Challenge1 challenge1 = new Challenge1();
            int[] challenge1Array = challenge1.RunChallenge(challengeArray, target);
            Console.Write($"       The indeces of the two numbers that add up to {target} are: ");
            for (int i = 0; i < challenge1Array.Length; i++)
            {
                Console.Write(challenge1Array[i] + " ");
            }
            
        }
    }
}
