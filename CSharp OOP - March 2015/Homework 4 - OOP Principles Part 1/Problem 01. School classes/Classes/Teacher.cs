namespace Problem_01.School_classes.Classes
{
    using Problem_01.School_classes.Interfaces;
    using System;
    using System.Collections.Generic;

    // Each teacher teaches, a set of disciplines
    // Teachers have a name. 
    // teachers are people.
    // could have optional comments (free text block).
    public class Teacher : Person, IFreeText
    {
        public Teacher(string name)
            : base(name)
        {
            this.Disciplines = new List<Discipline>();
        }

        public Teacher(string name, List<Discipline> listDisciplines)
            : base(name)
        {
            this.Disciplines = listDisciplines;
        }

        public List<Discipline> Disciplines { get; private set; }

        public string FreeText { get; set; }
    }
}
