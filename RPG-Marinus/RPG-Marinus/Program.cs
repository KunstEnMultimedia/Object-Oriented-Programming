using System.Numerics;

namespace RPG_Marinus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu Menu = new Menu();
            //de Selector functie maakt een menu die je kan navigeren met de arrow keys en enter
            Menu.Selector("Start", "Options", "Quit", 0);
            Menu.Selector("Samurai", "Gunslinger", "Wizard", 3);


            Console.ReadLine(); 
        }
    }
}
