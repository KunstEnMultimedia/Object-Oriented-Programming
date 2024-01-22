namespace Opdracht_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Opdracht111();
            Console.ReadLine();
        }

        public static void Opdracht111()
        {
            Student Willekeur = new Student();
            Student Harry = new Student("Harry");
            Console.WriteLine(Willekeur.Naam);
            Console.WriteLine(Harry.Naam);
        }
    }
}