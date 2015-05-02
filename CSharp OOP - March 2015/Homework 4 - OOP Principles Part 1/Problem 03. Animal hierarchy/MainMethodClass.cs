namespace Problem_03.Animal_hierarchy
{
    using Problem_03.Animal_hierarchy.Classes;
    using Problem_03.Animal_hierarchy.Enumerations;
    using System;

    class MainMethodClass
    {
        static void Main()
        {
            // Create arrays of different kinds of animals and calculate the average 
            // age of each kind of animal using a static method (you may use LINQ).
            Cat[] cats = new Cat[3];
            cats[0] = new Cat("maca", 5, Gender.Female);
            cats[1] = new Cat("pisana", 4, Gender.Female);
            cats[2] = new Cat("djesi", 3, Gender.Female);
            Console.WriteLine("Average age of the cats in the array is: {0}\n", Animal.CalculateAverageAge(cats));

            Dog[] dogs = new Dog[3];
            dogs[0] = new Dog("sharo", 8, Gender.Male);
            dogs[1] = new Dog("byki", 7, Gender.Male);
            dogs[2] = new Dog("hera", 6, Gender.Female);
            Console.WriteLine("Average age of the dogs in the array is: {0}\n", Animal.CalculateAverageAge(dogs));

            Frog[] frogs = new Frog[3];
            frogs[0] = new Frog("Kyrmit", 1, Gender.Male);
            frogs[1] = new Frog("Jabcho", 2, Gender.Male);
            frogs[2] = new Frog("Jinka", 4, Gender.Female);
            Console.WriteLine("Average age of the frogs in the array is: {0}\n", Animal.CalculateAverageAge(frogs));

            Kitten[] kittens = new Kitten[3];
            kittens[0] = new Kitten("pisanovica", 1);
            kittens[1] = new Kitten("unnamed yet", 1);
            kittens[2] = new Kitten("Puhka", 1);
            Console.WriteLine("Average age of the kittens in the array is: {0}\n", Animal.CalculateAverageAge(kittens));

            Tomcat[] toms = new Tomcat[3];
            toms[0] = new Tomcat("Ivancho", 4);
            toms[1] = new Tomcat("Pesho", 12);
            toms[2] = new Tomcat("Milancho", 5);
            Console.WriteLine("Average age of the tomcats in the array is: {0}\n", Animal.CalculateAverageAge(toms));
        }
    }
}
