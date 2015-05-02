namespace Problem_01_Student_class
{
    using Problem_01_Student_class.Classes;
    using Problem_01_Student_class.Enumeration;
    using System;

    class EntryPoint
    {
        static void Main()
        {
            Student student = new Student("Ivan", "Georgiev", "Stamatov", "Sofia", "1213141516", 
                "0987654321", "abv@abv.bg", 3, Specialty.ComputerScience, University.SofiaUniversity, Faculty.FMI);

            Console.WriteLine(student);
            Student SameStudent = student;
            Console.WriteLine(SameStudent.Equals(student)); // true

            Student NewStudent = new Student("Petar", "Ivanov", "Petrenski", "Sofia", "123456789", "1234567890", "vba@vba.gb", 3, Specialty.Psychology, University.TechnicalUniversity, Faculty.KSI);
            Console.WriteLine(NewStudent.Equals(student)); // false

            Console.WriteLine(SameStudent.GetHashCode());

            Console.WriteLine(student != NewStudent); // true
            Console.WriteLine(student == NewStudent); // false

            Console.WriteLine(student.CompareTo (NewStudent));
        }
    }
}
