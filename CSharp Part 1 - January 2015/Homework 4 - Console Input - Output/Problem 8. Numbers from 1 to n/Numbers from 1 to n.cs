﻿using System;

class numbersFrom1ToN
{
    /* Write a program that reads an integer number n from the console
     * and prints all the numbers in the interval [1..n], each on a single line. 
     */
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

