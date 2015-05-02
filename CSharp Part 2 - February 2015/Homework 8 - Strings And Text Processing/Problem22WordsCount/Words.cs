using System;
using System.Collections.Generic;
using System.Text;

class Words
{
	/* Write a program that reads a string from the console and lists all different 
	 * words in the string along with information how many times each word is found. 
	 */
	public static void Main()
	{
		Console.Write("Enter text: ");
		string text = Console.ReadLine();
		Console.Write(WordsCounter(text));
	}

	static string WordsCounter (string text)
	{
		Dictionary<string, int> kvp = new Dictionary<string, int>();
		string[] splitted = text.Split(new char[] { ' ', '.', ',', '\t', '\n', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
		for(int i = 0; i < splitted.Length; i++)
		{
			if (kvp.ContainsKey(splitted[i]))
			{
				++kvp[splitted[i]];
			}
			else
			{
				kvp.Add(splitted[i], 1);
			}
		}
		StringBuilder sb = new StringBuilder();
		foreach(var item in kvp)
		{
			string s = string.Format("{0} - found {1} times\n", item.Key, item.Value);
			sb.Append(s);
		}
		return sb.ToString();
	}
}

