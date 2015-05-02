namespace Application
{
	using System;

    [Version(2, 14)]
	class MainClass
	{
		public static void Main()
		{
            // Point3D Path and PathStorage
            string filename = "..\\..\\Files\\data.pd";
			Path p = new Path();
            p.AddPoint(new Point3D(1, 2, 3));
            p.AddPoint(new Point3D(1, 2, 3));
            p.AddPoint(new Point3D(1, 2, 3));
            PathStorage.SavePath(p, filename);
            Path newPath = PathStorage.LoadPath(filename);
            
            // Generic list
            GenericList<int> list = new GenericList<int>(8);

            for (int i = 0; i < 20; i++)
            {
                list.Add(i);
            }
            Console.WriteLine("List: {0}", list.ToString());

            list.InsertAt(5, 123231321);
            Console.WriteLine("List: {0}", list.ToString());
            list.RemoveAt(5);
            Console.WriteLine("List: {0}", list.ToString());
            list.Clear();
            list.Add(1);
            list.Add(22);
            list.Add(333);
            Console.WriteLine("List: {0}", list.ToString()); 
            // Max and Min
            uint max = list.Max();
            Console.WriteLine("Max: {0}", list[max]);
            uint min = list.Min();
            Console.WriteLine("Min: {0}", list[min]);
            
            //Matrix
            Console.WriteLine();
            Matrix<int> m = new Matrix<int>(3, 3);
            m[0, 0] = 5;
            m[0, 1] = 4;
            m[0, 2] = 3;
            m[1, 0] = 1;
            m[1, 1] = 2;
            m[1, 2] = 3;
            m[2, 0] = 9;
            m[2, 1] = 8;
            m[2, 2] = 7;
            Console.WriteLine("Matrix :\n{0}", m.ToString());
            Matrix<int> newMatrix = m + m;
            Console.WriteLine("Matrix after addition:\n{0}", newMatrix.ToString());
            newMatrix = m - m;
            Console.WriteLine("Matrix after subtraction:\n{0}", newMatrix.ToString());
            newMatrix = m * m;
            Console.WriteLine("Matrix after multiplication:\n{0}", newMatrix.ToString());
            // True and False
            Matrix<int> m2 = new Matrix<int>(5, 5);
            if (m2)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            // Atribute
            Type type = typeof(MainClass);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute attr in allAttributes)
            {
                Console.WriteLine("The version of the class is {0}. ", attr.Version);
            }
		}
	}
}
