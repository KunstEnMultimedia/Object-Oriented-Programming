namespace Opdracht_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Opdracht133();
            Console.ReadLine();
        }

        public static void Opdracht131()
        {
            Dier aDier = new Dier();
            Paard aPaard = new Paard();

            aDier.Eet();
            aPaard.Eet();
            aPaard.KanHinnikken = true;
            //aDier.KanHinnikken = false;

            aDier.geboorteJaar = 2002;
            aPaard.geboorteJaar = 2003;
            Console.WriteLine($"Paard geboortejaar : {aPaard.geboorteJaar} Dier geboortje jaar : {aDier.geboorteJaar}");
            aPaard.MaakOuder();
            Console.WriteLine($"Paard geboortejaar : {aPaard.geboorteJaar} Dier geboortje jaar : {aDier.geboorteJaar}");
        }
        public static void Opdracht132()
        {
            Veldarts arts = new Veldarts();
            Veldarts docterpersoon = new Veldarts(false);

            Console.WriteLine();

            Apartement fijftien_verdiepingen = new Apartement(15);
            Huis mijn_huis = new Huis(true,true,3);
            Villa villa = new Villa(true, true, 20);
        }

        public static void Opdracht133()
        { 
          Vliegtuig vliegtuig = new();
          Raket raket = new();
          vliegtuig.Vlieg();
          raket.Vlieg();

        }
    }
}
