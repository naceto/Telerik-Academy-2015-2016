namespace Problem_6.Divisible_by_7_and_3
{
    using System;
    using System.Linq;
    /*
        Problem 6. Divisible by 7 and 3
        Write a program that prints from given array of integers all numbers that are 
        divisible by 7 and 3. Use the built-in extension methods and lambda expressions. 
        Rewrite the same with LINQ.
     */
    class MainMethod
    {
        static void Main()
        {
            int[] numbers = new int[100];

            for (int i = 0; i < 100; i++)
            {
                numbers[i] = i;
            }

            Console.WriteLine("With extension methods\n");
            var result = numbers.Where(num => num % 7 == 0 && num % 3 == 0);

            foreach (var num in result)
            {
                Console.Write("{0}, ", num);
            }
            Console.WriteLine();

            Console.WriteLine("\nWith LINQ query\n");
            result = from num in numbers
                     where num % 7 == 0 && num % 3 == 0
                     select num;

            foreach (var num in result)
            {
                Console.Write("{0}, ", num);
            }
            Console.WriteLine();
        }
    }
}
