using System;

class modifyABitAtGivenPosition
{
    /* We are given an integer number n, a bit value v (v=0 or 1) and a position p.
     * Write a sequence of operators (a few lines of C# code) that modifies n to hold
     * the value v at the position p from the binary representation of n while preserving 
     * all other bits in n. */
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        Console.Write("Enter the position of the bit: ");
        int p = int.Parse(Console.ReadLine());

        Console.Write("Enter a bit value (0 or 1): ");
        int bitV = int.Parse(Console.ReadLine());

        int bitToModify = ((num & (1 << p)) >> p);

        if (bitToModify != bitV)
        {
            if (bitV == 1)
            {
                num |= 1 << p;
            }
            else
            {
                num &= ~(1 << p);
            }
        }
        Console.WriteLine(num);
    }
}
