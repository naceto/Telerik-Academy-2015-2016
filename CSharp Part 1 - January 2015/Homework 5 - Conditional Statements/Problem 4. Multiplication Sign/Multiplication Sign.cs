using System;

class MultiplicationSign
{
    /* Write a program that shows the sign (+, - or 0) of the product of three real
     * numbers, without calculating it.
     * Use a sequence of if operators. */
    static void Main()
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());
        int counter = 0;
        char sign;
        if (a > 0)
        {
            counter++;
        }
        if (b > 0)
        {
            counter++;
        }
        if (c > 0)
        {
            counter++;
        }
        if (counter % 2 != 0)
        {
            sign = '+';
        }
        else
        {
            sign = '-';
        }
        if (a == 0 || b == 0 || c == 0)
        {
            sign = '0';
        }
        Console.WriteLine(sign);
    }
}