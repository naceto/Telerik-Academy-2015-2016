using System;
using System.IO;

class MainClass
{
	/* Write a program that concatenates two text files into another text file. */
	public static void Main()
	{
		/* if using windows set this bool to false (I'm using MonoDevelop) P.S. Hope it works :D */
		bool isLinux = false;

		/* windows */
		string fileName1 = "..\\..\\Files\\TextFile1.txt";
		string fileName2 = "..\\..\\Files\\TextFile2.txt";
		string output = "..\\..\\Files\\Output.txt";

		if (isLinux)
		{
			fileName1 = ToLinuxPath(fileName1);
			fileName2 = ToLinuxPath(fileName2);
			output = ToLinuxPath(output);
		}
		var sr1 = new StreamReader(fileName1);
		var sr2 = new StreamReader(fileName2);
		var sw = new StreamWriter(output);

		using (sr1)
		{
			using (sr2)
			{
				using (sw)
				{
					string text1 = sr1.ReadToEnd();
					string text2 = sr2.ReadToEnd();
					sw.Write(text1 + text2);
				}
			}
		}
		var sr = new StreamReader(output);
		using (sr)
		{
			Console.WriteLine (sr.ReadToEnd());
		}
	}

	static string ToLinuxPath (string path)
	{
		return path.Replace('\\', '/');
	}
}
