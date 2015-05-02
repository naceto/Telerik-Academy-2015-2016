namespace Problem_01.School_classes.Classes
{
    using Problem_01.School_classes.Interfaces;
    using System;

    // Students have a name and unique class number.
    // students are people
    // Students could have optional comments (free text block).
    public class Student : Person, IFreeText, Iidentification
    {
        private string id;

        public Student(string name, string classId)
            : base(name)
        {
            this.ID = classId;
        }

        public string FreeText { get; set; }

        // class ID
        public string ID
        {
            get
            {
                return this.id;
            }
            set
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
