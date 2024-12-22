namespace Opdracht_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Opdracht14_3();
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
    }
}