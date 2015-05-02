namespace Problem_01.School_classes.Classes
{
    using Problem_01.School_classes.Interfaces;
    using System;

    // Disciplines have a name, number of lectures and number of exercises.
    // could have optional comments (free text block).
    public class Discipline : IFreeText
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Name cannot be null.");
                }
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }

            set
            {
                if (value > 0)
                {
                    this.numberOfLectures = value;
                }
                else
                {
                    throw new ArgumentException("Number of lectures must be greater than 0.");
                }
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                if (value > 0)
                {
                    this.numberOfExercises = value;
                }
                else
                {
                    throw new ArgumentException("Number of exercises cannot be 0.");
                }
            }
        }

        public string FreeText { get; set; }
    }
}
