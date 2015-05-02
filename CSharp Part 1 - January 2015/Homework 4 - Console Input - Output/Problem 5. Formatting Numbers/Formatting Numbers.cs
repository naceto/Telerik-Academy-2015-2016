using System;
using System.Threading;
using System.Globalization;

class formattingNumbers
{
    /* 
    Write a program that reads 3 numbers:
        integer a (0 <= a <= 500)
        floating-point b
        floating-point c
    The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
        The number a should be printed in hexadecimal, left aligned
        Then the number a should be printed in binary form, padded with zeroes
        The number b should be printed with 2 digits after the decimal point, right aligned
        The number c should be printed with 3 digits after the decimal point, left aligned.
 */
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        if (a <= 0 || a >= 500)
        {
            Console.WriteLine("Error: integer a (0 <= a <= 500), you entered {0} ", a);
            return;
        }

        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("|{0,-10:x}|{1,10:D10}|{2,10:F2}|{3,-10:F3}|", a, Convert.ToString(a, 2), b, c);
    }
}