using System;
class DecimalToBinary
{
    /* Using loops write a program that converts an integer number to its binary representation.
     * The input is entered as long. The output should be a variable of type string.
     * Do not use the built-in .NET functionality. */
    static void Main()
    {
        Console.Write("Enter a number: ");
        long n = long.Parse(Console.ReadLine());
        string binaryStr = "";
        byte reminder = 0;
        while (n > 0)
        {
            reminder = (byte)(n % 2);
            binaryStr = reminder + binaryStr;
            n /= 2;
        }
        Console.WriteLine(binaryStr);
    }
}
