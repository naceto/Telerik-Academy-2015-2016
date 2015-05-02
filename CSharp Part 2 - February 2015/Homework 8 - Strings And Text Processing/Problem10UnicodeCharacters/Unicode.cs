using System;
using System.Text;

class Unicode
{
	/* Write a program that converts a string to a sequence of C# Unicode character literals.
	 * Use format strings. */
	public static void Main()
	{
		Console.WriteLine("Enter a string: ");
		string text = Console.ReadLine();
		System.Console.WriteLine(StringToUnicode(text));
	}

	static string StringToUnicode(string text)
	{
		StringBuilder sb = new StringBuilder();
		for(int i = 0; i < text.Length; i++)
		{
			sb.AppendFormat("\\u{0:X4}", (int)text[i]);
		}
		return sb.ToString();
	}
}