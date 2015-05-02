using System;

class MatrixNumbers
{
    /* Write a program that reads from the console a positive integer 
     * number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. 
     * Use two nested loops. 
     */
    static void Main()
    {
        Console.Write("Enter the size of the matrix: ");
        int n = int.Parse(Console.ReadLine());
        if (n < 1 || n > 20)
        {
            Console.WriteLine("Invalid argument (1 ≤ n ≤ 20).");
            return;
        }
        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j < n + i; j++)
            {
                Console.Write(j);
                if (j < n + i)
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
    }
}
