namespace MainProject
{
	using System;
	public class MainClass
	{
		public static void Main()
		{
			const int ConsoleWidth = 80;
			// Project 7
			GSMTest.Test();

			Console.WriteLine();
			Console.WriteLine(new String ('*', ConsoleWidth)); // separator
			Console.WriteLine();

			// Prject 12
			GSMCallHistoryTest.GSMCallHistory_Test();
		}
	}
}

