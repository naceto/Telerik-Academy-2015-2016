using System;
using System.Collections.Generic;

public class StringComparer : IComparer<string>
{
    public int Compare (string lhs, string rhs)
    {
        if (lhs.Length > rhs.Length)
        {
            return 1;
        }
        else if (lhs.Length < rhs.Length)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}

class Program
{
    /* You are given an array of strings. Write a method that sorts the array 
     * by the length of its elements (the number of characters composing them). 
     */

    static void Main()
    {
        Console.Write("Enter the number of strings: ");
        int n = int.Parse(Console.ReadLine());

        string[] array = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter string {0}", i + 1);
            array[i] = Console.ReadLine();
        }
        Array.Sort(array, new StringComparer());
        foreach (var item in array)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }
}
