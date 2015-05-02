﻿using System;

class ExchangeIfGreater
{
    /* Write an if-statement that takes two double variables a 
     * and b and exchanges their values if the first one is greater
     * than the second one. As a result print the values a and b, 
     * separated by a space. 
     */
    static void Main()
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());

        if (a > b)
        {
            double temp = b;
            b = a;
            a = temp;
        }
        Console.WriteLine("{0} {1}", a, b);
    }
}

