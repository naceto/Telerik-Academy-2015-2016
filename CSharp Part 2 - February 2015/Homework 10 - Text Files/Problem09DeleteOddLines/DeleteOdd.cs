using System;
using System.IO;
using System.Text;

class DeleteOdd
{
	/* Write a program that deletes from given text file all odd lines.
	 * The result should be in the same file. 
	 */
	public static void Main()
	{
		const string file = "..\\..\\Files\\text.txt";
		StreamReader sr = new StreamReader(file);
		StringBuilder sb = new StringBuilder();
		using (sr) 
		{
			string line = string.Empty;
			int counter = 0;
			bool firstLine = true;
			while ((line = sr.ReadLine()) != null)
			{
				++counter;
				if (counter % 2 == 0)
				{
					if(firstLine)
					{
						firstLine = false;
					}
					else
					{
						sb.Append('\n');
					}
					sb.Append(line);
				}
			}
		}
		StreamWriter sw = new StreamWriter(file);
		using (sw)
		{
			sw.Write(sb.ToString());
		}
	}
}
