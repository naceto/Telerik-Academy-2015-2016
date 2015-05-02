using System;
using System.Threading;
using System.Globalization;

class numberComparer
{
    /* Write a program that gets two numbers from the 
     * console and prints the greater of them.
     * Try to implement this without if statements. */
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.WriteLine(firstNumber > secondNumber ? firstNumber : secondNumber);
    }
}
