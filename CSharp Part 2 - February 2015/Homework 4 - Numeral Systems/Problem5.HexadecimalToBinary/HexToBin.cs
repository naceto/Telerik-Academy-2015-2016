using System;
using System.Text;

class HexToBinClass
{
	/* Write a program to convert hexadecimal numbers to binary numbers (directly). */
	public static void Main()
	{
		Console.Write("Enter the HEX number to be converted to binary(format: 0X_____): ");
		string hex = Console.ReadLine();
		hex = hex.ToUpper();
		Console.WriteLine("{0}(HEX) = {1}(BIN)",hex, HexToBin(hex));
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
		return '0';
	}

	static string HexToBin(string hex)
	{
		StringBuilder binary = new StringBuilder();
		for(int i = hex.Length - 1; i >= 2; i--)
		{
			int number = GetHEXNums(hex[i]);
			for (int k = 0; k < 4; k++)
			{
				int remainder = number % 2;
				number /= 2;
				binary.Insert(0, remainder);
			}
		}
		return binary.ToString();
	}
}