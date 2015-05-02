using System;
using System.Text;

class Reverse
{
	/* Write a program that reads a string, reverses it and prints the result at the console. */
	public static void Main()
	{
		Console.Write("Enter a string please: ");
		string str = Console.ReadLine();
		str = ReverseString(str);
		Console.WriteLine("The reversed string is: {0}", str);
	}

	static string ReverseString (string str)
	{
		StringBuilder sb = new StringBuilder();
		for(int i = str.Length - 1; i >= 0; i--)
		{
			sb.Append(str[i]);
		}
		return sb.ToString();
	}
}
