using System;

class QuickSort
{
    /* Write a program that sorts an array of integers using the Quick sort 
     * algorithm. 
     */

    static void swap (int[] array, int pos1, int pos2)
    {
        if (pos1 != pos2)
        {
            array[pos1] = array[pos1] + array[pos2];
            array[pos2] = array[pos1] - array[pos2];
            array[pos1] = array[pos1] - array[pos2];
        }
    }
    
    static int partition (int[] array, int lo, int hi)
    {
        int pivot = array[lo];
        int leftWall = lo;

        for (int i = lo + 1; i <= hi; i++)
        {
            if (array[i] < pivot)
            {
                ++leftWall;
                swap (array, i, leftWall);
            }
        }
        swap (array, lo, leftWall);
        return leftWall;
    }

    static void quickSort (int[] array, int lo, int hi)
    {
        if (lo < hi)
        {
            int p = partition(array, lo, hi);
            quickSort(array, lo, p - 1);
            quickSort(array, p + 1, hi);
        }
    }

    static void Main()
    {
        Console.Write("Enter the size of the array: ");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        for (int i = 0; i < N; i++)
        {
            Console.Write("Enter the {0} out of {1} elements: ", i + 1, N);
            array[i] = int.Parse(Console.ReadLine());
        }

        quickSort(array, 0, array.Length - 1);
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}
