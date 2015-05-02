using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class WholeWord
{
	/* Modify the solution of the previous problem to replace only whole words (not strings). */
	public static void Main()
	{
		const string file = "..\\..\\Files\\text.txt";
		StringBuilder sb = new StringBuilder();
		StreamReader sr = new StreamReader(file);
		using (sr)
		{
			string line;
			while ((line = sr.ReadLine()) != null)
			{
				line = line.ToLower();
				line =  Regex.Replace(line, @"\bstart\b", "finish");
				sb.Append(line);
			}
		}
		StreamWriter sw = new StreamWriter(file);
		using (sw)
		{
			sw.Write(sb.ToString());
		}
	}
}

