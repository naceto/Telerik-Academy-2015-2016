using System;
using System.Numerics;

class CatalanNumbers
{
    /* Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100). */
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger dnf = 1; // (2*n)!
        BigInteger np1f = 1; // (n + 1)!
        BigInteger nf = 1; // n;
        for (int i = 1; i <= 2 * n; i++)
        {
            dnf *= i;
            if (i <= n + 1)
            {
                np1f *= i;
            }
            if (i <= n)
            {
                nf *= i;
            }
        }
        BigInteger catalan = dnf / (np1f * nf);
        Console.WriteLine("The {0} catalan number is {1}", n, catalan);
    }
}
