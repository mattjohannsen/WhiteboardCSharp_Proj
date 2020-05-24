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
            int[] challenge4Array = { 7, 9, -3, -32, 107, -1, 36, 95, -14, -99, 21 };

            Challenge4 challenge4 = new Challenge4();
            
            Console.WriteLine("\n\n       Welcome to Matt's C# Whiteboard!");
            
            //challenge1.RunChallenge();
            //challenge2.RunChallenge();
            //challenge3.RunChallenge();
            int[] displayArray = challenge4.RunChallenge(challenge4Array);
            for (int i = 0; i < displayArray.Length; i++)
            {
                Console.WriteLine(displayArray[i]);
            }

        }
    }
}
