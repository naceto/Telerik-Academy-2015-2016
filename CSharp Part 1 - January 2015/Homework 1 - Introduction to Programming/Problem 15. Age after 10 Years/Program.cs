using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15.Age_after_10_Years
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            string ageStr = Console.ReadLine();
            int age = int.Parse(ageStr);
            Console.WriteLine("After 10 years you'll be " + (age + 10) + " years old.");
        }
    }
}
