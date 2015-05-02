using System;

class Compare
{
    /* Write a program that reads two integer arrays 
     * from the console and compares them element by element. 
     */
    static void Main()
    {
        Console.Write("Enter the size of the first array: ");
        int size = int.Parse (Console.ReadLine());
        int[] array1 = new int[size];
        for (int i = 1; i <= size; i++)
        {
            Console.Write("Enter {0}/{1} number: ", i, size);
            array1[i - 1] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter the size of the second array: ");
        size = int.Parse(Console.ReadLine());
        int[] array2 = new int[size];
        for (int i = 1; i <= size; i++)
        {
            Console.Write("Enter {0}/{1} number: ", i, size);
            array2[i - 1] = int.Parse(Console.ReadLine());
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
