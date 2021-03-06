﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge127
    {
        public static int[] RemoveSmallest(int[] values)
        {
            return values.Where((value, index) => index != Array.IndexOf(values, values.Min())).ToArray();
        }
    }
}
