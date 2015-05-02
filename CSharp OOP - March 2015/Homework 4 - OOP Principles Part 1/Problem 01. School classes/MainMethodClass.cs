namespace Problem_01.School_classes
{
    using Problem_01.School_classes.Classes;
    using System;
    using System.Collections.Generic;

    class MainMethodClass
    {
        static void Main()
        {
            Student ivan = new Student("Ivan Ivanov", "A");
            Student pesho = new Student("Petar Petrov", "A");
            Student misho = new Student("Misho Petrov", "A");
            Student georgi = new Student("Georgi Atanasov", "A");

            List<Student> students = new List<Student>();
            students.Add(ivan);
            students.Add(pesho);
            students.Add(misho);
            students.Add(georgi);
            
            Teacher ginka = new Teacher("Ginka Mikova");
            ginka.Disciplines.Add(new Discipline("Mathematics", 10, 10));

            Teacher bogdan = new Teacher("Bogdan Dimitroff");
            bogdan.Disciplines.Add(new Discipline("Biology", 8, 16));

            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(ginka);
            teachers.Add(bogdan);

            SchoolClass classA = new SchoolClass("A", teachers, students);
            List<SchoolClass> listClasses = new List<SchoolClass>();
            listClasses.Add(classA);

            School bulgariaSchool = new School(listClasses);
        }
    }
}
