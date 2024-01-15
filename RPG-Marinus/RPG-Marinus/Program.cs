
namespace RPG_Marinus
{
    public class Program
    {
        public static int currentCount;
        public static Room currentRoom;
        public static Room Kamer = new Room("Loot", true, false, "You are lost, Good luck.", "You look around the room but find nothing new but you do have a potion on you");
        // kamer is eerste kamer

        public static void Main(string[] args)
        {
            Menu Menu = new Menu();
            Kamer.rooms.Add(Kamer);
            Kamer.GenerateRooms();

            //de Selector functie maakt een menu die je kan navigeren met de arrow keys en enter
            Menu.Selector("Start", "Options", "Quit", 0);
            Menu.Selector("Samurai", "Gunslinger", "Wizard", 2);

            for (currentCount = 0; currentCount <= Kamer.rooms.Count; currentCount++)
            {
                Console.WriteLine();
                Console.WriteLine();
                currentRoom = Kamer.rooms.ElementAt(currentCount);

                if (currentRoom == Kamer.rooms.ElementAt(currentCount))
                {
                     Menu.Selector("Travel", "CheckRoom", "Inventory", 2);
                }
            }
        }

        public static void check()
        {
                switch (currentRoom.specialEvent)
                {
                    case "Encounter":
                        Console.WriteLine("!");
                        //Program.currentCount--;
                        break;

                    case "Shop":
                    Console.WriteLine(Kamer.rooms[currentCount]);
                        //Program.currentCount--;
                        break;

                    case "Loot":
                    Console.WriteLine(Kamer.rooms[currentCount].lootItem);
                        //Program.currentCount--;
                        // geef item op basis van de lootItems List
                        break;
                }
            }

        public static void NextRoom()
        {
           currentRoom = Kamer.rooms[currentCount++];
           Console.SetCursorPosition(0,0);
           Console.Clear();
           Console.WriteLine(Kamer.rooms[currentCount].description);
           Console.WriteLine(currentCount);
           Console.WriteLine("Travel");
           Console.WriteLine("CheckRoom");
           Console.WriteLine("Inventory");
        }

    }
}