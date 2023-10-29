using System;
using System.Reflection;

	public class Class
	{
		public int baseHealth;
		public int baseDamage;
		public int baseArmor;
		public int baseCritChance;
		public int baseInventorySlots;

		public  Class(int _basehealth, int _basedamage, int _basearmor, int _basecritchance, int _baseinventoryslots)
		{
			baseHealth = _basehealth;
			baseDamage = _basedamage;
			baseArmor = _basearmor;
			baseCritChance = _basecritchance;
			baseInventorySlots = _baseinventoryslots;
		}
	    
	}


