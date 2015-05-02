using System;
using System.Globalization;

class DatesFromText
{
	/* Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
	 * Display them in the standard date format for Canada. */
	public static void Main()
	{
		System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-CA");
		Console.Write("Enter date: ");
		string dateAsString = Console.ReadLine();
		DateTime date = DateTime.ParseExact(dateAsString, "dd.MM.yyyy", CultureInfo.InvariantCulture);
		Console.WriteLine (date.ToShortDateString());
	}
}
