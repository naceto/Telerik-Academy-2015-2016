using System;

class checkABitAtGivenPosition
{
    /* Write a Boolean expression that returns if the bit at position p 
     * (counting from 0, starting from the right) in given integer number n, has value of 1.
     */
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Enter the position of the bit: ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine(((num & (1 << p)) >> p) == 1 ? true : false);
    }
}
