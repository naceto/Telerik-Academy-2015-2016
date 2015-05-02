using System;

class RandomNumbers
{
	/* Write a program that generates and prints to the console 10 random values in the range [100, 200]. */
	static Random rand = new Random();
	public static void Main()
	{
		for(int i = 0; i < 100; i++)
		{
			Console.WriteLine(RandomNumber());
		}	
	}
	static int RandomNumber ()
	{
		/* rand.Next() returns a number greater than or equal to minValue(100) and less than maxValue (201) */
		return rand.Next(100, 201);
	}
}
