using System;
using System.IO;

class OddLines
{
	/* Write a program that reads a text file and prints on the console its odd lines. */
	public static void Main()
	{
		bool isLinux = false;
		string filePath = "..\\..\\Files\\TextFile.txt";
		if (isLinux)
		{
			filePath = filePath.Replace('\\', '/');
		}

		OddLinesReader(filePath);
	}

	static void OddLinesReader (string file)
	{
		StreamReader sr = new StreamReader(file);
		using (sr)
		{
			string line = string.Empty;
			int count = 0;
			while ((line = sr.ReadLine()) != null)
			{
				++count;
				if (count % 2 == 0)
				{
					Console.WriteLine (line);
				}
			}
		}
	}
}
