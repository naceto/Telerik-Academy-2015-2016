using System;

class CalculateGCD
{
    /* Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
     * Use the Euclidean algorithm (find it in Internet). 
     * http://en.wikipedia.org/wiki/Euclidean_algorithm
     */
    static void Main()
    {
        Console.Write("Enter the first integer: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter the second integer: ");
        int b = int.Parse(Console.ReadLine());
        b = Math.Abs(b);
        while (a != b)
        {
            if (a > b)
            {
                a = a - b;
            }
            else
            {
                b = b - a;
            }
        }
        Console.WriteLine(a);
    }
}
