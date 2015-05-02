using System;
using System.Text;

class Extract
{
	/* Write a program that extracts from a given text all sentences containing given word. */
	public static void Main()
	{
		Console.Write("Enter the word: ");
		string word = Console.ReadLine();
		Console.Write("Enter the text: ");
		string text = Console.ReadLine();
		Console.WriteLine(ExtractS(text, word));
	}

	static string ExtractS (string text, string word)
	{
		string[] splitted = text.Split('.');
		StringBuilder sb = new StringBuilder();
		string newWord = " " + word + " ";
		for(int i = 0; i < splitted.Length; i++)
		{
			if (splitted[i].IndexOf(newWord) >= 0)
			{
				sb.Append(splitted[i]);
				sb.Append(".");
			}
		}
		return sb.ToString();
	}
}
