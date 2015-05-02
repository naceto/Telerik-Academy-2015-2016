using System;

class sumOfNNumbers
{
    /* Write a program that enters a number n and after 
     * that enters more n numbers and calculates and 
     * prints their sum. Note: You may need to use a 
     * for-loop. 
     */
    static void Main()
    {
        Console.Write("Enter count of numbers: ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter number {0}: ", i);
            double number = double.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine(sum);
    }
}
