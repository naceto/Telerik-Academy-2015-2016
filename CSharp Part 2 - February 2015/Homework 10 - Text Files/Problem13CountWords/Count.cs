using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;


class Count
{
	/* Write a program that reads a list of words from the file words.txt 
	 * and finds how many times each of the words is contained in another file test.txt.
	 * The result should be written in the file result.txt and the words should be 
	 * sorted by the number of their occurrences in descending order.
	 * Handle all possible exceptions in your methods. */
	public static void Main()
	{
		const string words = "..\\..\\Files\\words.txt";
		const string test = "..\\..\\Files\\test.txt";

		try
		{
			string[] list = ReadList(words);
			string testStr = ReadFile (test);
			string result = CountWords(list, testStr);
			Console.WriteLine (result);
		}
		catch (Exception ex)
		{
			Console.WriteLine (ex.Message);
		}
	}

	static string CountWords (string[] list, string test)
	{
		var dic = new Dictionary<string, int>();
		try
		{
			for (int i = 0; i < list.Length; i++) 
			{
				string word = @"\b" + list[i] + @"\b";
				Regex r = new Regex(word, RegexOptions.IgnoreCase);
				Match m = r.Match(test);
				if (m.Success)
				{
					dic.Add(list[i], 0);
				}
				while (m.Success)
				{
					++dic[list[i]];
					m = m.NextMatch();
				}
			}
		}
		catch (ArgumentNullException ex)
		{
			Console.WriteLine(ex.Message);
		}
		return DicToString(SortDictionary(dic, list));
	}

	static Dictionary<string, int> SortDictionary (Dictionary<string, int> dic, string[] words)
	{
		var newDic = new Dictionary<string, int>();
		while (dic.Keys.Count > 0)
		{
			int bestValue = 0;
			string word = string.Empty;
			foreach(var w in words)
			{
				if (dic.ContainsKey(w) && dic[w] > bestValue )
				{
					bestValue = dic[w];
					word = w;
				}
			}
			if(!string.IsNullOrEmpty(word))
			{
				newDic.Add(word, bestValue);
				dic.Remove(word);
			}
		}
		return newDic;
	}

	static string DicToString(Dictionary<string, int> dic)
	{
		return String.Join("\n", dic);
	}

	static string ReadFile (string fileName)
	{
		string words = string.Empty;
		try
		{
			using (StreamReader sr = new StreamReader(fileName))
			{
				words = sr.ReadToEnd();
			}
		}
		catch (IOException ex)
		{
			Console.WriteLine("Exception in ReadFile()");
			Console.WriteLine(ex.Message);
		}
		return words;
	}

	static string[] ReadList (string fileName)
	{

		string[] split;
		try 
		{
			string text = ReadFile(fileName);
			split = text.Split(new char[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);
		}
		catch (Exception ex)
		{
			throw ex;
		}
		return split;
	}
}
