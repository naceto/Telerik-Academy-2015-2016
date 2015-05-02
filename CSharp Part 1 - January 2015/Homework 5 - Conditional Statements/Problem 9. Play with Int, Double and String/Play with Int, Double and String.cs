using System;

class Play
{
    /* Write a program that, depending on the user’s choice, inputs an int, double or string variable.
     * If the variable is int or double, the program increases it by one.
     * If the variable is a string, the program appends * at the end.
     * Print the result at the console. Use switch statement. 
     */
    static void Main()
    {
        Console.Write("Enter 1 for int, 2 for double and 3 for string: ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1: // int
                Console.Write("Enter a int: ");
                int numberInt = int.Parse(Console.ReadLine());
                Console.WriteLine(++numberInt);
                break;
            case 2: // double
                Console.Write("Enter a double: ");
                double numberDouble = double.Parse(Console.ReadLine());
                Console.WriteLine(++numberDouble);
                break;
            case 3: // string
                Console.Write("Enter a string: ");
                string str = Console.ReadLine();
                Console.WriteLine(str + '*');
                break;
        }
    }
}