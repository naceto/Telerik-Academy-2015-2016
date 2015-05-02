using System;

class Tags
{
	/* Write a program that replaces in a HTML document given as string all the
	 * tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
	 */
	public static void Main()
	{
		Console.Write("Enter some HTML code: ");
		string text = Console.ReadLine();

		// in case you dont want to copy here's the code from the Homework :)
		//string text = "<p>Please visit <a href=\"http:/academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

		Console.WriteLine(ReplaceTags(text));
	}

	static string ReplaceTags (string text)
	{
		const string linkStartTag = "<a href=\"";
		const string end = "\">";
 		const string linkEndTag = "</a>";
		const string newLinkStartTag = "[URL=";
		const string newlinkEndTag = "[/URL]";
		//TODO: replace the first > after linkStartTag
		text = text.Replace(linkStartTag, newLinkStartTag);
		text = text.Replace(end, "]");
		text = text.Replace(linkEndTag, newlinkEndTag);
		return text;
	}
}