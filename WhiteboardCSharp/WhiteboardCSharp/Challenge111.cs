using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge111
    {
        public static string Century(int year)
        {
            int rounded = ((int)Math.Ceiling(year / 100.0));
            string str = rounded.ToString();
            if (rounded == 11 || rounded == 12 || rounded == 13)
            {
                return str + "th century";
            }
            else
            {
                switch (rounded % 10)
                {
                    case 1:
                        return str + "st century";
                    case 2:
                        return str + "nd century";
                    case 3:
                        return str + "rd century";
                    default:
                        return str + "th century";
                }
            }
        }
    }
}
//Get the Century
//Create a function that takes in a year and returns the correct century.

//Examples
//Century(1756) --> "18th century"
//Century(1555) --> "16th century"
//Century(1000) --> "10th century"
//Century(1001) --> "11th century"
//Century(2005) --> "21st century"
//Notes
//All years will be between 1000 and 2010.
//The 11th century is between 1001 and 1100.
//The 18th century is between 1701-1800.