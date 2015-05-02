namespace Application
{
	using System;
	using System.Collections.Generic;
	/*
		Problem 4. Path

		Create a class Path to hold a sequence of points in the 3D space.
		Create a static class PathStorage with static methods to save and load paths from a text file.
		Use a file format of your choice.
	 */
	public class Path
	{
		private List<Point3D> listOfPoints;
		public Path()
		{
			this.List = new List<Point3D>();
		}

		public Path (List<Point3D> list)
		{
			this.List = list;
		}

		public List<Point3D> List 
		{
			get { return this.listOfPoints; }

			private set { this.listOfPoints = value; }
		}

		public int Count 
		{
			get
			{
				return listOfPoints.Count;
			}
		}

		public void AddPoint (Point3D point)
		{
			this.List.Add(point);
		}
	}
}

