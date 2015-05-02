using System;

class Program
{   /* Write a program that enters in integer n and prints
     * the numbers 1, 2, …, n in random order. 
     */
    static void Main()
    {
        Console.Write("Enter integer n: ");
        int n = int.Parse(Console.ReadLine());
        int?[] numArray = new int?[n];
        Random r = new Random();
        for (int i = 1; i <= n; i++)
        {
            int randNum;
            do
            {
                randNum = r.Next(0, n);
            }
            while (numArray[randNum] != null);
            numArray[randNum] = i;
        }
        foreach (var a in numArray)
        {
            Console.Write(a + " ");
        }
    }
}
