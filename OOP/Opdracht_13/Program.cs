namespace Opdracht_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Opdracht131();
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
    }
}
