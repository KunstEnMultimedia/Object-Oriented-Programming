using System.Text.Json;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Opdracht96_D();
            Console.ReadLine();
        }

        static void Opdracht91()
        {
            int aantalBalletjes = 1000;
            Console.CursorVisible = false;
            Random r = new Random();
            Balletje[] veelBalletjes = new Balletje[aantalBalletjes];

            for (int i = 0; i < veelBalletjes.Length; i++)
            {
                veelBalletjes[i] = new Balletje();
                veelBalletjes[i].X = r.Next(1, 30);
                veelBalletjes[i].Y = r.Next(1, 30);
                veelBalletjes[i].VectorX = r.Next(-2, 10);
                veelBalletjes[i].VectorY = r.Next(-2, 10);
            }

            while (true)
            {
                for (int i = 0; i < veelBalletjes.Length; i++)
                {
                    veelBalletjes[i].Update();
                }

                for (int i = 0; i < veelBalletjes.Length; i++)
                {
                    veelBalletjes[i].TekenOpScherm();
                }
                System.Threading.Thread.Sleep(5);
                Console.Clear();
            }
        }

        public static void Opdracht92()
        {
            Mens deelnemer1 = new Mens();
            Mens deelnemer2 = new Mens();
            deelnemer1.Praat();
            deelnemer2.Praat();

            deelnemer2.VeranderLief("phoebe");
            deelnemer1.Praat();
            deelnemer2.Praat();

            deelnemer1.VeranderLief("camilla");
            deelnemer1.Praat();
            deelnemer2.Praat();
        }

        public static void Opdracht93()
        {
            SithLord Vader = new SithLord();
            Vader.ResetLord(20);
            Vader.SetName("DarthVader");
            Vader.GeboorteJaar = 2000;

            Console.WriteLine($"Vaders energie is {Vader.Energie}");

            Vader.ResetLord(-20);

            Console.WriteLine($"Vaders energie is {Vader.Energie}");
            Console.WriteLine(Vader.SithMail);
            Console.WriteLine($"{Vader.sithName} zijn geboortejaar is {Vader.GeboorteJaar} ");
            // Console.WriteLine(Vader.sithName); sithName is private, dit kan niet
        }

        public static void Opdracht94()
        {
            Random ran = new Random();
            string datumInvoer = Console.ReadLine();
            DateTime datumVerwerkt = DateTime.Parse(datumInvoer);
            Console.WriteLine(datumVerwerkt);
            Console.WriteLine(datumVerwerkt.AddDays(ran.Next(0,100)));
            Console.WriteLine(datumVerwerkt.DayOfWeek);

            if (DateTime.IsLeapYear(datumVerwerkt.Year))
            { 
              Console.WriteLine(datumVerwerkt+ " is een shikkeljaar");
            }
            else 
            {
              Console.WriteLine(datumVerwerkt+ " is geen een shikkeljaar");

            }

        }

        public static void Opdracht96_A()
        {
            RapportModule mijnpunten = new RapportModule();
            mijnpunten.Percentage = 65;
            mijnpunten.PrintGraad();
        }

        public static void Opdracht96_B()
        {
            NummerBerekenaar paar1 = new NummerBerekenaar();
            paar1.Getal1 = 12;
            paar1.Getal2 = 34;
            Console.WriteLine($"Paar: {paar1.Getal1}, {paar1.Getal2}");

            int berekendeSom = (int)paar1.Som();
            Console.WriteLine($"Som =  {berekendeSom}");

            Console.WriteLine($"Verschil = {paar1.Verschil()}");
            Console.WriteLine($"Product = {paar1.Product()}");
            Console.WriteLine($"Quotient = {paar1.Quotient()}");
        }

        public static void Opdracht96_C()
        { 
          Persoon Mens = new Persoon();
            Console.Write("Voornaam: ");
            Mens.Voornaam = Console.ReadLine();
            Console.Write("Achternaam: ");
            Mens.Achternaam = Console.ReadLine();
            Console.Write("GeboorteDatum: ");
            Mens.GeboorteDatum = DateTime.Parse((Console.ReadLine()));
            Console.WriteLine($"{Mens.Voornaam + " " + Mens.Achternaam} is {DateTime.Now.Year - Mens.GeboorteDatum.Year}"); //DateTime.year geeft een int
        }

        public static void Opdracht96_D()
        {
            Console.WriteLine("when birthday day/month");
            DateTime verjaardag = DateTime.Parse(Console.ReadLine());
            TimeSpan result = verjaardag.AddYears(1) - DateTime.Today;
            DateTime totVerjaardag = DateTime.Now;
            Console.Write($"You're birthday is in {result.TotalDays} days on a ");
            Console.WriteLine(System.Globalization.DateTimeFormatInfo.CurrentInfo.GetDayName(verjaardag.DayOfWeek));

        }
    }
}
