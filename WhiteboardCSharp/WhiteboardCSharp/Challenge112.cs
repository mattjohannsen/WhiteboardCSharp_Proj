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
            var solution = new DataTable().Compute(s, "");
            int returnValue = Convert.ToInt32(solution.ToString());
            return returnValue;
        }
    }
}
