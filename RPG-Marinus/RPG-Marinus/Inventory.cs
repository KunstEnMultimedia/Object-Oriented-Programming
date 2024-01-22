using System;

public class Inventory
{
    public int inventorySlots { get; set; }

    Dictionary<int,int> ItemStats = new Dictionary<int, int>();
    Dictionary<string, KeyValuePair<int,int>> InventorySlots = new Dictionary<string, KeyValuePair<int, int>>() { { "Frying pan", new KeyValuePair<int, int>(1,1) } };
    // elke entry in InvetorySlots heeft een naam en aan deze naam zitten de stat van dat item

    public void ShowInventory()
    {
        foreach (KeyValuePair<string, KeyValuePair<int,int>> Slot in InventorySlots)
        {
            //Slot.Value zijn de stats en de string is de bijbehorende key
            Console.WriteLine(Slot.Key);
            Console.WriteLine("Attack: " + Slot.Value.Key);
            Console.WriteLine("Defence: " + Slot.Value.Value);
        }
    }
    
    public Inventory() { }
    public Inventory(int _inventorySlots)
     {
         inventorySlots = _inventorySlots;
     }
    
    // Invetory(Slots van class, )

    

}



