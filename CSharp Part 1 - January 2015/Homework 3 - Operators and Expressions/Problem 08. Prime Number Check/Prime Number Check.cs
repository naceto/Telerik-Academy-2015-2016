using System;

class PrimeNumberCheck
{
    /* Write an expression that checks if given positive integer 
     * number n (n <= 100) is prime (i.e. it is divisible without 
     * remainder only to itself and 1). * Note: You should check 
     * if the number is positive */
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        if (num < 2 || num >= 100)
        {
            Console.WriteLine("Enter a number between 2 and 100");
            return;
        }

        bool isPrime = false;
        if (num == 2 || num == 3 || num == 5 || num == 7)
        {
            isPrime = true;
        }
        else if (num % 2 != 0 && num % 3 != 0 && num % 5 != 0 && num % 7 != 0)
        {
            isPrime = true;
        }
        Console.WriteLine("Is the number prime: {0}", isPrime);
    }
}