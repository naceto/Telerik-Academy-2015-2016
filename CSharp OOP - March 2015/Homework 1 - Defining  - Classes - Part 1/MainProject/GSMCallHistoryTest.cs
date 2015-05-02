namespace MainProject
{
	using System;
	/*
		Problem 12. Call history test
	    Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
		Create an instance of the GSM class.
		Add few calls.
		Display the information about the calls.
		Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
		Remove the longest call from the history and calculate the total price again.
		Finally clear the call history and print it.
	*/
	public class GSMCallHistoryTest
	{
		public static void GSMCallHistory_Test()
		{
			Display display = new Display(5.5, 16700000);
			Battery battery = new Battery("HJK", 60, 300, BatteryType.LiIon);
			GSM iPhone6Plus = new GSM("Apple", "iPhone6 Plus", 1399, null, display, battery, null);

			Call call = new Call("0987654321", 600, new DateTime (2015, 1, 18), new DateTime ().AddHours (5).AddMinutes (34).AddSeconds (54));
			iPhone6Plus.AddCall(call);

			call = new Call("+1234567890", 300);
			iPhone6Plus.AddCall(call);

			call = new Call("+1234567890343", 100);
			iPhone6Plus.AddCall(call);

			var calls = iPhone6Plus.CallHistory;

			foreach(var phonecall in calls)
			{
				Console.WriteLine (phonecall);
				Console.WriteLine();
			}

			decimal totalPrice = iPhone6Plus.CalculateTotalPrice(0.37M);
			Console.WriteLine("Total Price is = {0}", totalPrice);

			Call longetsCall = null;
			foreach(var item in calls)
			{
				if (longetsCall == null)
				{
					longetsCall = item;
					continue;
				}
				if (longetsCall.Duraion < item.Duraion)
				{
					longetsCall = item;
				}
			}
			iPhone6Plus.DeleteCall(longetsCall);

			totalPrice = iPhone6Plus.CalculateTotalPrice(0.37M);
			Console.WriteLine("The total price after removing the longest call is = {0}", totalPrice);
		}
	}
}

