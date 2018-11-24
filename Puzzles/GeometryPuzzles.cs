using Models;
using System;

namespace Puzzles
{
    public static class GeometryPuzzles
    {
        public static long CalculateOverLapArea(Rectangle2DPlane rectangle1, Rectangle2DPlane rectangle2)
        {
            long Area = 0;
            int xDistance = CalculateOverlapDistance(rectangle1.Bottom.X, rectangle1.Top.X, rectangle2.Bottom.X, rectangle2.Top.X);
            if (xDistance < 0) return 0;
            int yDistance = CalculateOverlapDistance(rectangle1.Bottom.Y, rectangle1.Top.Y, rectangle2.Bottom.Y, rectangle2.Top.Y);
            if (yDistance < 0) return 0;
            Area = xDistance * yDistance;
            return Area;
        }

        public static int CalculateOverlapDistance(int XY11, int XY12, int XY21, int XY22)
        {
            return (Math.Min(XY22, XY12) - Math.Max(XY11, XY21));
        }
    }
}
