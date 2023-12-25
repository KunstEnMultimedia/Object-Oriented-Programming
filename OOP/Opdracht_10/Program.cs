using NietOpdracht_10;
using System;
using static Mens;

namespace Opdracht_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Opdracht103();
            Console.ReadLine();
        }
        public static void Opdracht101()
        {
            int getal = 5;
            VerhoogParameter(getal);

            void VerhoogParameter(int a)
            {//ik laat de functie in de method staan hierbuiten verputst de organizatie van de opdrachten als methods
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
         //   dochter = oermoeder.PlantVoort();// ik heb de class veranderd in een latere opdracht dus ik comment deze twee stukken code
           // kleindochter = dochter.PlantVoort(); // 
        }

        public static void Opdracht103()
        {

         //   Student stud1 = null;
            Student John = new Student("John");
            Student Piet = new Student("Piet");
            Student Mike = new Student("Mike");


            Student[] Studenten = { Mike, Piet, John };

           // Console.WriteLine(stud1?.Naam);
            Console.WriteLine(Student.ZoekStudent(Studenten,"John").Naam);
            Console.WriteLine(Student.ZoekStudent(Studenten,"Egbert John").Naam);
            Console.WriteLine(Student.ZoekStudent(Studenten, "Joh").Naam);
            Console.WriteLine(Student.ZoekStudent(Studenten, "Piet").Naam);

            Mens mama = new Mens();
            mama.Geslacht = Geslachten.Vrouw;
            mama.MaxLengte = 180;
            Mens papa = new Mens();
            papa.Geslacht = Geslachten.Man;
            papa.MaxLengte = 169;

            Mens baby = mama.PlantVoort(papa);

            Console.WriteLine($"Baby gemaakt met geslacht {baby.Geslacht} en MaxLengte {baby.MaxLengte}");


        }

        public static void Opdracht104()
        { 
            
        }
    }
}