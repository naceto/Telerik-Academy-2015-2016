namespace Problem_03.First_before_last
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Student
    {
        public Student(string firstName, 
                string lastName, 
                uint age, 
                string fn, 
                string email, 
                int[] marks, 
                int groupNumber,
                string tel) 
            : this (firstName, lastName, age)
        {
            this.FN = fn;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
            this.Tel = tel;
        }

        public Student(string firstName, string lastName, uint age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public uint Age { get; private set; }

        // Problem 9.
        public string FN { get; private set; }
        public string Email { get; private set; }
        public string Tel { get; private set; }
        public int[] Marks { get; set;}
        public int GroupNumber { get; private set; }

        /* 
           Problem 3. First before last
           Write a method that from a given array of students finds all students whose 
           first name is before its last name alphabetically.
           Use LINQ query operators.
         */
        public static List<Student> FindAlphabetically(List<Student> list)
        {
            return list
                .Where(student => student.FirstName[0] < student.LastName[0])
                .ToList();
        }

        /*
           Problem 4. Age range
           Write a LINQ query that finds the first name and last name of all
           students with age between 18 and 24.
         */
        public static List<Student> FindAgeRange (List<Student> list)
        {
            return list
                .Where(student => (student.Age >= 18 && student.Age <= 24))
                .ToList();
        }

        /*
            Problem 5. Order students
            Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the 
            students by first name and last name in descending order.
            Rewrite the same with LINQ.
        */
        public static List<Student> OrderWithExtensionMethods (List<Student> list)
        {
            return list
                .OrderByDescending(student => student.FirstName)
                .ThenByDescending(student => student.LastName)
                .ToList();
        }
        public static List<Student> OrderWithLINQ (List<Student> list)
        {
            var newList = from student in list
                   orderby student.FirstName descending, student.LastName descending
                   select student;
            return newList.ToList<Student>();
        }

        /*
         * Problem 9. Student groups
         * Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
         * Create a List<Student> with sample students. Select only the students that are from group number 2.    Use LINQ query. Order the students by FirstName.
         */
        public static List<Student> GetStudentsByGroupQuery(List<Student> list, int g)
        {
            var l = from student in list
                    where student.GroupNumber == g
                    orderby student.LastName
                    select student;
            return l.ToList();
        }

        /* 
         * Problem 10. Student groups extensions
         * Implement the previous using the same query expressed with extension methods 
         */
        public static List<Student> GetStudentsByGroupEM (List<Student> list, int g)
        {
            return list
                .Where(student => student.GroupNumber == g)
                .OrderBy(student => student.LastName)
                .ToList();
        }

        /* 
         * Problem 11. Extract students by email
         * Extract all students that have email in abv.bg.
         * Use string methods and LINQ. 
         */
        public static List<Student> GetByEmail (List<Student> list, string contains)
        {
            var result = from s in list
                         where s.Email.Contains(contains)
                         select s;
            return result.ToList();
        }

        /*
         * Problem 12. Extract students by phone
         * Extract all students with phones in Sofia.
         * Use LINQ. 
         */
        public static List<Student> GetSofiaPhones (List<Student> list)
        {
            // 02 930 8200 -> 10 numbers starts with 029
            var result = from s in list 
                         where s.Tel.StartsWith("029") && s.Tel.Length == 10
                         select s;

            return result.ToList();
        }

        /*
         * Problem 13. Extract students by marks
         * Select all students that have at least one mark Excellent (6) into a new anonymous class 
         * that has properties – FullName and Marks.
         * Use LINQ.
         */
        public static dynamic GetByMarks (List<Student> list)
        {
            var result = from s in list
                         where s.Marks.Contains(6)
                         select new { FullName = string.Concat(s.FirstName, " ", s.LastName), Marks = s.Marks };
            return result;
        }

        /*         
         * Problem 14. Extract students with two marks
         * Write down a similar program that extracts the students with exactly two marks "2".
         * Use extension methods. 
         */
        public static List<Student> GetByTwoMarks (List<Student> list)
        {
            Predicate<int> pred = (num) => num == 2;

            return list.Where(s => Array.FindAll(s.Marks, pred).Length >= 2).ToList();
        }


        /*         
         * Problem 15. Extract marks
         * Extract all Marks of the students that enrolled in 2006. 
         * (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).  
         */
        public static List<int[]> GetMarksByYearInFN (List<Student> list)
        {
            var result =  from s in list
                          where s.FN[4] == '0' && s.FN[5] == '6'
                          select s.Marks;

            return result.ToList();
        }

        /*
         * Problem 18. Grouped by GroupNumber
         * Create a program that extracts all students grouped by GroupNumber and then prints 
         * them to the console. Use LINQ.
         */
        public static void GroupStudents (List<Student> list)
        {
            var result = from s in list 
                         group s by s.GroupNumber;

            foreach (var group in result)
            {
                Console.WriteLine(group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine(student.FirstName + " " + student.LastName  + " " + student.GroupNumber);
                }
            }
        }

        /* 
         * Problem 19. Grouped by GroupName extensions
         * Rewrite the previous using extension methods.
         */
        public static void GruopStudentsExtensionMethods (List<Student> list)
        {
            var result = list.GroupBy(s => s.GroupNumber);

            foreach (var group in result)
            {
                Console.WriteLine(group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine(student.FirstName + " " + student.LastName + " " + student.GroupNumber );
                }
            }
        }

        // Overrides
        public override string ToString()
        {
            return string.Format("First name = {0}, Last name = {1}\nAge = {2}, Group = {3}\nEmail = {4}, Telephone = {5}\nMarks = {6}\n\n", 
                this.FirstName, this.LastName, this.Age, this.GroupNumber, this.Email, this.Tel, String.Join(", ", this.Marks));
        }

    }
}
