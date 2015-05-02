using System;
using System.IO;
using System.Text.RegularExpressions;

class RemoveWords
{
	/* Write a program that removes from a text file all words listed in given another text file.
	 * Handle all possible exceptions in your methods. 
	 */
	public static void Main()
	{
		const string inputFile = "..\\..\\Files\\inputWords.txt";
		const string whereToRemoveFile = "..\\..\\Files\\text.txt";

		try
		{
			string input = string.Empty;
			using (StreamReader srInput = new StreamReader(inputFile))
			{
				input = srInput.ReadToEnd();
			}
			string toRemove = string.Empty;
            using (StreamReader srTR = new StreamReader(whereToRemoveFile))
			{
				toRemove = srTR.ReadToEnd();
			}

			string[] inputSplit = input.Split(new char[] { ' ', '\n', '\t', '\r' }, StringSplitOptions.RemoveEmptyEntries);

			for(int i = 0; i < inputSplit.Length; i++)
			{
				string word = inputSplit[i];
				string regexStr = @"(\b" + word + @"\b)";
				Regex r = new Regex(regexStr, RegexOptions.IgnoreCase);
				toRemove = r.Replace(toRemove, string.Empty);
			}

            using (StreamWriter sw = new StreamWriter(whereToRemoveFile))
			{
				sw.Write(toRemove);
			}
		}
		catch (IOException ex)
		{
			Console.WriteLine("An error occurred while processing the file: {0}.", ex.Message);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}
}

