using System;
using System.IO;
using System.Text;

class MainClass
{
	/* Write a program that extracts from given XML file all the text without the tags. */
	public static void Main()
	{
		const string filePath = "../../Files/xml.xml";
		System.Console.Write(ParseXML(filePath));

	}
	static string ParseXML(string filePath)
	{
		StreamReader sr = new StreamReader(filePath);
		string xml = string.Empty;
		using (sr)
		{
			xml = sr.ReadToEnd();
		}
		int index = xml.IndexOf("</");
		int i = index;
		StringBuilder sb = new StringBuilder();
		while (index != -1)
		{
			while (i >= 0 && xml[i] != '>')
			{
				--i;
			}
			if (i == 0 && xml[i] != '>')
			{
				break;
			}
			i++;
			string sub = xml.Substring(i, index - i);
			if (!string.IsNullOrWhiteSpace(sub))
			{
				sb.Append(sub);
				sb.Append("\n");
			}
			index = xml.IndexOf("</", index + 1);
			i = index;
		}
		return sb.ToString();
	}
}
