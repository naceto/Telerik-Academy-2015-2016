using System;
using System.Threading;
using System.Globalization;

class circlePerimeterАndArea
{
    /* Write a program that reads the radius r of a circle and prints 
     * its perimeter and area formatted with 2 digits after the decimal point.*/
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter the radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());
        Console.WriteLine("The perimeter of the circle with radius: {0} is {1:F2}.", radius, 2 * Math.PI * radius);
        Console.WriteLine("The area of the circle with radius: {0} is {1:F2}.", radius, Math.PI * Math.Pow(radius, 2));
    }
}
