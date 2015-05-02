using System;
using System.Text;


class BinToHexClass
{
	/* Write a program to convert binary numbers to hexadecimal numbers (directly). */
	public static void Main()
	{
		Console.WriteLine(BinToHex("101010"));
	}

	static string BinToHex(string bin)
	{
		StringBuilder hex = new StringBuilder();;
		for(int i = bin.Length - 1; i >= 0; i -= 4)
		{
			int num = 0;
			int pow = 0;
			for (int j = 0; j < 4; j++) 
			{
				if (i - j >= 0)
				{
					int digit = bin[i - j] - '0';
					num += digit * (int)Math.Pow(2, pow);
				}
				pow++;
			}
			hex.Insert(0, GetHEXChars((uint)num));
		}
		return hex.ToString();
	}

	static char GetHEXChars(uint num)
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
		return '0';
	}
}
