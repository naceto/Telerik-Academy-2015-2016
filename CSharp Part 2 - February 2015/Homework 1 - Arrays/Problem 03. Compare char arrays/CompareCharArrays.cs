using System;

class CompareCharArrays
{
    static void Main()
    {
        Console.Write("Enter the size of the first array: ");
        int size = int.Parse (Console.ReadLine());
        char[] array1 = new char[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter {0}/{1} character: ", i + 1, size);
            array1[i] = char.Parse(Console.ReadLine());
        }

        Console.Write("Enter the size of the second array: ");
        size = int.Parse(Console.ReadLine());
        char[] array2 = new char[size];
        for (int i = 1; i <= size; i++)
        {
            Console.Write("Enter {0}/{1} number: ", i, size);
            array2[i - 1] = char.Parse(Console.ReadLine());
        }

        if (array1.Length != array2.Length)
        {
            Console.WriteLine("The arrays are with different size so they are not equal.");
            return;
        }

        for (int i = 0; i < array1.Length; i++)
        {
            Console.Write("{0}", array1[i]);
            if (array1[i] == array2[i])
            {
                Console.Write(" = ");
            }
            else if (array1[i] > array2[i])
            {
                Console.Write(" > ");
            }
            else
            {
                Console.Write(" < ");
            }
            Console.WriteLine("{0}", array2[i]);
        }
    }
}
