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
            decimal x = Math.Round(-1m * b / (2m * a), 2);
            decimal y = Math.Round(a * x * x + b * x + c, 2);
            return new double[] { Convert.ToDouble(x), Convert.ToDouble(y) };
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