using System;

class MainClass
{
	/* Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
	 * reads its contents and prints it on the console.
	 * Find in MSDN how to use System.IO.File.ReadAllText(…).
	 * Be sure to catch all possible exceptions and print user-friendly error messages. 
	 */
	public static void Main()
	{
		Console.WriteLine("Enter a file path: ");
		string filePath = Console.ReadLine();
		try
		{
			string text = System.IO.File.ReadAllText(filePath);
			Console.WriteLine(text);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}
}

