namespace Problem_03.Animal_hierarchy.Classes
{
    using Problem_03.Animal_hierarchy.Enumerations;
    using System;

    public class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age)
        {
            base.Sex = Gender.Male;
        }

        public override string MakeSound()
        {
            return string.Format("Tomcat: {0}", base.MakeSound());
        }
    }
}
