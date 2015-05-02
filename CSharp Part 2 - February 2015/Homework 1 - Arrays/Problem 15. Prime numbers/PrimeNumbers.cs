using System;

class PrimeNumbers
{
    /* Write a program that finds all prime numbers in the range 
     * [1...10 000 000]. Use the Sieve of Eratosthenes algorithm. 
     */
    static void Main()
    {
        int n = 10000000;
        bool[] primeNumbers = new bool[n + 1];
        for (int i = 0; i < n; i++)
        {
            primeNumbers[i] = true;
        }

        int sqrt = (int)Math.Ceiling (Math.Sqrt(n));
        for (int i = 2; i < sqrt; i++)
        {
            if (primeNumbers[i] == true)
            {
                for (int j = i * i; j < n; j += i)
                {
                    primeNumbers[j] = false;
                }
            }
        }

        for (int i = 2; i < n; i++)
        {
            if (primeNumbers[i] == true)
            {
                Console.WriteLine(i);
            }
        }

    }
}
