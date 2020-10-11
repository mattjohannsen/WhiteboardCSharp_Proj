using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge112
    {
        public static int Equation(string s)
        {
            return Convert.ToInt32(new DataTable().Compute(s, "").ToString());
        }
    }
}
