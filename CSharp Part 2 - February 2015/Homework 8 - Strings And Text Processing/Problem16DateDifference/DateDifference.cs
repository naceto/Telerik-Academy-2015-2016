using System;
using System.Globalization;

class Date
{
	/* Write a program that reads two dates in the format: 
	 * day.month.year and calculates the number of days between them. */
	public static void Main()
	{
		Console.Write("Enter the first date: ");
		string date = Console.ReadLine();
		DateTime date1 = DateTime.ParseExact(date, "d.M.yyyy", CultureInfo.InvariantCulture);

		Console.Write("Enter the second date: ");
		date = Console.ReadLine();
		DateTime date2 = DateTime.ParseExact(date, "d.M.yyyy", CultureInfo.InvariantCulture);
		System.Console.WriteLine("{0} days",Math.Abs((date1 - date2).Days));
	}
}
