using System;

class Appear
{
    /* Write a method that counts how many times given number appears in given array.
       Write a test program to check if the method is workings correctly. 
     */
    static void Main()
    {
        Console.Write("Enter the number to check: ");
        int num = int.Parse(Console.ReadLine());

        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter {0} number: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Number {0} is found {1} times.", num, CountOccurrences(array, num));
    }

    static int CountOccurrences(int[] array, int number)
    {
        int counter = 0;
        foreach (int n in array)
        {
            if (n == number)
            {
                ++counter;
            }
        }
        return counter;
    }
}
