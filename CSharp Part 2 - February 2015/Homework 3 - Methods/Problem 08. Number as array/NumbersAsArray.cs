using System;

class NumbersAsArray
{
    /* Write a method that adds two positive integer numbers represented as 
     * arrays of digits (each array element arr[i] contains a digit; the last 
     * digit is kept in arr[0]). Each of the numbers that will be added could 
     * have up to 10 000 digits. */
    static void Main()
    {
        Console.Write("Enter the size of the first array: ");
        int size = int.Parse(Console.ReadLine());
        byte[] array1 = new byte[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter {0} number: ", i);
            array1[i] = byte.Parse(Console.ReadLine());
        }

        Console.Write("Enter the size of the second array: ");
        size = byte.Parse(Console.ReadLine());
        byte[] array2 = new byte[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter {0} number: ", i);
            array2[i] = byte.Parse(Console.ReadLine());
        }

        byte[] resultAdd = Add(array1, array2);
        Console.WriteLine("The resulting number is : " + String.Join("", resultAdd));

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