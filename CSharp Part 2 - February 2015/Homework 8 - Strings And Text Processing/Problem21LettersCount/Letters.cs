using System;
using System.Text;

class Letters
{
	/* Write a program that reads a string from the console and prints all 
	 * different letters in the string along with information how many times 
	 * each letter is found. */
	public static void Main()
	{
		Console.Write("Enter text: ");
		string text = Console.ReadLine();
		Console.Write(LettersCount(text));
	}

	static string LettersCount (string text)
	{
		int[] letters = new int[256];
		for (int i = 0; i < text.Length; i++) 
		{
			++letters[(int)text[i]];
		}
		StringBuilder sb = new StringBuilder ();
		for (int i = 0; i < 256; i++) 
		{
			if (letters[i] == 0)
			{
				continue;
			}
			string s = string.Format("{0} - {1} times found\n", (char)i, letters[i]);
			sb.Append(s);
		}
		return sb.ToString();
	}
}
