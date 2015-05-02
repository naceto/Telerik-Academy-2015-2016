using System;

class SequenceNMatrix
{
    /* We are given a matrix of strings of size N x M. Sequences in the matrix 
     * we define as sets of several neighbour elements located on the same line, 
     * column or diagonal. Write a program that finds the longest sequence of 
     * equal strings in the matrix. 
     */

    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter M: ");
        int m = int.Parse(Console.ReadLine());

        string[,] matrix = new string[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("Enter element {0}x{1}:", i, j);
                matrix[i, j] = Console.ReadLine();
            }
        }

        int bestSum = 0;
        int bestRow = 0;
        int bestCol = 0;
        string type = null;
        int sum = 0;

        // check horizontal
        for (int row = 0; row < n; row++)
        {
            string test = matrix[row, 0]; ;
            sum = 0;
            for (int col = 0; col < m; col++)
            {
                
                if (test == matrix[row, col])
                {
                    ++sum;
                }
                else
                {
                    test = matrix[row, col];
                    sum = 0;
                }
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                    type = "horizontal";
                }
            }
        }

        // vertical
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                // test vertical
                sum = 0;
                string test = matrix[row, col];
                for (int k = 0; k < n; k++)
                {
                    if (test == matrix[k, col])
                    {
                        ++sum;
                    }
                    else
                    {
                        test = matrix[k, col];
                        sum = 0;
                    }
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = k;
                        bestCol = col;
                        type = "vertical";
                    }
                }
            }
        }

        // check diagonal
        for (int i = 0; i < n; i++)
        {
            string test = null;
            for (int j = 0; j < m; j++)
            {
                // diagonal
                sum = 1;
                test = matrix[i, j];
                int k = i - 1;
                int l = j - 1;
                while (k >= 0 && l >= 0)
                {
                    if (test == matrix[k, l])
                    {
                        ++sum;
                    }
                    else
                    {
                        test = matrix[k, l];
                        sum = 0;
                    }
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = i;
                        bestCol = j;
                        type = "diagonal";
                    }
                    --k;
                    --l;
                }
            }
        }
        if (type == "horizontal")
        {
            Console.WriteLine("strings numbers: {0}, type: {1}", bestSum, type);
            for (int i = bestCol; i >= 0; i--)
            {
                Console.Write("{0} ", matrix[bestRow, i]);
            }
        }
        else if (type == "vertical")
        {
            Console.WriteLine("strings numbers: {0}, type: {1}", bestSum, type);
            for (int i = bestRow; i >= 0; i--)
            {
                Console.Write("{0} ", matrix[i, bestCol]);
            }
        }
        else if (type == "diagonal")
        {
            Console.WriteLine("strings numbers: {0}, type: {1}", bestSum, type);
            for (int i = bestRow, j = bestCol; i >= 0 && j >= 0; i--, j--)
            {
                Console.Write("{0} ", matrix[i, j]);
            }
        }
    }
}
