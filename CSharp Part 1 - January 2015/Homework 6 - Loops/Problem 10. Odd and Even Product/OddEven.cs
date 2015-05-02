using System;

class OddEven
{
    /* You are given n integers (given in a single line, separated by a space).
     * Write a program that checks whether the product of the odd elements is 
     * equal to the product of the even elements. Elements are counted from 1 
     * to n, so the first element is odd, the second is even, etc. 
     */
    static void Main()
    {
        Console.Write("Please enter the numbers: ");
        string numStr = Console.ReadLine();
        string[] numArray = numStr.Split(' ');
        int odd = 1, even = 1;
        for (int i = 0; i < numArray.Length; i++)
        {
            if (i % 2 == 0) // even
            {
                even *= int.Parse(numArray[i]);
            }
            else // odd
            {
                odd *= int.Parse(numArray[i]);
            }
        }
        Console.WriteLine(even == odd ? "yes" : "no");
    }
}