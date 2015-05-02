using System;

class FindSumInArray
{
    /* Write a program that finds in given arrayof integers 
     * a sequence of given sum S (if present). 
     */
    static void Main()
    {
        Console.Write("Enter the sum: ");
        int S = int.Parse(Console.ReadLine());

        Console.Write("Enter the size of the array: ");
        int N = int.Parse(Console.ReadLine());

        int[] array = new int[N];
        for (int i = 0; i < N; i++)
        {
            Console.Write("Enter the {0} of {1} element: ", i + 1, N);
            array[i] = int.Parse(Console.ReadLine());
        }
        int sum = 0;
        int startSum = 0;
        int endSum = 0;
        for (int i = 0; i < N; i++)
        {
            sum = 0;
            for (int j = i; j < N; j++)
            {
                sum += array[j];
                if (sum == S) 
                {
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
