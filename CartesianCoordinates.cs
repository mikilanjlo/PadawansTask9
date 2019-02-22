using System;
using System.Collections.Generic;

namespace PadawansTask9
{
    public class CartesianCoordinates
    {
        public static List<Point> GetNeighbors(Point point, int range, params Point[] points)
        {
            if (point.Equals(null))
                throw new ArgumentNullException();
            if (range <= 0)
                throw new ArgumentException();
            List<Point> result = new List<Point>();
            GetNeighbors(point, range,  result, points);
            return result;
        }

        private static void GetNeighbors(Point neighbor, int range, List<Point> result, params Point[] points)
        {
            foreach (Point point in points)
            {
                if (point.Equals(null))
                    throw new ArgumentNullException();
                if (Math.Abs(neighbor.X - point.X) <= range && Math.Abs(neighbor.Y - point.Y) <= range)
                    result.Add(point);
            }
        }
    }
}