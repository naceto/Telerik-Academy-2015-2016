namespace Application
{
    /* Problem 4. Path 
     * Create a static class PathStorage with static methods to save and load paths from a text file.
     */

    using System;
	using System.IO;
	using System.Collections.Generic;
	
	public class PathStorage
	{
		public static void SavePath (Path list, string filename)
		{
			using (StreamWriter sw = new StreamWriter (filename))
			{
				foreach(var point in list.List)
				{
					sw.WriteLine(point.ToString());
				}
			}
		}

		public static Path LoadPath (string filename)
		{
			List<Point3D> list = new List<Point3D>();
			using (StreamReader sr = new StreamReader(filename))
			{
				string line = string.Empty;
				while ((line = sr.ReadLine()) != null)
				{
					char[] points = { 'X', 'Y', 'Z' };
					int[] array = new int[3];
					int i = 0;
					for (int j = 0; j < array.Length; j++) 
					{
						while (i < line.Length && line[i] != points[j])
						{
							++i;
						}
						if (i == line.Length)
						{
							throw new FormatException ("Input file is not in the right format.");
						}

                        while (i < line.Length && !char.IsDigit(line[i]))
                        {
                            ++i;
                        }

                        if (i == line.Length)
                        {
                            throw new FormatException("Input file is not in the right format.");
                        }

						array[j] = line[i] - '0';
					}

					list.Add(new Point3D(array[0], array[1], array[2]));
				}
			}
			return new Path (list);
		}
	}
}
