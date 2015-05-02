using System;
using System.Text;

class Parse
{
	/* Write a program that parses an URL address given in the format: 
	 * [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements. */
	public static void Main()
	{
		Console.Write("Enter URL address: ");
		string text = Console.ReadLine();
		System.Console.WriteLine(ParseURL(text));
	}

	static string ParseURL (string url)
	{
		StringBuilder sb = new StringBuilder();
		const string pEnd = "://";
		const string sEnd = "/";

		// protocol
		int protocolEnd = url.IndexOf(pEnd);
		if(protocolEnd >= 0)
		{
			sb.Append("Protocol: ");
			sb.Append(url, 0, protocolEnd);
			sb.Append("\n");
		}

		// server
		int serverEnd = url.IndexOf(sEnd, protocolEnd + pEnd.Length);
		if (serverEnd >= 0)
		{
			sb.Append("Server: ");
			sb.Append(url, protocolEnd + pEnd.Length, serverEnd - protocolEnd - pEnd.Length);
			sb.Append("\n");
		}

		// resources
		sb.Append("Resource: ");
		sb.Append(url, serverEnd + 1, url.Length - serverEnd - 1);

		return sb.ToString();
	}
}
