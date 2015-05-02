using System;

class LeapYear
{
	/* Write a program that reads a year from the console and checks whether it is a leap one.
	 * Use System.DateTime. 
	 */
	public static void Main()
	{
		Console.Write("Enter a year to be checked if leap: ");
		int year = int.Parse(Console.ReadLine());
		if (DateTime.IsLeapYear(year))
		{
			Console.WriteLine("The year: {0} is leap", year);
		}
		else
		{
			Console.WriteLine("The year: {0} is NOT leap", year);
		}
	}
}
