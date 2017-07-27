using System;
using System.Collections.Generic;
using System.Linq;

class Boxes
{
    static void Main()
    {
        var boxs = new List<Box>();
        var points = new List<Point>();

        var input = Console.ReadLine();

        while (input != "end")
        {
            var tokens = input.Split(new[] { ' ', ':', '|' }, StringSplitOptions.RemoveEmptyEntries);

            Point upperLeft, upperRight, bottomLeft, bottomRight;

            AddPoints(tokens, out upperLeft, out upperRight, out bottomLeft, out bottomRight);

            var newBox = new Box
            {
                UpperLeft = upperLeft,
                UpperRight = upperRight,
                BottomLeft = bottomLeft,
                BottomRight = bottomRight
            };

            boxs.Add(newBox); 

            input = Console.ReadLine();
        }

        foreach (var box in boxs)
        {
            var width = Point.CalculateDistance(box.UpperLeft, box.UpperRight);
            var height = Point.CalculateDistance(box.UpperLeft, box.BottomLeft);
            var boxPerimeter = Box.CalculatePerimeter((int)width, (int)height);
            var boxArea = Box.CalculateArea((int)width, (int)height);

            Console.WriteLine($"Box: {width}, {height}");
            Console.WriteLine($"Perimeter: {boxPerimeter}");
            Console.WriteLine($"Area: {boxArea}");
        }
    }

    private static void AddPoints(string[] tokens, out Point upperLeft, out Point upperRight, out Point bottomLeft, out Point bottomRight)
    {
        upperLeft = new Point
        {
            X = int.Parse(tokens[0]),
            Y = int.Parse(tokens[1])
        };
        upperRight = new Point
        {
            X = int.Parse(tokens[2]),
            Y = int.Parse(tokens[3])
        };
        bottomLeft = new Point
        {
            X = int.Parse(tokens[4]),
            Y = int.Parse(tokens[5])
        };
        bottomRight = new Point
        {
            X = int.Parse(tokens[6]),
            Y = int.Parse(tokens[7])
        };
    }
}

