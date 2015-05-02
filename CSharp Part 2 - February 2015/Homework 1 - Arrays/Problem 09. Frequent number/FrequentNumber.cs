using System;

class FrequentNumber
{
    /* Write a program that finds the most frequent number in an array. */
    static void Main()
    {
        Console.Write("Enter the size of the array: ");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        int maxNumber = 0;
        for (int i = 0; i < N; i++)
        {
            Console.Write("Enter the {0} of {1} element: ", i + 1, N);
            array[i] = int.Parse(Console.ReadLine());
            maxNumber = Math.Max(maxNumber, array[i]);
        }
        int[] countArray = new int[maxNumber + 1];
        for (int i = 0; i < N; i++)
        {
            ++countArray[array[i]];
        }
        int mostFreq = 0, number = 0;
        for (int i = 0; i < countArray.Length; i++)
        {
            if (countArray[i] > mostFreq)
            {
                mostFreq = i;
                number = countArray[i];
            }
        }
        Console.Write("{0} ({1} times)",mostFreq, number);
    }
}
