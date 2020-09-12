﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge80
    {
        public static int square_areas_difference(int radius)
        {
            return ((radius * 2) * (radius * 2)) - (Convert.ToInt32(radius * Math.Sqrt(2) * (radius * Math.Sqrt(2))));
        }
    }
}
//A Circle and Two Squares
//Imagine a circle and two squares: a smaller and a bigger one.For the smaller one, the circle is a circumcircle and for the bigger one, an incircle.
//Scale
//Create a function, that takes an integer (radius of the circle) and returns the difference of the areas of the two squares.
//Examples
//square_areas_difference(5) --> 50
//square_areas_difference(6) --> 72
//square_areas_difference(7) --> 98
//Notes
//Use only positive integer parameters.