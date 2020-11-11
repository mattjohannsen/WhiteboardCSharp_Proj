using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Whiteboard
    {
        public void ShowWhiteboard()
        {
            Console.WriteLine("\n\n       Welcome to Matt's C# Whiteboard!");
            int a = 8;
            int b = 4;
            int c = 0;
            //double[] expected = { -0.25d, -0.5d };
            Console.WriteLine(Challenge129.FindVertex(a, b, c));
        }
    }
}