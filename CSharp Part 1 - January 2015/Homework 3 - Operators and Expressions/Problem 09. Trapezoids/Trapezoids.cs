using System;

class Trapezoids
{
    /* Write an expression that calculates trapezoid's 
     * area by given sides a and b and height h. */
    static void Main()
    {
        Console.Write("Enter side a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter side b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        double h = double.Parse(Console.ReadLine());
        decimal area = (decimal)(((a + b) / 2) * h);
        Console.WriteLine("The area of the rectanble is: {0}", area);
    }
}
