using System;
using System.Text;

class BinaryShort
{
	/* Write a program that shows the binary representation of given 
	 * 16-bit signed integer number (the C# type short). */
	public static void Main()
	{
		Console.Write("Enter a signed short number (-32,768 to 32,767): ");
		short sh = short.Parse(Console.ReadLine());
		Console.WriteLine("{0}(DEC) = {1}(BIN)", sh, Convert(sh));
	}

	static string Convert(short number)
	{
		StringBuilder binary = new StringBuilder();
		for(int i = 0; i < 16; i++)
		{
			if (i % 8 == 0)
			{
				binary.Insert(0, " ");
			}
			binary.Insert(0, (number >> i) & 1);
		}
		return binary.ToString();
	}
}