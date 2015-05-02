using System;
using System.Globalization;
using System.Threading;

class sumOf5Numbers
{
    /* Write a program that enters 5 numbers (given in a single line, 
    * separated by a space), calculates and prints their sum. */
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string numbers = Console.ReadLine();
        string[] parsedStr = numbers.Split(' ');
        double sum = 0;
        for (int i = 0; i < parsedStr.Length; i++)
        {
            sum += double.Parse(parsedStr[i]);
        }
        Console.WriteLine(sum);
    }
}
