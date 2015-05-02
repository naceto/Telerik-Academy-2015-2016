using System;

class BonusScore
{
    /* Write a program that applies bonus score to given score in the range [1…9] by the following rules:
        * If the score is between 1 and 3, the program multiplies it by 10.
        * If the score is between 4 and 6, the program multiplies it by 100.
        * If the score is between 7 and 9, the program multiplies it by 1000.
        * If the score is 0 or more than 9, the program prints “invalid score”.
     */
    static void Main()
    {
        Console.Write("Enter score: ");
        int score = int.Parse(Console.ReadLine());

        if (score <= 0 || score > 9)
        {
            Console.WriteLine("Invalid Score");
            return;
        }

        if (score >= 1 && score <=3)
        {
            score *= 10;
        }
        else if (score >= 4 && score <= 6)
        {
            score *= 100;
        }
        else if (score >= 7 && score <= 9)
        {
            score *= 1000;
        }
        Console.WriteLine(score);
    }
}