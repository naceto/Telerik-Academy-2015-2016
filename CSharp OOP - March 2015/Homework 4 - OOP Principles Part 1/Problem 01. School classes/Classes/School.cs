namespace Problem_01.School_classes.Classes
{
    using System;
    using System.Collections.Generic;
    // In the school there are classes of students
    public class School
    {
        public School ()
        {
            this.Classes = new List<SchoolClass>();
        }

        public School (List<SchoolClass> list)
        {
            this.Classes = list;
        }

        public List<SchoolClass> Classes { get; private set; }
    }
}
