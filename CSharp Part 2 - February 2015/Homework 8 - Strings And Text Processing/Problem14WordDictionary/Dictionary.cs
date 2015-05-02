using System;

class Dictionary
{
	/* A dictionary is stored as a sequence of text lines containing words and their explanations.
	 * Write a program that enters a word and translates it by using the dictionary. */
	static string[] dic = new string[] 
	{
		".NET - platform for applications from Microsoft",
		"CLR - managed execution environment for .NET" ,
		"namespace - hierarchical organization of classes",
		"whatever - whatever",
		"doge - wow",
		"wow - doge"
	};
	public static void Main()
	{
		Console.Write("Enter a word: ");
		string word = Console.ReadLine();
		System.Console.WriteLine(Translate(word));
	}
	static string Translate (string word)
	{
		for(int i = 0; i < dic.Length; i++)
		{ 
			int hasIt = dic[i].IndexOf(word);
			if(hasIt != -1)
			{
				int separatorIndex = dic[i].IndexOf('-', hasIt);
				if(separatorIndex != -1)
				{
					return dic[i].Substring(hasIt + word.Length + 3);
				}
			}
		}
		return "Not in the Dictionary";
	}
}
