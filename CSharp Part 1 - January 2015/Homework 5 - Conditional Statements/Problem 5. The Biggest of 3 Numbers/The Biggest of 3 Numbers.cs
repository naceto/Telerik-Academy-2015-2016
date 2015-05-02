using System;

class TheBiggestOf3Numbers
{
    /* Write a program that finds the biggest of three numbers. */
    static void Main()
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        double biggestNum = a;
        if (b > biggestNum)
        {
            biggestNum = b;
        }

        if (c > biggestNum)
        {
            biggestNum = c;
        }
        Console.WriteLine(biggestNum);
    }
}
