namespace Problem_2.Students_and_workers
{
    using Problem_2.Students_and_workers.Classes;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MainMethodClass
    {
        static void Main()
        {
            // Initialize a list of 10 students and sort them by grade in 
            // ascending order (use LINQ or OrderBy() extension method).
            Console.WriteLine("Students:\n");
            List<Student> students = new List<Student>();
            students.Add(new Student("Penka", "Benkovska", 6));
            students.Add(new Student("Mircho", "Vinkeloff", 2));
            students.Add(new Student("Gosho", "Otpochivka", 3));
            students.Add(new Student("Qwerty", "Uiop", 5));
            students.Add(new Student("Asdfg", "Hjkl", 4));
            students.Add(new Student("Touka", "Chan", 6));
            students.Add(new Student("Ichigo", "Kurosaki", 6));
            students.Add(new Student("Deadpool", "Whocares", 3));
            students.Add(new Student("Tired", "Ofthis", 6));
            students.Add(new Student("Still", "GoingOn", 5));

            var orderedStudents = from s in students
                                  orderby s.Grade
                                  select s;
            Console.WriteLine("{0,-10} {1,-12} {2}", "First name", "Last name", "Grade");
            foreach (var s in orderedStudents)
            {
                Console.WriteLine("{0,-10} {1,-12} {2}", s.FirstName, s.LastName, s.Grade);
            }


            Console.WriteLine("\nWorkers:\n");
            // Initialize a list of 10 workers and sort them by money per hour in descending order.
            List<Worker> workers = new List<Worker>();

            workers.Add(new Worker("Jenko", "Pirov", 100, 20));
            workers.Add(new Worker("Super", "Spiro", 200, 20));
            workers.Add(new Worker("Balgar", "Balgarov", 100, 16));
            workers.Add(new Worker("Nicolas", "Cage", 500, 12));
            workers.Add(new Worker("Micelangel", "Dadumtss", 400, 12));
            workers.Add(new Worker("Gospodin", "Shegadjiev", 343, 8));
            workers.Add(new Worker("Gergana", "Aprilska", 800, 8));
            workers.Add(new Worker("Anteku", "Tokyo", 546, 4));
            workers.Add(new Worker("Oneee", "Chan", 345, 15));
            workers.Add(new Worker("Siverster", "TheCat", 533, 9));

            var sortedWorkers = from w in workers
                                orderby w.MonerPerHour() descending
                                select w;
            Console.WriteLine("{0,-10:c} {1,-12} {2,-15}\n", "First name", "Last name", "Moner per hour");
            foreach (var w in sortedWorkers)
            {
                Console.WriteLine("{0,-10:c} {1,-12} {2,-6:.00}", w.FirstName, w.LastName, w.MonerPerHour());
            }


            //Merge the lists and sort them by first name and last name.
            Console.WriteLine("\nMerged Workers and students\n");

            List<Human> humans = new List<Human>();
            humans = humans.Concat(students).Concat(workers).ToList();

            var sortedHumans = from h in humans
                               orderby h.FirstName, h.LastName
                               select h;

            foreach (var h in sortedHumans)
            {
                Console.WriteLine("{0,-10} {1,-10}", h.FirstName, h.LastName);
            }
        }
    }
}
