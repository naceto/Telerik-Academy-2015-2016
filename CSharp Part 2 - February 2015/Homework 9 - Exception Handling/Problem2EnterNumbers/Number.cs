using System;

class EnterNumber
{
	/* Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
	 * If an invalid number or non-number text is entered, the method should throw an exception.
	 * Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100 */
	public static void Main()
	{
		for(int i = 0; i < 10; i++)
		{
			try
			{
				ReadNumber (1, 100);
			}
			catch(Exception ex)
			{
				Console.WriteLine (ex.Message);
			}
		}
	}
	static void ReadNumber (int start, int end)
	{
		try
		{
			Console.Write("Enter a number: ");
			int number = int.Parse(Console.ReadLine());	
			if (number < start ||  number > end)
			{
				throw new ArgumentException(String.Format("Number should be in the range: [{0},{1}]", start, end));
			}
		}
		catch(Exception ex)
		{
			throw;
		}
	}
}
