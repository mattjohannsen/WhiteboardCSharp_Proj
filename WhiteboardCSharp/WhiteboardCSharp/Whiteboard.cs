﻿using System;
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
            string str = "abcd";
            Console.WriteLine(Challenge126.Accum(str));
        }
    }
}