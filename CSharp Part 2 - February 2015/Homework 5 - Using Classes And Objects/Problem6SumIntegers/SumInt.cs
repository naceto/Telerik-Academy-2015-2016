using System;

class SumInt
{
	/* You are given a sequence of positive integer values written into a string, separated by spaces.
	 * Write a function that reads these values from given string and calculates their sum. 
	 */
	public static void Main()
	{
		Console.Write("Enter the numbers and press enter: ");
		string str = Console.ReadLine();	
		Console.WriteLine("The sum of the given numbers is {0}", SumOfIntegers(str));
	}

	static int SumOfIntegers(string numbers)
	{
		string[] splitNumbers = numbers.Split(' ');
		int sum = 0;
		for(int i = 0; i < splitNumbers.Length; i++)
		{
			sum += int.Parse(splitNumbers[i]);
		}
		return sum;
	}
}
