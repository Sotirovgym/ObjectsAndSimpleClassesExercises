using System;
using System.Collections.Generic;
using System.Linq;

class Point
{
    public int X { get; set; }

    public int Y { get; set; }

    public static double CalculateDistance(Point point1, Point point2)
    {
        var first = Math.Pow(point1.X - point2.X, 2);
        var second = Math.Pow(point1.Y - point2.Y, 2);

        var result = Math.Sqrt(first + second);

        return result;
    }

    
}

