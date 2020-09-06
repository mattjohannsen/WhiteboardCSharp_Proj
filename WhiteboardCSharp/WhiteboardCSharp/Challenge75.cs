using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge75
    {
        public void RunChallenge()
        {
            Console.WriteLine("       Challenge 75");
            Console.WriteLine($"       {OverlappingRectangles(new int[] { 2, 1, 3, 4 }, new int[] { 3, 2, 2, 5 })}");
        }
        public static int OverlappingRectangles(int[] rect1, int[] rect2)
        {
            int rect1xStart = rect1[0];
            int rect1yStart = rect1[1];
            int rect1width = rect1[2];
            int rect1height = rect1[3];
            int rect2xStart = rect2[0];
            int rect2yStart = rect2[1];
            int rect2width = rect2[2];
            int rect2height = rect2[3];
            int xOverlapCount = Math.Min(rect1xStart + rect1width, rect2xStart + rect2width) - Math.Max(rect1xStart, rect2xStart);
            if (xOverlapCount < 0)
            {
                xOverlapCount = 0;
            }
            int yOverlapCount = Math.Min(rect1yStart + rect1height, rect2yStart + rect2height) - Math.Max(rect1yStart, rect2yStart);
            if (yOverlapCount < 0)
            {
                yOverlapCount = 0;
            }
            return xOverlapCount * yOverlapCount;
        }
    }
}
//Area of Overlapping Rectangles
//Create a function that returns the area of the overlap between two rectangles.The function will receive two rectangles, each with the coordinates of the lower left corner followed by the width and the height int[] { x, y, width, height }.
//Examples
//OverlappingRectangles(new int[] { 2, 1, 3, 4 }, new int[] { 3, 2, 2, 5  }) --> 6
//OverlappingRectangles(new int[] { 2, -9, 11, 5 }, new int[] { 5, -11, 2, 9 }) --> 10
//OverlappingRectangles(new int[] { -8, -7, 4, 7 },  new int[] { -5, -9, 4, 7 }) --> 5
// Steps
//OverlappingRectangles(new int[] { 2, 1, 3, 4 }, new int[] { 3, 2, 2, 5  }) --> 6
//int rect1xStart = 2;
//int rect1yStart = 1;
//int rect1width = 3;
//int rect1length = 4;
//int rect2xStart = 2;
//int rect2yStart = 1;
//int rect2width = 3;
//int rect2length = 4;
// rect1xLength = rect1xStart +  rect1width
// rect2xLength = rect2xStart +  rect2width
// rectOverlap = 
// create xOverlapCount = 0
// start loop at 
