using System.Diagnostics;

namespace Opdracht_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Opdracht115a();



            Console.ReadLine();
        }

        public static void Opdracht111()
        {
            Student Willekeur = new Student();
            Student Harry = new Student("Harry");
            Console.WriteLine(Willekeur.Naam);
            Console.WriteLine(Harry.Naam);
        }

        public static void Opdracht112()
        {
            Student Piet = new Student("Piet", true);
            Student Jan = new Student("Jan", false);

            Microfoon Mic1 = new Microfoon(false);
            Microfoon Mic2 = new Microfoon(true);
        }

        public static void Opdracht113()
        {
            Microfoon NietUitverkocht = new Microfoon { IsUitverkocht = false, Merk = "Mijn Merk" };
            Microfoon Uitverkocht = new Microfoon { IsUitverkocht = true, Merk = "Mijn Merk" };

            if (!NietUitverkocht.IsUitverkocht && Uitverkocht.IsUitverkocht)
            {
                Console.WriteLine($"Microfoon {NietUitverkocht.Merk} is niet uitverkocht");
                Console.WriteLine($"Microfoon {Uitverkocht.Merk} is wel uitverkocht");
            }
        }

        public static void Opdracht114()
        {
            Mens m1 = new Mens();
            Mens m2 = new Mens();
            m1.Jarig();
            m1.Jarig();
            m2.Jarig();
            Console.WriteLine($"{m1.Geboortejaar}");
            Console.WriteLine($"{m2.Geboortejaar}");

            EpicLibrary.ToonInfo();
            int opgeteld = EpicLibrary.TelOp(3, 5);

            Console.WriteLine("EpicConsole tekst");
            Debug.WriteLine("EpicDebug tekst");


            Fiets merckx = new Fiets();
            Fiets steels = new Fiets();
            Fiets evenepoel = new Fiets();
            Fiets.VerminderFiets();
            Fiets aerts = new Fiets();
            Fiets.VerminderFiets();
        }

        public static void Opdracht115a()
        {
            DigitaleKluis kluis = new DigitaleKluis(33);
            DigitaleKluis.BruteForce(kluis);


            // dit is voor het handmatig raden van de codes uncomment dit als je -666/cheater detectie wilt testen

            //for (int i = 0; i <= 10; i++)
            //{
            //    try
            //    { 
            //        kluis.TryCode(Int32.Parse(Console.ReadLine()));
            //    }
            //    catch
            //    {
            //        Console.WriteLine("De code is een nummer code. Niet dit.");
            //    }
            //}
        }
    }
}