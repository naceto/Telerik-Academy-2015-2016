using System;

class SayHello
{
    /* Write a method that asks the user for his name and prints “Hello, <name>”
     * Write a program to test this method. 
     */
    static void Main()
    {
        PrintHello();
    }

    static void PrintHello()
    {
        Console.Write("Type in your name: ");
        Console.WriteLine("Hello, " + Console.ReadLine() + ".");
        Console.WriteLine("Have a nice day fellow programmer.");
    }

}
