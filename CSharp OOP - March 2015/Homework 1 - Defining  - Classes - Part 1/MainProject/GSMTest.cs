namespace MainProject
{
	using System;
	/*
		 Problem 7. GSM test
		 Write a class GSMTest to test the GSM class:
		 Create an array of few instances of the GSM class.
		 Display the information about the GSMs in the array.
		 Display the information about the static property IPhone4S.
	 */
	class GSMTest
	{
		public static void Test()
		{
			Battery battery = new Battery("SGH", 80, 300, BatteryType.LiIon);
			Display display = new Display(5.5, 16700000);
			GSM OnePlusOne = new GSM ("OnePlus", "One", 349, "Me", display, battery);

			battery = new Battery("ZLE", 60, 200, BatteryType.LiIon);
			display = new Display(5.26, 16700000);
			GSM SamsungS6 = new GSM ("Samsung", "S6", 849, "Someone", display, battery);

			GSM[] gsms = 
			{
				OnePlusOne,
				SamsungS6
			};

			foreach (var gsm in gsms) 
			{
				Console.WriteLine (gsm);
				Console.WriteLine ();
			}

			/* Display the information about the static property IPhone4S. */
			Console.WriteLine(GSM.Iphone4S);
		}
	}
}
