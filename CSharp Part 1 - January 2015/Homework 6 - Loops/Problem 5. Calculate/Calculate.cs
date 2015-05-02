using System;

class Calculate
{
    /* Write a program that, for a given two integer numbers n and x, 
     * calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
     * Use only one loop. Print the result with 5 digits after the decimal point. 
     */
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());
        int factoriel = 1;
        decimal sum = 1;
        for (int i = 1; i <= n; i++)
        {
            factoriel *= i;
            sum += (decimal)(factoriel / Math.Pow(x, i));
        }
        Console.WriteLine("{0:F5}", sum);
    }
}