using System;

class CheckForAPlayCard
{
    /* 
     * Classical play cards use the following signs to designate the card face:
     * `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters 
     * a string and prints “yes” if it is a valid card sign or “no” otherwise.
     */
    static void Main()
    {
        Console.Write("Enter a sign: ");
        string signStr = Console.ReadLine();
        int signInt;
        if (!int.TryParse(signStr, out signInt))
        {
            signInt = signStr[0];
        }
        switch (signInt)
        {
            case 2: 
            case 3:
            case 4:
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
            case 65:
            case 74:
            case 75:
            case 81:
                Console.WriteLine("yes");
                break;
            default:
                Console.WriteLine("no");
                break;
        }
    }
}
