using System;

class insideACircleOutsideOfRectangle
{
    static void Main()
    {
        const double circleX = 1;
        const double circleY = 1;
        const double circleRadius = 1.5;
        const double rectTop = 1;
        const double rectLeft = -1;
        const double rectWidth = 6;
        const double rectHeight = 2;

        Console.Write("Enter point x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter point y: ");
        double y = double.Parse(Console.ReadLine());

        bool isInside = (Math.Sqrt((x - circleX) * (x - circleX) + (y - circleY) * (y - circleY)) <= circleRadius) && (y > rectTop);
        Console.WriteLine(isInside ? "yes" : "no");
    }
}