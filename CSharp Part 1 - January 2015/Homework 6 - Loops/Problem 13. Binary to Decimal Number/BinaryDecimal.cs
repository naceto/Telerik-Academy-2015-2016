using System;

class BinaryDecimal
{
    /* Using loops write a program that converts a binary integer number to its decimal form.
     * The input is entered as string. The output should be a variable of type long.
     * Do not use the built-in .NET functionality. 
     */
    static void Main()
    {
        Console.Write("Enter th binary number: ");
        string binStr = Console.ReadLine();
        long number = 0;
        for (int i = 0; i < binStr.Length; i++)
        {
            number <<= 1;
            byte b = (byte)(binStr[i] - '0');
            number |= b;
        }
        Console.WriteLine(number);
    }
}
