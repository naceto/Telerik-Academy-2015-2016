using System;

class Forbidden
{
	/* We are given a string containing a list of forbidden words and a text containing some of these words.
	 * Write a program that replaces the forbidden words with asterisks.
 */
	public static void Main()
	{
		Console.Write("Enter the numer of forbidden words: ");
		int n = int.Parse(Console.ReadLine());
		string[] words = new string[n];
		for(int i = 0; i < n; i++)
		{
			Console.Write("Enter word {0}/{1}: ", i + 1, n);
			words[i] = Console.ReadLine();
		}
		Console.Write("Enter the text to replace forbidden words: ");
		string text = Console.ReadLine();
		Console.WriteLine(ReplaceForbidden(text, words));
	}
	static string ReplaceForbidden (string text, string[] words)
	{
		string newString = text;
		for(int i = 0; i < words.Length; i++)
		{
			newString = newString.Replace(words[i], new String('*', words[i].Length));
		}
		return newString;
	}
}
