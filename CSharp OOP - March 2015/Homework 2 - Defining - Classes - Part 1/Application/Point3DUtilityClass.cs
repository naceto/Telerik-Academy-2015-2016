namespace Application
{
	using System;

	/*
		Problem 3. Static class
		Write a static class with a static method to calculate the 
		distance between two points in the 3D space.
	 */
	public static class Point3DUtilityClass
	{
		public static double CalculateDistance (Point3D p1, Point3D p2)
		{
			double powX = Math.Pow(p1.X - p2.X, 2);
			double powY = Math.Pow(p1.Y - p2.Y, 2);
			double powZ = Math.Pow(p1.Z - p2.Z, 2);

			return Math.Sqrt (powX + powY + powZ);
		}
	}
}

