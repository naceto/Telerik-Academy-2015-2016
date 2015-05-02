using System;
using System.Net;

class MainClass
{
	/* Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
	 * Find in Google how to download files in C#.
	 * Be sure to catch all exceptions and to free any used resources in the finally block. 
	 */
	public static void Main()
	{
		WebClient Client = new WebClient ();
		try
		{	
			Client.DownloadFile("http://telerikacademy.com/Content/Images/news-img01.png", "news-img01.png");
		}
		catch(Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
		finally
		{
			Client.Dispose();
		}
	}
}

