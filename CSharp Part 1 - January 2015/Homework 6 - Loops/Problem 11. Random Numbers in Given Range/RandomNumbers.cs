using System;

class RandomNumbers
{
    /* Write a program that enters 3 integers n, min and max (min != max) 
     * and prints n random numbers in the range [min...max]. */
    static void Main()
    {
        Console.Write("Enter the number of numbers: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("min: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("max: ");
        int max = int.Parse(Console.ReadLine());
        Random r = new Random();
        for (int i = 1; i <= n; i++)
        {
            Console.Write(r.Next(min, max + 1));
            if (i < n)
            {
                Console.Write(' ');
            }
        }
        Console.WriteLine();
    }
}
