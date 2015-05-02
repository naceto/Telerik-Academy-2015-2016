using System;

class Program
{
    /* Write a program, that reads from the console an array of N integers and 
     * an integer K, sorts the array and using the method Array.BinSearch() 
     * finds the largest number in the array which is ≤ K. 
     */
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter element {0}: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);
        int index = Array.BinarySearch(array, k);
        if (index < 0)
        {
            index = ~index - 1;
        }
        if (index >= 0)
        {
            var result = array[index];
            Console.WriteLine("The larges number <= {0} is {1}.",k, result);
        }
        else
        {
            Console.WriteLine("No such number.");
        }
    }
}
