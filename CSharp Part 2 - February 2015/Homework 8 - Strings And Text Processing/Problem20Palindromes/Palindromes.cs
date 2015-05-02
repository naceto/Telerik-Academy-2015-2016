using System;
using System.Text;

class Palindromes
{
	/* Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe. */
	public static void Main()
	{
		Console.Write("Enter the string containing palindromes: ");
		string text = Console.ReadLine();
		Console.Write(ExtractPalindromes(text));
	}

	static string ExtractPalindromes(string text)
	{

		string[] splitted = text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
		StringBuilder sb = new StringBuilder();
		for(int i = 0; i < splitted.Length; i++)
		{
			string word = splitted[i];
			int len = splitted[i].Length;
			int howMuch = len / 2;
			int counter = 0;
			for (int j = 0; j < howMuch; j++) 
			{
				if (word[j] == word[len - j - 1])
				{
					++counter;
				}
			}
			if (counter == howMuch)
			{
				sb.Append(word);
				sb.Append("\n");
			}
		}
		return sb.ToString();
	}
}
