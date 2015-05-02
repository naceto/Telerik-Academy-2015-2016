using System;

class PrintADeck
{
    /* Write a program that generates and prints all possible cards from a standard 
     * deck of 52 cards (without the jokers). The cards should be printed using the 
     * classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
     * The card faces should start from 2 to A.Print each card face in its four possible 
     * suits: clubs, diamonds, hearts and spades. 
     * Use 2 nested for-loops and a switch-case statement. 
     */
    static void Main()
    {
        for (int i = 2; i <= 14; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                char cardFace;
                string cardSuit = null;
                switch (i)
                {
                    case 11:
                        cardFace = 'J';
                        break;
                    case 12:
                        cardFace = 'Q';
                        break;
                    case 13:
                        cardFace = 'K';
                        break;
                    case 14:
                        cardFace = 'A';
                        break;
                    default:
                        cardFace = (char)(i + (int)'0');
                        break;
                }
                switch (j)
                {
                    case 1:
                        cardSuit = "spades";
                        break;
                    case 2:
                        cardSuit = "clubs";
                        break;
                    case 3:
                        cardSuit = "hearts";
                        break;
                    case 4:
                        cardSuit = "diamonds";
                        break;
                }
                Console.Write("{0} of {1}", cardFace, cardSuit);
                if (j != 4)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}
