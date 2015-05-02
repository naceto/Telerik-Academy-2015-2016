using System;
using System.Text.RegularExpressions;

class Email
{
	/* Write a program for extracting all email addresses from given text.
	 * All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails. */
	public static void Main()
	{
		string regex = @"^([a-zA-Z0-9_\-][a-zA-Z0-9_\-\.]{0,49})" + @"@(([a-zA-Z0-9][a-zA-Z0-9\-]{0,49}\.)+[a-zA-Z]{2,4})$";
		Console.Write("Enter a string containing emails: ");
		string str = Console.ReadLine();
		char[] array = { ' ' };
		string[] spitted = str.Split(array, StringSplitOptions.RemoveEmptyEntries);
		for (int i = 0; i < spitted.Length; i++)
		{
			if (Regex.IsMatch(spitted[i],regex))
			{
				Console.WriteLine(spitted[i]);
			}
		}

	}
}
