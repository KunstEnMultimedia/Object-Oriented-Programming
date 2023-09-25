using System.Numerics;

namespace RPG_Marinus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu main = new Menu();

            Console.WriteLine("Start");
            Console.WriteLine("Options");
            Console.WriteLine("Quit");
            Console.WriteLine();
            Console.SetCursorPosition(0, 0);


            //while (main.menu == true)
            main.Selector("Start", "Options", "Quit");
            
            Console.ReadLine();
        }
    }
}
