using System;

class IndexOfLetters
{
    /* Write a program that creates an array containing all letters from the 
     * alphabet (A-Z). Read a word from the console and print the index of 
     * each of its letters in the array. 
     */
    static void Main()
    {
        // ASCII A - 65 -> z - 90
        int[] array = new int[26];
        for (int i = 0; i < 26; i++)
        {
            array[i] = 'A' + i;
        }

        Console.Write("Enter the letter you want to search: ");

        string word = Console.ReadLine();
        foreach (char l in word)
        {
            char letter = char.ToUpper(l);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == (int)letter)
                {
                    Console.Write("Index of letter {0} is {1}.\n", letter, i);
                }
            }
        }
    }
}
