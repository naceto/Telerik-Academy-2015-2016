using System;
using System.Text;

class Series
{
	/* Write a program that reads a string from the console and 
	 * replaces all series of consecutive identical letters with a single one. 
	 */
	public static void Main()
	{
		Console.Write("Enter text: ");
		string text = Console.ReadLine();
		Console.WriteLine(SeriesExtract(text));
	}

	static string SeriesExtract (string text)
	{
		StringBuilder sb = new StringBuilder ();
		char lastChar = text[0];
		sb.Append(text[0]);
		for (int i = 1; i < text.Length; i++) 
		{
			if (text[i] == lastChar)
			{
				continue;
			}
			lastChar = text[i];
			sb.Append(text[i]);
		}
		return sb.ToString();
	}
}