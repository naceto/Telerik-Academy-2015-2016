using System;
using System.IO;

class MainClass
{
	/* Write a program that reads a text file containing a list of strings, 
	 * sorts them and saves them to another text file. 
	 */	
	public static void Main()
	{
		const string input = "..\\..\\Files\\input.txt";
		const string output = "..\\..\\Files\\input.txt";
		StreamReader sr = new StreamReader(input);
		string text = string.Empty;
		using (sr)
		{
			text = sr.ReadToEnd();
		}

		string[] splited = text.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
		Array.Sort(splited);
		StreamWriter sw = new StreamWriter(output);
		using (sw)
		{
			for(int i = 0; i < splited.Length; i++)
			{
				sw.Write(splited[i]);
				if (i < splited.Length - 1)
				{
					sw.Write("\n");
				}
			}
		}
	}
}

