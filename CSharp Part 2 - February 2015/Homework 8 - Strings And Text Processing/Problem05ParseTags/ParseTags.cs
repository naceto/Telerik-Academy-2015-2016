using System;
using System.Text;

class Tags
{
	/* You are given a text. Write a program that changes the text in all regions 
	 * surrounded by the tags <upcase> and </upcase> to upper-case.
	 * The tags cannot be nested. 
	 */
	public static void Main()
	{
		Console.Write("Enter text: ");
		string text = Console.ReadLine();
		Console.WriteLine(ToUpper(text));
	}
	static string ToUpper (string text)
	{
		const string openingTag = "<upcase>";
		const string closingTag = "</upcase>";
		int startIndex = 0;
		int start = text.IndexOf(openingTag);
		int end = text.IndexOf(closingTag);
		StringBuilder sb = new StringBuilder();
		while (start != -1 && end != -1)
		{
			sb.Append(text, startIndex, start - startIndex);
			int upperStart = start + openingTag.Length;
			string upper = text.Substring(upperStart, end - upperStart).ToUpper();
			sb.Append(upper);
			startIndex = end + closingTag.Length;
			int lastEnd = end;
			start = text.IndexOf(openingTag, start + 1);
			end = text.IndexOf(closingTag, end + 1);
			if (start < 0 || end < 0)
			{
				lastEnd += closingTag.Length;
				sb.Append(text, lastEnd, text.Length - lastEnd);
			}
		}
		return sb.ToString();
	}
}
