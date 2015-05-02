using System;

class NumbersInIntervalDividableByGivenNumber
{
    /* Write a program that reads two positive integer 
     * numbers and prints how many numbers p exist between 
     * them such that the reminder of the division by 5 is 0. 
     */
    static void Main()
    {
        Console.Write("Enter the start number: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter the end number: ");
        int end = int.Parse(Console.ReadLine());

        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                Console.Write(i);
                Console.Write((i < end) ? ", " : "\n");
            }
        }
    }
}
