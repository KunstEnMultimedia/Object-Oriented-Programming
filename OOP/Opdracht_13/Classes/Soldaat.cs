using System;

public class Soldaat
{
	bool kanSchieten { get; private set; }
	public Soldaat(bool kanschietenIn)
	{
		kanSchieten = kanschietenIn;

		Console.WriteLine("Soldaat is gemaakt" + kanschieten);

	}
}
public class Veldarts : Soldaat
{
	public Veldarts() : base(true)
	{ 
		Console.WriteLine("Veldarts is gemaakt");
	}

	public Veldarts(bool kanschieten) : base(kanschieten)
	{
		Console.WriteLine("Veldarts is gemaakt" + kanschieten);
	}
}
