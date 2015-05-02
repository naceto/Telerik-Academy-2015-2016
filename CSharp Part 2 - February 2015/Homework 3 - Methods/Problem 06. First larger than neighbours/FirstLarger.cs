using System;

class FirstLarger
{
    /* Write a method that returns the index of the first element in array that 
     * is larger than its neighbours, or -1, if there’s no such element. Use the 
     * method from the previous exercise. */
    static void Main()
    {
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter {0} number: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int index = FindFirst(array);
        if (index >= 0)
        {
            Console.WriteLine("The index of the first element in the array that is greater than its neighbours is {0}.", index);
        }
        else
        {
            Console.WriteLine("No such element found.");
        }
    }

    static int FindFirst(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (LargerThanNeighbours(array, i) == true)
            {
                return i;
            }
        }
        return -1;
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
