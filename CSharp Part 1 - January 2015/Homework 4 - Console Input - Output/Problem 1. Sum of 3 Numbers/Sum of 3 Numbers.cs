using System;
using System.Globalization;
using System.Threading;

class problemSumof3Numbers
{
    /* Write a program that reads 3 real numbers from 
     * the console and prints their sum. */
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter the first number: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter the trird number: ");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, a + b + c);
    }
}

