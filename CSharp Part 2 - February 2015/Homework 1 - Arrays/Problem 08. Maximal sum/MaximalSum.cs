using System;

class MaximalSum
{
    /* Write a program that finds the sequence of maximal sum in given array.
     * Can you do it with only one loop (with single scan through the elements of the array)? */
    static void Main()
    {
        Console.Write("Enter the size of the array: ");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];

        for (int i = 0; i < N; i++)
        {
            Console.Write("Enter the {0} of {1} element: ", i + 1, N);
            array[i] = int.Parse(Console.ReadLine());
        }

        int maxsum, sum, startSum, endSum;
        sum = maxsum = startSum = endSum = 0;
        for (int i = 0; i < N; i++)
        {
            sum = 0;
            for (int j = i; j < N; j++)
            {
                sum += array[j];
                if (sum > maxsum)
                {
                    maxsum = sum;
                    startSum = i;
                    endSum = j;
                }
            }
        }

        for (int i = startSum; i <= endSum; i++)
        {
            Console.Write("{0} ", array[i]);
        }
    }
}
