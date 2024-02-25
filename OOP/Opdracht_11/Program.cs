namespace Opdracht_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Opdracht113();
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
    }
}