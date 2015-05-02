using System;

class bitExchangeAdvanced
{
    /* Write a program that exchanges bits {p, p+1, …, p+k-1} with bits 
     * {q, q+1, …, q+k-1} of a given 32-bit unsigned integer. The first 
     * and the second sequence of bits may not overlap. */
    static void Main()
    {
        Console.Write("Enter a number: ");
        uint num = uint.Parse(Console.ReadLine());

        Console.Write("Enter p: ");
        int p = int.Parse(Console.ReadLine());

        Console.Write("Enter q: ");
        int q = int.Parse(Console.ReadLine());

        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());

        if ((p > q && p + k > 31) || (q > p && q + k > 31))
        {
            Console.WriteLine("out of range");
            return;
        }
        if ((p < q && p + k > q) || (p > q && q + k > p))
        {
            Console.WriteLine("overlapping");
            return;
        }

        for (int i = p, j = q; i < p + k && j < q + k; i++, j++)
        {
            const uint one = 1;
            uint getMaskI = one << i;
            uint getMaskJ = one << j;
            uint bitI = (num & getMaskI) >> i;
            uint bitJ = (num & getMaskJ) >> j;
            if (bitJ != bitI)
            {
                if (bitJ == 1)
                {
                    num |= (one << i);
                    num &= ~(one << j);
                }
                else
                {
                    num &= ~(one << i);
                    num |= (one << j);
                }
            }
        }
        Console.WriteLine(num);
    }
}
