﻿using System;

class SelectionSort
{
    /* Sorting an array means to arrange its elements in increasing order. 
     * Write a program to sort an array. Use the Selection sort algorithm: 
     * Find the smallest element, move it at the first position, 
     * find the smallest from the rest, move it at the second position, etc. 
     */
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

        for (int i = 0; i < N; i++)
        {
            for (int j = i + 1; j < N; j++)
            {
                if (array[i] > array[j])
                {
                    // replace the numbers without temp variable
                    array[i] = array[i] + array[j];
                    array[j] = array[i] - array[j];
                    array[i] = array[i] - array[j];
                }
            }
        }

        foreach (int number in array)
        {
            Console.Write("{0} ", number);
        }
    }
}
