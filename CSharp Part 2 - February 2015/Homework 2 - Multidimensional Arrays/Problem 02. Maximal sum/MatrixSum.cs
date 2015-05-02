using System;

class MatrixSum
{
    /* Write a program that reads a rectangular matrix of size N x M and finds 
     * in it the square 3 x 3 that has maximal sum of its elements. 
     */
    static void Main()
    {
        int square = 3;
        Console.Write("Enter N: ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Enter M: ");
        int M = int.Parse(Console.ReadLine());

        if (M < square || N < square)
        {
            Console.WriteLine("ERROR: The matrix have to be atleast {0}x{0} elements", square);
            return;
        }

        int[,] matrix = new int[N, M];

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write("Enter element {0}x{1}:", i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        long bestSum = long.MinValue;
        int bestRow = 0, bestCol = 0;
        long sum = 0;
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                if (i + square <= N && j + square <= M)
                {
                    sum = 0;
                    for (int k = i; k < i + square; k++)
                    {
                        for (int m = j; m < j + square; m++)
                        {
                            sum += matrix[k, m];
                        }
                    }
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = i;
                        bestCol = j;
                    }
                }
            }
        }

        for (int i = 0; i < square; i++)
        {
            for (int j = 0; j < square; j++)
            {
                Console.Write("{0} ", matrix[bestRow + i, bestCol + j]);
            }
            Console.WriteLine();
        }
    }
}
