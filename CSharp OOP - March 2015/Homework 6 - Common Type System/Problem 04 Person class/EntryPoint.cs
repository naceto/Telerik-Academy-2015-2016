namespace Problem_04_Person_class
{
    using Problem_04_Person_class.Classes;
    using System;

    public class EntryPoint
    {
        static void Main()
        {
            Person p = new Person("Person1", null);
            Person p2 = new Person("Person2", 25);

            Console.WriteLine(p);
            Console.WriteLine(p2);
        }
    }
}
