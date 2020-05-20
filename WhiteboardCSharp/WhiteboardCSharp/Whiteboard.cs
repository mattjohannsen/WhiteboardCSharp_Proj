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
            int[] challengeArray = { 5, 17, 77, 50 };
            int target = 55;
            Challenge1 challenge1 = new Challenge1();
            challenge1.RunChallenge(challengeArray, target);
        }
    }
}
