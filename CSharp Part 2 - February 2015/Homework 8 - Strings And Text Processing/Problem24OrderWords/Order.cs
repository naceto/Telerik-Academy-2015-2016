using System;

class Order
{
	/* Write a program that reads a list of words, 
	 * separated by spaces and prints the list in an alphabetical order. */
	public static void Main()
	{
		Console.Write("Enter the string: ");
		string text = Console.ReadLine();
		Console.WriteLine(Sort (text));
	}
	static string Sort(string text)
	{
		string[] splitted = text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
		Array.Sort(splitted);
		return String.Join(" ", splitted);
	}
}

