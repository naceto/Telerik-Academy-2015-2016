using System;

class BinaryToDecimal
{
	/* Write a program to convert binary numbers to their decimal representation. */
	public static void Main()
	{
		Console.WriteLine("Info: this program works with signed int.");
		Console.Write("Enter the binary number: ");
		string binary = Console.ReadLine();
		long dec = BinToDec(binary);
		Console.WriteLine(dec);

	}

	static long BinToDec(string bin)
	{
		long decNumber = 0;
		for(int i = bin.Length - 1, j = 0; i >= 0; i--, j++)
		{
			int mask = 0;
			if (bin[i] - '0' == 1)
			{
				mask = 1;
			}
			decNumber |= mask << j;
		}
		return decNumber;
	}
}
