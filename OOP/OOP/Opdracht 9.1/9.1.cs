namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aantalBalletjes = 1000;
            Console.CursorVisible = false;
            Random r = new Random();
            Balletje[] veelBalletjes = new Balletje[aantalBalletjes];

            for (int i = 0; i < veelBalletjes.Length; i++)
            {
                veelBalletjes[i] = new Balletje();
                veelBalletjes[i].X = r.Next(1, 30);
                veelBalletjes[i].Y = r.Next(1,30);
                veelBalletjes[i].VectorX = r.Next(-2, 10); 
                veelBalletjes[i].VectorY =   r.Next(-2, 10);
            }

            while(true) 
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
    }
}
