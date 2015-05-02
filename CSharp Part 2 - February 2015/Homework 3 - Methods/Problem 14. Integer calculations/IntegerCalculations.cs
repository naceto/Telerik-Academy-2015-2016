using System;

class IntegerCalculations
{
    /* Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
     * Use variable number of arguments. */
    static void Main()
    {
        Console.Write("Enter the count of numbers: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter element {0}:", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("The minimum number is: " + Minimum(array));
        Console.WriteLine("The maximum number is: " + Maximum(array));
        Console.WriteLine("The Average of the numbers is: " + Average(array));
        Console.WriteLine("The sum of the numbers is: " + Sum (array));
        Console.WriteLine("The product of the numbers is: " + Product(array));
    }

    static int Product(params int[] numbers)
    {
        int product = 1;
        foreach (int num in numbers)
        {
            product *= num;
        }
        return product;
    }

    static int Sum(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }

    static double Average(params int[] numbers)
    {
        double average = 0;
        foreach (int num in numbers)
        {
            average += num;
        }
        return average / numbers.Length;
    }

    static int Maximum(params int[] numbers)
    {
        int max = numbers[0];
        foreach (var num in numbers)
        {
            max = Math.Max(max, num);
        }
        return max;
    }

    static int Minimum(params int[] numbers)
    {
        int min = numbers[0];
        foreach (var num in numbers)
        {
            min = Math.Min(min, num);
        }
        return min;
    }
}