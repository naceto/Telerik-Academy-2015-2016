using System;

class BinarySearch
{
    /* Write a program that finds the index of given element in a sorted array 
     * of integers by using the Binary search algorithm. 
     */
    static int binarySearch(int[] array, int startPos, int endPos, int searchValue)
    {
        int key = (endPos + startPos) / 2;
        if (array[key] == searchValue)
        {
            return key;
        }
        else if (array[key] > searchValue)
        {
            return binarySearch(array, startPos, key, searchValue);
        }
        else
        {
            return binarySearch(array, key, endPos, searchValue);
        }
    }

    static void Main()
    {
        Console.Write("Enter the value to search for: ");
        int value = int.Parse(Console.ReadLine());

        Console.Write("Enter the size of the array: ");
        int N = int.Parse(Console.ReadLine());

        int[] array = new int[N];
        Console.WriteLine("Enter the values in ascending or descending order.");
        for (int i = 0; i < N; i++)
        {
            Console.Write("Enter the {0} out of {1} elements: ", i + 1, N);
            array[i] = int.Parse(Console.ReadLine());
        }

        int index = binarySearch(array, 0, array.Length, value);
        Console.WriteLine(index);
    }
}
