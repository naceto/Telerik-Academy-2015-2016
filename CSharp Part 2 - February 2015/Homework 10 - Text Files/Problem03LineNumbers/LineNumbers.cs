using System;
using System.IO;

class MainClass
{
	/* Write a program that reads a text file and inserts line numbers in front of each of its lines.
	 * The result should be written to another text file. */
	public static void Main()
	{
        string filePath = "..\\..\\Files\\TextFile.txt";
		string output = "..\\..\\Files\\Output.txt";

		StreamReader sr = new StreamReader(filePath);
		StreamWriter sw = new StreamWriter(output);

		using (sr)
		{
			using (sw)
			{
				string line = String.Empty;
				int count = 0;
				while ((line = sr.ReadLine()) != null)
				{
					++count;
					sw.WriteLine(String.Format("{0,3}. {1}", count, line));
				}
			}
		}
	}
}

