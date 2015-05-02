using System;

class PointInACircle
{
    /* Write an expression that checks if given point (x, y) 
     * is inside a circle K({0, 0}, 2). */
    static void Main()
    {
        const double circleRadius = 2;
        Console.Write("Enter the point's x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter the point's y: ");
        double y = double.Parse(Console.ReadLine());
        // Pythagoras theorem
        bool isInside = (circleRadius >= Math.Sqrt (x*x + y*y));
        Console.WriteLine(isInside);
    }
}
