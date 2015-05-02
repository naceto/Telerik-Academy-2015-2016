using System;
using System.IO;

class MainClass
{
	/* Write a program that reads a text file containing a square matrix of numbers.
	 * Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
	 * The first line in the input file contains the size of matrix N.
	 * Each of the next N lines contain N numbers separated by space.
	 * The output should be a single number in a separate text file. 
	 */
	public static void Main()
	{
		var sr = new StreamReader("..\\..\\Files\\matrix.txt");

		string text = string.Empty;

		using (sr)
		{
			text = sr.ReadToEnd();
		}

		string[] numbers = text.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
		int size = int.Parse(numbers[0]);
		int[,] matrix = new int[size, size];
		for(int i = 0; i < size; i++)
		{
			for (int j = 0; j < size; j++) 
			{
				matrix[i, j] = int.Parse(numbers[j + i * size + 1]);
			}
		}
		int bestArea = 0;
		for(int i = 0; i < size - 1; i++)
		{
			for (int j = 0; j < size - 1; j++) 
			{
				int area = 0;
				for (int k = 0; k < 2; k++) 
				{
					for (int m = 0; m < 2; m++) 
					{
						area += matrix[i + k, j + m];	
					}
				}
				if (area > bestArea)
				{
					bestArea = area;
				}
			}
		}
		Console.WriteLine(bestArea);
	}
}