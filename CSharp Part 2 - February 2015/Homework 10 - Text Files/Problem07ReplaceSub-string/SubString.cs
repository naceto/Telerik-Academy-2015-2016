using System;
using System.IO;
using System.Text;

class SubString
{
	/* Write a program that replaces all occurrences of the sub-string 
	 * start with the sub-string finish in a text file. 
	 * Ensure it will work with large files (e.g. 100 MB). 
	 */
	public static void Main()
	{
		string file = "..\\..\\Files\\text.txt";
		StreamReader sr = new StreamReader(file);
		StringBuilder sb = new StringBuilder();
		using (sr)
		{
			string line = string.Empty;
			while ((line = sr.ReadLine()) != null)
			{
				line = line.Replace("start", "finish");
				sb.Append(line);
				sb.Append("\n");
			}
		}

		StreamWriter sw = new StreamWriter(file);
		using (sw)
		{
			sw.Write(sb.ToString());
		}
	}
}

