using System;

class SubString
{
	/* Write a program that finds how many times a sub-string is 
	 * contained in a given text (perform case insensitive search). */
	public static void Main()
	{
		Console.Write("Enter text: ");
		string text = Console.ReadLine();
		Console.Write("Enter the sub-string: ");
		string subStr = Console.ReadLine();
		Console.WriteLine("The result is: {0}", NumberOfOccurrences(text, subStr));
	}

	static int NumberOfOccurrences (string text, string what)
	{
		int index = 0;
		int counter = 0;
		int startFrom = 0;
		do
		{
			index = text.IndexOf(what, startFrom);
			if(index > 0)
			{
				++counter;
				startFrom = index + 1;
			}
		} while  (index >= 0);
		return counter;
	}
}
