using System;
using System.IO;
using System.Text.RegularExpressions;

class Prefix
{
	/* Write a program that deletes from a text file all words that start with the prefix test.
	 * Words contain only the symbols 0…9, a…z, A…Z, _. */
	public static void Main()
	{
		const string filePath = "..\\..\\Files\\text.txt";
		StreamReader sr = new StreamReader(filePath);
		string text = string.Empty;
		using (sr)
		{
			text = sr.ReadToEnd();
		}
		Regex rx = new Regex("test([A-Za-z0-9_])\\w*", RegexOptions.IgnoreCase);
		text = rx.Replace(text, string.Empty);

		var sw = new StreamWriter(filePath);
		using (sw)
		{
			sw.Write(text);
		}
	}
}
