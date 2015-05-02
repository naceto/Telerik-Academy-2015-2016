using System;
using System.Text;

class DecToHexClass
{
	/* Write a program to convert decimal numbers to their hexadecimal representation. */
	public static void Main()
	{
		Console.Write("Enter a decimal number to be converted to hex: ");
		int dec = int.Parse(Console.ReadLine());
		Console.WriteLine("{0}(DEC) = {1}(HEX)", dec, DecToHex(dec));
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

	static string DecToHex(int dec)
	{
		uint numToConvert = (uint)dec;
		if (dec < 0)
		{
			numToConvert = (uint)(uint.MaxValue + dec  + 1);
		}

		StringBuilder hex = new StringBuilder();
		while (numToConvert > 0)
		{
			uint remainder = numToConvert % 16;
			char HexChar;
			numToConvert /= 16;
			HexChar = GetHEXChars(remainder);
			hex.Insert(0, HexChar);
		}
		hex.Insert(0, 'X');
		hex.Insert(0, '0');
		return hex.ToString();
	}
}

