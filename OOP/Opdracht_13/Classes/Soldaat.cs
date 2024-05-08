using System;

public class Soldaat
{
	protected bool kanSchieten { get; private set; }
	public Soldaat(bool kanschietenIn)
	{
		kanSchieten = kanschietenIn;

		Console.WriteLine("Soldaat is gemaakt. Kanschieten: " + kanSchieten);

	}
}
public class Veldarts : Soldaat
{
	public Veldarts() : base(true)
	{ 
		Console.WriteLine("Veldarts is gemaakt. Kanschieten: " + kanSchieten);
	}

	public Veldarts(bool kanschieten) : base(kanschieten)
	{
		Console.WriteLine("Veldarts is gemaakt. Kanschieten: " + kanSchieten);
	}
}
