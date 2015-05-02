using System;

class extractBitFromInteger
{
    /* Write an expression that extracts from given integer n the value of given bit at index p. */
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Enter the position of the bit: ");
        int p = int.Parse(Console.ReadLine());
        int result = (num & (1 << p)) >> p;
        Console.WriteLine(result);
    }
}
