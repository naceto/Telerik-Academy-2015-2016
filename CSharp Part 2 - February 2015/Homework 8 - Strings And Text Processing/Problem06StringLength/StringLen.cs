using System;

class StringLen
{
	/* Write a program that reads from the console a string of maximum 20 characters. 
	 * If the length of the string is less than 20, the rest of the characters 
	 * should be filled with *. Print the result string into the console. */
	public static void Main()
	{
		string text = string.Empty;
		do
		{
			Console.Write("Enter a string that is at most 20 chars long: ");
			text = Console.ReadLine();
			if (text.Length > 20)
			{
				Console.Write ("This string is {0} characters long. Try again.\n", text.Length);
			}
		}
		while (text.Length > 20);
		Console.WriteLine("{0}", text.PadRight(20, '*'));
	}
}
