using System;

class Polynomials
{
    /* Write a method that adds two polynomials.
       Represent them as arrays of their coefficients.*/
    static void Main()
    {
        int[] polynomial1 = { -1, 123, 3};
        int[] polynomial2 = { 3, 1, 6 };

        Console.Write("The first polinominal is: ");
        PrintPolynominals(polynomial1);
        Console.Write("The second polinominal is: ");
        PrintPolynominals(polynomial2);
        Console.WriteLine();

        //add
        Console.WriteLine("Add: ");
        int[] result = AddSubstract(polynomial1, polynomial2, true);
        PrintPolynominals(result);
        Console.WriteLine();

        //substract
        Console.WriteLine("Substract: ");
        result = AddSubstract(polynomial1, polynomial2, false);
        PrintPolynominals(result);
        Console.WriteLine();

        // multiply
        Console.WriteLine("Multiply: ");
        result = Multiply(polynomial1, polynomial2);
        PrintPolynominals(result);
        Console.WriteLine();
    }

    static void PrintPolynominals (int[] p)
    {
        int pow = p.Length - 1;
        for (int i = 0; i < p.Length; i++)
        {
            int num = p[i];
            int abs = Math.Abs(num);
            if (num != 0)
            {
                if (i < p.Length)
                {
                    Console.Write(num >= 0 ? "+ " : "- ");
                }
                Console.Write((abs > 1 ? abs.ToString() : "") + (pow <= 0 ? "" : (pow == 1 ? "X" : "X^" + pow)) + " ");
            }
            --pow;
        }
        Console.WriteLine();
    }

    static int[] Multiply (int[] array1, int[] array2)
    {
        int size = array1.Length + array2.Length - 1;
        int[] result = new int[size];
        for (int i = 0; i < array1.Length; i++)
        {
            for (int j = 0; j < array2.Length; j++)
            {
                result[i + j] += array1[i] * array2[j];
            }
        }
        return result;
    }

    // `true` to add and `false` to substract
    static int[] AddSubstract(int[] array1, int[] array2, bool add)
    {
        int max = Math.Max(array1.Length, array2.Length);
        int a1Iter = array1.Length - 1;
        int a2Iter = array2.Length - 1;

        int[] result = new int[max];
        --max;
        while (max >= 0)
        {
            int p1 = 0;
            int p2 = 0;

            if (a1Iter >= 0)
            {
                p1 = array1[a1Iter--];

            }

            if (a2Iter >= 0)
            {
                p2 = array2[a2Iter--];
            }

            if (add)
            {
                result[max] = p1 + p2;
            }
            else
            {
                result[max] = p1 - p2;
            }
            --max;
        }
        return result;
    }

}