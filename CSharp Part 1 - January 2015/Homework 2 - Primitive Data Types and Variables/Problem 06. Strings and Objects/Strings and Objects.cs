using System;

class Program
{
    static void Main()
    {
        string helloString = "Hello";
        string worldString = "World";
        object stringAsObject = helloString + " " + worldString;
        string objectAsString = (string)stringAsObject;
        Console.WriteLine(objectAsString);
    }
}
