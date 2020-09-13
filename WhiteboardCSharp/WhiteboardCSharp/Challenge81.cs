using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge81
    {
        public static double[] FindLargest(double[][] values)
        {
            double[] solution = new double[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                double maxValue = values[i][0];
                for (int j = 0; j < values[i].Length; j++)
                {
                    if (values[i][j] > maxValue)
                    {
                        maxValue = values[i][j];
                    }
                }
                solution[i] = maxValue;
            }
            return solution;
        }
    }
}
//Find the Largest Numbers in a Group of Arrays https://edabit.com/challenge/nermqxzovZbfFBC9X
//Create a function that takes an array of arrays with numbers.Return a new(single) array with the largest numbers of each.

//Examples
//FindLargest([[4, 2, 7, 1], [20, 70, 40, 90], [1, 2, 0]]) --> [7, 90, 2]

//FindLargest([[-34, -54, -74], [-32, -2, -65], [-54, 7, -43]]) --> [-34, -2, 7]

//FindLargest([[0.4321, 0.7634, 0.652], [1.324, 9.32, 2.5423, 6.4314], [9, 3, 6, 3]]) --> [0.7634, 9.32, 9]
//Notes
//Watch out for negative numbers.