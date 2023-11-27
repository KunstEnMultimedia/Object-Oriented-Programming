using System;
using System.Reflection;

	public class Class
	{
		public int baseHealth { get; set; }
		public int baseDamage { get; set; }
        public int baseArmor { get; set; }
        public int baseCritChance { get; set; }
        public int baseInventorySlots { get; set; }

    public  Class(int _basehealth, int _basedamage, int _basearmor, int _basecritchance, int _baseinventoryslots)
		{
			baseHealth = _basehealth;
			baseDamage = _basedamage;
			baseArmor = _basearmor;
			baseCritChance = _basecritchance;
			baseInventorySlots = _baseinventoryslots;
		}
	    
	}


