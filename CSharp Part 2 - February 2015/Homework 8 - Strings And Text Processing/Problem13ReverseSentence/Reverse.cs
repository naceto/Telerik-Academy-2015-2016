using System;
using System.Text;
using System.Collections.Generic;

class Reverse
{
	/* Write a program that reverses the words in given sentence. */
	public static void Main()
	{
		string text = "C# is not C++, not PHP and not Delphi!";
		Console.WriteLine(ReverseWords(text));
	}

	static string ReverseWords(string text)
	{
		string[] splitted = text.Split(new char[] { ',', '.', ' ', '!', '?', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
		StringBuilder sb = new StringBuilder();
		StringBuilder reversed = new StringBuilder();
		for(int i = 48; i <= 57; i++)
		{
			sb.Append((char)i);
		}
		for(int i = 65; i <= 90; i++)
		{
			sb.Append((char)i);
		}
		for(int i = 97; i <= 122; i++)
		{
			sb.Append((char)i);
		}
		sb.Append('+');
		sb.Append('#');

		Array.Reverse(splitted);
		string[] delimiters = text.Split(sb.ToString().ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
		for(int i = 0; i < splitted.Length; i++)
		{
			reversed.Append(splitted[i]);
			reversed.Append(delimiters[i]);
		}
		return reversed.ToString();
	}
}
