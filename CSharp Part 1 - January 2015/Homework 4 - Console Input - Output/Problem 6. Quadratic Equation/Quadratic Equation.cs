using System;
using System.Globalization;
using System.Threading;

class quadraticEquation
{
    /* Write a program that reads the coefficients a, 
     * b and c of a quadratic equation ax2 + bx + c = 0 
     * and solves it (prints its real roots). */
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        double D = (b * b) - (4 * a * c);
        if (D < 0)
        {
            Console.WriteLine("no real roots");
            return;
        }

        double x1 = (-b - Math.Sqrt(D)) / (2 * a);
        Console.WriteLine(x1);
        double x2 = (-b + Math.Sqrt(D)) / (2 * a);
        Console.WriteLine(x2);
    }
}
