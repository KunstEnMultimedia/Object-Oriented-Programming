namespace Opdracht_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Opdracht14_4b();
            Console.ReadLine();
        }
        
        public static void Opdracht14_1()
        {
            Student stud = new();
            Student Pietje = new("Pietje");
            Console.WriteLine(stud.GetType().FullName); 
            Console.WriteLine(stud); // ToString wordt intern al gebruikt in Console.WriteLine();
            Console.WriteLine($"Student {stud} is {(stud.Equals(Pietje) ? "Wel" : "Niet")} Gelijk aan {Pietje}  ");
        }
        public static void Opdracht14_2()
        { 
            Wolf wolf = new Wolf();
            Dier paard = new Paard();

            Console.WriteLine(wolf.MaakGeluid());
            Console.WriteLine(paard.MaakGeluid());
        }

            
        public static void Opdracht14_3()
        {
            try
            {
                Timception.ResultaatBerekening(0);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Timception.TimsMethode();
            }
            catch (Timception e)
            {

                Console.WriteLine(e.ToString());
            }
        }

        public static void Opdracht14_4a()
        {
            Boek Remarkable = new(978147322, "An Absolutely Remarkable Thing", "Hank Green", 17.99);
            TextBoek ZieScherpScherper = new(9001,978946465,"ZieScherpScherper 2e","Tim Dams",25);
            KoffietafelBoek NewYork = new(978383279, "New York", "Thomas Hoepker", 42.50);

            Console.WriteLine(Remarkable);
            Console.WriteLine(ZieScherpScherper);
            Console.WriteLine(NewYork);

            Console.WriteLine();

            Console.WriteLine(Boek.TelOp(Remarkable, ZieScherpScherper));
        }

        public static void Opdracht14_4b()
        {
            var VierkantGelijk = new Vierkant(10, 10);
            var VierkantOngelijk = new Vierkant(10, 11);
            var RechtHoek = new RechtHoek(10, 20);
            var RechtHoekGelijk = new RechtHoek(10, 10);
            var Driehoek = new DrieHoek(3, 12);

            Console.WriteLine($"Vierkant: Hoogte: {VierkantGelijk.Hoogte} Breedte: {VierkantGelijk.Breedte} Oppervlakte: {VierkantGelijk.Oppervlakte}");
            Console.WriteLine($"VierkantOngelijk: Hoogte: {VierkantOngelijk.Hoogte} Breedte: {VierkantOngelijk.Breedte} Oppervlakte: {VierkantOngelijk.Oppervlakte}");
            Console.WriteLine($"RechtHoek: Hoogte: {RechtHoek.Hoogte} Breedte: {RechtHoek.Breedte} Oppervlakte: {RechtHoek.Oppervlakte}");
            Console.WriteLine($"RechthoekGelijk: Hoogte: {RechtHoekGelijk.Hoogte} Breedte: {RechtHoekGelijk.Breedte} Oppervlakte: {RechtHoekGelijk.Oppervlakte}");
            Console.WriteLine($"Driehoek: Hoogte: {Driehoek.Hoogte} Breedte: {Driehoek.Breedte} Oppervlakte: {Driehoek.Oppervlakte}");

        }
    }
}