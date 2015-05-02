using System;

class MainClass
{
	/* Write methods that calculate the surface of a triangle by given:
		 * Side and an altitude to it;
		 * Three sides;
		 * Two sides and an angle between them;
	 * Use System.Math.
	 */
	public static void Main()
	{
		Console.WriteLine("1. Side and altitude.");
		Console.WriteLine("2. Three sides.");
		Console.WriteLine("3. Two sides and angle.");
		Console.Write("Choose method: ");
		int choice = int.Parse(Console.ReadLine());
		switch (choice)
		{
		case 1:
			{
				Console.Write("Enter side: ");
				double side = double.Parse(Console.ReadLine());

				Console.Write("Enter altitude: ");
				double altitude = double.Parse(Console.ReadLine());

				Console.WriteLine("The area of the triangle is {0}", TriangleSurface.SideAndAltitude(side, altitude));
				break;
			}
		case 2:
			{
				Console.Write("Enter side 1: ");
				double s1 = double.Parse(Console.ReadLine());

				Console.Write("Enter side 2: ");
				double s2 = double.Parse(Console.ReadLine());

				Console.Write("Enter side 3: ");
				double s3 = double.Parse(Console.ReadLine());

				Console.WriteLine("The area of the triangle is {0}", TriangleSurface.ThreeSides(s1, s2, s3));
				break;
			}
		case 3:
			{
				Console.Write("Enter side 1: ");
				double s1 = double.Parse(Console.ReadLine());

				Console.Write("Enter side 2: ");
				double s2 = double.Parse(Console.ReadLine());

				Console.Write("Enter angle: ");
				double angle = double.Parse(Console.ReadLine());
				
				Console.WriteLine("The area of the triangle is {0}", TriangleSurface.TwoSidesAndAngle(s1, s2, angle));
				break;
			}
		default:
			Console.WriteLine("Error: invalid choice.");
			break;
		}
	}
}
class TriangleSurface
{
	static public double SideAndAltitude (double side, double altitude)
	{
		return (side * altitude) / 2;
	}

	static public double ThreeSides (double s1, double s2, double s3)
	{
		double s = (s1 + s2 + s3) / 2;
		return Math.Sqrt(s * ((s - s1) * (s - s2) * (s - s3)));
	}

	static public double TwoSidesAndAngle (double s1, double s2, double angle)
	{
		double sin = Math.Sin(angle);
		return Math.Abs((s1 * s2 * sin) / 2);
	}
}