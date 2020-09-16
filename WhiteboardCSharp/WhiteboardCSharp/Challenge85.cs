using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge85
    {
        public static string Bomb(string txt)
        {
            if (txt.ToLower().Contains("bomb"))
            {
                return "Duck!!!";
            }
            else
            {
                return "There is no bomb, relax.";
            }
        }
    }
}
