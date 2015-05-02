using System;

class gravitationOnTheMoon
{
    /* The gravitational field of the Moon is approximately 17% of that on the Earth.
     * Write a program that calculates the weight of a man on the moon by a given 
     * weight on the Earth. */
    static void Main()
    {
        Console.Write("Enter your weight: ");
        double weight = double.Parse(Console.ReadLine());
        double moonWeight = weight * 0.17;
        Console.WriteLine("Your weight on the moon would be {0} ", moonWeight);
    }
}
