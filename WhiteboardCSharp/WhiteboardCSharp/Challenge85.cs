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
            return txt.ToLower().Contains("bomb") ? "Duck!!!" : "There is no bomb, relax.";
        }
    }
}
