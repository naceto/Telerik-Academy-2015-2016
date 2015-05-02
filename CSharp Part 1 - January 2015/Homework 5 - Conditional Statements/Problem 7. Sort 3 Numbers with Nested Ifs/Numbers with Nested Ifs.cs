using System;

class SortNumbers
{
    /* Write a program that enters 3 real numbers and prints them sorted in descending order.
     * Use nested if statements.    
     * Note: Don’t use arrays and the built-in sorting functionality. */
    static void Main()
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        if (a >= b && a > c)
        {
            if (b > c)
            {
                Console.WriteLine("{0}, {1}, {2}.", a, b, c);
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}.", a, c, b);
            }
        }
        if (c >= b && a <= c)
        {
            if (b > a)
            {
                Console.WriteLine("{0}, {1}, {2}.", c, b, a);
            }
            else    // a > b
            {
                Console.WriteLine("{0}, {1}, {2}.", c, a, b);
            }
        }
        if (b > a && c < b)
        {
            if (a > c)
            {
                Console.WriteLine("{0}, {1}, {2}.", b, a, c);
            }
            else   // a < c
            {
                Console.WriteLine("{0}, {1}, {2}.", b, c, a);
            }
        }
    }
}