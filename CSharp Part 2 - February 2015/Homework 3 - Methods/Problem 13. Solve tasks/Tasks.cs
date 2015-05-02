using System;

class Tasks
{
    /* * Write a program that can solve these tasks:
            Reverses the digits of a number
            Calculates the average of a sequence of integers
            Solves a linear equation a * x + b = 0
       * Create appropriate methods.
       * Provide a simple text-based menu for the user to choose which task to solve.
       * Validate the input data:
            The decimal number should be non-negative
            The sequence should not be empty
            a should not be equal to 0 */
    static void Main()
    {
        Console.WriteLine("Hello please choose what you want to do:");
        Console.WriteLine("1 - Reverse digits in a number.");
        Console.WriteLine("2 - Find out the average value of a number sequence.");
        Console.WriteLine("3 - Solve linear equation a*x + b = 0.");
        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine();
        switch (choice)
        {
            case 1:
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());
                if (number <= 0)
                {
                    Console.WriteLine("The number has to be non-negative.");
                    break;
                }
                Console.WriteLine("The reversed number is: {0}", ReverseDigits(number));
                break;
            case 2:
                Console.Write("Enter the size of the sequence: ");
                int size = int.Parse(Console.ReadLine());
                if (size <= 0)
                {
                    Console.WriteLine("The sequence has to be at least 1 elements long.");
                    break;
                }
                int[] sequence = new int[size];
                FillArray(sequence);
                double average = Average(sequence);
                Console.WriteLine("The average of the sequence is: " + average);
                break;
            case 3:
                Console.Write("Enter a: ");
                int a = int.Parse(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine("a cannot be 0.");
                    break;
                }
                Console.Write("Enter b: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("The result is: " + LinearEquation(a, b));

                break;
            default:
                Console.WriteLine("The choice you made is not valid.");
                break;
        }
    }
    
    static void FillArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter number {0}: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
    }

    static int ReverseDigits(int number)
    {
        int reversed = 0;
        while (number > 0)
        {
            reversed += number % 10;
            number /= 10;
            if (number != 0)
            {
                reversed *= 10;
            }
        }
        return reversed;
    }

    static double Average(int[] numbers)
    {
        double average = 0;
        foreach (int n in numbers)
        {
            average += n;
        }
        return average / numbers.Length;
    }

    // a * x + b = 0
    static int LinearEquation(int a, int b)
    {
        return -b / a;
    }


}
