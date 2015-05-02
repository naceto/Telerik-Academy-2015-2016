using System;

class LargerThan
{
    /* Write a method that checks if the element at given position in given 
     * array of integers is larger than its two neighbours (when such exist). 
     */
    static void Main()
    {
        Console.Write("Enter the position to check for: ");
        int pos = int.Parse(Console.ReadLine());

        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter {0} number: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Is the element at position {0} larger than its neighbours: {1}", pos,
            LargerThanNeighbours(array, pos));
    }

    static bool LargerThanNeighbours(int[] array, int position)
    {
        if (position >= array.Length - 1 || array.Length <= 1)
        {
            return false;
        }
        else if (array[position] > array[position - 1] && array[position] > array[position + 1])
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
