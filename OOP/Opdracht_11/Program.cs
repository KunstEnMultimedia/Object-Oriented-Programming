namespace Opdracht_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Opdracht112();
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
    }
}