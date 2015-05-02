using System;

class HexToDecClass
{
	/* Write a program to convert hexadecimal numbers to their decimal representation. */
	public static void Main()
	{
		Console.Write("Enter the HEX number in the format 0X____: ");
		string hex = Console.ReadLine();
		hex = hex.ToUpper();
		Console.WriteLine("{0}(HEX = {1}(DEC)",hex, HexToDec(hex));
	}

	static int GetHEXNums(char hex)
	{
		if(hex >= 48 && hex <= 57)
		{
			return hex - '0';
		}
        return hex - 'A' + 10;
	}

	static int HexToDec(string hex)
	{
		int finalNum = 0;
		for(int i = hex.Length - 1, pow = 0; i >= 2; i--, pow++)
		{
			int number = GetHEXNums(hex[i]);
			finalNum += number * (int)Math.Pow(16, pow);
		}
		return finalNum;
	}
}

