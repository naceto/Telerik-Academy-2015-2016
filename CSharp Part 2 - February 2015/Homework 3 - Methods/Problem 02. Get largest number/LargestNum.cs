using System;

class Program
{
    /* Write a method GetMax() with two parameters that returns the larger 
     * of two integers. Write a program that reads 3 integers from the console 
     * and prints the largest of them using the method GetMax(). */
    static void Main()
    {
        int[] numbers = new int[3];
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter number {0}: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int result = GetMax(numbers[0], numbers[1]);
        result = GetMax(result, numbers[2]);
        Console.WriteLine("The largest of the numbers is: {0}", result);
    }

    static int GetMax(int num1, int num2)
    {
        return (num1 > num2) ? num1 : num2;
    }
}
