using System;
using System.IO;

class MainClass
{
	/* Write a program that compares two text files line by line and prints the 
	 * number of lines that are the same and the number of lines that are different.
	 * Assume the files have equal number of lines. */
	public static void Main(string[] args)
	{
		Console.Write("Enter the path to the first file: ");
		string firstFile= Console.ReadLine();

		Console.Write("Enter the path to the second file: ");
		string secondFile = Console.ReadLine();

		StreamReader sr = new StreamReader(firstFile);
		StreamReader sr2 = new StreamReader(secondFile);

		int sameLines = 0;
		int differentLines = 0;
		using (sr)
		{
			using (sr2)
			{
				string line1 = sr.ReadLine();
				string line2 = sr2.ReadLine();
				while ((line1 != null) || (line2 != null))
				{
					if (String.Compare(line1, line2) == 0)
					{
						++sameLines;
					}
					else
					{
						++differentLines;
					}
					line1 = sr.ReadLine();
					line2 = sr2.ReadLine();
				}
			}
		}
		Console.WriteLine("The files have {0} lines that are the same and {1} lines that are different.", sameLines, differentLines);
	}
}

