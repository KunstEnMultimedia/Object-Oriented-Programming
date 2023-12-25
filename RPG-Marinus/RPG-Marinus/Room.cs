using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Marinus
{
    public class Room
    {
        public string specialEvent { get; set; }
        public bool start { get; set; }
        public bool end { get; set; }
        public string description { get; set; }
        public string lootItem { get; set; }

        public List<Room> rooms = new List<Room>();

        public void GenerateRooms()
        {
            Random random = new Random();

            List<string> specialEvents = new List<string> { "Encounter", "Encounter", "Encounter", "Encounter", "Encounter", "Encounter", "Encounter", "Shop", "Shop", "Loot" };
            List<string> descriptions = new List<string> { "You enter a dark room and can't see much. ", "You enter a sewer, everything is wet and stinky. ", "You enter a small room with some barrels and crates, looks like a broken down storage room. ", "You walk into a nicely lit room that has some small tables and chairs. A dinner table for dwarves. ", "You enter a cold and almost instantly slip and fall, you manage to catch yourself right before you hit the floor. ", "You find yourself on staircase with some terribly crooked steps. ", "A big ornate bedroom. Too bad the matress is gone, a nap would be nice.", "You've entered an old prison cell. ", "You enter a library, it looks like it's been raided a long time ago. ", "This room has a low ceiling be carefull not to bump your head. ", "Just a hallway, nothing special. ", "You enter a big theatre with a podium. Maybe it was a comedy cub? ", "A kitchen. It smells like most of the food here spoilt. ", "You enter a room and there's windows that you cannot see through " };
            List<string> shopKeeperHello = new List<string> { "Hello traveller, please take a look at my items ", "Welcome traveller ", "Come and take a look at my wares " };
            List<string> lootItems = new List<string> {"While feeling your way through the room you bump into something.. A sword!", "You see something shiny in the water, it's a helmet.", "In one of the barrels you find an old gun", "You pick up a pan, this is now a deadly weapon","In this cold and empty place you look around and find... Nothing","Halfway up the stairs you trip over a nice looking jacket.", "You take find an ancient looking staff in the corner of the room", "You break loose and take the shackles from a dusty skeleten", "You find a book named 'How to not die exploring a dungen'. Convenient." ,                                                                                                    "You find a dead knight with most of his equipment broken, except his shield. ", "Except for the gigantic deathblade in the corner.", "You find a happy mask. ",                            "You have take a knife from one of the cupboards ", "An old armor stand has some leftover leggins"};
            
            for (int i = 0; i <= 15; i++)
            {
                int syncLists = random.Next(0,14);
                Room room = new Room(specialEvents[random.Next(0, 10)], false, false, descriptions[syncLists], lootItems[syncLists]);
                if (room.specialEvent == "Shop")
                {
                    room.description = shopKeeperHello[random.Next(0, 3)];
                }

                rooms.Add(room);
            }

        }
        public Room()
        {
        
        }

           public Room(string _specialEvent, bool _start, bool _end, string _description, string _lootItem)
           {
            lootItem = _lootItem;
            specialEvent = _specialEvent; 
            start = _start;
            end = _end;
            description = _description;
           } 
    }
}
