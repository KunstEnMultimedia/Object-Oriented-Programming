using System;

namespace Opdracht_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Opdracht101();
            Console.ReadLine();
        }
        public static void Opdracht101()
        {
            int getal = 5;
            VerhoogParameter(getal);
            void VerhoogParameter(int a)
            {
                a++;
                Console.WriteLine($"In methode {a}");
            }
            Console.WriteLine($"Na methode {getal}");
            Console.Write("Naam: ");
            Student stud = new Student(Console.ReadLine()); // readline defineerd de string name
            Student stud1 = new Student("Egbert");
            Console.WriteLine($"stud {stud.Naam}");
            Console.WriteLine($"stud1 {stud1.Naam}");
            stud1 = stud;
            Console.WriteLine($"stud  {stud.Naam}");
            Console.WriteLine($"stud1 {stud1.Naam}");


        }
    }
}