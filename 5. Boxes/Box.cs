using System;
using System.Collections.Generic;
using System.Linq;

class Box
{
    public Point UpperLeft { get; set; }

    public Point UpperRight { get; set; }

    public Point BottomLeft { get; set; }

    public Point BottomRight { get; set; }

    public static int CalculatePerimeter(int width, int height)
    {
        return (2 * width) + (2 * height);
    }

    public static int CalculateArea(int width, int height)
    {
        return width * height;
    }
}

