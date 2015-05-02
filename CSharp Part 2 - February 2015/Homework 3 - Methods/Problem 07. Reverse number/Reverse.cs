using System;

class Reverse
{
    /* Write a method that reverses the digits of given decimal number. */
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        decimal num = decimal.Parse(Console.ReadLine());

        decimal resultNum = ReverseDigits(num);
        Console.WriteLine(resultNum);
    }

    static decimal ReverseDigits(decimal num)
    {
        string numStr = num.ToString();
        int j = 0;
        char[] array = new char[numStr.Length];
        for (int i = numStr.Length - 1; i >= 0; i--)
        {
            array[j++] = numStr[i];
        }
        return decimal.Parse(String.Join("", array));
    }
}
