namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Opdracht93();
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
            Vader.Energie = 20;
            Console.WriteLine($"Vaders energie is {Vader.Energie}");
        }


    }
}
