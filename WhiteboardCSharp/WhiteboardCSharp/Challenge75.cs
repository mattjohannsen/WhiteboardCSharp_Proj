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
            ChallengeDescription();
            Console.WriteLine($"       {OverlappingRectangles(new int[] { 2, 1, 3, 4 }, new int[] { 3, 2, 2, 5 })}");
            Console.WriteLine($"       {OverlappingRectangles(new int[] { 2, -9, 11, 5 }, new int[] { 5, -11, 2, 9 })}");
            Console.WriteLine($"       {OverlappingRectangles(new int[] { -8, -7, 4, 7 }, new int[] { -5, -9, 4, 7 })}");
        }
        public static int OverlappingRectangles(int[] rect1, int[] rect2)
        {
            int xOverlap = Math.Min(rect1[0] + rect1[2], rect2[0] + rect2[2]) - Math.Max(rect1[0], rect2[0]);
            int yOverlap = Math.Min(rect1[1] + rect1[3], rect2[1] + rect2[3]) - Math.Max(rect1[1], rect2[1]);
            return ((xOverlap < 0) ? 0 : xOverlap) * ((yOverlap < 0) ? 0 : yOverlap);
        }
        public void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 75: Area of Overlapping Rectangles");
            Console.WriteLine("       Create a function that returns the area of the overlap between two rectangles.");
            Console.WriteLine("       The function will receive two rectangles, each with the coordinates of the lower");
            Console.WriteLine("       left corner followed by the width and the height int[] { x, y, width, height }.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       OverlappingRectangles(new int[] { 2, 1, 3, 4 }, new int[] { 3, 2, 2, 5  }) --> 6");
            Console.WriteLine("       OverlappingRectangles(new int[] { 2, -9, 11, 5 }, new int[] { 5, -11, 2, 9 }) --> 10");
            Console.WriteLine("       OverlappingRectangles(new int[] { -8, -7, 4, 7 },  new int[] { -5, -9, 4, 7 }) --> 5\n");
        }
    }
}
//Area of Overlapping Rectangles https://edabit.com/challenge/Jj6S7qQgtfAo4L2QR
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
