using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("a before the exchange: " + a);
        Console.WriteLine("b before the exchange: " + b);
        /* a simple algorithm to swap values of variables without using 3rd variable */
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("a after the exchange: " + a);
        Console.WriteLine("b after the exchange: " + b);
    }
}

