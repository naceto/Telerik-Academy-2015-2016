using System;

class SortingArray
{
    /* Write a method that return the maximal element in a portion of array of 
     * integers starting at given index. Using it write another method that 
     * sorts an array in ascending / descending order. */
    static void Main()
    {
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter the {0} element: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Ascending (true), descending (false) (true/false string expected): ");
        bool type = bool.Parse(Console.ReadLine());

        Console.WriteLine("The unsorted array: ");
        PrintArray(array);

        SortArray(array, type);

        Console.WriteLine("The sorted array: ");
        PrintArray(array);
    }

    static void PrintArray (int[] array)
    {
        Console.WriteLine(String.Join(" ", array));
    }

    static void SortArray (int[] array, bool ascending)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int max = FindMax(array, i);
            if (array[i] < array[max])
            {
                Swap(array, i, max);
            }
        }
        if (ascending)
        {
            for (int i = 0; i < array.Length / 2; i++)
			{
			    Swap (array, i, array.Length - i - 1);
			}
        }
    }

    static void Swap(int[] array, int pos1, int pos2)
    {
        array[pos1] = array[pos1] + array[pos2];
        array[pos2] = array[pos1] - array[pos2];
        array[pos1] = array[pos1] - array[pos2];
    }

    static int FindMax(int[] array, int startIndex)
    {
        int max = int.MinValue;
        int position = 0;
        for (int i = startIndex; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                position = i;
            }
        }
        return position;
    }
}