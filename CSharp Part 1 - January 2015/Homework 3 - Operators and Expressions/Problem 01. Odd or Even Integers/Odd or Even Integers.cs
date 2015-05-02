using System;

class oddOrEvenIntegers
{
    /* Write an expression that checks if given integer is odd or even. */
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine((number % 2 != 0) ? true : false);
    }
}