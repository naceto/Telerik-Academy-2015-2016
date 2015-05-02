using System;

class Program
{
    static void Main()
    {
        int? someNullInt = null;
        double? someNullDouble = null;
        Console.WriteLine("someNullInt: " + someNullInt);
        Console.WriteLine("someNullDouble: " + someNullDouble);
        someNullInt = 6;
        someNullDouble = 5.766;
        Console.WriteLine("someNullInt: " + someNullInt);
        Console.WriteLine("someNullDouble: " + someNullDouble);
    }
}

