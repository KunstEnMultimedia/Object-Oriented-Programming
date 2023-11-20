using System.Numerics;

namespace RPG_Marinus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu Menu = new Menu();
            Room Kamer = new Room("Loot", true,false, "You are lost, Good luck.");
            Kamer.rooms.Add(Kamer);
            Kamer.GenerateRooms();

            //de Selector functie maakt een menu die je kan navigeren met de arrow keys en enter
            Menu.Selector("Start", "Options", "Quit", 0);
            Menu.Selector("Samurai", "Gunslinger", "Wizard", 2);

            foreach (Room room in Kamer.rooms)//voor elke kamer in kamer
            { 

               if (currentRoom == Kamer.rooms.ElementAt(0))
               {
                   Menu.Selector("verder", "rondkijken", "inventaris", 0);
               }

            }


            Console.ReadLine(); 
        }
            
    }
}
