namespace Problem_2.Students_and_workers.Classes
{
    using System;

    // Define a new class Student which is derived from Human and has a new field – grade.
    class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName)
            : base (firstName, lastName)
        {
            // by default our student is an excellent student
            this.Grade = 6;
        }

        public Student(string firstName, string lastName, int grade)
            : this (firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get { return this.grade; }

            set
            {
                if (value >= 2 && value <= 6)
                {
                    this.grade = value;
                }
                else
                {
                    throw new ArgumentException("Grade must be in the bounds [2-6]");

                }
            }
        }
    }
}
