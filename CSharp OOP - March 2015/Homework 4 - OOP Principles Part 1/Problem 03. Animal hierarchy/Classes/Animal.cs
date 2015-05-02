namespace Problem_03.Animal_hierarchy.Classes
{
    using Problem_03.Animal_hierarchy.Enumerations;
    using Problem_03.Animal_hierarchy.Interfaces;
    using System;
    using System.Linq;
    // All animals can produce sound (specified by the ISound interface)
    // All animals are described by age, name and sex. 

    public abstract class Animal : ISound
    {
        private int age;
        private string name;

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be negative.");
                }
                this.age = value;
            }
        }

        public string Name
        {
            get { return this.name; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }
                this.name = value;
            }
        }

        public static int CalculateAverageAge (Animal[] animals)
        {
            var averageAge = (from a in animals
                              select a.Age).Average();
            return (int)averageAge;
        }

        public abstract Gender Sex { get; set; }

        public abstract string MakeSound();
    }
}
