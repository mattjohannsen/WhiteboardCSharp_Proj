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
            Challenge1 challenge1 = new Challenge1();
            Challenge2 challenge2 = new Challenge2();
            
            Console.WriteLine("\n\n       Welcome to Matt's C# Whiteboard!");
            
            challenge1.RunChallenge();
            challenge2.RunChallenge();

            
        }
    }
}
