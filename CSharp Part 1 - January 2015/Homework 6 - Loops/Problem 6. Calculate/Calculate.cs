using System;

class Calculate
{
    /* Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
     * Use only one loop. 
     */
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
        int nf = 1, kf = 1;
        for (int i = 1; i <= n; i++)
        {
            if (i <= k)
            {
                kf *= i;
            }
            nf *= i;
        }
        Console.WriteLine(nf / kf);
    }
}
