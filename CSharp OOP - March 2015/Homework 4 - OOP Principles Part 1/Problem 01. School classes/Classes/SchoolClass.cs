namespace Problem_01.School_classes.Classes
{
    using Problem_01.School_classes.Interfaces;
    using System;
    using System.Collections.Generic;

    // Each class has a set of teachers
    // Classes have unique text identifier. 
    // could have optional comments (free text block).
    public class SchoolClass : IFreeText, Iidentification
    {
        private string id;

        public SchoolClass (string id)
        {
            this.ID = id;
            this.Teachers = new List<Teacher>();
            this.Students = new List<Student>();
        }

        public SchoolClass (string id, List<Teacher> teachers, List<Student> students)
        {
            this.ID = id;
            this.Teachers = teachers;
            this.Students = students;
        }

        public List<Teacher> Teachers { get; private set; }

        public List<Student> Students { get; private set; }

        public string FreeText { get; set; }

        public string ID
        {
            get
            {
                return id;
            }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.id = value;
                }
                else
                {
                    throw new ArgumentException("Id cannot be null.");
                }
            }
        }
    }
}
