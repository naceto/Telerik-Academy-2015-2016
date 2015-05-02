using System;

class Program
{
    static void Main()
    {
        string someString1 = "The \"use\" of quotations causes difficulties.";
        string someString2 = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine("someString1: " + someString1);
        Console.WriteLine("someString2: " + someString2);
    }
}

