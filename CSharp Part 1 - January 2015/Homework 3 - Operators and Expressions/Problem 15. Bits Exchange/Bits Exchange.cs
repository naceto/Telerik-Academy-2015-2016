using System;

class bitsExchange
{
    /* Write a program that exchanges bits 3, 4 and 5 with
     * bits 24, 25 and 26 of given 32-bit unsigned integer. */
    static void Main()
    {
        Console.Write("Enter a number: ");
        uint num = uint.Parse(Console.ReadLine());
        for (int i = 3, j = 24; i <= 5 && j <= 26; i++, j++)
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
