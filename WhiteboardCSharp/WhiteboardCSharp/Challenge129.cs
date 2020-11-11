using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge129
    {
        public static double[] FindVertex(int a, int b, int c)
        {
            decimal x = -1m * (b / (2m * a));
            decimal y = (a * x * x) + (b * x) + c;
            x = Math.Round(x, 2, MidpointRounding.AwayFromZero);
            y = Math.Round(y, 2, MidpointRounding.AwayFromZero);
            string stringX = x.ToString();
            string stringY = y.ToString();
            double doubleX = Convert.ToDouble(stringX);
            double doubleY = Convert.ToDouble(stringY);
            double[] solution = { doubleX, doubleY };
            return solution;
        }
    }
}
//Find the Vertex of a Quadratic
//Every quadratic curve y = a x² + b x + c has a vertex point: the turning point where the curve stops heading down and starts going up.

//Given the values a, b and c, you need to return the coordinates of the vertex.Return your answers rounded to 2 decimal places.

//Examples
//FindVertex(1, 0, 25)  ➞ [0, 25]
//// The vertex of y=x²+25 is at (0, 25).

//FindVertex(-1, 0, 25) ➞ [0, 25]
//// The vertex of y=-x²+25 is at (0, 25).

//FindVertex(1, 10, 4) ➞ [-5, -21]
//// The vertex of y=x²+10x+4 is at (-5, -21).