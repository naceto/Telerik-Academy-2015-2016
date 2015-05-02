using System;
using System.Text;

class MultiTo
{
	/* Write a program to convert from any numeral system of given
	 * base s to any other numeral system of base d (2 ≤ s, d ≤ 16). */
	public static void Main()
	{

		Console.Write("Enter from base: ");
		int s = int.Parse(Console.ReadLine());

		Console.Write("Enter to base: ");
		int d = int.Parse(Console.ReadLine());

		Console.Write("Enter the number: ");
		string number = Console.ReadLine();
		number = number.ToUpper();
		Console.WriteLine("{0}({1}) = {2}({3})",number, s, Convert(number, s, d), d);
	}

	
	static string Convert (string str, int from, int to)
	{
		int number = 0;
		if (from > 10)
		{
			number = ToDecimal(str, from);
		}
		else
		{
			number = int.Parse(str);
		}

		return ToSpecific(number, to);
	}

	static int ToDecimal (string num, int from)
	{
		int result = 0;
		for(int i = num.Length - 1, pow = 0; i >= 0; i--, pow++)
		{
			int digit = GetHEXNums(num[i]);
			result += digit * (int)Math.Pow(from, pow);
		}
		return result;
	}

	// number is expected in int numberical system
	static string ToSpecific (int number, int to)
	{
		bool minus = false;
		if (number < 0)
		{
			minus = true;
			number = Math.Abs(number);
		}
		StringBuilder finalNumer = new StringBuilder();
		while (number > 0)
		{
			int remainder = number % to;
			number /= to;
			finalNumer.Insert(0, GetHEXChars(remainder));
		}
		if (minus)
		{
			finalNumer.Insert(0, '-');
		}
		return finalNumer.ToString();
	}


	static int GetHEXNums(char hex)
	{
		if(hex >= 48 && hex <= 57)
		{
			return hex - '0';
		}
		else
		{
			switch(hex)
			{
				case 'A': 
				return 10;
				case 'B':
				return 11;
				case 'C': 
				return 12;
				case 'D':
				return 13;
				case 'E':
				return 14;
				case 'F':
				return 15;
			}
		}
		return -1;
	}

	static char GetHEXChars(int num)
	{
		if(num >= 0 && num < 10)
		{
			return (char)(num + '0');
		}
		else
		{
			switch(num)
			{
				case 10: 
				return 'A';
				case 11:
				return 'B';
				case 12: 
				return 'C';
				case 13:
				return 'D';
				case 14:
				return 'E';
				case 15:
				return 'F';
			}
		}
		return 'X';
	}

}

