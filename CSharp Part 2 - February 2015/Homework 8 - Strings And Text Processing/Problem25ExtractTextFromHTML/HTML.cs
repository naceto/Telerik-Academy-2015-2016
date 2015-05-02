using System;
using System.Xml;

class MainClass
{
	public static void Main()
	{
		Console.WriteLine("Enter HTML code: ");
		string text = Console.ReadLine();
		XmlDocument doc = new XmlDocument();
		doc.LoadXml(text);

		XmlNode node = doc.DocumentElement.SelectSingleNode("/html/head/title");
		Console.WriteLine("Title: " + node.InnerText);
		node = doc.DocumentElement.SelectSingleNode("/html/body");
		Console.WriteLine("Body: " + node.InnerText);
	}
}

