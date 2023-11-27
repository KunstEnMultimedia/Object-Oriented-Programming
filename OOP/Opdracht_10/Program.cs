using System;

namespace Opdracht_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Opdracht102();
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

        public static void Opdracht102()
        {
            Meting m1 = new Meting();
            m1.Temperatuur = 26;
            m1.OpgemetenDoor = "Lieven Scheire";
            Meting m2 = new Meting();
            m2.Temperatuur = 34;
            m2.OpgemetenDoor = "Ann Dooms";

            m1.ToonMetingInKleur(ConsoleColor.Red);
            m2.ToonMetingInKleur(ConsoleColor.Cyan);


            m1.Temperatuur = 26;
            m1.OpgemetenDoor = "Lieven Scheire";
            m2.Temperatuur = 5;
            m2.OpgemetenDoor = "Lieven Scheire";
            m1.VoegMetingToeEnVerwijder(ref m2);
            Console.WriteLine($"Temperatuur m1: {m1.Temperatuur} en m2: {m2.Temperatuur}");


            m1.Temperatuur = 26;
            m1.OpgemetenDoor = "Lieven Scheire";
            Meting m3 = m1.GenereerRandomMeting();
            Console.WriteLine($"{m3.Temperatuur} gemeten door {m3.OpgemetenDoor}");

            Mens oermoeder = new Mens();
            Mens dochter;
            Mens kleindochter;
            dochter = oermoeder.PlantVoort();
            kleindochter = dochter.PlantVoort();
        }
    }
}