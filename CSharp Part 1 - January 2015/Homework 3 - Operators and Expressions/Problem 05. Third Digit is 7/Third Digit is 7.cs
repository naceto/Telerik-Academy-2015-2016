using System;

class thirdDigitIs7
{
    /* Write an expression that checks for given integer 
     * if its third digit from right-to-left is 7. */
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        bool isThirdNumberSeven = ((number / 100) % 10) == 7;
        Console.WriteLine(isThirdNumberSeven);

    }
}
