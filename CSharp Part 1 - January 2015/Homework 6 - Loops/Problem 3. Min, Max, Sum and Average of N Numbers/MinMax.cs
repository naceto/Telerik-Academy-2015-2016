using System;

class MinMax
{
    /* Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
     * the maximal number, * the sum and the average of all numbers (displayed with 2 digits after the decimal point).
     * The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.  
     */
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int? min = null, max = null, sum = 0;
        double avg;
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter the {0} number: ", i);
            int number = int.Parse (Console.ReadLine());
            if (i == 1)
            {
                min = max = number;
            }
            min = number < min ? number : min;
            max = number > max ? number : max;
            sum += number;
        }
        avg = (double)sum / n;
        Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3:f2}", min, max, sum, avg);
    }
}
