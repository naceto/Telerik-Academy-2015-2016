using System;

class CorrectBrackets
{
	/* Write a program to check if in a given expression the brackets are put correctly. */
	public static void Main()
	{
		Console.Write("Enter a stirng: ");
		string str = Console.ReadLine();
		Console.WriteLine(CheckBrackets(str) == false ? "Incorrect" : "Correct");

	}

	static bool CheckBrackets (string str)
	{
		int openingBracketsCounter = 0;
		int closingBracketsCounter = 0;
		for(int i = 0; i < str.Length; i++)
		{
			if(str[i] == '(')
			{
				++openingBracketsCounter;
			}
			else
			if(str[i] == ')')
			{
				// we have closing bracket but we dont a opening bracket, this covers the case: )(a + b)(, where
				// the number of brackets are equal but they are not in the right order
				if (openingBracketsCounter - closingBracketsCounter <= 0)
				{
					return false;
							}
				else
				{
					++closingBracketsCounter;
				}
			}
		}
		return openingBracketsCounter == closingBracketsCounter;
	}
}
