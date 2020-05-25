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
            //Challenge1 challenge1 = new Challenge1();
            //Challenge2 challenge2 = new Challenge2();
            //Challenge3 challenge3 = new Challenge3();
            //Challenge4 challenge4 = new Challenge4();
            Challenge5 challenge5 = new Challenge5();
            
            Console.WriteLine("\n\n       Welcome to Matt's C# Whiteboard!");

            challenge5.RunChallenge();
            //challenge1.RunChallenge();
            //challenge2.RunChallenge();
            //challenge3.RunChallenge();
            //challenge4.RunChallenge();

        }
    }
}
