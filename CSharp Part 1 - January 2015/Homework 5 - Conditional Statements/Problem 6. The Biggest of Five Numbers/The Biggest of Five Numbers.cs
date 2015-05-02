using System;

class TheBiggestOfFiveNumbers
{
    /* Write a program that finds the biggest of five numbers by using only five if statements. */
    static void Main()
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        Console.Write("Enter d: ");
        double d = double.Parse(Console.ReadLine());

        Console.Write("Enter e: ");
        double e = double.Parse(Console.ReadLine());

        double biggestNum = a;
        if (b > biggestNum)
        {
            biggestNum = b;
        }
        if (c > biggestNum)
        {
            biggestNum = c;
        }
        if (d > biggestNum)
        {
            biggestNum = c;
        }
        if (e > biggestNum)
        {
            biggestNum = e;
        }
        Console.WriteLine(biggestNum);
    }
}
