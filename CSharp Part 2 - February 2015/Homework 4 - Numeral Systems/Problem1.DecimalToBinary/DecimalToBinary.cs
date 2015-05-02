using System;
using System.Text;

class DecimalToBinary
{
	/* Write a program to convert decimal numbers to their binary representation. */
	public static void Main()
	{
		Console.WriteLine("Info: You can enter numbers up signed int.");
		Console.Write("Enter a number to be converted to binary: ");
		int number = int.Parse(Console.ReadLine());
		Console.WriteLine("{0}(DEC) = {1}(BIN)",number, DecToBin(number));
	}
	

	static string DecToBin(int number)
	{
		StringBuilder binaryStr = new StringBuilder ();
		for(int i = 0; i < 32; i++)
		{
			binaryStr.Insert(0 ,((number >> i) & 1));
		}
		return binaryStr.ToString();
	}
}