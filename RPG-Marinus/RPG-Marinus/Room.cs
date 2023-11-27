using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Marinus
{
    internal class Room
    {
           string specialEvent;
           bool start;
           bool end;
           string description;
           public List<Room> rooms = new List<Room>();

        public void GenerateRooms()
        {
            Random random = new Random();
          
            List<string> specialEvents = new List<string> {"Encounter","Encounter","Encounter","Encounter","Encounter","Encounter","Encounter","Shop","Shop","Loot"};
            List<string> descriptions = new List<string> {"You enter a dark room and can't see much. ", "You enter a sewer, everything is wet and stinky. ", "You enter a small room with some barrels and crates, looks like a broken down storage room. ", "You walk in a nicely lit with some small tables and chairs. A dinner table for tiny people . ", "You enter a cold and almost instantly slip and fall, you manage to catch yourself right before you hit the floor. ", "You find yourself on staircase which has some terribly crooked steps. " , "A big ornate bedroom. Too bad the matress is gone, a nap would be nice.", "You've entered an old prison cell, no corpses. That's nice. ", "You enter a library, it looks like it's been raided a long time ago. ", "This room has a low ceiling be carefull not to bump your head. ", "Just a hallway, nothing special. ", "You enter a big theatre with a podium. Maybe it was a comedy cub? ", "A kitchen. It smells like most of the food here spoilt. ", "You enter a room and there's..... nothing special. "};
            List<string> shopKeeperHello = new List<string> {"Hello ", "Welcome traveller ", "Come and take a look at my wares "};

            for (int i = 0; i  <= 15; i++)
            {
                Room room = new Room(specialEvents[random.Next(0, 9)], false, false, descriptions[random.Next(0,13)]);
                switch (room.specialEvent)
                { 
                    case "Encounter":

                      break;

                    case "Shop":
                        room.description = shopKeeperHello[random.Next(0,2)];

                        break;

                    case "Loot":

                        break;
                }
                  rooms.Add(room);
            }

        }
           public Room(string _specialEvent, bool _start, bool _end, string _description)
           {
            specialEvent = _specialEvent; 
            start = _start;
            end = _end;
            description = _description;
           } 
    }
}
