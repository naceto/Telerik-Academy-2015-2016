using System;

class SquareRoot
{
	/* Write a program that reads an integer number and calculates and prints its square root.
	 	* If the number is invalid or negative, print Invalid number.
	 	* In all cases finally print Good bye.
	 * Use try-catch-finally block. */
	public static void Main()
	{
		Console.Write("Enter a number: ");
		try
		{
			uint number = uint.Parse(Console.ReadLine());
			double sqrt = Math.Sqrt(number);	
			Console.WriteLine ("The squre root of {0} is {1}.", number, sqrt);
		}
		catch(FormatException)
		{
			Console.WriteLine("Invalid argument: Wrong Format");
		}
		catch (OverflowException)
		{
			Console.WriteLine("Invalid argument: Negative number.");
		}
		finally
		{
			Console.WriteLine("Goodbye");
		}
	}
}
