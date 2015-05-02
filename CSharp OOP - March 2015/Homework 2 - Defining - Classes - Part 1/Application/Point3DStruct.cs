namespace Application
{
	using System;

	/*
		Problem 1. Structure
		Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
		Implement the ToString() to enable printing a 3D point.
	 */
	public struct Point3D
	{
		// Problem 2.
		private static readonly Point3D pointO;

		static Point3D ()
		{
			pointO = new Point3D(0, 0, 0);
		}

		public Point3D(int x, int y, int z) : this()
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
		}

		// Problem 2.
		public static Point3D PointO { get { return pointO; } }

		public int X { get; set; }
		public int Y { get; set; }
		public int Z { get; set; }

		public override string ToString ()
		{
			return string.Format("Point3D: X = {0} Y = {1} Z = {2}", this.X, this.Y, this.Z);
		}
	}
}

