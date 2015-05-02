using System;

class EnglishDigit
{
    /*Write a method that returns the last digit of given integer as an English word.*/
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("The last digit is: " + GetLastDigit(num));
    }

    static string GetLastDigit(int number)
    {
        string[] numbersString = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        int lastDigit = number % 10;
        return numbersString[lastDigit];   
    }
}
