using System;

class FillTheMatrix
{
	/* Write a program that fills and prints a matrix of size (n, n) as shown below: */
    public static void Main()
    {
        Console.Write("Enter the size of the matrix: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("a)");
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0} ", n * col + 1 + row);
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("b)");
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (col % 2 == 0)
                {
                    Console.Write("{0} ", (n * col) + 1 + row);
                }
                else
                {
                    Console.Write("{0} ", n * (col + 1) - row);
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("c)");
        int[,] matrix = new int[n,n];

        int rows = matrix.GetLength(0) - 1;
        int cols = matrix.GetLength(1) - 1;
        int index = 1;
        int rowC = n - 1;
        int colC = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[rowC, colC] = index;
                index++;
                if (rowC == rows || colC == cols)
                {
                    ++colC;
                    while (rowC > 0 && colC > 0)
                    {
                        --colC; --rowC;
                    }
                }
                else
                {
                    ++colC; ++rowC;
                }
            }
        }
        // print c)
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0} ", matrix[i,j]);
            }
            Console.WriteLine();
        }
    }
}
