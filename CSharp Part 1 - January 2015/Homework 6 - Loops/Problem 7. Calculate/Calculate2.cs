using System;
using System.Numerics;

class Calculate2
{
    /* Calculate N! / (K! * (N-K)!) */
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());
        if (k >= n || k <= 1 || n >= 100)
        {
            Console.WriteLine("Invalid data");
            return;
        }
        BigInteger nf = 1, kf = 1;
        for (int i = 1; i <= n; i++)
        {
            if (i <= k)
            {
                kf *= i;
            }
            nf *= i;
        }
        BigInteger nkf = 1;
        for (int j = 1; j <= (n - k); j++)
        {
            nkf *= j;
        }
        BigInteger result = nf / (kf * nkf);
        Console.WriteLine(result);
    }
}
