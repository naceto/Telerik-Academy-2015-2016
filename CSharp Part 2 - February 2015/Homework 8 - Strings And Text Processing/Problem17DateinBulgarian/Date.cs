using System;
using System.Globalization;

class MainClass
{
	/* Write a program that reads a date and time given in the format: 
	 * day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes 
	 * (in the same format) along with the day of week in Bulgarian. 
	 */
	public static void Main()
	{
		System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("bg-BG");
		Console.Write("Enter date: ");
		string dateAsString = Console.ReadLine();
		DateTime date = DateTime.ParseExact(dateAsString, "d.M.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
		date = date.AddHours(6);
		date = date.AddMinutes(30);
		Console.WriteLine (date);
	}
}
