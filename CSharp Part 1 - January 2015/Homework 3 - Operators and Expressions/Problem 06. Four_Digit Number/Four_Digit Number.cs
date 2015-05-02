using System;

class fourDigitNumber
{
    /* Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
     * Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
     * Prints on the console the number in reversed order: dcba (in our example 1102).
     * Puts the last digit in the first position: dabc (in our example 1201).
     * Exchanges the second and the third digits: acbd (in our example 2101).
     * The number has always exactly 4 digits and cannot start with 0. */
    static void Main()
    {
        Console.Write("Enter a four-digit number: ");
        int fourDigitNum = int.Parse(Console.ReadLine());
        int firstNum = fourDigitNum / 1000;
        int secoundNum = (fourDigitNum / 100) % 10;
        int thirdNum = (fourDigitNum / 10) % 10;
        int fourthNum = fourDigitNum % 10;
        Console.WriteLine("Sum of the digits: {0}", firstNum + secoundNum + thirdNum + fourthNum);
        Console.WriteLine("Reversed: {3}{2}{1}{0}", firstNum, secoundNum, thirdNum, fourthNum);
        Console.WriteLine("Last digit in front: {3}{0}{1}{2}", firstNum, secoundNum, thirdNum, fourthNum);
        Console.WriteLine("Secound and third digit exchanged: {0}{2}{1}{3}", firstNum, secoundNum, thirdNum, fourthNum);
    }
}
    
