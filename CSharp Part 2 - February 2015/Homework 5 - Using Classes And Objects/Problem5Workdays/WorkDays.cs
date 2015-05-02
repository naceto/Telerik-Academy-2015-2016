using System;

class WorkDays
{
	/* Write a method that calculates the number of workdays between today 
	 * and given date, passed as parameter. Consider that workdays are all 
	 * days from Monday to Friday except a fixed list of public holidays 
	 * specified preliminary as array. 
	 */
	public static void Main()
	{
		Console.Write("Enter date: ");
		DateTime date = DateTime.Parse(Console.ReadLine());
		Console.Write(CalculateWorkDays(date));
	}

	static int CalculateWorkDays (DateTime date)
	{
		int workDays = 0;
		DateTime today = DateTime.Today;
		while (today.CompareTo(date) != 0)
		{
			if (today.DayOfWeek.ToString() != "Saturday" && 
			    today.DayOfWeek.ToString() != "Sunday" && 
			    IsSpecialNonWorkingDay(today) == false)
			{
				workDays++;
			}
			if(today.CompareTo(date) < 0)
			{
				today = today.AddDays(1);
			}
			else if (today.CompareTo(date) > 0)
			{
				today = today.AddDays(-1);			
			}
		}
		return workDays;
	}

	static bool IsSpecialNonWorkingDay(DateTime date)
	{
		DateTime[] dates = 
		{
			new DateTime(2015, 03, 03),
			new DateTime(2015, 03, 02)
		};
		for(int i = 0; i < dates.Length; i++)
		{
			if (date == dates[i])
			{
				return true;
			}
		}
		return false;
	}
}
