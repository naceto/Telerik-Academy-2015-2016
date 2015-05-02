namespace Problem_03.First_before_last
{
    using System;
    using System.Collections.Generic;
    
    class MainMethod
    {
        static void Main()
        {
            List<Student> list = new List<Student>();
            list.Add(new Student("Atanas", "Stamatov", 18, "123406789", "adsf@abv.bg", new int[] { 6, 5, 6 }, 1, "0295602024"));
            list.Add(new Student("Pesho", "Georgiev", 24, "123406349", "addsfsf@abv.bg", new int[] { 2, 4, 6 }, 1, "0295602024"));
            list.Add(new Student("Cvetan", "Donchev", 30, "127445789", "gazara@Batka.bg", new int[] { 2, 2, 2 }, 1, "0295602024"));
            list.Add(new Student("Mitko", "Mitkov", 20, "123454679", "zubar@gmail.cn", new int[] { 6, 6, 6 }, 2, "234354345"));
            list.Add(new Student("Qnkul", "Kostov", 23, "123456789", "adsf@btv.bg", new int[] { 6, 2, 2 }, 2, "664624342"));
            list.Add(new Student("Atanas", "Boikov", 18, "123456789", "adsf@abv.bg", new int[] { 6, 6, 6 }, 2, "046292905"));

            Console.WriteLine("\nProblem 3. First before last\n");

            List<Student> newlist = Student.FindAlphabetically(list);

            foreach (var student in newlist)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\nPRoblem 4. Age Range\n");

            newlist = Student.FindAgeRange(list);

            foreach (var student in newlist)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\nProblem 5. Order students - Order with extension methods\n");

            newlist = Student.OrderWithExtensionMethods(list);

            foreach (var student in newlist)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\nProblem 5. Order students - Order with LINQ query\n");

            newlist = Student.OrderWithLINQ(list);

            foreach (var student in newlist)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\nProblem 9. Student groups - query method\n");

            newlist = Student.GetStudentsByGroupQuery(list, 2);

            foreach (var student in newlist)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\nProblem 10. Student groups - extension method\n");

            newlist = Student.GetStudentsByGroupEM(list, 2);

            foreach (var student in newlist)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\nProblem 11. Extract students by email\n");

            newlist = Student.GetByEmail(list, "abv.bg");

            foreach (var student in newlist)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\nProblem 12. Extract students by telephone is sofia\n");

            newlist = Student.GetSofiaPhones(list);

            foreach (var student in newlist)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\nProblem 13. Extract students by marks\n");

            var students = Student.GetByMarks(list);

            foreach (var s in students)
            {
                Console.Write(s.FullName);
                for (int i = 0; i < s.Marks.Length; i++)
                {
                    Console.Write(" {0},", s.Marks[i]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nProblem 14. Extract students with two marks\n");

            newlist = Student.GetByTwoMarks(list);

            foreach (var student in newlist)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\nProblem 15. Extract all Marks of the students that enrolled in 2006.\n");

            List<int[]> markslist = Student.GetMarksByYearInFN(list);

            foreach (var marks in markslist)
            {
                Console.WriteLine(string.Join(", ", marks));
            }

            Console.WriteLine("\nProblem 18. Grouped by GroupNumber\n");
            Student.GroupStudents(list);

            Console.WriteLine("\nProblem 19. Grouped by GroupNumber Extension Methods\n");
            Student.GruopStudentsExtensionMethods(list);
        }
    }
}
