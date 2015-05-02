using System;

class fibonacciNumbers
{
    /* Write a program that reads a number n and prints on the 
     * console the first n members of the Fibonacci sequence 
     * (at a single line, separated by comma and space - ,) 
     */
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int a = 0;
            int b = 1;
            for (int j = 0; j < i; j++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            Console.Write(a);
            Console.Write((i != n - 1) ? ", " : "\n");
        }
    }
}