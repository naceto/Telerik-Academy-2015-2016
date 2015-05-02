using System;
using System.Text;

class EncodeDecode
{
	/* Write a program that encodes and decodes a string using given encryption key (cipher).
	 * The key consists of a sequence of characters.
	 * The encoding/decoding is done by performing XOR (exclusive or) operation over the 
	 * first letter of the string with the first of the key, the second – with the second, 
	 * etc. When the last key character is reached, the next is the first. 
	 */
	public static void Main()
	{
		Console.Write("Enter a cipher: ");
		const string cipher = Console.ReadLine();
		Console.Write("Enter the text to be coded: ");
		string text = Console.ReadLine();

		// coded
		string result = EncodeDecodeF(text, cipher);
		System.Console.WriteLine(result);

		//decoded
		result = EncodeDecodeF(result, cipher);
		System.Console.WriteLine(result);
	}
	static string EncodeDecodeF (string text, string cipher)
	{
		int index = 0;
		int cipherLen = cipher.Length;
		StringBuilder sb = new StringBuilder();
		while (index < text.Length)
		{
			int cipherIndex = index % cipherLen;
			char ch = text[index];
			char c = cipher[cipherIndex];
			sb.Append((char) ((int)ch ^ (int)c));
			index++;
		}
		return sb.ToString();
	}
}

