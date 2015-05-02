using System;
using System.Numerics;

class NFactoriel
{
    /* Write a program to calculate n! for each n in the range [1..100].
     * Hint: Implement first a method that multiplies a number represented 
     * as array of digits by given integer number. */
    static void Main()
    {
        byte[] factorial = { 1 };
        for (byte i = 1; i <= 100; i++)
        {
            factorial = Multiply(factorial, i);
            Console.WriteLine(String.Join("", factorial));
        }
    }

    static byte[] Multiply(byte[] array, byte n)
    {
        byte[] finalSum = new byte[array.Length];
        int offsetCounter = 0;
        while (n > 0)
        {
            byte lastDigit = (byte)(n % 10);
            n /= 10;
            byte[] sum = new byte[array.Length + offsetCounter];
            byte remainder = 0;

            for (int i = array.Length - 1, j = 0; i >= 0 || remainder > 0; i--, j++)
            {
                byte number = 0;
                if (i >= 0)
                {
                    number = array[i];
                }
                number *= lastDigit;
                if (remainder > 0)
                {
                    number += remainder;
                }
                remainder = (byte)(number / 10);
                number %= 10;

                // make sure there is enought space
                if (j + offsetCounter > sum.Length - 1)
                {
                    Array.Resize(ref sum, sum.Length + 1);
                }
                sum[j + offsetCounter] = number;
            }
            finalSum = Add(finalSum, Reverse (sum));
            ++offsetCounter;
        }
        return finalSum;
    }

    static byte[] Reverse(byte[] array)
    {
        byte[] reversed = new byte[array.Length];
        for (int i = array.Length - 1, j = 0; i >= 0; i--, j++)
        {
            reversed[j] = array[i];
        }
        return reversed;
    }
    
    // arrays are expected ordered
    static byte[] Add(byte[] array1, byte[] array2)
    {
        int resultIterator = 0;
        int max = Math.Max(array1.Length, array2.Length);
        int ar1Iter = array1.Length - 1;
        int ar2Iter = array2.Length - 1;
        byte remainder = 0;
        byte[] result = new byte[max];
        --max;  // from Length - 1
        while (max >= 0)
        {
            byte num = 0;
            byte a1n = 0;
            byte a2n = 0;
            if (ar1Iter >= 0 && ar1Iter < array1.Length)
            {
                a1n = array1[ar1Iter];
                --ar1Iter;
            }
            if (ar2Iter >= 0 && ar2Iter < array2.Length)
            {
                a2n = array2[ar2Iter];
                --ar2Iter;
            }
            num = (byte)(a1n + a2n);
            if (remainder > 0)
            {
                num += remainder;
                remainder = 0;
            }
            if (num >= 10)
            {
                remainder = (byte)(num / 10);
                num %= 10;
            }
            if (resultIterator > result.Length - 1)
            {
                Array.Resize(ref result, result.Length + 1);
            }
            result[resultIterator++] = num;
            --max;
        }
        if (remainder > 0)
        {
            if (resultIterator > result.Length - 1)
            {
                Array.Resize(ref result, result.Length + 1);
            }
            result[resultIterator++] = remainder;
        }
        return Reverse(result);
    }
}
