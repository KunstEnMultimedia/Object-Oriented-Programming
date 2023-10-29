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
           bool loot;
           bool encounter;
           bool shop;
           bool start;
           bool end;
           string description;

        void GenerateRooms()
        {
          Random random = new Random();

          List<Room> rooms = new List<Room>();
          
          List<bool> lootChance = new List<bool> {false,false,false,false,false,false,false,false,false,true};//10%
          List<bool> encounterChance = new List<bool> { false, false, false, true, true, true, true, true, true, true };//70%
          List<bool> shopChance = new List<bool> { false, false, false, false, false, false, false, false, true, true };//20%
          List<string> descriptions = new List<string> {"You enter a dark room and can't see much. ", "You enter a sewer tunnel everything is wet and it smells like disease. ", "You enter a small room with some barrels and crates, looks like an old storage room. ", "You walk in a nicely lit room with some spoiled food on a small dinner table. ", "You enter a cold and almost instantly slip and fall, but you manage to catch yourself. ", "You find yourself on staircase with some terrible and crooked steps. " , "A big ornate bedroom with. Too bad the sheets are gone, a nap would be nice right now.", "You entered an old prison cell, no old skeletons though. ", "You enter a library, it looks like it's been raided. ", "This room has a low ceiling be carefull to not bump your head. ", "Just a hallway, nothing special. ", "You enter a big theatre with a podium. Maybe it was a comedy cub? ", "A kitchen. It smells like most of the food here spoilt. ", "You enter a room and there's..... nothing special. "};
          List<string> shopKeeperHello = new List<string> {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };

            for (int i = 0; i  < rooms.Count; i ++)
            {
               Room room = new Room(lootChance[random.Next(0,10)], encounterChance[random.Next(0, 10)], shopChance[random.Next(0, 10)],false,false,"PlaceHolder");
               rooms.Add(room);
            }
            // if de ding met laagste percentage is true dan is zijn de andere dingen false

        }



           public Room(bool _loot, bool _encounter, bool _shop, bool _start, bool _end, string _description)
           {
            loot = _loot;
            encounter = _encounter;
            shop = _shop;
            start = _start;
            end = _end;
           } 
    }
}
