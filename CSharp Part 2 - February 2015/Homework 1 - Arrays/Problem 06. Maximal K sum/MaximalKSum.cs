using System;

class MaximalKSum
{
    /* Write a program that reads two integer numbers N and K and an array of N elements from the console.
     * Find in the array those K elements that have maximal sum. 
     */
    static void Main()
    {
        Console.Write("Enter the size of the array: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of the K elements: ");
        int K = int.Parse(Console.ReadLine());
        int?[] arrayK = new int?[K];
        for (int i = 0; i < N; i++)
        {
            Console.Write("Enter the {0} of {1}: ", i + 1, N);
            int number = int.Parse (Console.ReadLine());
            for (int j = 0; j < K; j++)
            {
                if (arrayK[j] == null)
                {
                    arrayK[j] = number;
                }
                else if (arrayK[j] < number)
                {
                    if (j + 1 < K && arrayK[j] > arrayK[j + 1])
                    {
                        arrayK[j + 1] = arrayK[j];
                    }
                    arrayK[j] = number;
                    break;
                }
            }
        }

        foreach (int n in arrayK)
        {
            Console.Write("{0} ", n);
        }
    }
    
}